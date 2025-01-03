using System;
using System.Collections.Generic;

namespace CoreAPIWeb1.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int ClassName { get; set; }

    public int Country { get; set; }

    public int State { get; set; }

    public string Gender { get; set; } = null!;

    public string PhotoPath { get; set; } = null!;

    public bool IsActive { get; set; }
}
