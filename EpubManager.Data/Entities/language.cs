using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class Language
{
    public int Id { get; set; }

    public string LangCode { get; set; } = null!;

    public string Link { get; set; } = null!;
}
