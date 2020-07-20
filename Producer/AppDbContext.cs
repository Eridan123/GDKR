using Gkdr.Producer.models;
using Microsoft.EntityFrameworkCore;

namespace Gkdr.Producer
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Adjudications> Adjudications { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Distinct> Distinct { get; set; }
        public virtual DbSet<EmployerHistory> EmployerHistory { get; set; }
        public virtual DbSet<Employers> Employers { get; set; }
        public virtual DbSet<Lawlicences> Lawlicences { get; set; }
        public virtual DbSet<Licences> Licences { get; set; }
        public virtual DbSet<Logevents> Logevents { get; set; }
        public virtual DbSet<MissionerLicences> MissionerLicences { get; set; }
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<Organizationtypes> Organizationtypes { get; set; }
        public virtual DbSet<Otherlicences> Otherlicences { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<Religious> Religious { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<Subreligious> Subreligious { get; set; }
        public virtual DbSet<UserRegions> UserRegions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Violations> Violations { get; set; }
        public virtual DbSet<Violationtypes> Violationtypes { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adjudications>(entity =>
            {
                entity.ToTable("adjudications");

                entity.HasIndex(e => e.IdOrganzation)
                    .HasName("fk_adjudications_organizations_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.IdOrganzation).HasColumnType("int(11)");

                entity.HasOne(d => d.IdOrganzationNavigation)
                    .WithMany(p => p.Adjudications)
                    .HasForeignKey(d => d.IdOrganzation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_adjudications_organizations");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("cities");

                entity.HasIndex(e => e.IdDistinct)
                    .HasName("fk_region_cities_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdDistinct).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDistinctNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.IdDistinct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkregioncity");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("countries");

                entity.Property(e => e.Id).HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.ToTable("departments");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Distinct>(entity =>
            {
                entity.ToTable("distinct");

                entity.HasIndex(e => e.IdRegion)
                    .HasName("fk_region_distinct_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdRegion).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.Distinct)
                    .HasForeignKey(d => d.IdRegion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_region_distinct");
            });

            modelBuilder.Entity<EmployerHistory>(entity =>
            {
                entity.ToTable("employer_history");

                entity.HasIndex(e => e.IdEmployer)
                    .HasName("fk_employer_history_idx");

                entity.HasIndex(e => e.IdOrganization)
                    .HasName("fk_organization_histoy_idx");

                entity.HasIndex(e => e.IdSpeciality)
                    .HasName("fk_speciality_history_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.DateEnd).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdEmployer).HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization).HasColumnType("int(11)");

                entity.Property(e => e.IdSpeciality)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasColumnType("smallint(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdEmployerNavigation)
                    .WithMany(p => p.EmployerHistory)
                    .HasForeignKey(d => d.IdEmployer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_employer_history");

                entity.HasOne(d => d.IdOrganizationNavigation)
                    .WithMany(p => p.EmployerHistory)
                    .HasForeignKey(d => d.IdOrganization)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_organization_histoy");

                entity.HasOne(d => d.IdSpecialityNavigation)
                    .WithMany(p => p.EmployerHistory)
                    .HasForeignKey(d => d.IdSpeciality)
                    .HasConstraintName("fk_speciality_history");
            });

            modelBuilder.Entity<Employers>(entity =>
            {
                entity.ToTable("employers");

                entity.HasIndex(e => e.IdCitizenship)
                    .HasName("fk_citizenship_employer_idx");

                entity.HasIndex(e => e.IdCity)
                    .HasName("fk_city_employer_idx");

                entity.HasIndex(e => e.IdInviteOrganization)
                    .HasName("fk_invite_organization_idx");

                entity.HasIndex(e => e.IdOrganization)
                    .HasName("fk_organization_emploer_idx");

                entity.HasIndex(e => e.IdSpeciality)
                    .HasName("fk_spec_employer_idx");

                entity.HasIndex(e => e.UniqueId)
                    .HasName("UniqueId_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Contacts)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateBirth).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateDepart).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Education)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdCitizenship)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdCity).HasColumnType("int(11)");

                entity.Property(e => e.IdInviteOrganization)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdOrganization)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdSpeciality).HasColumnType("int(11)");

                entity.Property(e => e.IsMissioner)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicecnseMesionerIssueDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicenseMessioner)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OtherWorkplace)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PasportAddress)
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Photo)
                    .HasColumnType("longblob")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdCitizenshipNavigation)
                    .WithMany(p => p.Employers)
                    .HasForeignKey(d => d.IdCitizenship)
                    .HasConstraintName("fk_citizenship_employer");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Employers)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_city_employer");

                entity.HasOne(d => d.IdInviteOrganizationNavigation)
                    .WithMany(p => p.EmployersIdInviteOrganizationNavigation)
                    .HasForeignKey(d => d.IdInviteOrganization)
                    .HasConstraintName("fk_invite_organization");

                entity.HasOne(d => d.IdOrganizationNavigation)
                    .WithMany(p => p.EmployersIdOrganizationNavigation)
                    .HasForeignKey(d => d.IdOrganization)
                    .HasConstraintName("fk_organization_emploer");

                entity.HasOne(d => d.IdSpecialityNavigation)
                    .WithMany(p => p.Employers)
                    .HasForeignKey(d => d.IdSpeciality)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_spec_employer");
            });

            modelBuilder.Entity<Lawlicences>(entity =>
            {
                entity.ToTable("lawlicences");

                entity.HasIndex(e => e.IdOrganization)
                    .HasName("fk_lawlicenses_organization_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization).HasColumnType("int(11)");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.IdOrganizationNavigation)
                    .WithMany(p => p.Lawlicences)
                    .HasForeignKey(d => d.IdOrganization)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lawlicenses_organization");
            });

            modelBuilder.Entity<Licences>(entity =>
            {
                entity.ToTable("licences");

                entity.HasIndex(e => e.IdOrganization)
                    .HasName("fkorganization_license_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization).HasColumnType("int(11)");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status).HasColumnType("bit(1)");

                entity.HasOne(d => d.IdOrganizationNavigation)
                    .WithMany(p => p.Licences)
                    .HasForeignKey(d => d.IdOrganization)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkorganization_license");
            });

            modelBuilder.Entity<Logevents>(entity =>
            {
                entity.ToTable("logevents");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Action).HasColumnType("smallint(6)");

                entity.Property(e => e.EntityType).HasColumnType("int(11)");

                entity.Property(e => e.IdEntry).HasColumnType("int(11)");

                entity.Property(e => e.IdUser).HasColumnType("int(11)");

                entity.Property(e => e.Result).IsRequired();
            });

            modelBuilder.Entity<MissionerLicences>(entity =>
            {
                entity.ToTable("missioner_licences");

                entity.HasIndex(e => e.IdEmployer)
                    .HasName("fk_missioner_licences_employer_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdEmployer).HasColumnType("int(11)");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.IdEmployerNavigation)
                    .WithMany(p => p.MissionerLicences)
                    .HasForeignKey(d => d.IdEmployer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_missioner_licences_employer");
            });

            modelBuilder.Entity<Organizations>(entity =>
            {
                entity.ToTable("organizations");

                entity.HasIndex(e => e.IdCity)
                    .HasName("fk_city_orgaization_idx");

                entity.HasIndex(e => e.IdDepartment)
                    .HasName("IdDepartment");

                entity.HasIndex(e => e.IdManager)
                    .HasName("fk_manager_organization_idx");

                entity.HasIndex(e => e.IdSubReligion)
                    .HasName("fkreligionorganization_idx");

                entity.HasIndex(e => e.IdType)
                    .HasName("fkorganizationtype_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CertificateNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Forbidden)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IdCity).HasColumnType("int(11)");

                entity.Property(e => e.IdDepartment)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdMainOrganization)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdManager)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdSubReligion).HasColumnType("int(11)");

                entity.Property(e => e.IdType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IsBranch)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RegistrationDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.WebSite)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkcityorganization");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.IdManager)
                    .HasConstraintName("fkmanagerorganization");

                entity.HasOne(d => d.IdSubReligionNavigation)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.IdSubReligion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fksubreligion");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.IdType)
                    .HasConstraintName("fkorganizationtype");
            });

            modelBuilder.Entity<Organizationtypes>(entity =>
            {
                entity.ToTable("organizationtypes");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Otherlicences>(entity =>
            {
                entity.ToTable("otherlicences");

                entity.HasIndex(e => e.IdOrganization)
                    .HasName("fk_otherlicenses_organization_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization).HasColumnType("int(11)");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.IdOrganizationNavigation)
                    .WithMany(p => p.Otherlicences)
                    .HasForeignKey(d => d.IdOrganization)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_otherlicenses_organization");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.ToTable("regions");

                entity.HasIndex(e => e.IdCountry)
                    .HasName("Fk_country_regions_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCountry).HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Religious>(entity =>
            {
                entity.ToTable("religious");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.ToTable("speciality");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subreligious>(entity =>
            {
                entity.ToTable("subreligious");

                entity.HasIndex(e => e.IdReligion)
                    .HasName("fksubreligious_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdReligion).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdReligionNavigation)
                    .WithMany(p => p.Subreligious)
                    .HasForeignKey(d => d.IdReligion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fksubreligious");
            });

            modelBuilder.Entity<UserRegions>(entity =>
            {
                entity.ToTable("user_regions");

                entity.HasIndex(e => e.IdRegion)
                    .HasName("fk_region_user2_idx");

                entity.HasIndex(e => e.IdUser)
                    .HasName("fk_region_user_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdRegion).HasColumnType("int(11)");

                entity.Property(e => e.IdUser).HasColumnType("int(11)");

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.UserRegions)
                    .HasForeignKey(d => d.IdRegion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_region_user2");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserRegions)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_region_user");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Add)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IdRegion)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdType)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Modify)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Read)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SecondName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Violations>(entity =>
            {
                entity.ToTable("violations");

                entity.HasIndex(e => e.IdType)
                    .HasName("fkviolationtype_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization).HasColumnType("int(11)");

                entity.Property(e => e.IdType).HasColumnType("int(11)");

                entity.Property(e => e.PersonNameViolation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Violations)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkviolationtype");
            });

            modelBuilder.Entity<Violationtypes>(entity =>
            {
                entity.ToTable("violationtypes");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            // OnModelCreatingPartial(modelBuilder);
        }
    }
}