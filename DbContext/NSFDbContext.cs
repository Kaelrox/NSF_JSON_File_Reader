using Microsoft.EntityFrameworkCore;
using NSF_JSON_Reader.Entities;


public class ApplicationDbContext : DbContext
{
    public DbSet<NSF_JSON_Reader.Entities.Award> Awards { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.Institution> Institutions { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.AwardInstitution> AwardInstitutions { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.Person> Persons { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.AwardPerson> AwardPersons { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.ProgramElement> ProgramElements { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.AwardProgramElement> AwardProgramElements { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.ProgramReference> ProgramReferences { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.AwardProgramReference> AwardProgramReferences { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.PrimaryProgramFundingSource> PrimaryProgramFundingSources { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.AwardFundingSource> AwardFundingSources { get; set; }
    public DbSet<NSF_JSON_Reader.Entities.FinancialObligationYear> FinancialObligationYears { get; set; }


    private readonly string _connectionString;

    public ApplicationDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql(_connectionString, new MySqlServerVersion(new Version(8, 0, 34)));
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity< NSF_JSON_Reader.Entities.Person >().ToTable("Person");
        modelBuilder.Entity<NSF_JSON_Reader.Entities.Award>().ToTable("award");
        modelBuilder.Entity<NSF_JSON_Reader.Entities.AwardPerson>().ToTable("award_person");
        modelBuilder.Entity<NSF_JSON_Reader.Entities.Institution>().ToTable("institution");
        modelBuilder.Entity<NSF_JSON_Reader.Entities.FinancialObligationYear>().ToTable("financialobligationyear");
        modelBuilder.Entity<NSF_JSON_Reader.Entities.PrimaryProgramFundingSource>().ToTable("primaryprogramfundingsource");
        modelBuilder.Entity<NSF_JSON_Reader.Entities.ProgramElement>().ToTable("programelement");
        modelBuilder.Entity<NSF_JSON_Reader.Entities.ProgramReference>().ToTable("programreference");

        // AwardInstitution
        modelBuilder.Entity<AwardInstitution>()
            .ToTable("award_institution")
            .HasKey(ai => new { ai.AwardId, ai.InstitutionId });

        modelBuilder.Entity<AwardInstitution>()
            .HasOne(ai => ai.Award)
            .WithMany(a => a.AwardInstitutions)
            .HasForeignKey(ai => ai.AwardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AwardInstitution>()
            .HasOne(ai => ai.Institution)
            .WithMany(i => i.AwardInstitutions)
            .HasForeignKey(ai => ai.InstitutionId)
            .OnDelete(DeleteBehavior.Cascade);

        // AwardPerson
        modelBuilder.Entity<AwardPerson>()
            .ToTable("award_person")
            .HasKey(ap => new { ap.AwardId, ap.PersonId });

        modelBuilder.Entity<AwardPerson>()
            .HasOne(ap => ap.Award)
            .WithMany(a => a.AwardPersons)
            .HasForeignKey(ap => ap.AwardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AwardPerson>()
            .HasOne(ap => ap.Person)
            .WithMany(p => p.AwardPersons)
            .HasForeignKey(ap => ap.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        // AwardProgramElement
        modelBuilder.Entity<AwardProgramElement>()
            .ToTable("award_programelement")
            .HasKey(ape => new { ape.AwardId, ape.ProgramElementId });

        modelBuilder.Entity<AwardProgramElement>()
            .HasOne(ape => ape.Award)
            .WithMany(a => a.AwardProgramElements)
            .HasForeignKey(ape => ape.AwardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AwardProgramElement>()
            .HasOne(ape => ape.ProgramElement)
            .WithMany(pe => pe.AwardProgramElements)
            .HasForeignKey(ape => ape.ProgramElementId)
            .OnDelete(DeleteBehavior.Cascade);

        // AwardProgramReference
        modelBuilder.Entity<AwardProgramReference>()
            .ToTable("award_programreference")
            .HasKey(apr => new { apr.AwardId, apr.ProgramReferenceId });

        modelBuilder.Entity<AwardProgramReference>()
            .HasOne(apr => apr.Award)
            .WithMany(a => a.AwardProgramReferences)
            .HasForeignKey(apr => apr.AwardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AwardProgramReference>()
            .HasOne(apr => apr.ProgramReference)
            .WithMany(pr => pr.AwardProgramReferences)
            .HasForeignKey(apr => apr.ProgramReferenceId)
            .OnDelete(DeleteBehavior.Cascade);

        // AwardFundingSource
        modelBuilder.Entity<AwardFundingSource>()
            .ToTable("award_fundingsource")
            .HasKey(afs => new { afs.AwardId, afs.FundingSourceId });

        modelBuilder.Entity<AwardFundingSource>()
            .HasOne(afs => afs.Award)
            .WithMany(a => a.AwardFundingSources)
            .HasForeignKey(afs => afs.AwardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AwardFundingSource>()
            .HasOne(afs => afs.FundingSource)
            .WithMany(fs => fs.AwardFundingSources)
            .HasForeignKey(afs => afs.FundingSourceId)
            .OnDelete(DeleteBehavior.Cascade);

        //Added because entity framework hates me
        modelBuilder.Entity<NSF_JSON_Reader.Entities.FinancialObligationYear>(entity =>
        {
            entity.HasKey(f => f.ObligationId);
            entity.HasOne(f => f.Award)
                  .WithMany(a => a.FinancialObligations)
                  .HasForeignKey(f => f.AwardId)
                  .OnDelete(DeleteBehavior.Cascade);
        });


        // Unique constraints
        modelBuilder.Entity<NSF_JSON_Reader.Entities.Institution>()
            .HasIndex(i => i.UeiNumber)
            .IsUnique();

        //modelBuilder.Entity<NSF_JSON_Reader.Entities.Institution>()
        //    .HasIndex(i => i.ParentUeiNumber)
        //    .IsUnique();

        modelBuilder.Entity<Award>()
            .HasIndex(a => a.NSFAwdId)
            .IsUnique();
    }
}
