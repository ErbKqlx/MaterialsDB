using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class Material
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Image { get; set; }

    public short IdTypeOfMaterial { get; set; }

    public virtual TypesOfMaterial IdTypeOfMaterialNavigation { get; set; } = null!;

    public virtual ICollection<ProductsMaterial> ProductsMaterials { get; set; } = new List<ProductsMaterial>();

    public virtual ICollection<SuppliersMaterial> SuppliersMaterials { get; set; } = new List<SuppliersMaterial>();
}
