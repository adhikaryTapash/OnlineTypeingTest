using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeingTest.EFCore.Model
{
    public class RoleOld
    {
        public int RoleId { get; set; }

        public string? Name { get; set; }

       // public virtual ObservableCollectionListSource<Product> Products { get; } = new();
    }
}
