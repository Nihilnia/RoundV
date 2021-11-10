using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3_ScaffoldingDatabase.Migrations
{
    public partial class fly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    first_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email_address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    job_title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    business_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    home_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mobile_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fax_number = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    address = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    state_province = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    zip_postal_code = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country_region = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    web_page = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    notes = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attachments = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    first_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email_address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    job_title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    business_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    home_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mobile_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fax_number = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    address = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    state_province = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    zip_postal_code = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country_region = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    web_page = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    notes = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attachments = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "inventory_transaction_types",
                columns: table => new
                {
                    id = table.Column<sbyte>(type: "tinyint", nullable: false),
                    type_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_transaction_types", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "order_details_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    status_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_details_status", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "orders_status",
                columns: table => new
                {
                    id = table.Column<sbyte>(type: "tinyint", nullable: false),
                    status_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders_status", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "orders_tax_status",
                columns: table => new
                {
                    id = table.Column<sbyte>(type: "tinyint", nullable: false),
                    tax_status_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders_tax_status", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "privileges",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    privilege_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privileges", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    supplier_ids = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    product_code = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    product_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    description = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    standard_cost = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: true, defaultValueSql: "'0.0000'"),
                    list_price = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: false),
                    reorder_level = table.Column<int>(type: "int", nullable: true),
                    target_level = table.Column<int>(type: "int", nullable: true),
                    quantity_per_unit = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    discontinued = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    minimum_reorder_quantity = table.Column<int>(type: "int", nullable: true),
                    category = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attachments = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "purchase_order_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_order_status", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "sales_reports",
                columns: table => new
                {
                    group_by = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    display = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    filter_row_source = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    @default = table.Column<bool>(name: "default", type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.group_by);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "shippers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    first_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email_address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    job_title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    business_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    home_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mobile_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fax_number = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    address = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    state_province = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    zip_postal_code = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country_region = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    web_page = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    notes = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attachments = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shippers", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "strings",
                columns: table => new
                {
                    string_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    string_data = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_strings", x => x.string_id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    first_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email_address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    job_title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    business_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    home_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mobile_phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fax_number = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    address = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    state_province = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    zip_postal_code = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country_region = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    web_page = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    notes = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    attachments = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "employee_privileges",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    privilege_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.employee_id, x.privilege_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_employee_privileges_employees1",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_employee_privileges_privileges1",
                        column: x => x.privilege_id,
                        principalTable: "privileges",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employee_id = table.Column<int>(type: "int", nullable: true),
                    customer_id = table.Column<int>(type: "int", nullable: true),
                    order_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    shipped_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    shipper_id = table.Column<int>(type: "int", nullable: true),
                    ship_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ship_address = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ship_city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ship_state_province = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ship_zip_postal_code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ship_country_region = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    shipping_fee = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: true, defaultValueSql: "'0.0000'"),
                    taxes = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: true, defaultValueSql: "'0.0000'"),
                    payment_type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    paid_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    notes = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    tax_rate = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    tax_status_id = table.Column<sbyte>(type: "tinyint", nullable: true),
                    status_id = table.Column<sbyte>(type: "tinyint", nullable: true, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                    table.ForeignKey(
                        name: "fk_orders_customers",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orders_employees1",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orders_orders_status1",
                        column: x => x.status_id,
                        principalTable: "orders_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orders_orders_tax_status1",
                        column: x => x.tax_status_id,
                        principalTable: "orders_tax_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orders_shippers1",
                        column: x => x.shipper_id,
                        principalTable: "shippers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "purchase_orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    supplier_id = table.Column<int>(type: "int", nullable: true),
                    created_by = table.Column<int>(type: "int", nullable: true),
                    submitted_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    creation_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    status_id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'0'"),
                    expected_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    shipping_fee = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: false),
                    taxes = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: false),
                    payment_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    payment_amount = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: true, defaultValueSql: "'0.0000'"),
                    payment_method = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    notes = table.Column<string>(type: "longtext", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    approved_by = table.Column<int>(type: "int", nullable: true),
                    approved_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    submitted_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_orders", x => x.id);
                    table.ForeignKey(
                        name: "fk_purchase_orders_employees1",
                        column: x => x.created_by,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_purchase_orders_purchase_order_status1",
                        column: x => x.status_id,
                        principalTable: "purchase_order_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_purchase_orders_suppliers1",
                        column: x => x.supplier_id,
                        principalTable: "suppliers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int", nullable: true),
                    invoice_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    due_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    tax = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: true, defaultValueSql: "'0.0000'"),
                    shipping = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: true, defaultValueSql: "'0.0000'"),
                    amount_due = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: true, defaultValueSql: "'0.0000'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.id);
                    table.ForeignKey(
                        name: "fk_invoices_orders1",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "order_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: true, defaultValueSql: "'0.0000'"),
                    discount = table.Column<double>(type: "double", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: true),
                    date_allocated = table.Column<DateTime>(type: "datetime", nullable: true),
                    purchase_order_id = table.Column<int>(type: "int", nullable: true),
                    inventory_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_details", x => x.id);
                    table.ForeignKey(
                        name: "fk_order_details_order_details_status1",
                        column: x => x.status_id,
                        principalTable: "order_details_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_order_details_orders1",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_order_details_products1",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "inventory_transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    transaction_type = table.Column<sbyte>(type: "tinyint", nullable: false),
                    transaction_created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    transaction_modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    purchase_order_id = table.Column<int>(type: "int", nullable: true),
                    customer_order_id = table.Column<int>(type: "int", nullable: true),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_transactions", x => x.id);
                    table.ForeignKey(
                        name: "fk_inventory_transactions_inventory_transaction_types1",
                        column: x => x.transaction_type,
                        principalTable: "inventory_transaction_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_inventory_transactions_orders1",
                        column: x => x.customer_order_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_inventory_transactions_products1",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_inventory_transactions_purchase_orders1",
                        column: x => x.purchase_order_id,
                        principalTable: "purchase_orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "purchase_order_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchase_order_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    unit_cost = table.Column<decimal>(type: "decimal(19,4)", precision: 19, scale: 4, nullable: false),
                    date_received = table.Column<DateTime>(type: "datetime", nullable: true),
                    posted_to_inventory = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    inventory_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_order_details", x => x.id);
                    table.ForeignKey(
                        name: "fk_purchase_order_details_inventory_transactions1",
                        column: x => x.inventory_id,
                        principalTable: "inventory_transactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_purchase_order_details_products1",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_purchase_order_details_purchase_orders1",
                        column: x => x.purchase_order_id,
                        principalTable: "purchase_orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateIndex(
                name: "city",
                table: "customers",
                column: "city");

            migrationBuilder.CreateIndex(
                name: "company",
                table: "customers",
                column: "company");

            migrationBuilder.CreateIndex(
                name: "first_name",
                table: "customers",
                column: "first_name");

            migrationBuilder.CreateIndex(
                name: "last_name",
                table: "customers",
                column: "last_name");

            migrationBuilder.CreateIndex(
                name: "state_province",
                table: "customers",
                column: "state_province");

            migrationBuilder.CreateIndex(
                name: "zip_postal_code",
                table: "customers",
                column: "zip_postal_code");

            migrationBuilder.CreateIndex(
                name: "employee_id",
                table: "employee_privileges",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "privilege_id",
                table: "employee_privileges",
                column: "privilege_id");

            migrationBuilder.CreateIndex(
                name: "city1",
                table: "employees",
                column: "city");

            migrationBuilder.CreateIndex(
                name: "company1",
                table: "employees",
                column: "company");

            migrationBuilder.CreateIndex(
                name: "first_name1",
                table: "employees",
                column: "first_name");

            migrationBuilder.CreateIndex(
                name: "last_name1",
                table: "employees",
                column: "last_name");

            migrationBuilder.CreateIndex(
                name: "state_province1",
                table: "employees",
                column: "state_province");

            migrationBuilder.CreateIndex(
                name: "zip_postal_code1",
                table: "employees",
                column: "zip_postal_code");

            migrationBuilder.CreateIndex(
                name: "customer_order_id",
                table: "inventory_transactions",
                column: "customer_order_id");

            migrationBuilder.CreateIndex(
                name: "product_id",
                table: "inventory_transactions",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "purchase_order_id",
                table: "inventory_transactions",
                column: "purchase_order_id");

            migrationBuilder.CreateIndex(
                name: "transaction_type",
                table: "inventory_transactions",
                column: "transaction_type");

            migrationBuilder.CreateIndex(
                name: "fk_invoices_orders1_idx",
                table: "invoices",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "id",
                table: "invoices",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "fk_order_details_order_details_status1_idx",
                table: "order_details",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "fk_order_details_orders1_idx",
                table: "order_details",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "id2",
                table: "order_details",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "inventory_id",
                table: "order_details",
                column: "inventory_id");

            migrationBuilder.CreateIndex(
                name: "product_id1",
                table: "order_details",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "purchase_order_id1",
                table: "order_details",
                column: "purchase_order_id");

            migrationBuilder.CreateIndex(
                name: "customer_id",
                table: "orders",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "employee_id1",
                table: "orders",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "fk_orders_orders_status1",
                table: "orders",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "id1",
                table: "orders",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "ship_zip_postal_code",
                table: "orders",
                column: "ship_zip_postal_code");

            migrationBuilder.CreateIndex(
                name: "shipper_id",
                table: "orders",
                column: "shipper_id");

            migrationBuilder.CreateIndex(
                name: "tax_status",
                table: "orders",
                column: "tax_status_id");

            migrationBuilder.CreateIndex(
                name: "product_code",
                table: "products",
                column: "product_code");

            migrationBuilder.CreateIndex(
                name: "id4",
                table: "purchase_order_details",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "inventory_id1",
                table: "purchase_order_details",
                column: "inventory_id");

            migrationBuilder.CreateIndex(
                name: "product_id2",
                table: "purchase_order_details",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "purchase_order_id2",
                table: "purchase_order_details",
                column: "purchase_order_id");

            migrationBuilder.CreateIndex(
                name: "created_by",
                table: "purchase_orders",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "id3",
                table: "purchase_orders",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "status_id",
                table: "purchase_orders",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "supplier_id",
                table: "purchase_orders",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "city2",
                table: "shippers",
                column: "city");

            migrationBuilder.CreateIndex(
                name: "company2",
                table: "shippers",
                column: "company");

            migrationBuilder.CreateIndex(
                name: "first_name2",
                table: "shippers",
                column: "first_name");

            migrationBuilder.CreateIndex(
                name: "last_name2",
                table: "shippers",
                column: "last_name");

            migrationBuilder.CreateIndex(
                name: "state_province2",
                table: "shippers",
                column: "state_province");

            migrationBuilder.CreateIndex(
                name: "zip_postal_code2",
                table: "shippers",
                column: "zip_postal_code");

            migrationBuilder.CreateIndex(
                name: "city3",
                table: "suppliers",
                column: "city");

            migrationBuilder.CreateIndex(
                name: "company3",
                table: "suppliers",
                column: "company");

            migrationBuilder.CreateIndex(
                name: "first_name3",
                table: "suppliers",
                column: "first_name");

            migrationBuilder.CreateIndex(
                name: "last_name3",
                table: "suppliers",
                column: "last_name");

            migrationBuilder.CreateIndex(
                name: "state_province3",
                table: "suppliers",
                column: "state_province");

            migrationBuilder.CreateIndex(
                name: "zip_postal_code3",
                table: "suppliers",
                column: "zip_postal_code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee_privileges");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "order_details");

            migrationBuilder.DropTable(
                name: "purchase_order_details");

            migrationBuilder.DropTable(
                name: "sales_reports");

            migrationBuilder.DropTable(
                name: "strings");

            migrationBuilder.DropTable(
                name: "privileges");

            migrationBuilder.DropTable(
                name: "order_details_status");

            migrationBuilder.DropTable(
                name: "inventory_transactions");

            migrationBuilder.DropTable(
                name: "inventory_transaction_types");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "purchase_orders");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "orders_status");

            migrationBuilder.DropTable(
                name: "orders_tax_status");

            migrationBuilder.DropTable(
                name: "shippers");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "purchase_order_status");

            migrationBuilder.DropTable(
                name: "suppliers");
        }
    }
}
