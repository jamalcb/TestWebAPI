using System;
using System.Collections.Generic;

namespace CoreAPIWeb1.Models;

public partial class State
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public int Country { get; set; }
}
