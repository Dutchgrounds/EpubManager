using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class Identifier
{
    public int Id { get; set; }

    public int Book { get; set; }

    public string Type { get; set; } = null!;

    public string Val { get; set; } = null!;
}
