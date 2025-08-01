using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addOrderAndOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentRefrenceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentGateway = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Count = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0799a13e-77f5-4ede-833e-1629d0cf0e9f"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("086eca5b-0bbe-4167-bd5a-933641b32a51"),
                columns: new[] { "Discount", "Price" },
                values: new object[] { 345000.0, 293250.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1806db32-da8a-4dce-ba51-c5a0f8ea43eb"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22659c32-8c87-4cdb-80bf-fd19262f6f16"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2fa1c6c0-a5dd-485c-b943-c683848ed99d"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("31589b83-9399-4edc-b3f3-a3b9871a9dbd"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4688e9d5-b505-47e9-92e2-86bbeb06a2b7"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4851ec98-e3fc-4d6b-8cbd-2df89e74c40e"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("510b2a9d-4f14-4f19-a3ab-5da3199f2e96"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("57e6aaec-607f-43b5-8737-ddc2ceaf58c4"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("593c31d7-d00c-4b32-bd5e-90f333a4f3ad"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c93480ea-23b8-4cb1-a0f1-329a077422b5"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1f290ff-58cf-4e88-8b80-e106f11c4d5f"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc7a27c9-bac7-45eb-a70c-490d856e2052"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5f08920-e2f8-4032-9647-1764b9fd34b9"),
                column: "Discount",
                value: 345000.0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BookId",
                table: "OrderDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0799a13e-77f5-4ede-833e-1629d0cf0e9f"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("086eca5b-0bbe-4167-bd5a-933641b32a51"),
                columns: new[] { "Discount", "Price" },
                values: new object[] { 0.0, 120000.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1806db32-da8a-4dce-ba51-c5a0f8ea43eb"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22659c32-8c87-4cdb-80bf-fd19262f6f16"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2fa1c6c0-a5dd-485c-b943-c683848ed99d"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("31589b83-9399-4edc-b3f3-a3b9871a9dbd"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4688e9d5-b505-47e9-92e2-86bbeb06a2b7"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4851ec98-e3fc-4d6b-8cbd-2df89e74c40e"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("510b2a9d-4f14-4f19-a3ab-5da3199f2e96"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("57e6aaec-607f-43b5-8737-ddc2ceaf58c4"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("593c31d7-d00c-4b32-bd5e-90f333a4f3ad"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c93480ea-23b8-4cb1-a0f1-329a077422b5"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1f290ff-58cf-4e88-8b80-e106f11c4d5f"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc7a27c9-bac7-45eb-a70c-490d856e2052"),
                column: "Discount",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5f08920-e2f8-4032-9647-1764b9fd34b9"),
                column: "Discount",
                value: 0.0);
        }
    }
}
