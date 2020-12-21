using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarsFighters.Data.Migrations
{
    public partial class UpgradeBuildingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Accounts_AccountId",
                table: "Achievements");

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

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_BuildingBuilds_BuildingBuildsId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Accounts_AccountId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Quests_Accounts_AccountId",
                table: "Quests");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Accounts_AccountId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_BuildingBuilds_BuildingsId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "BuildingFormulas");

            migrationBuilder.DropTable(
                name: "BuildingRequireds");

            migrationBuilder.DropTable(
                name: "BuildingBuilds");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_BuildingBuildsId",
                table: "Buildings");

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
                name: "BuildingBuildsId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "BuildingRequiredId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "UpgradeTimeFormula",
                table: "Buildings");

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

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Quests",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Buildings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentLevel",
                table: "Buildings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ResourceAmountPerMinute",
                table: "Buildings",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ResourceName",
                table: "Buildings",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "UpgradeEndTime",
                table: "Buildings",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<bool>(
                name: "UpgradeOnGoing",
                table: "Buildings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShipTypeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Achievements",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Achievements",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_AccountId",
                table: "Buildings",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShipTypeId",
                table: "AspNetUsers",
                column: "ShipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_AspNetUsers_AccountId",
                table: "Achievements",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Ships_ShipTypeId",
                table: "AspNetUsers",
                column: "ShipTypeId",
                principalTable: "Ships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_AspNetUsers_AccountId",
                table: "Buildings",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_AccountId",
                table: "Items",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quests_AspNetUsers_AccountId",
                table: "Quests",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_AspNetUsers_AccountId",
                table: "Resources",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_AspNetUsers_AccountId",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Ships_ShipTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_AspNetUsers_AccountId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_AccountId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Quests_AspNetUsers_AccountId",
                table: "Quests");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_AspNetUsers_AccountId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_AccountId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ShipTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "CurrentLevel",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "ResourceAmountPerMinute",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "ResourceName",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "UpgradeEndTime",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "UpgradeOnGoing",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "QuestId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShipTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Achievements");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Resources",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Quests",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuildingBuildsId",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuildingRequiredId",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UpgradeTimeFormula",
                table: "Buildings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUserTokens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUserLogins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetUserClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AspNetRoleClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Achievements",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BuildingFormulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    ProductionFormula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    UpgradeFormula = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingFormulas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingFormulas_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingFormulas_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildingRequireds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    BuildingRequiredId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingRequireds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingRequireds_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildingBuilds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    BuildingCost = table.Column<double>(type: "float", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    CurrentLevel = table.Column<int>(type: "int", nullable: false),
                    EarnPerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpgradeEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    UpgradeOnGoing = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingBuilds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AspUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingsId = table.Column<int>(type: "int", nullable: true),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    ShipTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_BuildingBuilds_BuildingsId",
                        column: x => x.BuildingsId,
                        principalTable: "BuildingBuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Ships_ShipTypeId",
                        column: x => x.ShipTypeId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_BuildingBuildsId",
                table: "Buildings",
                column: "BuildingBuildsId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BuildingsId",
                table: "Accounts",
                column: "BuildingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ShipTypeId",
                table: "Accounts",
                column: "ShipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingBuilds_AccountId",
                table: "BuildingBuilds",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingFormulas_BuildingId",
                table: "BuildingFormulas",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingFormulas_ResourceId",
                table: "BuildingFormulas",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingRequireds_BuildingId",
                table: "BuildingRequireds",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Accounts_AccountId",
                table: "Achievements",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_BuildingBuilds_BuildingBuildsId",
                table: "Buildings",
                column: "BuildingBuildsId",
                principalTable: "BuildingBuilds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Accounts_AccountId",
                table: "Items",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quests_Accounts_AccountId",
                table: "Quests",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Accounts_AccountId",
                table: "Resources",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingBuilds_Accounts_AccountId",
                table: "BuildingBuilds",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
