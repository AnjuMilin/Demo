﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TerminologyDemo.Models;

namespace TerminologyDemo.Migrations
{
    [DbContext(typeof(OurDBContext))]
    partial class OurDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TerminologyDemo.Models.ProjectManagement", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectName")
                        .IsRequired();

                    b.HasKey("ProjectId");

                    b.ToTable("ProjectManagement");
                });

            modelBuilder.Entity("TerminologyDemo.Models.ProjectUpload", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contributer")
                        .IsRequired();

                    b.Property<string>("NewsTitle");

                    b.Property<string>("ProjectTitle");

<<<<<<< HEAD
                    b.Property<int>("UserId");

=======
>>>>>>> 74b5af5cb63ce0e9691d4e2f5d07e652b86827e2
                    b.Property<string>("urlName")
                        .IsRequired();

                    b.HasKey("PId");

<<<<<<< HEAD
                    b.HasIndex("UserId");

=======
>>>>>>> 74b5af5cb63ce0e9691d4e2f5d07e652b86827e2
                    b.ToTable("ProjectUpload");
                });

            modelBuilder.Entity("TerminologyDemo.Models.UserAccount", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

<<<<<<< HEAD
                    b.Property<string>("ConformPassword");
=======
                    b.Property<string>("ConformPassword")
                        .IsRequired();
>>>>>>> 74b5af5cb63ce0e9691d4e2f5d07e652b86827e2

                    b.Property<string>("EmailId")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("firstName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("UserAccount");
                });
<<<<<<< HEAD

            modelBuilder.Entity("TerminologyDemo.Models.ProjectUpload", b =>
                {
                    b.HasOne("TerminologyDemo.Models.UserAccount", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
=======
>>>>>>> 74b5af5cb63ce0e9691d4e2f5d07e652b86827e2
#pragma warning restore 612, 618
        }
    }
}
