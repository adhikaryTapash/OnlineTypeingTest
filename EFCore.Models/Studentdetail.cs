using System;
using System.Collections.Generic;

namespace TypeingTest.EFCore.Models;

public partial class Studentdetail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string RollNo { get; set; } = null!;

    public int? ContactNo { get; set; }

    public int UserId { get; set; }

    public virtual Userdetail User { get; set; } = null!;
}
