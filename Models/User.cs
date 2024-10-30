using System;
using System.Collections.Generic;

namespace CockyEntertainment.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? MovieName { get; set; }

    public string? ReviewDescr { get; set; }
}
