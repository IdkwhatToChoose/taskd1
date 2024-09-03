using System;
using System.Collections.Generic;

namespace TaskyApp.Model;

public partial class TaskProp
{
    public string Task { get; set; } = null!;

    public string? TaskDescription { get; set; }

    public string Completed { get; set; } = null!;

    public int Id { get; set; }
}
