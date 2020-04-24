﻿// <auto-generated />
using System;
using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lyra.WebAPI.Migrations
{
    [DbContext(typeof(LyraContext))]
    [Migration("20200424154206_removeIDFromUserRoles")]
    partial class removeIDFromUserRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lyra.WebAPI.Database.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<string>("CoverArtPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ArtistID = 0,
                            Name = "Gorillaz",
                            ReleaseYear = 2001
                        },
                        new
                        {
                            ID = 2,
                            ArtistID = 0,
                            Name = "Demon Days",
                            ReleaseYear = 2003
                        });
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.AlbumTrack", b =>
                {
                    b.Property<int>("AlbumID")
                        .HasColumnType("int");

                    b.Property<int>("TrackID")
                        .HasColumnType("int");

                    b.HasKey("AlbumID", "TrackID");

                    b.HasIndex("TrackID");

                    b.ToTable("AlbumTracks");

                    b.HasData(
                        new
                        {
                            AlbumID = 1,
                            TrackID = 1
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 2
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 3
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 4
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 5
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 6
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 7
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 8
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 9
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 10
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 11
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 12
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 13
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 14
                        },
                        new
                        {
                            AlbumID = 1,
                            TrackID = 15
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 1
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 2
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 3
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 4
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 5
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 6
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 7
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 8
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 9
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 10
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 11
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 12
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 13
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 14
                        },
                        new
                        {
                            AlbumID = 2,
                            TrackID = 15
                        });
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Gorillaz"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Audioslave"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Deftones"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Childish Gambino"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Of Monsters and Men"
                        });
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Rock"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Rap"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Hip-Hop"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Pop"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Metal"
                        });
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.Playlist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistID")
                        .HasColumnType("int");

                    b.Property<int>("TrackID")
                        .HasColumnType("int");

                    b.HasKey("PlaylistID", "TrackID");

                    b.HasIndex("TrackID");

                    b.ToTable("PlaylistTracks");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaylistID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AlbumID");

                    b.HasIndex("PlaylistID");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Length = new TimeSpan(0, 0, 3, 32, 0),
                            Name = "Re-Hash"
                        },
                        new
                        {
                            ID = 2,
                            Length = new TimeSpan(0, 0, 2, 35, 0),
                            Name = "5/4"
                        },
                        new
                        {
                            ID = 3,
                            Length = new TimeSpan(0, 0, 3, 7, 0),
                            Name = "Tomorrow Comes Today"
                        },
                        new
                        {
                            ID = 4,
                            Length = new TimeSpan(0, 0, 3, 51, 0),
                            Name = "New Genious (Brother)"
                        },
                        new
                        {
                            ID = 5,
                            Length = new TimeSpan(0, 0, 5, 32, 0),
                            Name = "Clint Eastwood"
                        },
                        new
                        {
                            ID = 6,
                            Length = new TimeSpan(0, 0, 4, 22, 0),
                            Name = "Man Research (Clapper)"
                        },
                        new
                        {
                            ID = 7,
                            Length = new TimeSpan(0, 0, 1, 33, 0),
                            Name = "Punk"
                        },
                        new
                        {
                            ID = 8,
                            Length = new TimeSpan(0, 0, 4, 32, 0),
                            Name = "Sound Check (Gravity)"
                        },
                        new
                        {
                            ID = 9,
                            Length = new TimeSpan(0, 0, 4, 36, 0),
                            Name = "Double Bass"
                        },
                        new
                        {
                            ID = 10,
                            Length = new TimeSpan(0, 0, 4, 1, 0),
                            Name = "Rock The House"
                        },
                        new
                        {
                            ID = 11,
                            Length = new TimeSpan(0, 0, 3, 21, 0),
                            Name = "19-2000"
                        },
                        new
                        {
                            ID = 12,
                            Length = new TimeSpan(0, 0, 3, 30, 0),
                            Name = "Latin Simone (Que Pasa Contigo)"
                        },
                        new
                        {
                            ID = 13,
                            Length = new TimeSpan(0, 0, 3, 25, 0),
                            Name = "Starshine"
                        },
                        new
                        {
                            ID = 14,
                            Length = new TimeSpan(0, 0, 3, 29, 0),
                            Name = "Slow Country"
                        },
                        new
                        {
                            ID = 15,
                            Length = new TimeSpan(0, 0, 10, 21, 0),
                            Name = "M1 A1"
                        },
                        new
                        {
                            ID = 16,
                            Length = new TimeSpan(0, 0, 1, 1, 0),
                            Name = "Intro"
                        },
                        new
                        {
                            ID = 17,
                            Length = new TimeSpan(0, 0, 3, 4, 0),
                            Name = "Last Living Soul"
                        },
                        new
                        {
                            ID = 18,
                            Length = new TimeSpan(0, 0, 3, 39, 0),
                            Name = "Kids With Guns"
                        },
                        new
                        {
                            ID = 19,
                            Length = new TimeSpan(0, 0, 4, 24, 0),
                            Name = "O Green World"
                        },
                        new
                        {
                            ID = 20,
                            Length = new TimeSpan(0, 0, 3, 37, 0),
                            Name = "Dirty Harry"
                        },
                        new
                        {
                            ID = 21,
                            Length = new TimeSpan(0, 0, 3, 34, 0),
                            Name = "Feel Good Inc."
                        },
                        new
                        {
                            ID = 22,
                            Length = new TimeSpan(0, 0, 3, 43, 0),
                            Name = "El Manana"
                        },
                        new
                        {
                            ID = 23,
                            Length = new TimeSpan(0, 0, 4, 44, 0),
                            Name = "Every Planet We Reach Is Dead"
                        },
                        new
                        {
                            ID = 24,
                            Length = new TimeSpan(0, 0, 2, 36, 0),
                            Name = "November Has Come"
                        },
                        new
                        {
                            ID = 25,
                            Length = new TimeSpan(0, 0, 3, 23, 0),
                            Name = "All Alone"
                        },
                        new
                        {
                            ID = 26,
                            Length = new TimeSpan(0, 0, 2, 4, 0),
                            Name = "White Light"
                        },
                        new
                        {
                            ID = 27,
                            Length = new TimeSpan(0, 0, 3, 57, 0),
                            Name = "DARE"
                        },
                        new
                        {
                            ID = 28,
                            Length = new TimeSpan(0, 0, 3, 10, 0),
                            Name = "Fire Comming Out Of The Monkeys Head"
                        },
                        new
                        {
                            ID = 29,
                            Length = new TimeSpan(0, 0, 1, 56, 0),
                            Name = "Don't Get Lost In Heaven"
                        },
                        new
                        {
                            ID = 30,
                            Length = new TimeSpan(0, 0, 4, 21, 0),
                            Name = "Demon Days"
                        });
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.TrackArtist", b =>
                {
                    b.Property<int>("TrackID")
                        .HasColumnType("int");

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<int>("TrackArtistRole")
                        .HasColumnType("int");

                    b.HasKey("TrackID", "ArtistID");

                    b.HasIndex("ArtistID");

                    b.ToTable("TrackArtist");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.TrackGenre", b =>
                {
                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<int>("TrackID")
                        .HasColumnType("int");

                    b.HasKey("GenreID", "TrackID");

                    b.HasIndex("TrackID");

                    b.ToTable("TrackGenres");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.UserRoles", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "RoleID");

                    b.HasIndex("RoleID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.Album", b =>
                {
                    b.HasOne("Lyra.WebAPI.Database.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.AlbumTrack", b =>
                {
                    b.HasOne("Lyra.WebAPI.Database.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lyra.WebAPI.Database.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.Playlist", b =>
                {
                    b.HasOne("Lyra.WebAPI.Database.User", "User")
                        .WithMany("Playlists")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.PlaylistTrack", b =>
                {
                    b.HasOne("Lyra.WebAPI.Database.Playlist", "Playlist")
                        .WithMany()
                        .HasForeignKey("PlaylistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lyra.WebAPI.Database.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.Track", b =>
                {
                    b.HasOne("Lyra.WebAPI.Database.Album", null)
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumID");

                    b.HasOne("Lyra.WebAPI.Database.Playlist", null)
                        .WithMany("Tracks")
                        .HasForeignKey("PlaylistID");
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.TrackArtist", b =>
                {
                    b.HasOne("Lyra.WebAPI.Database.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lyra.WebAPI.Database.Track", "Track")
                        .WithMany("Artists")
                        .HasForeignKey("TrackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.TrackGenre", b =>
                {
                    b.HasOne("Lyra.WebAPI.Database.Genre", "Genre")
                        .WithMany("TrackGenres")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lyra.WebAPI.Database.Track", "Track")
                        .WithMany("Genres")
                        .HasForeignKey("TrackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lyra.WebAPI.Database.UserRoles", b =>
                {
                    b.HasOne("Lyra.WebAPI.Database.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lyra.WebAPI.Database.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
