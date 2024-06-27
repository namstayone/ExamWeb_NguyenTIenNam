using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_NguyenTIenNam.Migrations
{
    public partial class TaoDuLieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaDe = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DienVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false),
                    GiaVe = table.Column<double>(type: "float", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phims", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Phims",
                columns: new[] { "Id", "DienVien", "GiaVe", "ThoiLuong", "TrongNuoc", "TuaDe" },
                values: new object[,]
                {
                    { 1, "Huyền Lizzie, Mạnh Trường", 150000.0, 110, true, "Chúng ta của 8 năm sau" },
                    { 2, "Sam Worthington", 250000.0, 161, false, "Avatar" },
                    { 3, "Đình Tú, Anh Đào", 160000.0, 105, true, "Gặp em ngày nắng" },
                    { 4, "Hoàng Thùy Linh, Nhan Phúc Vinh", 120000.0, 150, true, "Không ngại cưới" },
                    { 5, "Đức Khuê, Nguyệt Hằng", 130000.0, 120, true, "Gia đình đại chiến" },
                    { 6, "Arnold Schwarzenegger", 210000.0, 107, false, "Kẻ Huỷ Diệt " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phims");
        }
    }
}
