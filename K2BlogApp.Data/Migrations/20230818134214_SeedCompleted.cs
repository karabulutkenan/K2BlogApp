using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K2BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bd23f52e-5dc9-4121-874a-7baadcd4f0fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a75a048-fe15-4e64-8709-0e063b17e169"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("14e4a5db-30b2-46d0-b7c7-e549da5568f5"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { new Guid("b573250c-2835-4ac0-b126-110c65748ffb"), "Keno", new DateTime(2023, 8, 18, 16, 42, 14, 379, DateTimeKind.Local).AddTicks(9413), null, null, false, null, null, "Genel" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("c9ed2a27-292d-489e-a726-9bc75abd0bac"), "Keno", new DateTime(2023, 8, 18, 16, 42, 14, 379, DateTimeKind.Local).AddTicks(9566), null, null, "images/testimage", "jpg", false, null, null });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("8822db46-a7e1-4b9c-aa36-f47599a3401c"), new Guid("b573250c-2835-4ac0-b126-110c65748ffb"), "LoremIpsum Dolor Sitamet Kontent Yazılsın", "Keno", new DateTime(2023, 8, 18, 16, 42, 14, 379, DateTimeKind.Local).AddTicks(9178), null, null, new Guid("c9ed2a27-292d-489e-a726-9bc75abd0bac"), false, null, null, "Deneme Makalesi1", 15 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8822db46-a7e1-4b9c-aa36-f47599a3401c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b573250c-2835-4ac0-b126-110c65748ffb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c9ed2a27-292d-489e-a726-9bc75abd0bac"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("bd23f52e-5dc9-4121-874a-7baadcd4f0fb"), new Guid("b573250c-2835-4ac0-b126-110c65748ffb"), "LoremIpsum Dolor Sitamet Kontent Yazılsın", "Keno", new DateTime(2023, 8, 18, 16, 39, 56, 319, DateTimeKind.Local).AddTicks(6822), null, null, new Guid("c9ed2a27-292d-489e-a726-9bc75abd0bac"), false, null, null, "Deneme Makalesi1", 15 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { new Guid("3a75a048-fe15-4e64-8709-0e063b17e169"), "Keno", new DateTime(2023, 8, 18, 16, 39, 56, 319, DateTimeKind.Local).AddTicks(7008), null, null, false, null, null, "Genel" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("14e4a5db-30b2-46d0-b7c7-e549da5568f5"), "Keno", new DateTime(2023, 8, 18, 16, 39, 56, 319, DateTimeKind.Local).AddTicks(7098), null, null, "images/testimage", "jpg", false, null, null });
        }
    }
}
