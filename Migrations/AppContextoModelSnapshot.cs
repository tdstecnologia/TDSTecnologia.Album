﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TDSTecnologia.FaceAlbum.Web.Data;

namespace TDSTecnologia.FaceAlbum.Web.Migrations
{
    [DbContext(typeof(AppContexto))]
    partial class AppContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TDSTecnologia.FaceAlbum.Web.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Capa")
                        .HasColumnName("capa");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnName("dt_inicio");

                    b.Property<string>("Descricao")
                        .HasColumnName("descricao");

                    b.Property<string>("Titulo")
                        .HasColumnName("titulo");

                    b.HasKey("AlbumId");

                    b.ToTable("tb01_album");
                });
#pragma warning restore 612, 618
        }
    }
}
