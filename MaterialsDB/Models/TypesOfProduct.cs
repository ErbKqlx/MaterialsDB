using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class TypesOfProduct
{
    public short Id { get; set; }

    public string TypeOfProduct { get; set; } = null!;

    public decimal TypeCoefficient { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
