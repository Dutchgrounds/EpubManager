using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class BooksSeriesLink
{
    public int Id { get; set; }

    public int Book { get; set; }

    public int Series { get; set; }
}
