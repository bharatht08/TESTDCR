using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Lshp.BaseWebApi.Migrations
{
    /// <summary>
    /// lshp
    /// </summary>

    public partial class lshp : Migration
    {
        /// <summary>
        /// Up
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Access",
                columns: table => new
                {
                    AccessID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AccessType = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access", x => x.AccessID);
                });

            migrationBuilder.CreateTable(
                name: "jsonmessage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    MessageData = table.Column<string>(nullable: true),
                    MessageTypeId = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    SubjectData = table.Column<string>(nullable: true),
                    TemplateId = table.Column<int>(nullable: false),
                    ToEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jsonmessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Culture = table.Column<string>(nullable: true),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "messagetype",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Code = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messagetype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Code = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserActionEventLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EventID = table.Column<int>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    LogLevel = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    RequestData = table.Column<string>(nullable: true),
                    RequestID = table.Column<string>(nullable: true),
                    RequestIP = table.Column<string>(nullable: true),
                    RequestUrl = table.Column<string>(nullable: true),
                    ServerName = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActionEventLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Content = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    JsonMessageId = table.Column<int>(nullable: false),
                    MessageTypeId = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    RetryCount = table.Column<int>(nullable: false),
                    SentDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    ToEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_messages_jsonmessage_JsonMessageId",
                        column: x => x.JsonMessageId,
                        principalTable: "jsonmessage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_messages_messagetype_MessageTypeId",
                        column: x => x.MessageTypeId,
                        principalTable: "messagetype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "template",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Body = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    MessageTypeId = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template", x => x.Id);
                    table.ForeignKey(
                        name: "FK_template_messagetype_MessageTypeId",
                        column: x => x.MessageTypeId,
                        principalTable: "messagetype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    ResourceID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    OwnerID = table.Column<int>(nullable: false),
                    ResourceDetails = table.Column<string>(nullable: true),
                    ResourceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceID);
                    table.ForeignKey(
                        name: "FK_Resource_Users_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShareResource",
                columns: table => new
                {
                    ShareID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AccessID = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ResourceID = table.Column<int>(nullable: false),
                    ShareUserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShareResource", x => x.ShareID);
                    table.ForeignKey(
                        name: "FK_ShareResource_Access_AccessID",
                        column: x => x.AccessID,
                        principalTable: "Access",
                        principalColumn: "AccessID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShareResource_Resource_ResourceID",
                        column: x => x.ResourceID,
                        principalTable: "Resource",
                        principalColumn: "ResourceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShareResource_Users_ShareUserID",
                        column: x => x.ShareUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_messages_JsonMessageId",
                table: "messages",
                column: "JsonMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_messages_MessageTypeId",
                table: "messages",
                column: "MessageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_OwnerID",
                table: "Resource",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_ShareResource_AccessID",
                table: "ShareResource",
                column: "AccessID");

            migrationBuilder.CreateIndex(
                name: "IX_ShareResource_ResourceID",
                table: "ShareResource",
                column: "ResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ShareResource_ShareUserID",
                table: "ShareResource",
                column: "ShareUserID");

            migrationBuilder.CreateIndex(
                name: "IX_template_MessageTypeId",
                table: "template",
                column: "MessageTypeId");
        }

        /// <summary>
        /// Down
        /// </summary>
        /// <param name="migrationBuilder"></param>

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Localization");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "ShareResource");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "template");

            migrationBuilder.DropTable(
                name: "UserActionEventLog");

            migrationBuilder.DropTable(
                name: "jsonmessage");

            migrationBuilder.DropTable(
                name: "Access");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "messagetype");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
