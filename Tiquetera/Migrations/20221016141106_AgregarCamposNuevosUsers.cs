using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tiquetera.Migrations
{
    public partial class AgregarCamposNuevosUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "confirmarContraseña",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contrasena",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaCreacion",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaMaquinaModifica",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaNacimiento",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idContacto",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTipoDocumento",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTipoUsuario",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maquinaCreacion",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maquinaModifica",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numeroCelular",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numeroDocumento",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primerApellido",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primerNombre",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "segundoApellido",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "segundoNombre",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tipoId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "usuarioCrea",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "usuarioModifica",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "vigente",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "confirmarContraseña",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "contrasena",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "direccion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "fechaCreacion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "fechaMaquinaModifica",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "fechaNacimiento",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "idContacto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "idTipoDocumento",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "idTipoUsuario",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "maquinaCreacion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "maquinaModifica",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "numeroCelular",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "numeroDocumento",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "primerApellido",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "primerNombre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "segundoApellido",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "segundoNombre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "tipoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "usuarioCrea",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "usuarioModifica",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "vigente",
                table: "AspNetUsers");
        }
    }
}
