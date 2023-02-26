using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessCaseEYAcademy.Models;

public partial class BusinessCaseContext : DbContext
{
    public BusinessCaseContext()
    {
    }

    public BusinessCaseContext(DbContextOptions<BusinessCaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bcfeedback> Bcfeedbacks { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Produit> Produits { get; set; }

    public virtual DbSet<Reclamation> Reclamations { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bcfeedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId);

            entity.ToTable("BCFeedback");

            entity.Property(e => e.Commentaire).HasColumnType("text");
            entity.Property(e => e.Feedback).HasColumnType("text");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mdp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MDP");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Produit>(entity =>
        {
            entity.HasKey(e => e.Produit1);

            entity.ToTable("Produit");

            entity.Property(e => e.Produit1).HasColumnName("Produit");
            entity.Property(e => e.Categorie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reclamation>(entity =>
        {
            entity.ToTable("Reclamation");

            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Etat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importance)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Solution)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.Property(e => e.Categorie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
