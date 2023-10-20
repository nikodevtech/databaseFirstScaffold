using System;
using System.Collections.Generic;

namespace DatabaseFirstScaffold.Models;

public partial class Genero
{
    public int Id { get; set; }

    public string Categoria { get; set; } = null!;

    public string Seccion { get; set; } = null!;
}
