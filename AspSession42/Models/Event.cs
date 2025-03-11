using System;
using System.Collections.Generic;

namespace AspSession42.Models;

public partial class Event
{
    public string? Title { get; set; }
    public DateTime? Date { get; set; }
    public string? Description { get; set; }
    public string? Author { get; set; }
}
