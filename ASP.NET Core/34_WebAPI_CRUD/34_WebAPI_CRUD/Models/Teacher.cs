using System;
using System.Collections.Generic;

namespace _34_WebAPI_CRUD.Models;

public partial class Teacher
{
    public int TId { get; set; }

    public string? TName { get; set; }

    public string? TAddress { get; set; }

    public string? TPhone { get; set; }
}
