﻿using System;
using System.Collections.Generic;

namespace TiendaTennis.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public string? Contraseña { get; set; }

    public string? Telefono { get; set; }
}
