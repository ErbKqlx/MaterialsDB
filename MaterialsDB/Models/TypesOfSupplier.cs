using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class TypesOfSupplier
{
    public short Id { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
