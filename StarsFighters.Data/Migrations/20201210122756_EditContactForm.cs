using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarsFighters.Data.Migrations
{
    public partial class EditContactForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersAccounts");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUserTokens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUserLogins",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUserClaims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetRoleClaims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspUserId",
                table: "Accounts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Account = table.Column<string>(nullable: true),
                    About = table.Column<string>(maxLength: 25, nullable: false),
                    Subject = table.Column<string>(maxLength: 450, nullable: false),
                    SubmitedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserTokens_AccountId",
                table: "AspNetUserTokens",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AccountId",
                table: "AspNetUsers",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_AccountId",
                table: "AspNetUserRoles",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_AccountId",
                table: "AspNetUserLogins",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_AccountId",
                table: "AspNetUserClaims",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_AccountId",
                table: "AspNetRoles",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_AccountId",
                table: "AspNetRoleClaims",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Accounts_AccountId",
                table: "AspNetRoleClaims",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_Accounts_AccountId",
                table: "AspNetRoles",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Accounts_AccountId",
                table: "AspNetUserClaims",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Accounts_AccountId",
                table: "AspNetUserLogins",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Accounts_AccountId",
                table: "AspNetUserRoles",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Accounts_AccountId",
                table: "AspNetUsers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_Accounts_AccountId",
                table: "AspNetUserTokens",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Accounts_AccountId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_Accounts_AccountId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Accounts_AccountId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_Accounts_AccountId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_Accounts_AccountId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Accounts_AccountId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_Accounts_AccountId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserTokens_AccountId",
                table: "AspNetUserTokens");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AccountId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_AccountId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_AccountId",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_AccountId",
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_AccountId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoleClaims_AccountId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "AspNetUserTokens");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "AspUserId",
                table: "Accounts");

            migrationBuilder.CreateTable(
                name: "UsersAccounts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAccounts", x => new { x.UserId, x.AccountId });
                    table.ForeignKey(
                        name: "FK_UsersAccounts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersAccounts_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersAccounts_AccountId",
                table: "UsersAccounts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAccounts_UserId1",
                table: "UsersAccounts",
                column: "UserId1");
        }
    }
}
