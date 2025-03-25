using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class UnitsOfMeasurement
{
    public short Id { get; set; }

    public string Unit { get; set; } = null!;

    public virtual ICollection<SuppliersMaterial> SuppliersMaterials { get; set; } = new List<SuppliersMaterial>();
}
