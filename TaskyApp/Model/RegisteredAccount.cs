using System;
using System.Collections.Generic;

namespace TaskyApp.Model;

public partial class RegisteredAccount
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
