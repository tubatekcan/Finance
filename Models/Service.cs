using System;
using System.Collections.Generic;

namespace FinanceApp.Models;

public partial class Service
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public string? Detail { get; set; }
}
