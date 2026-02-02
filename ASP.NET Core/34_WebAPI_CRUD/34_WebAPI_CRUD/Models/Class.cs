using System;
using System.Collections.Generic;

namespace _34_WebAPI_CRUD.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public string? Section { get; set; }

    public int? TId { get; set; }
}
