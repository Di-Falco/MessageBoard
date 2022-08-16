﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    MessageBody = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Computer chat for big nerds.", "Coding" },
                    { 2, "Talking about gaming... lol", "Gamin'" },
                    { 3, "Motion Picture Appreciators", "Movies" },
                    { 4, "SporsBall... americas passtime", "Sports" },
                    { 5, "Anything goes", "Misc" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_TopicId",
                table: "Messages",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
