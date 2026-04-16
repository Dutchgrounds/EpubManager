using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class Preference
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public string Val { get; set; } = null!;
}
