using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bookallocationsystem.Migrations
{
    public partial class changeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Allocate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LearnerId = table.Column<int>(type: "int", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedById = table.Column<int>(type: "int", nullable: true),
                    AllocationCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Returned = table.Column<bool>(type: "bit", nullable: false),
                    ReturnedCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    returnedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allocate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allocate_AspNetUsers_AddedById",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Allocate_AspNetUsers_returnedById",
                        column: x => x.returnedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Allocate_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Allocate_Learner_LearnerId",
                        column: x => x.LearnerId,
                        principalTable: "Learner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Allocate_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Audit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditQuater = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllocateId = table.Column<int>(type: "int", nullable: true),
                    AuditById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audit_Allocate_AllocateId",
                        column: x => x.AllocateId,
                        principalTable: "Allocate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audit_AspNetUsers_AuditById",
                        column: x => x.AuditById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allocate_AddedById",
                table: "Allocate",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Allocate_BookId",
                table: "Allocate",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Allocate_LearnerId",
                table: "Allocate",
                column: "LearnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Allocate_returnedById",
                table: "Allocate",
                column: "returnedById");

            migrationBuilder.CreateIndex(
                name: "IX_Allocate_SchoolId",
                table: "Allocate",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Audit_AllocateId",
                table: "Audit",
                column: "AllocateId");

            migrationBuilder.CreateIndex(
                name: "IX_Audit_AuditById",
                table: "Audit",
                column: "AuditById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit");

            migrationBuilder.DropTable(
                name: "Allocate");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Book");
        }
    }
}
