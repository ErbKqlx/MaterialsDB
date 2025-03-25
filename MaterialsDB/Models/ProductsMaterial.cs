using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class ProductsMaterial
{
    public int Id { get; set; }

    public short IdProduct { get; set; }

    public int IdMaterial { get; set; }

    public virtual Material IdMaterialNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
