using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CockyEntertainment.Models;

public partial class CockyContext : DbContext
{
    public CockyContext()
    {
    }

    public CockyContext(DbContextOptions<CockyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Countryhq> Countryhqs { get; set; }

    public virtual DbSet<Currencymark> Currencymarks { get; set; }

    public virtual DbSet<Currencytype> Currencytypes { get; set; }

    public virtual DbSet<Customerteam> Customerteams { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Indivtransaction> Indivtransactions { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Teamtransaction> Teamtransactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:CE");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Countryhq>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__countryh__BC9931C7681626BE");

            entity.ToTable("countryhq");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Hqaddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqaddress1");
            entity.Property(e => e.Hqaddress2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hqaddress2");
            entity.Property(e => e.Hqcity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqcity");
            entity.Property(e => e.Hqcountry)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqcountry");
            entity.Property(e => e.Hqid).HasColumnName("hqid");
            entity.Property(e => e.Hqregion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqregion");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Currencymark>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__currency__BC9931C7FD6F5BAC");

            entity.ToTable("currencymark");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Currencydescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("currencydescription");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currencyid");
            entity.Property(e => e.Dollarmark).HasColumnName("dollarmark");
            entity.Property(e => e.Sterlingmark).HasColumnName("sterlingmark");
            entity.Property(e => e.Yuanmark).HasColumnName("yuanmark");
        });

        modelBuilder.Entity<Currencytype>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__currency__BC9931C727D23886");

            entity.ToTable("currencytype");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Currencydescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("currencydescription");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currencyid");
            entity.Property(e => e.Exchangecorpid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exchangecorpid");
            entity.Property(e => e.Exchangecorpsubid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exchangecorpsubid");
        });

        modelBuilder.Entity<Customerteam>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__customer__BC9931C798548457");

            entity.ToTable("customerteams");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Jgroupid).HasColumnName("jgroupid");
            entity.Property(e => e.Storeorigination)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("storeorigination");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
            entity.Property(e => e.Teamdescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("teamdescription");
            entity.Property(e => e.Teamid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teamid");
            entity.Property(e => e.TeammanagerJid).HasColumnName("teammanagerJid");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__employee__BC9931C702456EC3");

            entity.ToTable("employee");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Dynamicsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dynamicsid");
            entity.Property(e => e.Employeefullname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeefullname");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Jid).HasColumnName("jid");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Middle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("middle");
            entity.Property(e => e.Ncrid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ncrid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Indivtransaction>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__indivtra__BC9931C7F144055C");

            entity.ToTable("indivtransactions");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Adultqty).HasColumnName("adultqty");
            entity.Property(e => e.Branchmgrcomment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("branchmgrcomment");
            entity.Property(e => e.Childrenqty).HasColumnName("childrenqty");
            entity.Property(e => e.Cityregiontax).HasColumnName("cityregiontax");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currencyid");
            entity.Property(e => e.Custid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("custid");
            entity.Property(e => e.Erpsystemid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("erpsystemid");
            entity.Property(e => e.Erptransid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("erptransid");
            entity.Property(e => e.Fedtax).HasColumnName("fedtax");
            entity.Property(e => e.Othertax1).HasColumnName("othertax1");
            entity.Property(e => e.Othertax1descr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("othertax1descr");
            entity.Property(e => e.Othertax2).HasColumnName("othertax2");
            entity.Property(e => e.Othertax2descr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("othertax2descr");
            entity.Property(e => e.Seniorqty).HasColumnName("seniorqty");
            entity.Property(e => e.Statetx).HasColumnName("statetx");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
            entity.Property(e => e.Transamount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transamount");
            entity.Property(e => e.Transcomment1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transcomment1");
            entity.Property(e => e.Transcomment2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transcomment2");
            entity.Property(e => e.Transdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transdate");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__region__BC9931C7916E882E");

            entity.ToTable("region");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Hqaddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqaddress1");
            entity.Property(e => e.Hqaddress2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hqaddress2");
            entity.Property(e => e.Hqcity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqcity");
            entity.Property(e => e.Hqcountry)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqcountry");
            entity.Property(e => e.Hqregion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hqregion");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__stores__BC9931C77CA24FA4");

            entity.ToTable("stores");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("region");
            entity.Property(e => e.Regionid).HasColumnName("regionid");
            entity.Property(e => e.Storeid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("storeid");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
        });

        modelBuilder.Entity<Teamtransaction>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber).HasName("PK__teamtran__BC9931C779F8A08C");

            entity.ToTable("teamtransactions");

            entity.Property(e => e.Sequencenumber)
                .ValueGeneratedNever()
                .HasColumnName("sequencenumber");
            entity.Property(e => e.Adultqty).HasColumnName("adultqty");
            entity.Property(e => e.Branchmgrcomment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("branchmgrcomment");
            entity.Property(e => e.Childrenqty).HasColumnName("childrenqty");
            entity.Property(e => e.Cityregiontax).HasColumnName("cityregiontax");
            entity.Property(e => e.Companyid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("companyid");
            entity.Property(e => e.Currencyid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currencyid");
            entity.Property(e => e.Erpsystemid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("erpsystemid");
            entity.Property(e => e.Erptransid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("erptransid");
            entity.Property(e => e.Fedtax).HasColumnName("fedtax");
            entity.Property(e => e.Othertax1).HasColumnName("othertax1");
            entity.Property(e => e.Othertax1descr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("othertax1descr");
            entity.Property(e => e.Othertax2).HasColumnName("othertax2");
            entity.Property(e => e.Othertax2descr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("othertax2descr");
            entity.Property(e => e.Seniorqty).HasColumnName("seniorqty");
            entity.Property(e => e.Statetx).HasColumnName("statetx");
            entity.Property(e => e.Subaccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subaccount");
            entity.Property(e => e.Teamid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teamid");
            entity.Property(e => e.Transamount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transamount");
            entity.Property(e => e.Transcomment1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transcomment1");
            entity.Property(e => e.Transcomment2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transcomment2");
            entity.Property(e => e.Transdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transdate");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC0715332B1A");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.MovieName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ReviewDescr).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
