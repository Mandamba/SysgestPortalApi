using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SysgestColegios.Models;

namespace SysgestColegios.Data
{
    public partial class sysgest_colegiosContext : DbContext
    {
        public sysgest_colegiosContext()
        {
        }

        public sysgest_colegiosContext(DbContextOptions<sysgest_colegiosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DsAlunoTurma> DsAlunoTurmas { get; set; } = null!;
        public virtual DbSet<LogTorniquete> LogTorniquetes { get; set; } = null!;
        public virtual DbSet<Tabaluno> Tabalunos { get; set; } = null!;
        public virtual DbSet<Tabanoslectivo> Tabanoslectivos { get; set; } = null!;
        public virtual DbSet<Tabciclo> Tabciclos { get; set; } = null!;
        public virtual DbSet<Tabclass> Tabclasses { get; set; } = null!;
        public virtual DbSet<Tabcurso> Tabcursos { get; set; } = null!;
        public virtual DbSet<Tabmatricula> Tabmatriculas { get; set; } = null!;
        public virtual DbSet<Tabstatus> Tabstatuses { get; set; } = null!;
        public virtual DbSet<Tabturma> Tabturmas { get; set; } = null!;
        public virtual DbSet<Tabturno> Tabturnos { get; set; } = null!;
        public virtual DbSet<Tabuser> Tabusers { get; set; } = null!;
        public virtual DbSet<TbProfessorTurma> TbProfessorTurmas { get; set; } = null!;
        public virtual DbSet<Tdocente> Tdocentes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=srv\\SYSGEST;initial Catalog=sysgest_colegios;User Id=sa;Password=1234qwer.;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<DsAlunoTurma>(entity =>
            {
                entity.HasKey(e => e.IdDsAlunoTurma)
                    .HasName("PK_dbo.DsAlunoTurma");

                entity.ToTable("DsAlunoTurma");

                entity.Property(e => e.DataAlter).HasColumnType("datetime");

                entity.Property(e => e.DataAnulacao).HasColumnType("datetime");

                entity.Property(e => e.DataEntrAnt).HasColumnType("datetime");

                entity.Property(e => e.DataEntrada).HasColumnType("datetime");

                entity.Property(e => e.DataRegisto).HasColumnType("datetime");

                entity.Property(e => e.DataSaida).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.HoraAnulacao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoraEntrAnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoraEntrada)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoraSaida)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observacoes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAlter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeDeleted)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeRegist)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogTorniquete>(entity =>
            {
                entity.HasKey(e => e.IdLogTorniquete)
                    .HasName("PK_dbo.LogTorniquete");

                entity.ToTable("LogTorniquete");

                entity.HasIndex(e => e.IdAluno, "IX_IdAluno");

                entity.HasIndex(e => e.IdTorniquete, "IX_IdTorniquete");

                entity.Property(e => e.ApiId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardAcompIfIsAluno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardAlunoIfIsGuardian)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Classe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataRegisto).HasColumnType("datetime");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrActionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Funcao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GatewayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuardianName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoraRegisto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeEntidade)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTorniquete)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Turma)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Turno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.LogTorniquetes)
                    .HasForeignKey(d => d.IdAluno)
                    .HasConstraintName("FK_dbo.LogTorniquete_dbo.TABALUNOS_IdAluno");
            });

            modelBuilder.Entity<Tabaluno>(entity =>
            {
                entity.HasKey(e => e.Idaluno)
                    .HasName("PK__TABALUNO__7E25E18CCD685AC8");

                entity.ToTable("TABALUNOS");

                entity.HasIndex(e => new { e.Citipo, e.Cinumero }, "UC_ALUNOS_IDENTIFICACAO")
                    .IsUnique();

                entity.HasIndex(e => e.Nome, "UC_ALUNOS_NOME")
                    .IsUnique();

                entity.HasIndex(e => e.Numaluno, "UC_ALUNOS_NUMERO")
                    .IsUnique();

                entity.Property(e => e.Idaluno).HasColumnName("IDALUNO");

                entity.Property(e => e.Anulmatricula)
                    .HasColumnName("ANULMATRICULA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApiId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bairro)
                    .HasMaxLength(100)
                    .HasColumnName("BAIRRO");

                entity.Property(e => e.Cidata)
                    .HasColumnType("datetime")
                    .HasColumnName("CIDATA")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ciidpais).HasColumnName("CIIDPAIS");

                entity.Property(e => e.Cilocal)
                    .HasMaxLength(60)
                    .HasColumnName("CILOCAL");

                entity.Property(e => e.Cinumero)
                    .HasMaxLength(20)
                    .HasColumnName("CINUMERO");

                entity.Property(e => e.Citipo)
                    .HasMaxLength(1)
                    .HasColumnName("CITIPO");

                entity.Property(e => e.Civalidade)
                    .HasColumnType("datetime")
                    .HasColumnName("CIVALIDADE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Comuna)
                    .HasMaxLength(100)
                    .HasColumnName("COMUNA");

                entity.Property(e => e.Contribnumero)
                    .HasMaxLength(15)
                    .HasColumnName("CONTRIBNUMERO");

                entity.Property(e => e.CuidEspecSaude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datanasc)
                    .HasColumnType("datetime")
                    .HasColumnName("DATANASC")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DcanAdminMedic)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DCanAdminMedic");

                entity.Property(e => e.DescDoenCronic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrAlergias)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DrstritAliment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DRstritAliment");

                entity.Property(e => e.EedcLocalTrab)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EedcNaturalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Eedprofissao)
                    .HasMaxLength(100)
                    .HasColumnName("EEDPROFISSAO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Eedresidencia)
                    .HasMaxLength(100)
                    .HasColumnName("EEDRESIDENCIA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("FOTO");

                entity.Property(e => e.Idbolsa).HasColumnName("IDBOLSA");

                entity.Property(e => e.Idpaisorigem).HasColumnName("IDPAISORIGEM");

                entity.Property(e => e.Idprovincia)
                    .HasColumnName("IDPROVINCIA")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Idstatus)
                    .HasColumnName("IDSTATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo).HasColumnName("INACTIVO");

                entity.Property(e => e.LimiteSaldoDia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaeLocalTrab)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaeNaturalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Maeprofissao)
                    .HasMaxLength(100)
                    .HasColumnName("MAEPROFISSAO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maeresidencia)
                    .HasMaxLength(100)
                    .HasColumnName("MAERESIDENCIA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Morada)
                    .HasMaxLength(1000)
                    .HasColumnName("MORADA");

                entity.Property(e => e.MrecCob)
                    .HasColumnName("MRecCob")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(100)
                    .HasColumnName("MUNICIPIO");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("NOME");

                entity.Property(e => e.Numaluno).HasColumnName("NUMALUNO");

                entity.Property(e => e.ObsEii).HasColumnName("ObsEII");

                entity.Property(e => e.Observacoes).HasColumnName("OBSERVACOES");

                entity.Property(e => e.Oiemailenc)
                    .HasMaxLength(254)
                    .HasColumnName("OIEMAILENC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Oiemailmae)
                    .HasMaxLength(60)
                    .HasColumnName("OIEMAILMAE");

                entity.Property(e => e.Oiemailpai)
                    .HasMaxLength(60)
                    .HasColumnName("OIEMAILPAI");

                entity.Property(e => e.Oiencarregado)
                    .HasMaxLength(1)
                    .HasColumnName("OIENCARREGADO");

                entity.Property(e => e.Oinomeencarg)
                    .HasMaxLength(100)
                    .HasColumnName("OINOMEENCARG");

                entity.Property(e => e.Oinomemae)
                    .HasMaxLength(100)
                    .HasColumnName("OINOMEMAE");

                entity.Property(e => e.Oinomepai)
                    .HasMaxLength(100)
                    .HasColumnName("OINOMEPAI");

                entity.Property(e => e.Oiparentesco)
                    .HasMaxLength(60)
                    .HasColumnName("OIPARENTESCO");

                entity.Property(e => e.Oitelfencarg)
                    .HasMaxLength(20)
                    .HasColumnName("OITELFENCARG");

                entity.Property(e => e.Oitelfmae)
                    .HasMaxLength(20)
                    .HasColumnName("OITELFMAE");

                entity.Property(e => e.Oitelfpai)
                    .HasMaxLength(20)
                    .HasColumnName("OITELFPAI");

                entity.Property(e => e.OrecCob)
                    .HasColumnName("ORecCob")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Outrodesc).HasColumnName("OUTRODESC");

                entity.Property(e => e.Outrodescnome)
                    .HasMaxLength(100)
                    .HasColumnName("OUTRODESCNOME");

                entity.Property(e => e.Outrodescperc)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("OUTRODESCPERC");

                entity.Property(e => e.PaiLocalTrab)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaiNaturalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Paiprofissao)
                    .HasMaxLength(100)
                    .HasColumnName("PAIPROFISSAO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pairesidencia)
                    .HasMaxLength(100)
                    .HasColumnName("PAIRESIDENCIA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrecCob)
                    .HasColumnName("PRecCob")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuerAtl).HasColumnName("QuerATL");

                entity.Property(e => e.RequerCes).HasColumnName("RequerCES");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .HasColumnName("SEXO");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(20)
                    .HasColumnName("TELEFONE");

                entity.Property(e => e.Tipoaluno)
                    .HasMaxLength(1)
                    .HasColumnName("TIPOALUNO");

                entity.HasOne(d => d.IdstatusNavigation)
                    .WithMany(p => p.Tabalunos)
                    .HasForeignKey(d => d.Idstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ALUNOS_STATUS");
            });

            modelBuilder.Entity<Tabanoslectivo>(entity =>
            {
                entity.HasKey(e => e.Idano)
                    .HasName("PK__TABANOSL__932083D827081A47");

                entity.ToTable("TABANOSLECTIVOS");

                entity.HasIndex(e => e.Ano, "UC_ANOSLECTIVOS_ANO")
                    .IsUnique();

                entity.Property(e => e.Idano).HasColumnName("IDANO");

                entity.Property(e => e.Ano)
                    .HasColumnName("ANO")
                    .HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.Datafim)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAFIM");

                entity.Property(e => e.Datafimp1)
                    .HasColumnType("date")
                    .HasColumnName("DATAFIMP1");

                entity.Property(e => e.Datafimp2)
                    .HasColumnType("date")
                    .HasColumnName("DATAFIMP2");

                entity.Property(e => e.Datafimp3)
                    .HasColumnType("date")
                    .HasColumnName("DATAFIMP3");

                entity.Property(e => e.Datainicio)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAINICIO");

                entity.Property(e => e.Datainip1)
                    .HasColumnType("date")
                    .HasColumnName("DATAINIP1");

                entity.Property(e => e.Datainip2)
                    .HasColumnType("date")
                    .HasColumnName("DATAINIP2");

                entity.Property(e => e.Datainip3)
                    .HasColumnType("date")
                    .HasColumnName("DATAINIP3");

                entity.Property(e => e.Dataprevfim)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAPREVFIM");

                entity.Property(e => e.Dataprevinicio)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAPREVINICIO");

                entity.Property(e => e.Fechado)
                    .HasColumnName("FECHADO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.P1fechado).HasColumnName("P1Fechado");

                entity.Property(e => e.P2fechado).HasColumnName("P2Fechado");

                entity.Property(e => e.P3fechado).HasColumnName("P3Fechado");

                entity.Property(e => e.TextAnoLectivo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tabciclo>(entity =>
            {
                entity.HasKey(e => e.Idciclo)
                    .HasName("PK__TABCICLO__7357D8A11A3A7E98");

                entity.ToTable("TABCICLOS");

                entity.HasIndex(e => new { e.Nome, e.Idano }, "UC_CICLOS_NOME")
                    .IsUnique();

                entity.Property(e => e.Idciclo).HasColumnName("IDCICLO");

                entity.Property(e => e.Cursos)
                    .HasColumnName("CURSOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExclCreche).HasColumnName("Excl_Creche");

                entity.Property(e => e.Idano).HasColumnName("IDANO");

                entity.Property(e => e.Idsubsistemac).HasColumnName("IDSUBSISTEMAC");

                entity.Property(e => e.Idsubsistemal).HasColumnName("IDSUBSISTEMAL");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("NOME");

                entity.HasOne(d => d.IdanoNavigation)
                    .WithMany(p => p.Tabciclos)
                    .HasForeignKey(d => d.Idano)
                    .HasConstraintName("FK_CICLOSANO_IDANO");
            });

            modelBuilder.Entity<Tabclass>(entity =>
            {
                entity.HasKey(e => e.Idclasse)
                    .HasName("PK__TABCLASS__473363C8BBC20B9B");

                entity.ToTable("TABCLASSES");

                entity.HasIndex(e => new { e.Nome, e.Idano }, "UC_CLASSES_NOME")
                    .IsUnique();

                entity.Property(e => e.Idclasse).HasColumnName("IDCLASSE");

                entity.Property(e => e.DirPedag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtIdadeLimite).HasColumnType("date");

                entity.Property(e => e.EscolaTutela)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExclCreche).HasColumnName("Excl_Creche");

                entity.Property(e => e.Idano).HasColumnName("IDANO");

                entity.Property(e => e.Idciclo).HasColumnName("IDCICLO");

                entity.Property(e => e.Idpdgciclo).HasColumnName("IDPDGCICLO");

                entity.Property(e => e.Idplncurric).HasColumnName("IDPLNCURRIC");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MapOficTit01)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MapOficTit02)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MapOficTit03)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MapOficTit04)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MapOficTit05)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("NOME");

                entity.Property(e => e.NomeEscolaMapasOfic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumEscTutela)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubDirPedag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdanoNavigation)
                    .WithMany(p => p.Tabclasses)
                    .HasForeignKey(d => d.Idano)
                    .HasConstraintName("FK_CLASSEANO_IDANO");

                entity.HasOne(d => d.IdcicloNavigation)
                    .WithMany(p => p.Tabclasses)
                    .HasForeignKey(d => d.Idciclo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSES_CICLOS");
            });

            modelBuilder.Entity<Tabcurso>(entity =>
            {
                entity.HasKey(e => e.Idcurso)
                    .HasName("PK__TABCURSO__91D9FD32BAA7333D");

                entity.ToTable("TABCURSOS");

                entity.HasIndex(e => new { e.Nome, e.Idano }, "UC_CURSOS_NOME")
                    .IsUnique();

                entity.Property(e => e.Idcurso).HasColumnName("IDCURSO");

                entity.Property(e => e.Idano).HasColumnName("IDANO");

                entity.Property(e => e.Idciclo).HasColumnName("IDCICLO");

                entity.Property(e => e.Idplncurric).HasColumnName("IDPLNCURRIC");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("NOME");

                entity.HasOne(d => d.IdanoNavigation)
                    .WithMany(p => p.Tabcursos)
                    .HasForeignKey(d => d.Idano)
                    .HasConstraintName("FK_CURSOSANO_IDANO");

                entity.HasOne(d => d.IdcicloNavigation)
                    .WithMany(p => p.Tabcursos)
                    .HasForeignKey(d => d.Idciclo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURSOS_CICLOS");
            });

            modelBuilder.Entity<Tabmatricula>(entity =>
            {
                entity.HasKey(e => e.Idmatricula)
                    .HasName("PK__TABMATRI__987508BC2AA7CC33");

                entity.ToTable("TABMATRICULAS");

                entity.HasIndex(e => new { e.Idmatricula, e.Idaluno, e.Idanolectivo }, "U_TABMATRIC");

                entity.Property(e => e.Idmatricula).HasColumnName("IDMATRICULA");

                entity.Property(e => e.AnoAnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Anulmatricula).HasColumnName("ANULMATRICULA");

                entity.Property(e => e.CicloAnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseAnoAnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Confmatricula).HasColumnName("CONFMATRICULA");

                entity.Property(e => e.CursoAnoAnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datahoranulou)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAHORANULOU");

                entity.Property(e => e.Datamatric)
                    .HasColumnType("date")
                    .HasColumnName("DATAMATRIC")
                    .HasDefaultValueSql("('19000101')");

                entity.Property(e => e.Datamotivo)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAMOTIVO");

                entity.Property(e => e.FromExtSw).HasDefaultValueSql("((0))");

                entity.Property(e => e.Horamatric)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("HORAMATRIC")
                    .HasDefaultValueSql("(CONVERT([varchar](8),getdate(),(108)))");

                entity.Property(e => e.Idaluno).HasColumnName("IDALUNO");

                entity.Property(e => e.Idanolectivo).HasColumnName("IDANOLECTIVO");

                entity.Property(e => e.Idbolsa)
                    .HasColumnName("IDBOLSA")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Idclasse).HasColumnName("IDCLASSE");

                entity.Property(e => e.Idcurso).HasColumnName("IDCURSO");

                entity.Property(e => e.Idstatus)
                    .HasColumnName("IDSTATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idturma).HasColumnName("IDTURMA");

                entity.Property(e => e.Idturno).HasColumnName("IDTURNO");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.InstituicaoAnoAnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ismatricula).HasColumnName("ISMATRICULA");

                entity.Property(e => e.MatricInExtSw).HasDefaultValueSql("((0))");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(254)
                    .HasColumnName("MOTIVO");

                entity.Property(e => e.Numero)
                    .HasMaxLength(20)
                    .HasColumnName("NUMERO");

                entity.Property(e => e.TurmaAnoAnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TurmaFechado).HasDefaultValueSql("((0))");

                entity.Property(e => e.TurnoAnoAnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdalunoNavigation)
                    .WithMany(p => p.Tabmatriculas)
                    .HasForeignKey(d => d.Idaluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MATRICULAS_ALUNO");

                entity.HasOne(d => d.IdclasseNavigation)
                    .WithMany(p => p.Tabmatriculas)
                    .HasForeignKey(d => d.Idclasse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MATRICULAS_CLASSE");

                entity.HasOne(d => d.IdstatusNavigation)
                    .WithMany(p => p.Tabmatriculas)
                    .HasForeignKey(d => d.Idstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ALUNOMATRICULA_STATUS");

                entity.HasOne(d => d.IdturmaNavigation)
                    .WithMany(p => p.Tabmatriculas)
                    .HasForeignKey(d => d.Idturma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MATRICULAS_TURMA");

                entity.HasOne(d => d.IdturnoNavigation)
                    .WithMany(p => p.Tabmatriculas)
                    .HasForeignKey(d => d.Idturno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MATRICULAS_TURNO");
            });

            modelBuilder.Entity<Tabstatus>(entity =>
            {
                entity.HasKey(e => e.Idstatus)
                    .HasName("PK__TABSTATU__39212CBFD06A9FB3");

                entity.ToTable("TABSTATUS");

                entity.HasIndex(e => e.Nome, "UC_STATUS_NOME")
                    .IsUnique();

                entity.Property(e => e.Idstatus).HasColumnName("IDSTATUS");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo).HasColumnName("INACTIVO");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("NOME");

                entity.Property(e => e.Resumo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tabturma>(entity =>
            {
                entity.HasKey(e => e.Idturma)
                    .HasName("PK__TABTURMA__958415D23737153C");

                entity.ToTable("TABTURMAS");

                entity.HasIndex(e => new { e.Nome, e.Idano, e.Idclasse }, "UC_TURMAS_NOME")
                    .IsUnique();

                entity.Property(e => e.Idturma).HasColumnName("IDTURMA");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.ApiId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtFechada).HasColumnType("date");

                entity.Property(e => e.ExclCreche).HasColumnName("Excl_Creche");

                entity.Property(e => e.Filldatatemp).HasColumnName("FILLDATATEMP");

                entity.Property(e => e.HoraFechoTurma)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Horafecho)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("HORAFECHO");

                entity.Property(e => e.Idano).HasColumnName("IDANO");

                entity.Property(e => e.Idclasse).HasColumnName("IDCLASSE");

                entity.Property(e => e.Idcurso).HasColumnName("IDCURSO");

                entity.Property(e => e.Idplncurric).HasColumnName("IDPLNCURRIC");

                entity.Property(e => e.Idturno).HasColumnName("IDTURNO");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("NOME");

                entity.Property(e => e.Numvagas).HasColumnName("NUMVAGAS");

                entity.Property(e => e.Sala)
                    .HasMaxLength(10)
                    .HasColumnName("SALA");

                entity.HasOne(d => d.IdanoNavigation)
                    .WithMany(p => p.Tabturmas)
                    .HasForeignKey(d => d.Idano)
                    .HasConstraintName("FK_TURMASANO_IDANO");
            });

            modelBuilder.Entity<Tabturno>(entity =>
            {
                entity.HasKey(e => e.Idturno)
                    .HasName("PK__TABTURNO__95839F86FA7917C5");

                entity.ToTable("TABTURNOS");

                entity.HasIndex(e => new { e.Nome, e.Idano }, "UC_TURNOS_NOME")
                    .IsUnique();

                entity.Property(e => e.Idturno).HasColumnName("IDTURNO");

                entity.Property(e => e.ExclCreche).HasColumnName("Excl_Creche");

                entity.Property(e => e.Hfim)
                    .HasMaxLength(5)
                    .HasColumnName("HFIM");

                entity.Property(e => e.Hinicio)
                    .HasMaxLength(5)
                    .HasColumnName("HINICIO");

                entity.Property(e => e.Idano).HasColumnName("IDANO");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("NOME");

                entity.HasOne(d => d.IdanoNavigation)
                    .WithMany(p => p.Tabturnos)
                    .HasForeignKey(d => d.Idano)
                    .HasConstraintName("FK_TURNOSANO_IDANO");
            });

            modelBuilder.Entity<Tabuser>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("PK__TABUSER__94F7C0591889FC31");

                entity.ToTable("TABUSER");

                entity.HasIndex(e => e.Iniciais, "UC_USER_INICIAIS")
                    .IsUnique();

                entity.HasIndex(e => e.Nome, "UC_USER_NOME")
                    .IsUnique();

                entity.HasIndex(e => e.Userlogin, "UC_USER_USERLOGIN")
                    .IsUnique();

                entity.Property(e => e.Iduser).HasColumnName("IDUSER");

                entity.Property(e => e.Abrecaixa)
                    .IsRequired()
                    .HasColumnName("ABRECAIXA")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("INACTIVO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Iniciais)
                    .HasMaxLength(10)
                    .HasColumnName("INICIAIS");

                entity.Property(e => e.IsSuperAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mudarpwd).HasColumnName("MUDARPWD");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("NOME");

                entity.Property(e => e.NomePerfilAcesso).HasMaxLength(100);

                entity.Property(e => e.PassHs)
                    .HasMaxLength(64)
                    .HasColumnName("PassHS")
                    .IsFixedLength();

                entity.Property(e => e.SaltPw).HasColumnName("SaltPW");

                entity.Property(e => e.Useradmin)
                    .HasColumnName("USERADMIN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(50)
                    .HasColumnName("USERLOGIN");

                entity.Property(e => e.Userpassword)
                    .HasMaxLength(20)
                    .HasColumnName("USERPASSWORD");
            });

            modelBuilder.Entity<TbProfessorTurma>(entity =>
            {
                entity.HasKey(e => e.IdProfessorTurma);

                entity.ToTable("tb_ProfessorTurma");

                entity.Property(e => e.IdProfessorTurma).HasColumnName("id_ProfessorTurma");

                entity.Property(e => e.DataRegisto)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idturma).HasColumnName("IDTURMA");

                entity.Property(e => e.Iduser).HasColumnName("IDUSER");

                entity.HasOne(d => d.IdturmaNavigation)
                    .WithMany(p => p.TbProfessorTurmas)
                    .HasForeignKey(d => d.Idturma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_ProfessorTurma_TABTURMAS");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.TbProfessorTurmas)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_ProfessorTurma_TABUSER");
            });

            modelBuilder.Entity<Tdocente>(entity =>
            {
                entity.ToTable("TDocentes");

                entity.HasIndex(e => e.PaisIdPais, "IX_Pais_IdPais");

                entity.HasIndex(e => e.ProvinciaIdprovincia, "IX_Provincia_Idprovincia");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaEnsino)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bairro)
                    .HasMaxLength(100)
                    .HasColumnName("BAIRRO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codpostal)
                    .HasMaxLength(20)
                    .HasColumnName("CODPOSTAL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Comuna)
                    .HasMaxLength(100)
                    .HasColumnName("COMUNA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dataemissdoc)
                    .HasColumnType("date")
                    .HasColumnName("DATAEMISSDOC");

                entity.Property(e => e.Datanasc)
                    .HasColumnType("date")
                    .HasColumnName("DATANASC");

                entity.Property(e => e.DocumentoPessoalIdDocumentoPessoal).HasColumnName("DocumentoPessoal_IdDocumentoPessoal");

                entity.Property(e => e.DtAdmissao).HasColumnType("datetime");

                entity.Property(e => e.DtFimContrato).HasColumnType("datetime");

                entity.Property(e => e.DtIniContrato).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Funcao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HabLiter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasMaxLength(30)
                    .HasColumnName("IBAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idnacionalidade).HasColumnName("IDNACIONALIDADE");

                entity.Property(e => e.Idpaisemissdoc).HasColumnName("IDPAISEMISSDOC");

                entity.Property(e => e.Idrovincia).HasColumnName("IDROVINCIA");

                entity.Property(e => e.Idtipodoc).HasColumnName("IDTIPODOC");

                entity.Property(e => e.Idusr).HasColumnName("IDUSR");

                entity.Property(e => e.Inactivo).HasColumnName("INACTIVO");

                entity.Property(e => e.Localemissdoc)
                    .HasMaxLength(60)
                    .HasColumnName("LOCALEMISSDOC");

                entity.Property(e => e.Localidade)
                    .HasMaxLength(100)
                    .HasColumnName("LOCALIDADE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Morada)
                    .HasMaxLength(1000)
                    .HasColumnName("MORADA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(100)
                    .HasColumnName("MUNICIPIO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nib)
                    .HasMaxLength(30)
                    .HasColumnName("NIB")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nif)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NIF");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("NOME");

                entity.Property(e => e.Numdoc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NUMDOC");

                entity.Property(e => e.Numdocente).HasColumnName("NUMDOCENTE");

                entity.Property(e => e.Observacoes)
                    .HasColumnName("OBSERVACOES")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaisIdPais).HasColumnName("Pais_IdPais");

                entity.Property(e => e.Profissao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinciaIdprovincia).HasColumnName("Provincia_Idprovincia");

                entity.Property(e => e.Sexo).HasColumnName("SEXO");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.Property(e => e.Telemovel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEMOVEL");

                entity.Property(e => e.Validadedoc)
                    .HasColumnType("date")
                    .HasColumnName("VALIDADEDOC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
