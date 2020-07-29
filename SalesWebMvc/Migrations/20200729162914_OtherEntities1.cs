using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class OtherEntities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Saller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Saller_Department_DepartmentId",
                table: "Saller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saller",
                table: "Saller");

            migrationBuilder.RenameTable(
                name: "Saller",
                newName: "Seller");

            migrationBuilder.RenameIndex(
                name: "IX_Saller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seller",
                table: "Seller",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seller",
                table: "Seller");

            migrationBuilder.RenameTable(
                name: "Seller",
                newName: "Saller");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "Saller",
                newName: "IX_Saller_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saller",
                table: "Saller",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Saller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Saller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saller_Department_DepartmentId",
                table: "Saller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
