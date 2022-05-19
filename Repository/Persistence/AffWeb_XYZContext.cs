using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository.Core.Models;
using Utils;

namespace Repository.Persistence
{
    public partial class AffWeb_XYZContext : DbContext
    {
        public AffWeb_XYZContext()
        {
        }

        public AffWeb_XYZContext(DbContextOptions<AffWeb_XYZContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CpyRotCom> CpyRotComs { get; set; } = null!;
        public virtual DbSet<Dbversion> Dbversions { get; set; } = null!;
        public virtual DbSet<DeletedSpot> DeletedSpots { get; set; } = null!;
        public virtual DbSet<Dtslog> Dtslogs { get; set; } = null!;
        public virtual DbSet<DuplicateSpot> DuplicateSpots { get; set; } = null!;
        public virtual DbSet<EmailNewSpot> EmailNewSpots { get; set; } = null!;
        public virtual DbSet<EmailUpdateSpot> EmailUpdateSpots { get; set; } = null!;
        public virtual DbSet<Eua> Euas { get; set; } = null!;
        public virtual DbSet<ExportHeader> ExportHeaders { get; set; } = null!;
        public virtual DbSet<ExportSpot> ExportSpots { get; set; } = null!;
        public virtual DbSet<GameInfo> GameInfos { get; set; } = null!;
        public virtual DbSet<GameInfoTmp> GameInfoTmps { get; set; } = null!;
        public virtual DbSet<Header> Headers { get; set; } = null!;
        public virtual DbSet<History> Histories { get; set; } = null!;
        public virtual DbSet<Makegood> Makegoods { get; set; } = null!;
        public virtual DbSet<MissedReason> MissedReasons { get; set; } = null!;
        public virtual DbSet<MissedSpot> MissedSpots { get; set; } = null!;
        public virtual DbSet<NewSpot> NewSpots { get; set; } = null!;
        public virtual DbSet<Pwchange> Pwchanges { get; set; } = null!;
        public virtual DbSet<ReplacementReason> ReplacementReasons { get; set; } = null!;
        public virtual DbSet<ReportParm> ReportParms { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<SiteOption> SiteOptions { get; set; } = null!;
        public virtual DbSet<Spot> Spots { get; set; } = null!;
        public virtual DbSet<SpotHistory> SpotHistories { get; set; } = null!;
        public virtual DbSet<SpotRevision> SpotRevisions { get; set; } = null!;
        public virtual DbSet<SpotsVendorImported> SpotsVendorImporteds { get; set; } = null!;
        public virtual DbSet<Srchange> Srchanges { get; set; } = null!;
        public virtual DbSet<StationFileStatus> StationFileStatuses { get; set; } = null!;
        public virtual DbSet<SystemOption> SystemOptions { get; set; } = null!;
        public virtual DbSet<TempSpotWithError> TempSpotWithErrors { get; set; } = null!;
        public virtual DbSet<TmpExportSpot> TmpExportSpots { get; set; } = null!;
        public virtual DbSet<UpdatedSpot> UpdatedSpots { get; set; } = null!;
        public virtual DbSet<UserActivity> UserActivities { get; set; } = null!;
        public virtual DbSet<VendorServiceController> VendorServiceControllers { get; set; } = null!;
        public virtual DbSet<VwCurSpot> VwCurSpots { get; set; } = null!;
        public virtual DbSet<VwDeletedRadioSpot> VwDeletedRadioSpots { get; set; } = null!;
        public virtual DbSet<VwImpNewSpot> VwImpNewSpots { get; set; } = null!;
        public virtual DbSet<VwNewspot> VwNewspots { get; set; } = null!;
        public virtual DbSet<VwRadioSpot> VwRadioSpots { get; set; } = null!;
        public virtual DbSet<VwSpot> VwSpots { get; set; } = null!;
        public virtual DbSet<VwTstNewEmail> VwTstNewEmails { get; set; } = null!;
        public virtual DbSet<VwUpdatespot> VwUpdatespots { get; set; } = null!;
        public virtual DbSet<VwWeekDate> VwWeekDates { get; set; } = null!;
        public virtual DbSet<WebEmt> WebEmts { get; set; } = null!;
        public virtual DbSet<WebExportArchive> WebExportArchives { get; set; } = null!;
        public virtual DbSet<WebSession> WebSessions { get; set; } = null!;
        public virtual DbSet<WebSpot> WebSpots { get; set; } = null!;
        public virtual DbSet<WebVendor> WebVendors { get; set; } = null!;
        public virtual DbSet<WebVendorCountArchive> WebVendorCountArchives { get; set; } = null!;
        public virtual DbSet<WebVendorExport> WebVendorExports { get; set; } = null!;
        public virtual DbSet<WebVendorExportFact> WebVendorExportFacts { get; set; } = null!;
        public virtual DbSet<WebVendorImportQueue> WebVendorImportQueues { get; set; } = null!;
        public virtual DbSet<WebVendorImportQueueStatus> WebVendorImportQueueStatuses { get; set; } = null!;
        public virtual DbSet<WebVendorOrphanedSpot> WebVendorOrphanedSpots { get; set; } = null!;
        public virtual DbSet<WebVendorServiceLog> WebVendorServiceLogs { get; set; } = null!;
        public virtual DbSet<WebVendorsHeader> WebVendorsHeaders { get; set; } = null!;
        public virtual DbSet<Webl> Webls { get; set; } = null!;
        public virtual DbSet<WeblHistory> WeblHistories { get; set; } = null!;
        public virtual DbSet<Wh> Whs { get; set; } = null!;
        public virtual DbSet<Wh2> Wh2s { get; set; } = null!;
        public virtual DbSet<WorkStatus> WorkStatuses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CpyRotCom>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("CpyRotCom");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("text");
            });

