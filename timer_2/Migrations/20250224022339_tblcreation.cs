using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace timer_2.Migrations
{
    /// <inheritdoc />
    public partial class tblcreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    fldslno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fldname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fldmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fldpassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.fldslno);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
