﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra02.Data.Migrations
{
	/// <inheritdoc />
	public partial class lophoc : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "LopHoc",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
					DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
					DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
					Soluong = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_LopHoc", x => x.Id);
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "LopHoc");
		}
	}
}