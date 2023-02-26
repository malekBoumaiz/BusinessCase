using System;
using System.Collections.Generic;

namespace BusinessCaseEYAcademy.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string? Categorie { get; set; }

    public string? Email { get; set; }

    public bool? IsAdmin { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }
}
