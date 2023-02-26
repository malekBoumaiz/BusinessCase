using System;
using System.Collections.Generic;

namespace BusinessCaseEYAcademy.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string? Email { get; set; }

    public string? Mdp { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public int? Telephone { get; set; }
}
