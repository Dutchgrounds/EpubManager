using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class ConversionOption
{
    public int Id { get; set; }

    public string Format { get; set; } = null!;

    public int? Book { get; set; }

    public byte[] Data { get; set; } = null!;
}
