using System;
using System.Collections.Generic;

namespace TypeingTest.EFCore.Models;

public partial class UserInExam
{
    public int ExamId { get; set; }

    public int UserId { get; set; }

    public int UserMarks { get; set; }

    public virtual Exammaster Exam { get; set; } = null!;

    public virtual Userdetail User { get; set; } = null!;
}
