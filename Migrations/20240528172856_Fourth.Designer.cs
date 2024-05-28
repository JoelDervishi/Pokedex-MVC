﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Pokedex_MVC.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20240528172856_Fourth")]
    partial class Fourth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("EggGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EggGroups");
                });

            modelBuilder.Entity("Favourite", b =>
                {
                    b.Property<int>("PokemonDexId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PokemonDexId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Favourite");
                });

            modelBuilder.Entity("Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Animated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Animated_s")
                        .HasColumnType("TEXT");

                    b.Property<string>("Official")
                        .HasColumnType("TEXT");

                    b.Property<string>("Official_s")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sprite")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sprite_s")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Power")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PowerPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Precision")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.Property<int>("DexId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Atk")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Catch_rate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Def")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Gender_rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Growth_rate")
                        .HasColumnType("TEXT");

                    b.Property<int>("HP")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Height")
                        .HasColumnType("REAL");

                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_baby")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_legendary")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_mythic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PreviousStageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpAtk")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpDef")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Spd")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("DexId");

                    b.HasIndex("ImageId")
                        .IsUnique();

                    b.HasIndex("PreviousStageId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("Pokemon_Ability", b =>
                {
                    b.Property<int>("PokemonDexId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AbilityId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_hidden")
                        .HasColumnType("INTEGER");

                    b.HasKey("PokemonDexId", "AbilityId");

                    b.HasIndex("AbilityId");

                    b.ToTable("Pokemon_Ability");
                });

            modelBuilder.Entity("Pokemon_EggGroup", b =>
                {
                    b.Property<int>("PokemonDexId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EggGroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PokemonDexId", "EggGroupId");

                    b.HasIndex("EggGroupId");

                    b.ToTable("Pokemon_EggGroup");
                });

            modelBuilder.Entity("Pokemon_Move", b =>
                {
                    b.Property<int>("PokemonDexId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoveId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PokemonDexId", "MoveId");

                    b.HasIndex("MoveId");

                    b.ToTable("Pokemon_Move");
                });

            modelBuilder.Entity("Pokemon_Type", b =>
                {
                    b.Property<int>("PokemonDexId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PokemonDexId", "TypeId");

                    b.HasIndex("TypeId");

                    b.ToTable("Pokemon_Type");
                });

            modelBuilder.Entity("Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("TypesInteraction", b =>
                {
                    b.Property<int>("FirstTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SecondTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Interaction")
                        .HasColumnType("REAL");

                    b.HasKey("FirstTypeId", "SecondTypeId");

                    b.HasIndex("SecondTypeId");

                    b.ToTable("TypesInteraction");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Favourite", b =>
                {
                    b.HasOne("Pokemon", "Pokemon")
                        .WithMany("Favourites")
                        .HasForeignKey("PokemonDexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany("Favourites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Move", b =>
                {
                    b.HasOne("Type", "Type")
                        .WithMany("Moves")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.HasOne("Image", "Image")
                        .WithOne("Pokemon")
                        .HasForeignKey("Pokemon", "ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokemon", "PreviousStage")
                        .WithMany()
                        .HasForeignKey("PreviousStageId");

                    b.Navigation("Image");

                    b.Navigation("PreviousStage");
                });

            modelBuilder.Entity("Pokemon_Ability", b =>
                {
                    b.HasOne("Ability", "Ability")
                        .WithMany("Pokemons")
                        .HasForeignKey("AbilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokemon", "Pokemon")
                        .WithMany("Abilities")
                        .HasForeignKey("PokemonDexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ability");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Pokemon_EggGroup", b =>
                {
                    b.HasOne("EggGroup", "EggGroup")
                        .WithMany("Pokemons")
                        .HasForeignKey("EggGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokemon", "Pokemon")
                        .WithMany("EggGroups")
                        .HasForeignKey("PokemonDexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EggGroup");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Pokemon_Move", b =>
                {
                    b.HasOne("Move", "Move")
                        .WithMany("Pokemons")
                        .HasForeignKey("MoveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokemon", "Pokemon")
                        .WithMany("Moves")
                        .HasForeignKey("PokemonDexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Move");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Pokemon_Type", b =>
                {
                    b.HasOne("Pokemon", "Pokemon")
                        .WithMany("Types")
                        .HasForeignKey("PokemonDexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Type", "Type")
                        .WithMany("Pokemons")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("TypesInteraction", b =>
                {
                    b.HasOne("Type", "FirstType")
                        .WithMany()
                        .HasForeignKey("FirstTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Type", "SecondType")
                        .WithMany()
                        .HasForeignKey("SecondTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirstType");

                    b.Navigation("SecondType");
                });

            modelBuilder.Entity("Ability", b =>
                {
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("EggGroup", b =>
                {
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("Image", b =>
                {
                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Move", b =>
                {
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.Navigation("Abilities");

                    b.Navigation("EggGroups");

                    b.Navigation("Favourites");

                    b.Navigation("Moves");

                    b.Navigation("Types");
                });

            modelBuilder.Entity("Type", b =>
                {
                    b.Navigation("Moves");

                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("Favourites");
                });
#pragma warning restore 612, 618
        }
    }
}
