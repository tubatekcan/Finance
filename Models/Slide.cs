using System;
using System.Collections.Generic;

namespace FinanceApp.Models;

public partial class Slide
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public int? DisplayIndex { get; set; }

    public string? Link { get; set; }
}
