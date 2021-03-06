﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perpustakaan.Data;

namespace Perpustakaan.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210125014743_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Perpustakaan.Models.Anggota", b =>
                {
                    b.Property<string>("NoKtp")
                        .HasColumnName("NoKTP")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Alamat")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int?>("IdUserId")
                        .HasColumnType("int(11)");

                    b.Property<string>("NamaLengkap")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("NoHp")
                        .IsRequired()
                        .HasColumnName("NoHP")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("NoKtp")
                        .HasName("PRIMARY");

                    b.HasIndex("IdUserId")
                        .HasName("IX_Anggota_IdUserId");

                    b.ToTable("anggota");
                });

            modelBuilder.Entity("Perpustakaan.Models.Buku", b =>
                {
                    b.Property<string>("KodeBuku")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("JudulBuku")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Penerbit")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Pengarang")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<short>("ThnTerbit")
                        .HasColumnType("smallint(6)");

                    b.HasKey("KodeBuku")
                        .HasName("PRIMARY");

                    b.ToTable("buku");
                });

            modelBuilder.Entity("Perpustakaan.Models.Pegawai", b =>
                {
                    b.Property<string>("Nip")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Alamat")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int?>("IdUserId")
                        .HasColumnType("int(11)");

                    b.Property<string>("NamaPegawai")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("NoHp")
                        .IsRequired()
                        .HasColumnName("NoHP")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("Nip")
                        .HasName("PRIMARY");

                    b.HasIndex("IdUserId")
                        .HasName("IX_Pegawai_IdUserId");

                    b.ToTable("pegawai");
                });

            modelBuilder.Entity("Perpustakaan.Models.Pinjam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Kembali")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("KodeBuku1")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Nip1")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("NoKtp1")
                        .HasColumnName("NoKTP1")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<DateTime?>("TglKembali")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("TglPinjam")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("KodeBuku1")
                        .HasName("IX_Pinjam_KodeBuku1");

                    b.HasIndex("Nip1")
                        .HasName("IX_Pinjam_Nip1");

                    b.HasIndex("NoKtp1")
                        .HasName("IX_Pinjam_NoKTP1");

                    b.ToTable("pinjam");
                });

            modelBuilder.Entity("Perpustakaan.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int?>("IdTypeId")
                        .HasColumnType("int(11)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("IdTypeId")
                        .HasName("IX_Users_IdTypeId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Perpustakaan.Models.Usertype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("longtext")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("Id");

                    b.ToTable("usertype");
                });

            modelBuilder.Entity("Perpustakaan.Models.Anggota", b =>
                {
                    b.HasOne("Perpustakaan.Models.Users", "IdUser")
                        .WithMany("Anggota")
                        .HasForeignKey("IdUserId")
                        .HasConstraintName("FK_Anggota_Users_IdUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Perpustakaan.Models.Pegawai", b =>
                {
                    b.HasOne("Perpustakaan.Models.Users", "IdUser")
                        .WithMany("Pegawai")
                        .HasForeignKey("IdUserId")
                        .HasConstraintName("FK_Pegawai_Users_IdUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Perpustakaan.Models.Pinjam", b =>
                {
                    b.HasOne("Perpustakaan.Models.Buku", "KodeBuku1Navigation")
                        .WithMany("Pinjam")
                        .HasForeignKey("KodeBuku1")
                        .HasConstraintName("FK_Pinjam_Buku_KodeBuku1");

                    b.HasOne("Perpustakaan.Models.Pegawai", "Nip1Navigation")
                        .WithMany("Pinjam")
                        .HasForeignKey("Nip1")
                        .HasConstraintName("FK_Pinjam_Pegawai_Nip1");

                    b.HasOne("Perpustakaan.Models.Anggota", "NoKtp1Navigation")
                        .WithMany("Pinjam")
                        .HasForeignKey("NoKtp1")
                        .HasConstraintName("FK_Pinjam_Anggota_NoKTP1");
                });

            modelBuilder.Entity("Perpustakaan.Models.Users", b =>
                {
                    b.HasOne("Perpustakaan.Models.Usertype", "IdType")
                        .WithMany("Users")
                        .HasForeignKey("IdTypeId")
                        .HasConstraintName("FK_Users_UserType_IdTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
