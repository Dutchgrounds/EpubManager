using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class BooksPublishersLink
{
    public int Id { get; set; }

    public int Book { get; set; }

    public int Publisher { get; set; }
}
