﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FornecedoresAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTelefoneToFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Fornecedores");
        }
    }
}
