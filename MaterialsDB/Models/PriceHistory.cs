using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class PriceHistory
{
    public int Id { get; set; }

    public int IdMaterial { get; set; }

    public decimal Price { get; set; }

    public DateOnly DateOfChange { get; set; }

    public virtual Material IdMaterialNavigation { get; set; } = null!;
}
