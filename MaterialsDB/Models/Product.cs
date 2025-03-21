using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class Product
{
    public short Id { get; set; }

    public short IdTypeOfProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinimalPrice { get; set; }

    public virtual TypesOfProduct IdTypeOfProductNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();

    public virtual ICollection<ProductsMaterial> ProductsMaterials { get; set; } = new List<ProductsMaterial>();
}
