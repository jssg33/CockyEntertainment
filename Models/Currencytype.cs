using System;
using System.Collections.Generic;

namespace CockyEntertainment.Models;

public partial class Currencytype
{
    public int Sequencenumber { get; set; }

    public string? Currencyid { get; set; }

    public string? Currencydescription { get; set; }

    public string? Exchangecorpid { get; set; }

    public string? Exchangecorpsubid { get; set; }
}
