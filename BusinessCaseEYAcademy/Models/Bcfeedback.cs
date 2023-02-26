using System;
using System.Collections.Generic;

namespace BusinessCaseEYAcademy.Models;

public partial class Bcfeedback
{
    public int FeedbackId { get; set; }

    public string? Commentaire { get; set; }

    public string? Feedback { get; set; }

    public int? Produit { get; set; }

    public int? Rating { get; set; }

    public int? Client { get; set; }
}
