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
    [Migration("20240514183050_Fir")]
    partial class Fir
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

            modelBuilder.Entity("EggGroupPokemon", b =>
                {
                    b.Property<int>("EggGroupsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PokemonsDexId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EggGroupsId", "PokemonsDexId");

                    b.HasIndex("PokemonsDexId");

                    b.ToTable("EggGroupPokemon");
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

                    b.Property<int?>("PokemonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sprite")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sprite_s")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PokemonId");

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

                    b.Property<int>("Power")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Precision")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("MovePokemon", b =>
                {
                    b.Property<int>("MovesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PokemonsDexId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovesId", "PokemonsDexId");

                    b.HasIndex("PokemonsDexId");

                    b.ToTable("MovePokemon");
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

                    b.Property<int?>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_baby")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_legendary")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_mythic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name_Jap")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NextStageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Roomaji")
                        .HasColumnType("TEXT");

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

                    b.HasIndex("NextStageId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokemonType", b =>
                {
                    b.Property<int>("PokemonsDexId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PokemonsDexId", "TypesId");

                    b.HasIndex("TypesId");

                    b.ToTable("PokemonType");
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
                    b.Property<int?>("FirstTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Interaction")
                        .HasColumnType("REAL");

                    b.Property<int?>("SecondTypeId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("FirstTypeId");

                    b.HasIndex("SecondTypeId");

                    b.ToTable("TypesInteractions");
                });

            modelBuilder.Entity("EggGroupPokemon", b =>
                {
                    b.HasOne("EggGroup", null)
                        .WithMany()
                        .HasForeignKey("EggGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonsDexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Image", b =>
                {
                    b.HasOne("Pokemon", "Pokemon")
                        .WithMany()
                        .HasForeignKey("PokemonId");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Move", b =>
                {
                    b.HasOne("Type", "Type")
                        .WithMany("Moves")
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("MovePokemon", b =>
                {
                    b.HasOne("Move", null)
                        .WithMany()
                        .HasForeignKey("MovesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonsDexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.HasOne("Image", "Images")
                        .WithOne()
                        .HasForeignKey("Pokemon", "ImageId");

                    b.HasOne("Pokemon", "NextStage")
                        .WithMany()
                        .HasForeignKey("NextStageId");

                    b.Navigation("Images");

                    b.Navigation("NextStage");
                });

            modelBuilder.Entity("PokemonType", b =>
                {
                    b.HasOne("Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonsDexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Type", null)
                        .WithMany()
                        .HasForeignKey("TypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("TypesInteraction", b =>
                {
                    b.HasOne("Type", "FirstType")
                        .WithMany()
                        .HasForeignKey("FirstTypeId");

                    b.HasOne("Type", "SecondType")
                        .WithMany()
                        .HasForeignKey("SecondTypeId");

                    b.Navigation("FirstType");

                    b.Navigation("SecondType");
                });

            modelBuilder.Entity("Ability", b =>
                {
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.Navigation("Abilities");
                });

            modelBuilder.Entity("Type", b =>
                {
                    b.Navigation("Moves");
                });
#pragma warning restore 612, 618
        }
    }
}
