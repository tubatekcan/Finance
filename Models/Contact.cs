using System;
using System.Collections.Generic;

namespace FinanceApp.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public DateTime? RecDate { get; set; }

    public string? Ipno { get; set; }
}
