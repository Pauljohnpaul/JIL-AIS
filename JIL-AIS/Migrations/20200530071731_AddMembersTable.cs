using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JIL_AIS.Migrations
{
    public partial class AddMembersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lastname = table.Column<string>(maxLength: 30, nullable: false),
                    Firstname = table.Column<string>(maxLength: 30, nullable: false),
                    Middlename = table.Column<string>(maxLength: 30, nullable: true),
                    CompleteAddress = table.Column<string>(maxLength: 30, nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(maxLength: 10, nullable: true),
                    ResidenceTelNo = table.Column<string>(maxLength: 30, nullable: true),
                    CivilStatus = table.Column<string>(maxLength: 15, nullable: true),
                    Occupation = table.Column<string>(maxLength: 30, nullable: true),
                    CellphoneNo = table.Column<string>(maxLength: 30, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    IsAttendingLifeGroup = table.Column<bool>(nullable: true),
                    LifeGroupLeader = table.Column<string>(maxLength: 50, nullable: true),
                    MembershipProfile = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