            modelBuilder.Entity<Dbversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DBVersion");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VersionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");
            });

            modelBuilder.Entity<DeletedSpot>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.AstCode, "IX_DeleteSpots")
                    .HasFillFactor(90);

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dtslog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DTSLog");

                entity.Property(e => e.Dtspackage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DTSPackage");

                entity.Property(e => e.Event)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LogID");
            });

            modelBuilder.Entity<DuplicateSpot>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AstCode).HasColumnName("astCode");
            });

            modelBuilder.Entity<EmailNewSpot>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Code, "IX_EmailNewSpots")
                    .HasFillFactor(90);

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Station)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailUpdateSpot>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Code, "IX_EmailUpdateSpots")
                    .HasFillFactor(90);

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Station)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Eua>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EUA");

                entity.Property(e => e.EndUserAgreement).HasColumnType("text");

                entity.Property(e => e.Ukey)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UKEY");
            });

            modelBuilder.Entity<ExportHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exportHeader");

                entity.Property(e => e.Attagreementemail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attagreementemail");

                entity.Property(e => e.Attagreementpw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attagreementpw");

                entity.Property(e => e.Attcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attcode");

                entity.Property(e => e.Attexporttype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attexporttype");

                entity.Property(e => e.Attlogtype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attlogtype");

                entity.Property(e => e.Attposttype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attposttype");

                entity.Property(e => e.Attstationemail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attstationemail");

                entity.Property(e => e.Attstationpw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attstationpw");

                entity.Property(e => e.Networkname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("networkname");

                entity.Property(e => e.Networkswprovider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("networkswprovider");

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShowAvailNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("startTime");

                entity.Property(e => e.Stationname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stationname");

                entity.Property(e => e.Stationprovider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stationprovider");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleFtpsite)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("VehicleFTPSite");

                entity.Property(e => e.Vehiclename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vehiclename");

                entity.Property(e => e.Websiteprovider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("websiteprovider");
            });

            modelBuilder.Entity<ExportSpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exportSpots");

                entity.HasIndex(e => e.FeedDate, "IX_ExportSpots_FeedDate");

                entity.HasIndex(e => e.AttCode, "IX_ExportSpots_attCode");

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')")
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<GameInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GameInfo");

                entity.HasIndex(e => e.Code, "IX_GameInfo_Code");

                entity.Property(e => e.AttCode)
                    .HasColumnName("attCode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EventCarried)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('U')")
                    .IsFixedLength();

                entity.Property(e => e.FeedSource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GameDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GameStartTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomeTeamAbbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomeTeamName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTeamAbbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTeamName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GameInfoTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GameInfo_Tmp");

                entity.Property(e => e.AttCode)
                    .HasColumnName("attCode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EventCarried)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('U')")
                    .IsFixedLength();

                entity.Property(e => e.FeedSource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GameDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GameStartTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomeTeamAbbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomeTeamName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTeamAbbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTeamName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Header>(entity =>
            {
                entity.HasKey(e => e.Attcode)
                    .HasName("PK_Header");

                entity.ToTable("header");

                entity.HasIndex(e => e.Stationname, "IX_Header_StationName")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Vehiclename, "IX_Header_VehicleName")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.MultiCast, "IX_header_MC")
                    .HasFillFactor(90);

                entity.Property(e => e.Attcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attcode");

                entity.Property(e => e.AltVehName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("altVehName")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.Attagreementemail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attagreementemail");

                entity.Property(e => e.Attagreementpw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attagreementpw");

                entity.Property(e => e.Attexporttype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attexporttype");

                entity.Property(e => e.Attlogtype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attlogtype");

                entity.Property(e => e.Attposttype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attposttype");

                entity.Property(e => e.Attstationemail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attstationemail");

                entity.Property(e => e.Attstationpw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attstationpw");

                entity.Property(e => e.InterfaceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogEndDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogStartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Market)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MgsOnWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MGsOnWeb")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Mode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MonthlyPosting)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MultiCast)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Networkname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("networkname");

                entity.Property(e => e.Networkswprovider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("networkswprovider");

                entity.Property(e => e.PledgeByEvent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.Rank).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplacementsOnWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShowAvailNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShowCart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("startTime");

                entity.Property(e => e.Stationname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stationname");

                entity.Property(e => e.Stationprovider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stationprovider");

                entity.Property(e => e.SuppressLog)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UseActual)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VehicleFtpsite)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("VehicleFTPSite");

                entity.Property(e => e.Vehiclename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vehiclename");

                entity.Property(e => e.WebLogFeedTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WebLogSummary)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WebSiteVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Websiteprovider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("websiteprovider");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("History");

                entity.Property(e => e.HCallLetters)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hCallLetters");

                entity.Property(e => e.HCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("hCode");

                entity.Property(e => e.HDate)
                    .HasColumnType("datetime")
                    .HasColumnName("hDate");

                entity.Property(e => e.HPostDay)
                    .HasColumnType("datetime")
                    .HasColumnName("hPostDay");

                entity.Property(e => e.HTime)
                    .HasColumnType("datetime")
                    .HasColumnName("hTime");

                entity.Property(e => e.HType).HasColumnName("hType");

                entity.Property(e => e.HUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hUserName");

                entity.Property(e => e.HVehicleName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hVehicleName");

                entity.Property(e => e.HattCode).HasColumnName("hattCode");
            });

            modelBuilder.Entity<Makegood>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.AttCode, e.OrgAstCode }, "IX_MAKEGOODS_ORGASTCODE");

                entity.Property(e => e.AirDate)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AirTime)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.Isci)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ISCI");
            });

            modelBuilder.Entity<MissedReason>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IsDefault)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<MissedSpot>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')")
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NewSpot>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.AttCode, "IX_NewSpots");

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')")
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1-1-2000')")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pwchange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PWChanges");

                entity.Property(e => e.AttCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attCode");

                entity.Property(e => e.NewAgreementPw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NewAgreementPW");

                entity.Property(e => e.NewStationPw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NewStationPW");

                entity.Property(e => e.OldAgreementPw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OldAgreementPW");

                entity.Property(e => e.OldStationPw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OldStationPW");

                entity.Property(e => e.StationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReplacementReason>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<ReportParm>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Parameters)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RecId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RecID");

                entity.Property(e => e.ReplaceSql)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ReplaceSQL");

                entity.Property(e => e.RptfileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RPTFileName");

                entity.Property(e => e.Sqlstring)
                    .HasColumnType("text")
                    .HasColumnName("SQLString");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteOption>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdminAddress1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminAddress2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminCity)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminFax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminLastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminState)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdminZip)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AllowBonusSpots)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ChngPswd).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.CombineVehicles)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DaysRetainPosted).HasDefaultValueSql("((30))");

                entity.Property(e => e.DaysToDelayExport).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysToRetainMissed).HasDefaultValueSql("((30))");

                entity.Property(e => e.EndUserAgreement).HasColumnType("text");

                entity.Property(e => e.NoDaysViewPost)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('30')");

                entity.Property(e => e.SiteAllowAutoPost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.SiteAllowMgspots)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteAllowMGSpots")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.SiteAllowReplSpots)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteAllowReplSpots")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.SiteAllowTodayAndFuturePosting)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteAllowTodayAndFuturePosting")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.SiteCompetSepTime)
                    .HasColumnName("siteCompetSepTime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteIscipolicy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteISCIPolicy")
                    .HasDefaultValueSql("('O')")
                    .IsFixedLength();

                entity.Property(e => e.SiteLastWk1stWk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteLastWk1stWk")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.SiteMgdays)
                    .HasColumnName("siteMGDays")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteMissedMgbypass)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteMissedMGBypass")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.SiteNoMissedReason)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteNoMissedReason")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.SiteSkipHiatusWk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteSkipHiatusWk")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.SiteSyncMulticast)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteSyncMulticast")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.SiteTimeRange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteTimeRange")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.SiteValidDaysOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteValidDaysOnly")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.SiteWithinMissMonth)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("siteWithinMissMonth")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.SuppressLogs).HasDefaultValueSql("((0))");

                entity.Property(e => e.WeeksOverdue).HasDefaultValueSql("((5))");
            });

            modelBuilder.Entity<Spot>(entity =>
            {
                entity.HasKey(e => e.AstCode);

                entity.HasIndex(e => e.ExportedFlag, "IX_Spots_ExportedFlag")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.AttCode, "IX_Spots_Headers")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PledgeEndDate, "IX_Spots_Pledge_End_Date")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PledgeStartDate, "IX_Spots_Pledge_Start_Date")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.RecType, "IX_Spots_RecType")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SpotSeqNum, "IX_Spots_SpotSeqNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostedFlag, "IX_Spots_postedFlag")
                    .HasFillFactor(90);

                entity.Property(e => e.AstCode)
                    .ValueGeneratedNever()
                    .HasColumnName("astCode");

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')")
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SpotHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Spot_History");

                entity.HasIndex(e => e.AttCode, "IDX_SH_ATTCODE");

                entity.HasIndex(e => e.AttCode, "IX_Spot_History");

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime).HasColumnType("datetime");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SpotRevision>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Srlink, "IX_SpotRevisions_SRLink")
                    .HasFillFactor(90);

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')")
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SpotsVendorImported>(entity =>
            {
                entity.HasKey(e => e.AstCode)
                    .HasName("PK__SpotsVen__7258E4E2C6A8FC0C");

                entity.ToTable("SpotsVendorImported");

                entity.Property(e => e.AstCode)
                    .ValueGeneratedNever()
                    .HasColumnName("astCode");

                entity.Property(e => e.ActualDateTimeH1)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31 01:23:45')");

                entity.Property(e => e.ActualDateTimeH2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31 01:23:45')");

                entity.Property(e => e.ActualDateTimeH3)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31 01:23:45')");

                entity.Property(e => e.Iscih1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCIH1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iscih2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCIH2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iscih3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCIH3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iscioriginal)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCIOriginal")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessedDateTimeH1)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcessedDateTimeH2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcessedDateTimeH3)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceH1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceH2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceH3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCodeH1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCodeH2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCodeH3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Srchange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SRChanges");

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.Msg)
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StationFileStatus>(entity =>
            {
                entity.HasKey(e => new { e.EndDate, e.AttCode })
                    .HasName("PK__StationFileStatu__18977ACE");

                entity.ToTable("StationFileStatus");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.AttCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.HasOne(d => d.AttCodeNavigation)
                    .WithMany(p => p.StationFileStatuses)
                    .HasForeignKey(d => d.AttCode)
                    .HasConstraintName("FK__StationFi__AttCo__198B9F07");
            });

            modelBuilder.Entity<SystemOption>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.LastWebLcode).HasColumnName("LastWebLCode");

                entity.Property(e => e.NetWorkName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SignonTroubleLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpfromEmailAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SMTPFromEmailAddress");

                entity.Property(e => e.SmtpfromName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SMTPFromName");

                entity.Property(e => e.Smtppassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SMTPPassword");

                entity.Property(e => e.Smtpport)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMTPPort");

                entity.Property(e => e.Smtpserver)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SMTPServer");

                entity.Property(e => e.SmtpuserId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SMTPUserID");

                entity.Property(e => e.WebLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempSpotWithError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempSpotWithError");

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime).HasColumnType("datetime");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TmpExportSpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_exportSpots");

                entity.Property(e => e.ActualAirDate1)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ActualAirTime1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FeedDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FeedTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.PledgeEndDate)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeStartDate1)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeStartTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpdatedSpot>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.AstCode, "IX_UpdatedSpots_astCode");

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.ActualTime).HasColumnType("datetime");

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.Isci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISCI");

                entity.Property(e => e.MissedReason)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserActivity");

                entity.Property(e => e.HashedPassword)
                    .IsUnicode(false)
                    .HasColumnName("hashedPassword");

                entity.Property(e => e.UaBrowserInfo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uaBrowserInfo")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UaCallLetters)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uaCallLetters");

                entity.Property(e => e.UaCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("uaCode");

                entity.Property(e => e.UaDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("uaDateTime");

                entity.Property(e => e.UaIpaddr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uaIPAddr");

                entity.Property(e => e.UaPassWord)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uaPassWord");

                entity.Property(e => e.UaPcname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uaPCName");
            });

            modelBuilder.Entity<VendorServiceController>(entity =>
            {
                entity.HasKey(e => e.Mode)
                    .HasName("PK__VendorSe__2488AC2793BB82F1");

                entity.ToTable("VendorServiceController");

                entity.Property(e => e.Mode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('E')")
                    .IsFixedLength();

                entity.Property(e => e.ExportFrom).HasColumnType("datetime");

                entity.Property(e => e.ExportRetries).HasDefaultValueSql("((3))");

                entity.Property(e => e.ExportSpotMax).HasDefaultValueSql("((5000))");

                entity.Property(e => e.GenerateDebug)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.GenerateFile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.HaltUntil)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01')");

                entity.Property(e => e.ImportFiles)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ImportLast)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01')");

                entity.Property(e => e.ImportSpan)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1:00:00')");

                entity.Property(e => e.InternalTesting)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.IsRunning)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isRunning")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwCurSpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CurSpots");

                entity.Property(e => e.ActualAirDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualAirtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualDateTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime).HasColumnType("datetime");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FeedTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PledgeEndTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PledgeStartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PledgeStartTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwDeletedRadioSpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_DeletedRadioSpots");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attCode");

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwImpNewSpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ImpNewSpots");

                entity.Property(e => e.ActualAirDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualAirtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualDateTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime).HasColumnType("datetime");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FeedTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PledgeEndTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PledgeStartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PledgeStartTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwNewspot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_newspots");

                entity.Property(e => e.Email)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate).HasColumnType("datetime");

                entity.Property(e => e.Station)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRadioSpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_RadioSpots");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attCode");

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.StationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSpots");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AiredDt)
                    .HasColumnType("datetime")
                    .HasColumnName("AiredDT");

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode");

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Psd)
                    .HasColumnType("datetime")
                    .HasColumnName("PSD");

                entity.Property(e => e.Pst)
                    .HasColumnType("datetime")
                    .HasColumnName("PST");

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Seqn).HasColumnName("SEQN");

                entity.Property(e => e.Sn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.SrAdvt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SR_Advt");

                entity.Property(e => e.SrAstCode).HasColumnName("SR_astCode");

                entity.Property(e => e.SrAttCode).HasColumnName("SR_attCode");

                entity.Property(e => e.SrAvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SR_AvailName");

                entity.Property(e => e.SrCpyRotCode).HasColumnName("SR_CpyRotCode");

                entity.Property(e => e.SrFeedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SR_FeedDate");

                entity.Property(e => e.SrFeedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("SR_FeedTime");

                entity.Property(e => e.SrIsci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SR_ISCI")
                    .IsFixedLength();

                entity.Property(e => e.SrPledgeEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SR_PledgeEndDate");

                entity.Property(e => e.SrPledgeEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("SR_PledgeEndTime");

                entity.Property(e => e.SrProd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SR_Prod");

                entity.Property(e => e.SrRecType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SR_RecType")
                    .IsFixedLength();

                entity.Property(e => e.SrSpotLen).HasColumnName("SR_SpotLen");

                entity.Property(e => e.SrTranType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SR_TranType");

                entity.Property(e => e.Srpsd)
                    .HasColumnType("datetime")
                    .HasColumnName("SRPSD");

                entity.Property(e => e.Srpst)
                    .HasColumnType("datetime")
                    .HasColumnName("SRPST");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("VN");
            });

            modelBuilder.Entity<VwTstNewEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TST_NewEmails");

                entity.Property(e => e.Email)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate).HasColumnType("datetime");

                entity.Property(e => e.Station)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUpdatespot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_updatespots");

                entity.Property(e => e.Email)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate).HasColumnType("datetime");

                entity.Property(e => e.Station)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwWeekDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwWeekDates");

                entity.Property(e => e.MonDate)
                    .HasColumnType("datetime")
                    .HasColumnName("monDate");

                entity.Property(e => e.StationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sunDate");

                entity.Property(e => e.VehicleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebEmt>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("WebEMT");

                entity.HasIndex(e => e.CallLetters, "IX_WebEMT_CallLetters");

                entity.HasIndex(e => e.Code, "IX_WebEMT_Code");

                entity.HasIndex(e => e.Email, "IX_WebEMT_EMail");

                entity.Property(e => e.CallLetters)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("EMail")
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsRequired()
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<WebExportArchive>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__WebExpor__A25C5AA6306BB35F");

                entity.ToTable("WebExportArchive");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.EnteredDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExportMondayDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01')");

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01')");

                entity.Property(e => e.VendorIdCode).HasColumnName("vendorIdCode");
            });

            modelBuilder.Entity<WebSession>(entity =>
            {
                entity.HasKey(e => e.Ukey);

                entity.ToTable("WebSession");

                entity.Property(e => e.Ukey)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UKey")
                    .IsFixedLength();

                entity.Property(e => e.Dtstamp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DTStamp")
                    .IsFixedLength();

                entity.Property(e => e.Pcname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PCName")
                    .IsFixedLength();
            });

            modelBuilder.Entity<WebSpot>(entity =>
            {
                entity.HasKey(e => e.Ukey)
                    .HasName("PK_WebSpotsUkey");

                entity.Property(e => e.Ukey).HasColumnName("UKey");

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')")
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<WebVendor>(entity =>
            {
                entity.HasKey(e => e.IdCode)
                    .HasName("PK__WebVendo__37DBAFC668E5ECBA");

                entity.Property(e => e.IdCode).ValueGeneratedNever();

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AllowAutoPost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.ApprovalPassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.LastImportDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01')");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendUpdatesOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.SourceName)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StationPassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StationUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorPassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.VendorUpdateStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.VendorUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<WebVendorCountArchive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebVendorCountArchive");

                entity.HasIndex(e => new { e.AttCode, e.VendorIdCode, e.SpotsDate, e.ExportOrImport }, "WVCA2");

                entity.HasIndex(e => e.ProcessedDateTime, "wvad");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.ExportOrImport)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('E')")
                    .IsFixedLength();

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Service)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')")
                    .IsFixedLength();

                entity.Property(e => e.SpotsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01')");

                entity.Property(e => e.VendorIdCode).HasColumnName("vendorIdCode");
            });

            modelBuilder.Entity<WebVendorExport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebVendorExport");

                entity.HasIndex(e => new { e.ExportMondayDate, e.HasBeenSent }, "PDS");

                entity.HasIndex(e => new { e.ExportMondayDate, e.HasBeenSent, e.SentToAff }, "PDSA");

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.EnteredDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExportMondayDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01')");

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1970-01-01')");

                entity.Property(e => e.SentToAff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.VendorIdCode).HasColumnName("vendorIdCode");
            });

            modelBuilder.Entity<WebVendorExportFact>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.ExportFactId, "IX_WebVendorExportFacts_Main");

                entity.HasIndex(e => new { e.AstCode, e.VendorIdCode }, "WVEF1");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AstCode).HasColumnName("astCode");

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.ExportFactId).ValueGeneratedOnAdd();

                entity.Property(e => e.FeedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-29')");

                entity.Property(e => e.FeedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-29')");

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.TransmissionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WebVendorImportQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebVendorImportQueue");

                entity.HasIndex(e => e.StatusGuid, "WVIQ");

                entity.Property(e => e.AiredDate).HasColumnType("datetime");

                entity.Property(e => e.AiredTime).HasColumnType("datetime");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("StatusGUID");
            });

            modelBuilder.Entity<WebVendorImportQueueStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebVendorImportQueueStatus");

                entity.HasIndex(e => e.Id, "UQ__WebVendo__3214EC265DDE0F29")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "WVIQI");

                entity.HasIndex(e => e.ReturnStatus, "WVIQS");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Message)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WebVendorOrphanedSpot>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.HandleUnMatched, e.AttCode, e.VendorIdCode }, "WVOS1");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.Isci)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Issue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Missed)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SentDateTime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<WebVendorServiceLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebVendorServiceLog");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.ExportOrImport)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FunctionCalled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.Message)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentToAff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Service)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')")
                    .IsFixedLength();

                entity.Property(e => e.TransmissionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WebVendorsHeader>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.AttCode })
                    .HasName("PK__WebVendo__6B42E6F4FE2E0D1B");

                entity.ToTable("WebVendors_Header");

                entity.Property(e => e.MulticastDontSend)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.VendorSpecificInfo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorSpecificInfo2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorSpecificInfo3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorSpecificInfo4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorSpecificInfo5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorSpecificInfo6)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Webl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WEBL");

                entity.Property(e => e.WebPostDay).HasColumnType("datetime");

                entity.Property(e => e.WebUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("webUserName");

                entity.Property(e => e.WeblCallLetters)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("weblCallLetters");

                entity.Property(e => e.WeblCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("weblCode");

                entity.Property(e => e.WeblDate)
                    .HasColumnType("datetime")
                    .HasColumnName("weblDate");

                entity.Property(e => e.WeblIpaddr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("weblIPAddr");

                entity.Property(e => e.WeblPcname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("weblPCName");

                entity.Property(e => e.WeblTime)
                    .HasColumnType("datetime")
                    .HasColumnName("weblTime");

                entity.Property(e => e.WeblType).HasColumnName("weblType");

                entity.Property(e => e.WeblVehicleName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("weblVehicleName");

                entity.Property(e => e.WeblattCode).HasColumnName("weblattCode");
            });

            modelBuilder.Entity<WeblHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Webl_History");

                entity.Property(e => e.WebPostDay).HasColumnType("datetime");

                entity.Property(e => e.WebUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("webUserName");

                entity.Property(e => e.WeblCallLetters)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("weblCallLetters");

                entity.Property(e => e.WeblCode).HasColumnName("weblCode");

                entity.Property(e => e.WeblDate)
                    .HasColumnType("datetime")
                    .HasColumnName("weblDate");

                entity.Property(e => e.WeblIpaddr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("weblIPAddr");

                entity.Property(e => e.WeblPcname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("weblPCName");

                entity.Property(e => e.WeblTime)
                    .HasColumnType("datetime")
                    .HasColumnName("weblTime");

                entity.Property(e => e.WeblType).HasColumnName("weblType");

                entity.Property(e => e.WeblVehicleName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("weblVehicleName");

                entity.Property(e => e.WeblattCode).HasColumnName("weblattCode");
            });

            modelBuilder.Entity<Wh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wh");

                entity.Property(e => e.AggreementEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AggreementPw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AggreementPW");

                entity.Property(e => e.AltVehName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("altVehName");

                entity.Property(e => e.AttCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attCode");

                entity.Property(e => e.InterfaceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogEndDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogStartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Market)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MgsOnWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MGsOnWeb")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Mode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MonthlyPosting)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MultiCast)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkSwprovider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NetworkSWProvider");

                entity.Property(e => e.PledgeByEvent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.PostType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rank).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplacementsOnWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShowAvailNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShowCart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationProvider)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationPw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("StationPW");

                entity.Property(e => e.SuppressLog)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UseActual)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VehicleFtpsite)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("VehicleFTPSite");

                entity.Property(e => e.VehicleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebLogFeedTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WebLogSummary)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WebSiteVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WebsiteProvider)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wh2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WH2");

                entity.Property(e => e.AggreementEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AggreementPw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AggreementPW");

                entity.Property(e => e.AltVehName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("altVehName");

                entity.Property(e => e.AttCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attCode");

                entity.Property(e => e.InterfaceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogEndDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogStartDate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Market)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MgsOnWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MGsOnWeb")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Mode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyPosting)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MultiCast)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkSwprovider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NetworkSWProvider");

                entity.Property(e => e.PledgeByEvent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.PostType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rank).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplacementsOnWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.SendLogEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShowAvailNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShowCart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationProvider)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StationPw)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("StationPW");

                entity.Property(e => e.SuppressLog)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UseActual)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.VehicleFtpsite)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("VehicleFTPSite");

                entity.Property(e => e.VehicleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebLogFeedTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WebLogSummary)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.WebSiteVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WebsiteProvider)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkStatus");

                entity.HasIndex(e => e.FileName, "IX_WorkStatus")
                    .HasFillFactor(90);

                entity.Property(e => e.Dtstamp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DTStamp");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Msg1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Msg2)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
