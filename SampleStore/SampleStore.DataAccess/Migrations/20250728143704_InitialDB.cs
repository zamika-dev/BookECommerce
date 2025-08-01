using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SampleStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Writers_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desctiption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description", "DisplayOrder" },
                values: new object[,]
                {
                    { new Guid("05203634-a0ca-48d7-9caf-d81b01265983"), "ترسناک", "آثار با عناصر وحشت و فراطبیعی", 0 },
                    { new Guid("0ae0819e-5cac-41af-8c31-a5a6feb492d0"), "روانشناسی", "کتاب‌های مربوط به ذهن و رفتار انسان", 0 },
                    { new Guid("2c912630-85dc-466f-b96d-c1300fef34ff"), "عاشقانه", "داستان‌هایی با محوریت روابط عاشقانه", 0 },
                    { new Guid("3dcdcfa8-9c8b-479e-b356-14309924a9ca"), "سفرنامه", "تجربیات و مشاهدات مسافران از مناطق مختلف", 0 },
                    { new Guid("493a46ae-c734-4408-b971-632939e06920"), "علمی-تخیلی", "داستان‌هایی با زمینه علمی و فناوری‌های آینده‌نگرانه", 0 },
                    { new Guid("640cb937-d344-4847-b5ef-a69b6200eb50"), "فلسفه", "آثار مربوط به تفکر فلسفی و نظریه‌پردازی", 0 },
                    { new Guid("6b5d53cc-54fd-4b05-a1e7-7edc06969b9c"), "هنر و طراحی", "کتاب‌های مربوط به هنرهای تجسمی و طراحی", 0 },
                    { new Guid("708a1378-40da-4580-b31b-727a000d91a4"), "رمان", "آثار داستانی بلند با طرح‌های پیچیده و شخصیت‌های توسعه یافته", 0 },
                    { new Guid("77321d37-4fb5-4d01-8769-d346eb2cdddb"), "زندگینامه", "شرح زندگی افراد مشهور و تأثیرگذار", 0 },
                    { new Guid("943df6d9-f44d-401a-90da-ca736276e148"), "توسعه فردی", "کتاب‌های خودیاری و بهبود مهارت‌های شخصی", 0 },
                    { new Guid("b005956b-d1c7-4064-aefc-dc67e21c08ec"), "داستان کوتاه", "مجموعه‌ای از داستان‌های کوتاه با موضوعات متنوع", 0 },
                    { new Guid("b42b2855-c2b3-40a4-ae71-ef414b29c40c"), "تاریخی", "رمان‌ها و آثار غیرداستانی با زمینه تاریخی", 0 },
                    { new Guid("c34e7f91-e350-4365-b330-e92071db5c6e"), "آشپزی", "دستورالعمل‌ها و تکنیک‌های آشپزی", 0 },
                    { new Guid("c8595e03-4f28-4262-b9ac-c5d36b84a464"), "تکنولوژی", "آخرین پیشرفت‌های فناوری و علوم کامپیوتر", 0 },
                    { new Guid("dfeaa92f-0b47-429c-a0cf-fbba9d9568f1"), "فانتزی", "آثار خیال‌انگیز با عناصر ماوراء طبیعی و جادویی", 0 }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { new Guid("1ccab492-8384-4dfe-a4e5-985c6ff1c0c2"), "برزیل" },
                    { new Guid("1f4b8250-0363-45b9-b796-3f181f438752"), "ژاپن" },
                    { new Guid("2643f2bf-d214-4f3c-a9ae-45ccca259704"), "استرالیا" },
                    { new Guid("365908df-7a1f-45df-9a4a-1b741841c975"), "هند" },
                    { new Guid("397d6a56-a680-492b-9944-768ec09450f3"), "اسپانیا" },
                    { new Guid("43169c29-a4f7-4d20-8e5a-eba0f5cab4cd"), "ایتالیا" },
                    { new Guid("449b5c41-b0f7-4cf8-af67-1098799400d7"), "آرژانتین" },
                    { new Guid("44c6fcaf-45dd-482a-9cb9-67d0fe10f879"), "روسیه" },
                    { new Guid("4b998595-4b0d-4174-a1e8-094a5b07ccf2"), "آلمان" },
                    { new Guid("73f242f6-6d3f-4627-9faf-d953306c7047"), "بریتانیا" },
                    { new Guid("794cbc58-4d83-4875-9801-7a5b305c459a"), "مصر" },
                    { new Guid("7c36d192-c3c6-443f-8d79-5440472637e1"), "مکزیک" },
                    { new Guid("afbbc95f-be11-4099-bbc1-182518004bee"), "ایران" },
                    { new Guid("b4a5f671-15e2-4b4a-ae5d-d2f41b173ef3"), "کره جنوبی" },
                    { new Guid("bf0dd6c3-d152-469f-b65a-a1517555ef8d"), "کانادا" },
                    { new Guid("c9b9a288-9bef-4af3-9e1d-4e5b5910c624"), "فرانسه" },
                    { new Guid("d22f7c41-90b1-4bca-9d73-0b34443b88e8"), "آمریکا" },
                    { new Guid("ed4937fa-d6da-4fc6-9266-16656f42f551"), "ترکیه" },
                    { new Guid("f7d69a0d-f64f-492c-99f1-a3bbd02e5d2b"), "آفریقای جنوبی" },
                    { new Guid("fb2c1707-4e8e-403c-b42f-c546d2b0ea81"), "چین" }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "ProvinceName" },
                values: new object[,]
                {
                    { new Guid("2c513843-1a07-4c4d-8044-be58525823a7"), "فارس" },
                    { new Guid("3cec9d28-80fc-49cd-a611-bbad16f3972c"), "سمنان" },
                    { new Guid("49e5ecd9-335e-43d4-86ee-45d74a57412a"), "هرمزگان" },
                    { new Guid("6341f29d-4257-4123-9600-804747a46013"), "اصفهان" },
                    { new Guid("78d9f126-979f-4613-a96d-01e0d33dfee3"), "خراسان شمالی" },
                    { new Guid("84b46230-3ba2-4e0f-b92d-ac18b527b8a6"), "زنجان" },
                    { new Guid("89a7af45-e239-4408-984e-ce64c1073963"), "یزد" },
                    { new Guid("9106a46c-cfa1-45f9-bfed-4954ad369518"), "کرمان" },
                    { new Guid("9e9d2065-43e3-46bd-afba-3aa380a85cdb"), "خوزستان" },
                    { new Guid("a4a522af-0cbc-46c0-8fd1-54dfe3439640"), "همدان" },
                    { new Guid("ae3dc98f-f6d2-4ff5-befa-446664595702"), "سیستان و بلوچستان" },
                    { new Guid("b4427192-a119-4ef6-b66b-4b802020a572"), "کهگیلویه و بویراحمد" },
                    { new Guid("bbae735f-69a0-4dfd-944f-bb76ab744103"), "قم" },
                    { new Guid("bd562450-2efb-4f7d-a9cd-69f9f067e354"), "آذربایجان غربی" },
                    { new Guid("c6dcaf58-da0b-401f-a284-c0bd21a3f317"), "کرمانشاه" },
                    { new Guid("ccfd7b22-07de-481c-b276-9a3ed302821e"), "چهارمحال و بختیاری" },
                    { new Guid("cff49c8d-547a-47fe-af95-1bd0919619cd"), "بوشهر" },
                    { new Guid("d286fedf-a647-4e01-b19f-e990be895cff"), "مرکزی" },
                    { new Guid("d2ea55b7-452c-472e-b7c8-7b16cba758f2"), "گلستان" },
                    { new Guid("d42125b1-3986-4785-9b04-b8213f0ddd85"), "خراسان جنوبی" },
                    { new Guid("d4f0fc62-9525-4a7d-9346-6474ddb77f81"), "اردبیل" },
                    { new Guid("d6a54798-e29c-4566-891a-056e402192a8"), "خراسان رضوی" },
                    { new Guid("d6ad0016-816b-44e5-8f81-51b8f3f78537"), "قزوین" },
                    { new Guid("da314798-ed14-4dcf-bcf1-b5cbed99b448"), "آذربایجان شرقی" },
                    { new Guid("dd1d3b26-2b7f-4413-93b4-b77fe0748a0a"), "ایلام" },
                    { new Guid("ddebb38b-f674-4091-a851-b76fc7fcbac7"), "البرز" },
                    { new Guid("e4598fdf-270f-4139-a418-43d529a35b83"), "مازندران" },
                    { new Guid("e7d96627-f01d-47e0-b667-9bb0999e1eed"), "لرستان" },
                    { new Guid("f19764ee-925c-47fa-8fd6-387ff17952aa"), "گیلان" },
                    { new Guid("fce7c129-a376-44f2-ae1d-b31068f52348"), "کردستان" },
                    { new Guid("fed5cade-3d06-47ea-915e-a37fce2f89ff"), "تهران" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "ProvinceId" },
                values: new object[,]
                {
                    { new Guid("1a1f64db-fb20-4949-9b45-e83a2b0a80d1"), "تبریز", new Guid("da314798-ed14-4dcf-bcf1-b5cbed99b448") },
                    { new Guid("27296f29-ff9c-43d7-8b5d-223c5123bddd"), "خوی", new Guid("bd562450-2efb-4f7d-a9cd-69f9f067e354") },
                    { new Guid("2fe54e24-41cf-4473-b23d-1889b779084a"), "اصفهان", new Guid("6341f29d-4257-4123-9600-804747a46013") },
                    { new Guid("38663209-9e46-4ac5-9865-513a6a551d3d"), "کرج", new Guid("ddebb38b-f674-4091-a851-b76fc7fcbac7") },
                    { new Guid("4113fdeb-0cb6-4d7e-8b66-1225b1cbf65d"), "کاشان", new Guid("6341f29d-4257-4123-9600-804747a46013") },
                    { new Guid("6d469baa-bd59-4bd3-83f7-6d9d19fad7e0"), "مراغه", new Guid("da314798-ed14-4dcf-bcf1-b5cbed99b448") },
                    { new Guid("95105922-71a9-4a3e-b758-3582d0409f3b"), "ارومیه", new Guid("bd562450-2efb-4f7d-a9cd-69f9f067e354") },
                    { new Guid("a8ddd736-09fd-490f-9dd3-d9b1b48aa0a2"), "اردبیل", new Guid("d4f0fc62-9525-4a7d-9346-6474ddb77f81") },
                    { new Guid("f30cc42f-ba13-43c9-a5ab-2d384ce4d805"), "مشگین‌شهر", new Guid("d4f0fc62-9525-4a7d-9346-6474ddb77f81") }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "CountryId", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { new Guid("4b18983f-c931-4b74-b675-0ccd82232b1d"), new Guid("73f242f6-6d3f-4627-9faf-d953306c7047"), new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "جین", "Female", "آستین" },
                    { new Guid("56f356c8-74e5-4cac-94ff-c890fa4fb4bb"), new Guid("d22f7c41-90b1-4bca-9d73-0b34443b88e8"), new DateTime(1899, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ارنست", "Male", "همینگوی" },
                    { new Guid("638e2599-4a2b-48d4-ba2e-806852b11a24"), new Guid("73f242f6-6d3f-4627-9faf-d953306c7047"), new DateTime(1564, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ویلیام", "Male", "شکسپیر" },
                    { new Guid("656a25d8-8161-45b7-8961-7f68844dd133"), new Guid("1ccab492-8384-4dfe-a4e5-985c6ff1c0c2"), new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "گابریل", "Male", "گارسیا مارکز" },
                    { new Guid("66642c35-20d9-46b1-8554-6605cec4e8ae"), new Guid("afbbc95f-be11-4099-bbc1-182518004bee"), new DateTime(1903, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "صادق", "Male", "هدایت" },
                    { new Guid("7705327a-1886-49b4-9c03-cda1e1814093"), new Guid("44c6fcaf-45dd-482a-9cb9-67d0fe10f879"), new DateTime(1821, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "فئودور", "Male", "داستایوفسکی" },
                    { new Guid("7b08c076-8fe9-4060-be80-7b13dcf73fe4"), new Guid("c9b9a288-9bef-4af3-9e1d-4e5b5910c624"), new DateTime(1900, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "آنتوان", "Male", "دو سنت اگزوپری" },
                    { new Guid("a578f8b8-04a5-48cc-9f70-fdb4f9021205"), new Guid("44c6fcaf-45dd-482a-9cb9-67d0fe10f879"), new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "لئو", "Male", "تولستوی" },
                    { new Guid("bc74523b-6ed1-42d4-bbf6-f3cfc160778c"), new Guid("73f242f6-6d3f-4627-9faf-d953306c7047"), new DateTime(1882, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ویرجینیا", "Female", "وولف" },
                    { new Guid("f674c236-e3c4-40c4-a967-1510e7d5944c"), new Guid("449b5c41-b0f7-4cf8-af67-1098799400d7"), new DateTime(1899, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "خورخه", "Male", "لوئیس بورخس" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookName", "CategoryId", "Condition", "CreatedDate", "Desctiption", "ImagePath", "Price", "ProvinceId", "PublishDate", "PublisherName", "WriterId" },
                values: new object[,]
                {
                    { new Guid("0799a13e-77f5-4ede-833e-1629d0cf0e9f"), "جنایت و مکافات", new Guid("708a1378-40da-4580-b31b-727a000d91a4"), "", new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/crime_and_punishment.jpg", 135000, new Guid("e7d96627-f01d-47e0-b667-9bb0999e1eed"), new DateTime(1866, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات امیرکبیر", new Guid("7705327a-1886-49b4-9c03-cda1e1814093") },
                    { new Guid("086eca5b-0bbe-4167-bd5a-933641b32a51"), "هملت", new Guid("708a1378-40da-4580-b31b-727a000d91a4"), "", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/hamlet.jpg", 120000, new Guid("d42125b1-3986-4785-9b04-b8213f0ddd85"), new DateTime(1603, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات امیرکبیر", new Guid("638e2599-4a2b-48d4-ba2e-806852b11a24") },
                    { new Guid("1806db32-da8a-4dce-ba51-c5a0f8ea43eb"), "زنگ‌ها برای که به صدا درمی‌آیند", new Guid("b42b2855-c2b3-40a4-ae71-ef414b29c40c"), "", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/for_whom_the_bell_tolls.jpg", 125000, new Guid("da314798-ed14-4dcf-bcf1-b5cbed99b448"), new DateTime(1940, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات علمی و فرهنگی", new Guid("56f356c8-74e5-4cac-94ff-c890fa4fb4bb") },
                    { new Guid("22659c32-8c87-4cdb-80bf-fd19262f6f16"), "خانم دالووی", new Guid("708a1378-40da-4580-b31b-727a000d91a4"), "", new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/mrs_dalloway.jpg", 110000, new Guid("c6dcaf58-da0b-401f-a284-c0bd21a3f317"), new DateTime(1925, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات مرکز", new Guid("bc74523b-6ed1-42d4-bbf6-f3cfc160778c") },
                    { new Guid("2fa1c6c0-a5dd-485c-b943-c683848ed99d"), "بوف کور", new Guid("05203634-a0ca-48d7-9caf-d81b01265983"), "", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/blind_owl.jpg", 90000, new Guid("9106a46c-cfa1-45f9-bfed-4954ad369518"), new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات جاویدان", new Guid("66642c35-20d9-46b1-8554-6605cec4e8ae") },
                    { new Guid("31589b83-9399-4edc-b3f3-a3b9871a9dbd"), "الف", new Guid("b005956b-d1c7-4064-aefc-dc67e21c08ec"), "", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/aleph.jpg", 75000, new Guid("dd1d3b26-2b7f-4413-93b4-b77fe0748a0a"), new DateTime(1949, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات کارنامه", new Guid("f674c236-e3c4-40c4-a967-1510e7d5944c") },
                    { new Guid("4688e9d5-b505-47e9-92e2-86bbeb06a2b7"), "جنگ و صلح", new Guid("b42b2855-c2b3-40a4-ae71-ef414b29c40c"), "", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/war_and_peace.jpg", 250000, new Guid("d2ea55b7-452c-472e-b7c8-7b16cba758f2"), new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات نیلوفر", new Guid("a578f8b8-04a5-48cc-9f70-fdb4f9021205") },
                    { new Guid("4851ec98-e3fc-4d6b-8cbd-2df89e74c40e"), "اما", new Guid("2c912630-85dc-466f-b96d-c1300fef34ff"), "", new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/emma.jpg", 105000, new Guid("b4427192-a119-4ef6-b66b-4b802020a572"), new DateTime(1815, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات نگاه", new Guid("4b18983f-c931-4b74-b675-0ccd82232b1d") },
                    { new Guid("510b2a9d-4f14-4f19-a3ab-5da3199f2e96"), "به سوی فانوس دریایی", new Guid("708a1378-40da-4580-b31b-727a000d91a4"), "", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/to_the_lighthouse.jpg", 98000, new Guid("cff49c8d-547a-47fe-af95-1bd0919619cd"), new DateTime(1927, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات مرکز", new Guid("bc74523b-6ed1-42d4-bbf6-f3cfc160778c") },
                    { new Guid("57e6aaec-607f-43b5-8737-ddc2ceaf58c4"), "مکبث", new Guid("708a1378-40da-4580-b31b-727a000d91a4"), "", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/macbeth.jpg", 85000, new Guid("d4f0fc62-9525-4a7d-9346-6474ddb77f81"), new DateTime(1623, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات نی", new Guid("638e2599-4a2b-48d4-ba2e-806852b11a24") },
                    { new Guid("593c31d7-d00c-4b32-bd5e-90f333a4f3ad"), "صد سال تنهایی", new Guid("dfeaa92f-0b47-429c-a0cf-fbba9d9568f1"), "", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/one_hundred_years.jpg", 180000, new Guid("bd562450-2efb-4f7d-a9cd-69f9f067e354"), new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات نیلوفر", new Guid("656a25d8-8161-45b7-8961-7f68844dd133") },
                    { new Guid("c93480ea-23b8-4cb1-a0f1-329a077422b5"), "پیرمرد و دریا", new Guid("708a1378-40da-4580-b31b-727a000d91a4"), "", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/old_man_and_sea.jpg", 80000, new Guid("84b46230-3ba2-4e0f-b92d-ac18b527b8a6"), new DateTime(1952, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات علمی و فرهنگی", new Guid("56f356c8-74e5-4cac-94ff-c890fa4fb4bb") },
                    { new Guid("d1f290ff-58cf-4e88-8b80-e106f11c4d5f"), "غرور و تعصب", new Guid("2c912630-85dc-466f-b96d-c1300fef34ff"), "", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/pride_and_prejudice.jpg", 95000, new Guid("fce7c129-a376-44f2-ae1d-b31068f52348"), new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات خوارزمی", new Guid("4b18983f-c931-4b74-b675-0ccd82232b1d") },
                    { new Guid("dc7a27c9-bac7-45eb-a70c-490d856e2052"), "آنا کارنینا", new Guid("708a1378-40da-4580-b31b-727a000d91a4"), "", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/anna_karenina.jpg", 220000, new Guid("78d9f126-979f-4613-a96d-01e0d33dfee3"), new DateTime(1878, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات ماهی", new Guid("a578f8b8-04a5-48cc-9f70-fdb4f9021205") },
                    { new Guid("e5f08920-e2f8-4032-9647-1764b9fd34b9"), "شازده کوچولو", new Guid("dfeaa92f-0b47-429c-a0cf-fbba9d9568f1"), "", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "images/little_prince.jpg", 60000, new Guid("ccfd7b22-07de-481c-b276-9a3ed302821e"), new DateTime(1943, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "انتشارات پرتقال", new Guid("7b08c076-8fe9-4060-be80-7b13dcf73fe4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ProvinceId",
                table: "Books",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_WriterId",
                table: "Books",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_BookId",
                table: "ShoppingCarts",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Writers_CountryId",
                table: "Writers",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Writers");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
