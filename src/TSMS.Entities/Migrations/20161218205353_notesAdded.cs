using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TSMS.Entities.Migrations
{
    public partial class notesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Pricing_PricingId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_AspNetUsers_CustomerId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Pricing_PricingId",
                table: "Delivery");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pricing",
                table: "Pricing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Delivery",
                table: "Delivery");

            migrationBuilder.RenameTable(
                name: "Pricing",
                newName: "Pricings");

            migrationBuilder.RenameTable(
                name: "Delivery",
                newName: "Deliveries");

            migrationBuilder.RenameIndex(
                name: "IX_Delivery_PricingId",
                table: "Deliveries",
                newName: "IX_Deliveries_PricingId");

            migrationBuilder.RenameIndex(
                name: "IX_Delivery_CustomerId",
                table: "Deliveries",
                newName: "IX_Deliveries_CustomerId");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pricings",
                table: "Pricings",
                column: "PricingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries",
                column: "DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Pricings_PricingId",
                table: "AspNetUsers",
                column: "PricingId",
                principalTable: "Pricings",
                principalColumn: "PricingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_AspNetUsers_CustomerId",
                table: "Deliveries",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Pricings_PricingId",
                table: "Deliveries",
                column: "PricingId",
                principalTable: "Pricings",
                principalColumn: "PricingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Pricings_PricingId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_AspNetUsers_CustomerId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Pricings_PricingId",
                table: "Deliveries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pricings",
                table: "Pricings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Pricings",
                newName: "Pricing");

            migrationBuilder.RenameTable(
                name: "Deliveries",
                newName: "Delivery");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_PricingId",
                table: "Delivery",
                newName: "IX_Delivery_PricingId");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_CustomerId",
                table: "Delivery",
                newName: "IX_Delivery_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pricing",
                table: "Pricing",
                column: "PricingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Delivery",
                table: "Delivery",
                column: "DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Pricing_PricingId",
                table: "AspNetUsers",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "PricingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_AspNetUsers_CustomerId",
                table: "Delivery",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Pricing_PricingId",
                table: "Delivery",
                column: "PricingId",
                principalTable: "Pricing",
                principalColumn: "PricingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
