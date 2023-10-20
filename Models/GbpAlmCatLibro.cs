using System;
using System.Collections.Generic;

namespace DatabaseFirstScaffold.Models;

public partial class GbpAlmCatLibro
{
    public long IdLibro { get; set; }

    public string? Titulo { get; set; }

    public string? Autor { get; set; }

    public string? Isbn { get; set; }

    public int? Edicion { get; set; }
}
