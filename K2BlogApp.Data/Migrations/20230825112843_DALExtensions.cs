using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K2BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8822db46-a7e1-4b9c-aa36-f47599a3401c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("9b416f24-18b7-4eef-a20a-5c71e32c0284"), new Guid("b573250c-2835-4ac0-b126-110c65748ffb"), "LoremIpsum Dolor Sitamet Kontent Yazılsın", "Keno", new DateTime(2023, 8, 25, 14, 28, 43, 313, DateTimeKind.Local).AddTicks(4247), null, null, new Guid("c9ed2a27-292d-489e-a726-9bc75abd0bac"), false, null, null, "Deneme Makalesi1", 15 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b573250c-2835-4ac0-b126-110c65748ffb"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 25, 14, 28, 43, 313, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c9ed2a27-292d-489e-a726-9bc75abd0bac"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 25, 14, 28, 43, 313, DateTimeKind.Local).AddTicks(4539));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9b416f24-18b7-4eef-a20a-5c71e32c0284"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("8822db46-a7e1-4b9c-aa36-f47599a3401c"), new Guid("b573250c-2835-4ac0-b126-110c65748ffb"), "LoremIpsum Dolor Sitamet Kontent Yazılsın", "Keno", new DateTime(2023, 8, 18, 16, 42, 14, 379, DateTimeKind.Local).AddTicks(9178), null, null, new Guid("c9ed2a27-292d-489e-a726-9bc75abd0bac"), false, null, null, "Deneme Makalesi1", 15 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b573250c-2835-4ac0-b126-110c65748ffb"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 18, 16, 42, 14, 379, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c9ed2a27-292d-489e-a726-9bc75abd0bac"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 18, 16, 42, 14, 379, DateTimeKind.Local).AddTicks(9566));
        }
    }
}
