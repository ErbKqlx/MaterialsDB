using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public bool Active { get; set; }

    public short IdTypeOfSupplier { get; set; }

    public virtual TypesOfSupplier IdTypeOfSupplierNavigation { get; set; } = null!;

    public virtual ICollection<SuppliersMaterial> SuppliersMaterials { get; set; } = new List<SuppliersMaterial>();
}
