using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class Material
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int AmountPackage { get; set; }

    public short IdUnit { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public int Amount { get; set; }

    public int MinAmount { get; set; }

    public virtual UnitsOfMeasurement IdUnitNavigation { get; set; } = null!;

    public virtual ICollection<PriceHistory> PriceHistories { get; set; } = new List<PriceHistory>();

    public virtual ICollection<ProductsMaterial> ProductsMaterials { get; set; } = new List<ProductsMaterial>();

    public virtual ICollection<SuppliersMaterial> SuppliersMaterials { get; set; } = new List<SuppliersMaterial>();
}
