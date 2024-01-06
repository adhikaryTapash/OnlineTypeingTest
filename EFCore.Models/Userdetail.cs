using System;
using System.Collections.Generic;

namespace TypeingTest.EFCore.Models;

public partial class Userdetail
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Studentdetail> Studentdetails { get; set; } = new List<Studentdetail>();

    public virtual ICollection<UserInExam> UserInExams { get; set; } = new List<UserInExam>();

    public virtual ICollection<Roledetail> Roles { get; set; } = new List<Roledetail>();
}
