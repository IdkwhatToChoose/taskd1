using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Model;

public partial class Taskd1Context : DbContext
{
    public Taskd1Context()
    {
    }

    public Taskd1Context(DbContextOptions<Taskd1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<RegisteredAccount> RegisteredAccounts { get; set; }

    public virtual DbSet<TaskProp> TaskProps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOPCOMP;Initial Catalog=taskd1;Trusted_Connection=True;Encrypt=False;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RegisteredAccount>(entity =>
        {
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<TaskProp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table_1");

            entity.Property(e => e.Completed)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Task)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaskDescription)
                .HasMaxLength(350)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
