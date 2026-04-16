using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class MetadataDirtied
{
    public int Id { get; set; }

    public int Book { get; set; }
}
