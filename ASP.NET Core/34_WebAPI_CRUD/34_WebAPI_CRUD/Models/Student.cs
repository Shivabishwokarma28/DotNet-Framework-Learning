using System;
using System.Collections.Generic;

namespace _34_WebAPI_CRUD.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? StName { get; set; }

    public string? StPhone { get; set; }

    public int? StRoll { get; set; }
}
