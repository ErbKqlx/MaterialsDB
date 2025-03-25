using System;
using System.Collections.Generic;

namespace MaterialsDB.Models;

public partial class TypesOfMaterial
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
