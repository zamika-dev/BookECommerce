using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addDiscountToBookAndChangedCartShoppingToCartItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Province_ProvinceId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ProvinceId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Books");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Books",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Books",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0799a13e-77f5-4ede-833e-1629d0cf0e9f"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "crime_and_punishment.webp", 135000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("086eca5b-0bbe-4167-bd5a-933641b32a51"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "hamlet.webp", 120000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1806db32-da8a-4dce-ba51-c5a0f8ea43eb"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "for_whom_the_bell_tolls.webp", 125000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22659c32-8c87-4cdb-80bf-fd19262f6f16"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "mrs_dalloway.webp", 110000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2fa1c6c0-a5dd-485c-b943-c683848ed99d"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "blind_owl.webp", 90000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("31589b83-9399-4edc-b3f3-a3b9871a9dbd"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "aleph.webp", 75000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4688e9d5-b505-47e9-92e2-86bbeb06a2b7"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "war_and_peace.webp", 250000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4851ec98-e3fc-4d6b-8cbd-2df89e74c40e"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "emma.webp", 105000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("510b2a9d-4f14-4f19-a3ab-5da3199f2e96"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "to_the_lighthouse.webp", 98000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("57e6aaec-607f-43b5-8737-ddc2ceaf58c4"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "macbeth.webp", 85000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("593c31d7-d00c-4b32-bd5e-90f333a4f3ad"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "one_hundred_years.webp", 180000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c93480ea-23b8-4cb1-a0f1-329a077422b5"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "old_man_and_sea.webp", 80000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1f290ff-58cf-4e88-8b80-e106f11c4d5f"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "pride_and_prejudice.webp", 95000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc7a27c9-bac7-45eb-a70c-490d856e2052"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "anna_karenina.webp", 220000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5f08920-e2f8-4032-9647-1764b9fd34b9"),
                columns: new[] { "Discount", "ImagePath", "Price" },
                values: new object[] { 0.0, "little_prince.webp", 60000.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<Guid>(
                name: "ProvinceId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0799a13e-77f5-4ede-833e-1629d0cf0e9f"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/crime_and_punishment.jpg", 135000, new Guid("e7d96627-f01d-47e0-b667-9bb0999e1eed") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("086eca5b-0bbe-4167-bd5a-933641b32a51"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/hamlet.jpg", 120000, new Guid("d42125b1-3986-4785-9b04-b8213f0ddd85") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1806db32-da8a-4dce-ba51-c5a0f8ea43eb"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/for_whom_the_bell_tolls.jpg", 125000, new Guid("da314798-ed14-4dcf-bcf1-b5cbed99b448") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22659c32-8c87-4cdb-80bf-fd19262f6f16"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/mrs_dalloway.jpg", 110000, new Guid("c6dcaf58-da0b-401f-a284-c0bd21a3f317") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2fa1c6c0-a5dd-485c-b943-c683848ed99d"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/blind_owl.jpg", 90000, new Guid("9106a46c-cfa1-45f9-bfed-4954ad369518") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("31589b83-9399-4edc-b3f3-a3b9871a9dbd"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/aleph.jpg", 75000, new Guid("dd1d3b26-2b7f-4413-93b4-b77fe0748a0a") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4688e9d5-b505-47e9-92e2-86bbeb06a2b7"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/war_and_peace.jpg", 250000, new Guid("d2ea55b7-452c-472e-b7c8-7b16cba758f2") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4851ec98-e3fc-4d6b-8cbd-2df89e74c40e"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/emma.jpg", 105000, new Guid("b4427192-a119-4ef6-b66b-4b802020a572") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("510b2a9d-4f14-4f19-a3ab-5da3199f2e96"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/to_the_lighthouse.jpg", 98000, new Guid("cff49c8d-547a-47fe-af95-1bd0919619cd") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("57e6aaec-607f-43b5-8737-ddc2ceaf58c4"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/macbeth.jpg", 85000, new Guid("d4f0fc62-9525-4a7d-9346-6474ddb77f81") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("593c31d7-d00c-4b32-bd5e-90f333a4f3ad"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/one_hundred_years.jpg", 180000, new Guid("bd562450-2efb-4f7d-a9cd-69f9f067e354") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c93480ea-23b8-4cb1-a0f1-329a077422b5"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/old_man_and_sea.jpg", 80000, new Guid("84b46230-3ba2-4e0f-b92d-ac18b527b8a6") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1f290ff-58cf-4e88-8b80-e106f11c4d5f"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/pride_and_prejudice.jpg", 95000, new Guid("fce7c129-a376-44f2-ae1d-b31068f52348") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc7a27c9-bac7-45eb-a70c-490d856e2052"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/anna_karenina.jpg", 220000, new Guid("78d9f126-979f-4613-a96d-01e0d33dfee3") });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5f08920-e2f8-4032-9647-1764b9fd34b9"),
                columns: new[] { "ImagePath", "Price", "ProvinceId" },
                values: new object[] { "images/little_prince.jpg", 60000, new Guid("ccfd7b22-07de-481c-b276-9a3ed302821e") });

            migrationBuilder.CreateIndex(
                name: "IX_Books_ProvinceId",
                table: "Books",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Province_ProvinceId",
                table: "Books",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
