using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WithYou_project.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                columns: new[] { "Email", "Fname", "Lname", "Password" },
                values: new object[] { "sara@admin.com", "Sara", "Khalil", "AdminPass1" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 2,
                columns: new[] { "Email", "Fname", "Lname", "Password", "Role" },
                values: new object[] { "omar@admin.com", "Omar", "Nasser", "AdminPass2", "Moderator" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 3,
                columns: new[] { "Email", "Fname", "Lname", "Password", "Role" },
                values: new object[] { "lina@admin.com", "Lina", "Mansour", "AdminPass3", "Editor" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 4,
                columns: new[] { "Email", "Fname", "Lname", "Password" },
                values: new object[] { "fadi@admin.com", "Fadi", "Qassem", "AdminPass4" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 5,
                columns: new[] { "Email", "Fname", "Lname", "Password" },
                values: new object[] { "dina@admin.com", "Dina", "Salem", "AdminPass5" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Tips and exercises to manage anxiety.", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Managing Anxiety in Daily Life" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Symptoms and coping strategies for depression.", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Depression" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Workplace stress and how to manage it.", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stress Management at Work" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Steps towards recovery after traumatic experiences.", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healing from Trauma" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Understanding and processing grief.", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coping with Grief" });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Feeling anxious today.", new DateTime(2024, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "I need help dealing with sadness.", new DateTime(2024, 5, 2, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Can't sleep due to stress.", new DateTime(2024, 5, 3, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 4,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Old memories resurfacing.", new DateTime(2024, 5, 4, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 5,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Feeling very alone.", new DateTime(2024, 5, 5, 7, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 50m, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 40m, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3,
                columns: new[] { "Amount", "Date", "Method" },
                values: new object[] { 45m, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bank Transfer" });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 55m, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5,
                columns: new[] { "Amount", "Date", "Method" },
                values: new object[] { 60m, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Credit Card" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 1,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Severe anxiety issues", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anxiety" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 2,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Depression symptoms", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Depression" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 3,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Stress at work", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stress" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 4,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Childhood trauma", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trauma" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 5,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Grieving loss of parent", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grief" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 1,
                columns: new[] { "Certificates", "Email", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "PhD Psychology", "rami@psych.com", "Rami", "Awad", "PsyPass1", "Anxiety" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 2,
                columns: new[] { "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "MA Clinical Psychology", "nour@psych.com", 8, "Nour", "Hamed", "PsyPass2", "Depression" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 3,
                columns: new[] { "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "MSc Behavioral Psychology", "sami@psych.com", 6, "Sami", "Badran", "PsyPass3", "Stress" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 4,
                columns: new[] { "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "PhD Psychology", "huda@psych.com", 12, "Huda", "Zein", "PsyPass4", "Trauma" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 5,
                columns: new[] { "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "MSc Clinical Psychology", "ibrahim@psych.com", 9, "Ibrahim", "Saleh", "PsyPass5", "Grief" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Very helpful session", new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Good listener", new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "Comment", "Rating", "ReviewDate" },
                values: new object[] { "Helped with my stress", 4, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "Comment", "Rating", "ReviewDate" },
                values: new object[] { "Trauma guidance was excellent", 5, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Very understanding", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 1,
                columns: new[] { "Date", "Description", "Status" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anxiety session", "Available" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 2,
                columns: new[] { "Date", "Description", "Status", "Time" },
                values: new object[] { new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Depression support", "Booked", "2:00 PM" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 3,
                columns: new[] { "Date", "Description", "Status", "Time" },
                values: new object[] { new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stress handling", "Available", "4:00 PM" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 4,
                columns: new[] { "Date", "Description", "Status", "Time" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trauma discussion", "Completed", "11:00 AM" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 5,
                columns: new[] { "Date", "Description", "Status", "Time" },
                values: new object[] { new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grief counseling", "Available", "3:00 PM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Password" },
                values: new object[] { new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmad@example.com", "Ahmad", "UserPass1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Lname", "Password", "Phone" },
                values: new object[] { new DateTime(1992, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "mona@example.com", "Mona", "Yousef", "UserPass2", "0597654321" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Gender", "Lname", "Password", "Phone" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nader@example.com", "Nader", "Male", "Issa", "UserPass3", "0599876543" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Gender", "Lname", "Password", "Phone" },
                values: new object[] { new DateTime(1988, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "layla@example.com", "Layla", "Female", "Samir", "UserPass4", "0593332221" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Lname", "Password", "Phone" },
                values: new object[] { new DateTime(1990, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tariq@example.com", "Tariq", "Hassan", "UserPass5", "0591237890" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                columns: new[] { "Email", "Fname", "Lname", "Password" },
                values: new object[] { "ali1@example.com", "Ali", "Saleh", "Password123" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 2,
                columns: new[] { "Email", "Fname", "Lname", "Password", "Role" },
                values: new object[] { "sara@example.com", "Sara", "Khalil", "Password1234", "Admin" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 3,
                columns: new[] { "Email", "Fname", "Lname", "Password", "Role" },
                values: new object[] { "mona@example.com", "Mona", "Naser", "Password1235", "Admin" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 4,
                columns: new[] { "Email", "Fname", "Lname", "Password" },
                values: new object[] { "omar@example.com", "Omar", "Sami", "Password1236" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 5,
                columns: new[] { "Email", "Fname", "Lname", "Password" },
                values: new object[] { "lina@example.com", "Lina", "Ahmad", "Password1237" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Content about depression...", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Depression" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Content about therapy...", new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Importance of Therapy" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Content about anxiety...", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to Cope with Anxiety" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Content about stress...", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overcoming Stress" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                columns: new[] { "Content", "PublishDate", "Title" },
                values: new object[] { "Content about neuroscience...", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neuroscience and Mental Health" });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "I'm feeling very low lately.", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "I feel anxious about upcoming events.", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "Work is really stressful right now.", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 4,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "I can't control my anger at times.", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 5,
                columns: new[] { "Content", "Timestamp" },
                values: new object[] { "I can't sleep at night.", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 100m, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 150m, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 3,
                columns: new[] { "Amount", "Date", "Method" },
                values: new object[] { 120m, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debit Card" });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 4,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 130m, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "PaymentId",
                keyValue: 5,
                columns: new[] { "Amount", "Date", "Method" },
                values: new object[] { 140m, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bank Transfer" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 1,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Struggling with depression", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mental Health" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 2,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Anxiety issues", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mental Health" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 3,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Stress from work", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mental Health" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 4,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Difficulty managing emotions", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emotional Health" });

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "ProblemId",
                keyValue: 5,
                columns: new[] { "Description", "DiagnosisDate", "Type" },
                values: new object[] { "Sleep disorders", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Physical Health" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 1,
                columns: new[] { "Certificates", "Email", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "PhD in Psychology", "ahmed@example.com", "Dr. Ahmed", "Sami", "pswd123", "Clinical" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 2,
                columns: new[] { "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "Masters in Counseling", "noura@example.com", 5, "Dr. Noura", "Almasri", "pswd123", "Counseling" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 3,
                columns: new[] { "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "PhD in Behavioral Science", "samer@example.com", 12, "Dr. Samer", "Hassan", "pswd123", "Behavioral" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 4,
                columns: new[] { "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "Masters in Psychology", "mona@example.com", 8, "Dr. Mona", "Tariq", "pswd123", "Therapist" });

            migrationBuilder.UpdateData(
                table: "Psychologiest",
                keyColumn: "PsychologistId",
                keyValue: 5,
                columns: new[] { "Certificates", "Email", "ExperienceYears", "Fname", "Lname", "Password", "Specialization" },
                values: new object[] { "PhD in Neuroscience", "layla@example.com", 15, "Dr. Layla", "Ibrahim", "pswd123", "Neuroscience" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Great session, helped a lot", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Very informative and useful", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "Comment", "Rating", "ReviewDate" },
                values: new object[] { "Excellent session, highly recommend", 5, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "Comment", "Rating", "ReviewDate" },
                values: new object[] { "The session was okay, but could improve", 3, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Really helped me with my mental health", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 1,
                columns: new[] { "Date", "Description", "Status" },
                values: new object[] { new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Session on Depression", "Completed" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 2,
                columns: new[] { "Date", "Description", "Status", "Time" },
                values: new object[] { new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Session on Anxiety", "Scheduled", "11:00 AM" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 3,
                columns: new[] { "Date", "Description", "Status", "Time" },
                values: new object[] { new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Session on Stress Management", "Completed", "12:00 PM" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 4,
                columns: new[] { "Date", "Description", "Status", "Time" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Therapy Session", "Scheduled", "02:00 PM" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "SessionId",
                keyValue: 5,
                columns: new[] { "Date", "Description", "Status", "Time" },
                values: new object[] { new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mental Health Session", "Completed", "03:00 PM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Password" },
                values: new object[] { new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "yousef@example.com", "Yousef", "pass123" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Lname", "Password", "Phone" },
                values: new object[] { new DateTime(1998, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "laila@example.com", "Laila", "Hassan", "pass123", "0591234568" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Gender", "Lname", "Password", "Phone" },
                values: new object[] { new DateTime(1995, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ola@example.com", "Ola", "Female", "Tariq", "pass123", "0591234569" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Gender", "Lname", "Password", "Phone" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hani@example.com", "Hani", "Male", "Mohsen", "pass123", "0591234570" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "Email", "Fname", "Lname", "Password", "Phone" },
                values: new object[] { new DateTime(1993, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sami@example.com", "Sami", "Ibrahim", "pass123", "0591234571" });
        }
    }
}
