using System;
using System.Collections.Generic;

namespace BusinessCaseEYAcademy.Models;

public partial class Reclamation
{
    public int ReclamationId { get; set; }

    public string? Description { get; set; }

    public string? Etat { get; set; }

    public string? Importance { get; set; }

    public int? Produit { get; set; }

    public string? Solution { get; set; }

    public int? Staff { get; set; }

    public string? Titre { get; set; }
}
