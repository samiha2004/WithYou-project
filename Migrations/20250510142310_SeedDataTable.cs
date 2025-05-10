using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WithYou_project.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Email", "Fname", "Lname", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "ali1@example.com", "Ali", "Saleh", "Password123", "SuperAdmin" },
                    { 2, "sara@example.com", "Sara", "Khalil", "Password1234", "Admin" },
                    { 3, "mona@example.com", "Mona", "Naser", "Password1235", "Admin" },
                    { 4, "omar@example.com", "Omar", "Sami", "Password1236", "Admin" },
                    { 5, "lina@example.com", "Lina", "Ahmad", "Password1237", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Psychologiest",
                columns: new[] { "PsychologistId", "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[,]
                {
                    { 1, "PhD in Psychology", "ahmed@example.com", 10, "Dr. Ahmed", "Sami", "pswd123", "Clinical" },
                    { 2, "Masters in Counseling", "noura@example.com", 5, "Dr. Noura", "Almasri", "pswd123", "Counseling" },
                    { 3, "PhD in Behavioral Science", "samer@example.com", 12, "Dr. Samer", "Hassan", "pswd123", "Behavioral" },
                    { 4, "Masters in Psychology", "mona@example.com", 8, "Dr. Mona", "Tariq", "pswd123", "Therapist" },
                    { 5, "PhD in Neuroscience", "layla@example.com", 15, "Dr. Layla", "Ibrahim", "pswd123", "Neuroscience" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "DateOfBirth", "Email", "Fname", "Gender", "Lname", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "yousef@example.com", "Yousef", "Male", "Ali", "pass123", "0591234567" },
                    { 2, new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "laila@example.com", "Laila", "Female", "Hassan", "pass123", "0591234568" },
                    { 3, new DateTime(1995, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ola@example.com", "Ola", "Female", "Tariq", "pass123", "0591234569" },
                    { 4, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hani@example.com", "Hani", "Male", "Mohsen", "pass123", "0591234570" },
                    { 5, new DateTime(1993, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sami@example.com", "Sami", "Male", "Ibrahim", "pass123", "0591234571" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "PsychologistId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Content about depression...", 1, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Depression" },
                    { 2, "Content about therapy...", 2, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Importance of Therapy" },
                    { 3, "Content about anxiety...", 3, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to Cope with Anxiety" },
                    { 4, "Content about stress...", 4, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overcoming Stress" },
                    { 5, "Content about neuroscience...", 5, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neuroscience and Mental Health" }
                });

            migrationBuilder.InsertData(
                table: "Problem",
                columns: new[] { "ProblemId", "Description", "DiagnosisDate", "PsychologistId", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "Struggling with depression", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mental Health", 1 },
                    { 2, "Anxiety issues", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Mental Health", 2 },
                    { 3, "Stress from work", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mental Health", 3 },
                    { 4, "Difficulty managing emotions", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Emotional Health", 4 },
                    { 5, "Sleep disorders", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Physical Health", 5 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "Comment", "PsychologistId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Great session, helped a lot", 1, 5, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Very informative and useful", 2, 4, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Excellent session, highly recommend", 3, 5, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "The session was okay, but could improve", 4, 3, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "Really helped me with my mental health", 5, 5, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "SessionId", "Date", "Description", "PsychologistId", "Status", "Time", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Session on Depression", 1, "Completed", "10:00 AM", 1 },
                    { 2, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Session on Anxiety", 2, "Scheduled", "11:00 AM", 2 },
                    { 3, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Session on Stress Management", 3, "Completed", "12:00 PM", 3 },
                    { 4, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Therapy Session", 4, "Scheduled", "02:00 PM", 4 },
                    { 5, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mental Health Session", 5, "Completed", "03:00 PM", 5 }
                });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "MessageId", "Content", "ProblemId", "PsychologistId", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { 1, "I'm feeling very low lately.", 1, 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "I feel anxious about upcoming events.", 2, 2, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Work is really stressful right now.", 3, 3, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "I can't control my anger at times.", 4, 4, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "I can't sleep at night.", 5, 5, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "PaymentId", "Amount", "Date", "Method", "SessionId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 100m, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Credit Card", 1, "Paid", 1 },
                    { 2, 150m, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PayPal", 2, "Pending", 2 },
                    { 3, 120m, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debit Card", 3, "Paid", 3 },
                    { 4, 130m, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash", 4, "Paid", 4 },
                    { 5, 140m, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bank Transfer", 5, "Pending", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5);
        }
    }
}
