using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    Key = table.Column<string>(maxLength: 50, nullable: true),
                    Value = table.Column<string>(maxLength: 500, nullable: true),
                    AboutUsId = table.Column<int>(nullable: true),
                    AboutTitle = table.Column<string>(maxLength: 100, nullable: true),
                    AboutText = table.Column<string>(maxLength: 500, nullable: true),
                    AboutPhone = table.Column<string>(maxLength: 50, nullable: true),
                    İmage = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    BlogTitle = table.Column<string>(maxLength: 100, nullable: true),
                    BlogText = table.Column<string>(maxLength: 500, nullable: true),
                    BlogImage = table.Column<string>(maxLength: 100, nullable: true),
                    Position = table.Column<string>(maxLength: 100, nullable: true),
                    ActionText = table.Column<string>(maxLength: 100, nullable: true),
                    Brand_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Brand_Logo = table.Column<string>(maxLength: 100, nullable: true),
                    OrderBy = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    HomeSlider_Image = table.Column<string>(maxLength: 200, nullable: true),
                    EndPoint = table.Column<string>(maxLength: 100, nullable: true),
                    Slogon = table.Column<string>(maxLength: 100, nullable: true),
                    HomeSlider_ActionText = table.Column<string>(maxLength: 50, nullable: true),
                    Text = table.Column<string>(maxLength: 50, nullable: true),
                    Color = table.Column<string>(maxLength: 50, nullable: true),
                    Likeable_Title = table.Column<string>(maxLength: 100, nullable: true),
                    Likeable_Text = table.Column<string>(maxLength: 500, nullable: true),
                    Likeable_Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Likeable_İmage = table.Column<string>(maxLength: 100, nullable: true),
                    Likeable_ActionText = table.Column<string>(maxLength: 50, nullable: true),
                    Likeable_AboutUsId = table.Column<int>(nullable: true),
                    Product_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Product_Logo = table.Column<string>(nullable: true),
                    LabelId = table.Column<int>(nullable: true),
                    ProductSpec_OrderBy = table.Column<int>(nullable: true),
                    ProductSpec_ProductId = table.Column<int>(nullable: true),
                    ProductSpec_Key = table.Column<string>(maxLength: 50, nullable: true),
                    ProductSpec_Value = table.Column<string>(maxLength: 500, nullable: true),
                    Setting_Logo = table.Column<string>(maxLength: 100, nullable: true),
                    HaveAnyQuery = table.Column<string>(maxLength: 50, nullable: true),
                    Adress = table.Column<string>(maxLength: 50, nullable: true),
                    Setting_Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    OficceTime = table.Column<string>(maxLength: 50, nullable: true),
                    Testimonial_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Testimonial_AboutText = table.Column<string>(maxLength: 500, nullable: true),
                    Testimonial_Position = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_AboutUsId",
                        column: x => x.AboutUsId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Likeable_AboutUsId",
                        column: x => x.Likeable_AboutUsId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_LabelId",
                        column: x => x.LabelId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductSpec_ProductId",
                        column: x => x.ProductSpec_ProductId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_AboutUsId",
                table: "BaseEntities",
                column: "AboutUsId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductId",
                table: "BaseEntities",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Likeable_AboutUsId",
                table: "BaseEntities",
                column: "Likeable_AboutUsId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_LabelId",
                table: "BaseEntities",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductSpec_ProductId",
                table: "BaseEntities",
                column: "ProductSpec_ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");
        }
    }
}
