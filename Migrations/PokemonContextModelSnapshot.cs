﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Pokedex_MVC.Migrations
{
    [DbContext(typeof(PokemonContext))]
    partial class PokemonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("Is_hidden")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("AbilityPokemon", b =>
                {
                    b.Property<int>("Ability")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Pokemon")
                        .HasColumnType("INTEGER");

                    b.HasKey("Ability", "Pokemon");

                    b.HasIndex("Pokemon");

                    b.ToTable("AbilityPokemon");
                });

            modelBuilder.Entity("EvolutionChain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CurrentStageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Method")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NextStageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CurrentStageId");

                    b.HasIndex("NextStageId");

                    b.ToTable("EvolutionChains");
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

                    b.Property<int?>("Move")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Power")
                        .HasColumnType("TEXT");

                    b.Property<string>("Precision")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Move");

                    b.HasIndex("TypeId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("MovePokemon", b =>
                {
                    b.Property<int>("Move")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PokemonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Move", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("MovePokemon");
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.Property<int>("DexId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Catch_rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Egg_group")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender_rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Growth_rate")
                        .HasColumnType("TEXT");

                    b.Property<float>("Height")
                        .HasColumnType("REAL");

                    b.Property<int?>("Image")
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

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("DexId");

                    b.HasIndex("Image")
                        .IsUnique();

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokemonType", b =>
                {
                    b.Property<int>("Pokemon")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Pokemon", "Type");

                    b.HasIndex("Type");

                    b.ToTable("PokemonType");
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

            modelBuilder.Entity("AbilityPokemon", b =>
                {
                    b.HasOne("Pokemon", null)
                        .WithMany()
                        .HasForeignKey("Ability")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ability", null)
                        .WithMany()
                        .HasForeignKey("Pokemon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EvolutionChain", b =>
                {
                    b.HasOne("Pokemon", "CurrentStage")
                        .WithMany()
                        .HasForeignKey("CurrentStageId");

                    b.HasOne("Pokemon", "NextStage")
                        .WithMany()
                        .HasForeignKey("NextStageId");

                    b.Navigation("CurrentStage");

                    b.Navigation("NextStage");
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
                    b.HasOne("Type", null)
                        .WithMany("Moves")
                        .HasForeignKey("Move");

                    b.HasOne("Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("MovePokemon", b =>
                {
                    b.HasOne("Pokemon", null)
                        .WithMany()
                        .HasForeignKey("Move")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Move", null)
                        .WithMany()
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.HasOne("Image", "Images")
                        .WithOne()
                        .HasForeignKey("Pokemon", "Image");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("PokemonType", b =>
                {
                    b.HasOne("Type", null)
                        .WithMany()
                        .HasForeignKey("Pokemon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokemon", null)
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("Type", b =>
                {
                    b.Navigation("Moves");
                });
#pragma warning restore 612, 618
        }
    }
}