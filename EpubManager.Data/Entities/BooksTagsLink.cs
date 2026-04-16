using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class BooksTagsLink
{
    public int Id { get; set; }

    public int Book { get; set; }

    public int Tag { get; set; }
}
