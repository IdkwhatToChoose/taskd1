﻿using System;
using System.Collections.Generic;

namespace MyWebApp.Model;

public partial class RegisteredAccount
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
