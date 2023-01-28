﻿
using System.Collections.Generic;

namespace CP.Models;

public partial class ObjectType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Realty> Realties { get; } = new List<Realty>();
}
