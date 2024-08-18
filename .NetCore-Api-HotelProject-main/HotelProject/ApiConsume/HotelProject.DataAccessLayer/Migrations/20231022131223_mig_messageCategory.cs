using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_messageCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageSubjectCategoryId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MessageSubjectCategories",
                columns: table => new
                {
                    MessageSubjectCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageSubjectCategories", x => x.MessageSubjectCategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MessageSubjectCategoryId",
                table: "Contacts",
                column: "MessageSubjectCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageSubjectCategories_MessageSubjectCategoryId",
                table: "Contacts",
                column: "MessageSubjectCategoryId",
                principalTable: "MessageSubjectCategories",
                principalColumn: "MessageSubjectCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageSubjectCategories_MessageSubjectCategoryId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "MessageSubjectCategories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_MessageSubjectCategoryId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MessageSubjectCategoryId",
                table: "Contacts");
        }
    }
}
