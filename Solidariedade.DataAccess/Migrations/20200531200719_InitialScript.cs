using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Solidariedade.DataAccess.Migrations
{
    public partial class InitialScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    tx_uf = table.Column<string>(type: "varchar(2)", nullable: false),
                    tx_nome = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.tx_uf);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    tx_nome = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    tx_email = table.Column<string>(type: "varchar(80)", nullable: false),
                    tx_nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    tx_endereco = table.Column<string>(type: "varchar(200)", nullable: true),
                    tx_cidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    StateUF = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_Estado_StateUF",
                        column: x => x.StateUF,
                        principalTable: "Estado",
                        principalColumn: "tx_uf",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produto_para_doacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nu_quantidade = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<Guid>(nullable: true),
                    DonatorPersonId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_para_doacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_produto_para_doacao_Pessoa_DonatorPersonId",
                        column: x => x.DonatorPersonId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_produto_para_doacao_Produto_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produto_solicitado",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nu_quantidade = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<Guid>(nullable: true),
                    DoneePersonId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_solicitado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_produto_solicitado_Pessoa_DoneePersonId",
                        column: x => x.DoneePersonId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_produto_solicitado_Produto_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "item_doacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nu_quantidade = table.Column<int>(type: "Integer", nullable: false),
                    ProductId = table.Column<Guid>(nullable: true),
                    DonationId = table.Column<Guid>(nullable: true),
                    ProductId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_doacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_item_doacao_Produto_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_item_doacao_Produto_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "doacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    dt_doacao = table.Column<DateTime>(type: "Date", nullable: false),
                    DonationDeliveryType = table.Column<int>(nullable: false),
                    ItemsId = table.Column<Guid>(nullable: true),
                    DonatorPersonId = table.Column<Guid>(nullable: true),
                    DoneePersonId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_doacao_Pessoa_DonatorPersonId",
                        column: x => x.DonatorPersonId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_doacao_Pessoa_DoneePersonId",
                        column: x => x.DoneePersonId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_doacao_item_doacao_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "item_doacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "tx_uf", "tx_nome" },
                values: new object[,]
                {
                    { "AC", "Acre" },
                    { "SP", "São Paulo" },
                    { "SC", "Santa Catarina" },
                    { "RR", "Roraima" },
                    { "RO", "Rondônia" },
                    { "RS", "Rio Grande do Sul" },
                    { "RN", "Rio Grande do Norte" },
                    { "RJ", "Rio de Janeiro" },
                    { "PI", "Piauí" },
                    { "PE", "Pernambuco" },
                    { "PR", "Paraná" },
                    { "PB", "Paraíba" },
                    { "SE", "Sergipe" },
                    { "PA", "Pará" },
                    { "MS", "Mato Grosso do Sul" },
                    { "MT", "Mato Grosso" },
                    { "MA", "Maranhão" },
                    { "GO", "Goiás" },
                    { "ES", "Espírito Santo" },
                    { "DF", "Distrito Federal" },
                    { "CE", "Ceará" },
                    { "BA", "Bahia" },
                    { "AM", "Amazonas" },
                    { "AP", "Amapá" },
                    { "AL", "Alagoas" },
                    { "MG", "Minas Gerais" },
                    { "TO", "Tocantins" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_doacao_DonatorPersonId",
                table: "doacao",
                column: "DonatorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_doacao_DoneePersonId",
                table: "doacao",
                column: "DoneePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_doacao_ItemsId",
                table: "doacao",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_item_doacao_DonationId",
                table: "item_doacao",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_item_doacao_ProductId",
                table: "item_doacao",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_item_doacao_ProductId1",
                table: "item_doacao",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_StateUF",
                table: "Pessoa",
                column: "StateUF");

            migrationBuilder.CreateIndex(
                name: "IX_produto_para_doacao_DonatorPersonId",
                table: "produto_para_doacao",
                column: "DonatorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_para_doacao_ProductId",
                table: "produto_para_doacao",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_solicitado_DoneePersonId",
                table: "produto_solicitado",
                column: "DoneePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_solicitado_ProductId",
                table: "produto_solicitado",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_item_doacao_doacao_DonationId",
                table: "item_doacao",
                column: "DonationId",
                principalTable: "doacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doacao_Pessoa_DonatorPersonId",
                table: "doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_doacao_Pessoa_DoneePersonId",
                table: "doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_doacao_item_doacao_ItemsId",
                table: "doacao");

            migrationBuilder.DropTable(
                name: "produto_para_doacao");

            migrationBuilder.DropTable(
                name: "produto_solicitado");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "item_doacao");

            migrationBuilder.DropTable(
                name: "doacao");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
