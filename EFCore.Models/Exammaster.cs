using System;
using System.Collections.Generic;

namespace TypeingTest.EFCore.Models;

public partial class Exammaster
{
    public int Id { get; set; }

    public string Examname { get; set; } = null!;

    public string Examcontext { get; set; } = null!;

    public DateTime? Examstart { get; set; }

    public DateTime Createdon { get; set; }

    public virtual ICollection<UserInExam> UserInExams { get; set; } = new List<UserInExam>();
}
