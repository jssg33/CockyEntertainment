﻿using System;
using System.Collections.Generic;

namespace CockyEntertainment.Models;

public partial class Region
{
    public int Sequencenumber { get; set; }

    public int? Regionid { get; set; }

    public string? Hqaddress1 { get; set; }

    public string? Hqaddress2 { get; set; }

    public string? Hqcity { get; set; }

    public string? Hqregion { get; set; }

    public string? Hqcountry { get; set; }

    public string? Companyid { get; set; }

    public string? Subaccount { get; set; }

    public string? Storeid { get; set; }
}
