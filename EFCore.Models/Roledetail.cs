using System;
using System.Collections.Generic;

namespace TypeingTest.EFCore.Models;

public partial class Roledetail
{
    public int Id { get; set; }

    public string Rolename { get; set; } = null!;

    public virtual ICollection<Userdetail> Users { get; set; } = new List<Userdetail>();
}
