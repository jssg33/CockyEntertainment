using System;
using System.Collections.Generic;

namespace CockyEntertainment.Models;

public partial class Customerteam
{
    public int Sequencenumber { get; set; }

    public string? Teamid { get; set; }

    public string? Teamdescription { get; set; }

    public int? TeammanagerJid { get; set; }

    public int? Jgroupid { get; set; }

    public string? Storeorigination { get; set; }

    public string? Companyid { get; set; }

    public string? Subaccount { get; set; }
}
