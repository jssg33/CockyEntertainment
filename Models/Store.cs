using System;
using System.Collections.Generic;

namespace CockyEntertainment.Models;

public partial class Store
{
    public int Sequencenumber { get; set; }

    public string? Storeid { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? Country { get; set; }

    public int? Regionid { get; set; }

    public string? Companyid { get; set; }

    public string? Subaccount { get; set; }
}
