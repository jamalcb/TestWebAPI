using System;
using System.Collections.Generic;

namespace CoreAPIWeb1.Models;

public partial class StudentLang
{
    public int LangId { get; set; }

    public int StudentId { get; set; }

    public string LangKnown { get; set; } = null!;

    public int? IsActive { get; set; }
}
