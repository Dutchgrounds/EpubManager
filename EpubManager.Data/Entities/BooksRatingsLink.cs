using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class BooksRatingsLink
{
    public int Id { get; set; }

    public int Book { get; set; }

    public int Rating { get; set; }
}
