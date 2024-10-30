using System;
using System.Collections.Generic;

namespace CockyEntertainment.Models;

public partial class Currencymark
{
    public int Sequencenumber { get; set; }

    public string? Currencyid { get; set; }

    public string? Currencydescription { get; set; }

    public double? Dollarmark { get; set; }

    public double? Yuanmark { get; set; }

    public double? Sterlingmark { get; set; }
}
