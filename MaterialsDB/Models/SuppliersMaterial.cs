using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class SuppliersMaterial
{
    public int Id { get; set; }

    public int IdSupplier { get; set; }

    public int IdMaterial { get; set; }

    public DateOnly DateOfSupply { get; set; }

    public short AmountInPackage { get; set; }

    public short PackageAmount { get; set; }

    public decimal Price { get; set; }

    public short IdUnit { get; set; }

    public short Quality { get; set; }

    public virtual Material IdMaterialNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual UnitsOfMeasurement IdUnitNavigation { get; set; } = null!;
}
