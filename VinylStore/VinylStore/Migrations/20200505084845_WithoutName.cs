﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VinylStore.Migrations
{
    public partial class WithoutName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    AddressLine = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    ArtistId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vinyls",
                columns: table => new
                {
                    VinylId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsVinylOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    AlbumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinyls", x => x.VinylId);
                    table.ForeignKey(
                        name: "FK_Vinyls_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vinyls_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    VinylId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Vinyls_VinylId",
                        column: x => x.VinylId,
                        principalTable: "Vinyls",
                        principalColumn: "VinylId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VinylId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Vinyls_VinylId",
                        column: x => x.VinylId,
                        principalTable: "Vinyls",
                        principalColumn: "VinylId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistName", "Description", "ImgUrl" },
                values: new object[,]
                {
                    { 1, "Pink Floyd", null, "https://life.bodo.ua/upload/files/cm-event/17/16666/image/971226c05f8108a4375440fad6ebd5d788edcf12-r1r1h1000w1422zc3q100.jpg" },
                    { 2, "Madonna", null, "https://imgclf.112.ua/original/2019/05/15/388283.jpg?timestamp=1557857653" },
                    { 3, "Stevie Wonder", null, "https://tunnel.ru/media/images/2019-05/post/128729/stevie-wonder-1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "New Arrivals", null },
                    { 2, "Timeless Classic", null },
                    { 3, "All records", null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "GenreName" },
                values: new object[,]
                {
                    { 1, null, "Rock/Pop" },
                    { 2, null, "Soul/R&B" },
                    { 3, null, "Jazz" },
                    { 4, null, "Electronic" },
                    { 5, null, "Classic" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumName", "ArtistId", "Description", "GenreId", "ImgUrl" },
                values: new object[] { 1, "The Dark Side of the Moon", 1, null, 1, null });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumName", "ArtistId", "Description", "GenreId", "ImgUrl" },
                values: new object[] { 2, "Like a Prayer", 2, null, 1, null });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumName", "ArtistId", "Description", "GenreId", "ImgUrl" },
                values: new object[] { 3, "Songs in the Key of Life", 3, null, 2, null });

            migrationBuilder.InsertData(
                table: "Vinyls",
                columns: new[] { "VinylId", "AlbumId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsVinylOfTheWeek", "Label", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { 1, 1, 2, "https://images-na.ssl-images-amazon.com/images/I/31+szRBlJyL._AC_US218_.jpg", "https://idealsounds.net/images/covers/pink-floyd-the-dark-side-of-the-moon-lp-180-gram-vinyl.jpg", true, true, "Virgin Records", null, 23.56m, "Best album" });

            migrationBuilder.InsertData(
                table: "Vinyls",
                columns: new[] { "VinylId", "AlbumId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsVinylOfTheWeek", "Label", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { 2, 2, 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQXyy1CosKQ5bVmevo6YGHa8nXQNwzyB1xoyLgPORqnfQTwMXUG&usqp=CAU", "https://cdn.shopify.com/s/files/1/0593/0549/products/MADONNASELG_800x667_9eadab26-9683-442a-8560-700bfd08c39b.jpg?v=1466277186", true, false, "EMO Records", null, 13.46m, "Best album" });

            migrationBuilder.InsertData(
                table: "Vinyls",
                columns: new[] { "VinylId", "AlbumId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsVinylOfTheWeek", "Label", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { 3, 3, 3, "data:image/jpeg;base64,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", "https://cdn.shopify.com/s/files/1/0068/0042/products/MOT5316422.1_800x.jpg?v=1571439086", true, false, "Vertigo Records", null, 13.46m, "Best album" });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");

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
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_VinylId",
                table: "OrderDetails",
                column: "VinylId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_VinylId",
                table: "ShoppingCartItems",
                column: "VinylId");

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_AlbumId",
                table: "Vinyls",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_CategoryId",
                table: "Vinyls",
                column: "CategoryId");
        }

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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Vinyls");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
