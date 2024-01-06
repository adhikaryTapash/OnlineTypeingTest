using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TypeingTest.EFCore.Models;

public partial class OnlineTestContext : DbContext
{
    public OnlineTestContext()
    {
    }

    public OnlineTestContext(DbContextOptions<OnlineTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Exammaster> Exammasters { get; set; }

    public virtual DbSet<Roledetail> Roledetails { get; set; }

    public virtual DbSet<Studentdetail> Studentdetails { get; set; }

    public virtual DbSet<UserInExam> UserInExams { get; set; }

    public virtual DbSet<Userdetail> Userdetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=OnlineTest;Username=postgres;Password=Tapash@123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exammaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("exammaster_pkey");

            entity.ToTable("exammaster");

            entity.HasIndex(e => e.Examname, "exammaster_examname_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Examcontext)
                .HasMaxLength(5000)
                .HasColumnName("examcontext");
            entity.Property(e => e.Examname)
                .HasMaxLength(50)
                .HasColumnName("examname");
            entity.Property(e => e.Examstart)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("examstart");
        });

        modelBuilder.Entity<Roledetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roledetail_pkey");

            entity.ToTable("roledetail");

            entity.HasIndex(e => e.Rolename, "roledetail_rolename_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Rolename)
                .HasMaxLength(50)
                .HasColumnName("rolename");

            entity.HasMany(d => d.Users).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "Userinrole",
                    r => r.HasOne<Userdetail>().WithMany()
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_userinrole_userid"),
                    l => l.HasOne<Roledetail>().WithMany()
                        .HasForeignKey("Roleid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_userinrole_roleid"),
                    j =>
                    {
                        j.HasKey("Roleid", "Userid").HasName("userinrole_pkey");
                        j.ToTable("userinrole");
                        j.IndexerProperty<int>("Roleid")
                            .ValueGeneratedOnAdd()
                            .HasColumnName("roleid");
                        j.IndexerProperty<int>("Userid")
                            .ValueGeneratedOnAdd()
                            .HasColumnName("userid");
                    });
        });

        modelBuilder.Entity<Studentdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("studentdetail_pkey");

            entity.ToTable("studentdetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.RollNo)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.User).WithMany(p => p.Studentdetails)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_student_user");
        });

        modelBuilder.Entity<UserInExam>(entity =>
        {
            entity.HasKey(e => new { e.ExamId, e.UserId }).HasName("UserInExam_pkey");

            entity.ToTable("UserInExam");

            entity.HasOne(d => d.Exam).WithMany(p => p.UserInExams)
                .HasForeignKey(d => d.ExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_exam_exaid");

            entity.HasOne(d => d.User).WithMany(p => p.UserInExams)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_exam_userid");
        });

        modelBuilder.Entity<Userdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("userdetail_pkey");

            entity.ToTable("userdetail");

            entity.HasIndex(e => e.Username, "userdetail_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
