using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WithYou_project.Database.Entities;
using WithYou_project.Models;

namespace WithYou_project.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Admin
            builder.Entity<Admin>()
                .HasKey(a => a.AdminId);

            // User
            builder.Entity<User>()
            .HasKey(u => u.UserId);

            builder.Entity<User>()
            .HasMany(u => u.Message)
            .WithOne(m => m.User)
            .HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.Payments)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.Problems)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Psychologist
            builder.Entity<Psychologist>()
                .HasKey(p => p.PsychologistId);

            builder.Entity<Psychologist>()
                .HasMany(p => p.Sessions)
                .WithOne(s => s.Psychologist)
                .HasForeignKey(s => s.PsychologistId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Psychologist>()
                .HasMany(p => p.Articles)
                .WithOne(a => a.Psychologist)
                .HasForeignKey(a => a.PsychologistId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Psychologist>()
                .HasMany(p => p.Reviews)
                .WithOne(r => r.Psychologist)
                .HasForeignKey(r => r.PsychologistId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Psychologist>()
                .HasMany(p => p.Problems)
                .WithOne(pr => pr.Psychologist)
                .HasForeignKey(pr => pr.PsychologistId)
                .OnDelete(DeleteBehavior.Cascade);

            // Article
            builder.Entity<Article>()
                .HasKey(a => a.ArticleId);

            // Session
            builder.Entity<Session>()
             .HasOne(s => s.User)
             .WithMany(u => u.Sessions)
             .HasForeignKey(s => s.UserId)
             .OnDelete(DeleteBehavior.Restrict); 


            // Payment
            builder.Entity<Payment>()
                .HasKey(p => p.PaymentId);

            builder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Payments)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Payment>()
                .HasOne(p => p.Session)
                .WithMany()
                .HasForeignKey(p => p.SessionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Review
            builder.Entity<Review>()
                .HasKey(r => r.ReviewId);

            // Problem
            builder.Entity<Problem>()
                .HasKey(p => p.ProblemId);
            //Message
           builder.Entity<Message>()
             .HasOne(m => m.User)
             .WithMany(u => u.Message)
             .HasForeignKey(m => m.UserId)
             .OnDelete(DeleteBehavior.Restrict); // منع الحذف التلقائي لتجنب التضارب

           builder.Entity<Message>()
                .HasOne(m => m.Problem)
                .WithMany()
                .HasForeignKey(m => m.ProblemId)
                .OnDelete(DeleteBehavior.Cascade);
          builder.Entity<Message>()
                .HasOne(m => m.Psychologist)
                .WithMany(p => p.Messages)
                .HasForeignKey(m => m.PsychologistId)
                .OnDelete(DeleteBehavior.Restrict); // يمكن استخدام Cascade إذا رغبت

            // -------------------- Admin --------------------
            builder.Entity<Admin>().HasData(
                new Admin { AdminId = 1, Fname = "Sara", Lname = "Khalil", Email = "sara@admin.com", Password = "AdminPass1", Role = "SuperAdmin" },
                new Admin { AdminId = 2, Fname = "Omar", Lname = "Nasser", Email = "omar@admin.com", Password = "AdminPass2", Role = "Moderator" },
                new Admin { AdminId = 3, Fname = "Lina", Lname = "Mansour", Email = "lina@admin.com", Password = "AdminPass3", Role = "Editor" },
                new Admin { AdminId = 4, Fname = "Fadi", Lname = "Qassem", Email = "fadi@admin.com", Password = "AdminPass4", Role = "Admin" },
                new Admin { AdminId = 5, Fname = "Dina", Lname = "Salem", Email = "dina@admin.com", Password = "AdminPass5", Role = "Admin" }
            );

            // -------------------- User --------------------
            builder.Entity<User>().HasData(
                new User { UserId = 1, Fname = "Ahmad", Lname = "Ali", Email = "ahmad@example.com", Password = "UserPass1", Phone = "0591234567", Gender = "Male", DateOfBirth = new DateTime(1995, 4, 15) },
                new User { UserId = 2, Fname = "Mona", Lname = "Yousef", Email = "mona@example.com", Password = "UserPass2", Phone = "0597654321", Gender = "Female", DateOfBirth = new DateTime(1992, 8, 23) },
                new User { UserId = 3, Fname = "Nader", Lname = "Issa", Email = "nader@example.com", Password = "UserPass3", Phone = "0599876543", Gender = "Male", DateOfBirth = new DateTime(2000, 1, 1) },
                new User { UserId = 4, Fname = "Layla", Lname = "Samir", Email = "layla@example.com", Password = "UserPass4", Phone = "0593332221", Gender = "Female", DateOfBirth = new DateTime(1988, 11, 30) },
                new User { UserId = 5, Fname = "Tariq", Lname = "Hassan", Email = "tariq@example.com", Password = "UserPass5", Phone = "0591237890", Gender = "Male", DateOfBirth = new DateTime(1990, 6, 5) }
            );

            // -------------------- Psychologist --------------------
            builder.Entity<Psychologist>().HasData(
                new Psychologist { PsychologistId = 1, Fname = "Rami", Lname = "Awad", Email = "rami@psych.com", Password = "PsyPass1", Certificates = "PhD Psychology", Specialization = "Anxiety", ExperienceYears = 10 },
                new Psychologist { PsychologistId = 2, Fname = "Nour", Lname = "Hamed", Email = "nour@psych.com", Password = "PsyPass2", Certificates = "MA Clinical Psychology", Specialization = "Depression", ExperienceYears = 8 },
                new Psychologist { PsychologistId = 3, Fname = "Sami", Lname = "Badran", Email = "sami@psych.com", Password = "PsyPass3", Certificates = "MSc Behavioral Psychology", Specialization = "Stress", ExperienceYears = 6 },
                new Psychologist { PsychologistId = 4, Fname = "Huda", Lname = "Zein", Email = "huda@psych.com", Password = "PsyPass4", Certificates = "PhD Psychology", Specialization = "Trauma", ExperienceYears = 12 },
                new Psychologist { PsychologistId = 5, Fname = "Ibrahim", Lname = "Saleh", Email = "ibrahim@psych.com", Password = "PsyPass5", Certificates = "MSc Clinical Psychology", Specialization = "Grief", ExperienceYears = 9 }
            );

            // -------------------- Article --------------------
            builder.Entity<Article>().HasData(
                new Article { ArticleId = 1, PsychologistId = 1, Title = "Managing Anxiety in Daily Life", Content = "Tips and exercises to manage anxiety.", PublishDate = new DateTime(2024, 5, 1) },
                new Article { ArticleId = 2, PsychologistId = 2, Title = "Understanding Depression", Content = "Symptoms and coping strategies for depression.", PublishDate = new DateTime(2024, 4, 15) },
                new Article { ArticleId = 3, PsychologistId = 3, Title = "Stress Management at Work", Content = "Workplace stress and how to manage it.", PublishDate = new DateTime(2024, 3, 10) },
                new Article { ArticleId = 4, PsychologistId = 4, Title = "Healing from Trauma", Content = "Steps towards recovery after traumatic experiences.", PublishDate = new DateTime(2024, 2, 5) },
                new Article { ArticleId = 5, PsychologistId = 5, Title = "Coping with Grief", Content = "Understanding and processing grief.", PublishDate = new DateTime(2024, 1, 20) }
            );

            // -------------------- Session --------------------
            builder.Entity<Session>().HasData(
                new Session { SessionId = 1, PsychologistId = 1, UserId = 1, Description = "Anxiety session", Status = "Available", Date = new DateTime(2024, 6, 1), Time = "10:00 AM", },
                new Session { SessionId = 2, PsychologistId = 2, UserId = 2, Description = "Depression support", Status = "Booked", Date = new DateTime(2024, 6, 2), Time = "2:00 PM",  },
                new Session { SessionId = 3, PsychologistId = 3, UserId = 3, Description = "Stress handling", Status = "Available", Date = new DateTime(2024, 6, 3), Time = "4:00 PM",  },
                new Session { SessionId = 4, PsychologistId = 4, UserId = 4, Description = "Trauma discussion", Status = "Completed", Date = new DateTime(2024, 6, 4), Time = "11:00 AM", },
                new Session { SessionId = 5, PsychologistId = 5, UserId = 5, Description = "Grief counseling", Status = "Available", Date = new DateTime(2024, 6, 5), Time = "3:00 PM",  }
            );

            // -------------------- Payment --------------------
            builder.Entity<Payment>().HasData(
                new Payment { PaymentId = 1, UserId = 1, SessionId = 1, Amount = 50, Date = new DateTime(2024, 5, 1), Status = "Paid", Method = "Credit Card" },
                new Payment { PaymentId = 2, UserId = 2, SessionId = 2, Amount = 40, Date = new DateTime(2024, 5, 2), Status = "Pending", Method = "PayPal" },
                new Payment { PaymentId = 3, UserId = 3, SessionId = 3, Amount = 45, Date = new DateTime(2024, 5, 3), Status = "Paid", Method = "Bank Transfer" },
                new Payment { PaymentId = 4, UserId = 4, SessionId = 4, Amount = 55, Date = new DateTime(2024, 5, 4), Status = "Paid", Method = "Cash" },
                new Payment { PaymentId = 5, UserId = 5, SessionId = 5, Amount = 60, Date = new DateTime(2024, 5, 5), Status = "Pending", Method = "Credit Card" }
            );

            // -------------------- Review --------------------
            builder.Entity<Review>().HasData(
                new Review { ReviewId = 1, UserId = 1, PsychologistId = 1, Comment = "Very helpful session", ReviewDate = new DateTime(2024, 5, 6), Rating = 5 },
                new Review { ReviewId = 2, UserId = 2, PsychologistId = 2, Comment = "Good listener", ReviewDate = new DateTime(2024, 5, 7), Rating = 4 },
                new Review { ReviewId = 3, UserId = 3, PsychologistId = 3, Comment = "Helped with my stress", ReviewDate = new DateTime(2024, 5, 8), Rating = 4 },
                new Review { ReviewId = 4, UserId = 4, PsychologistId = 4, Comment = "Trauma guidance was excellent", ReviewDate = new DateTime(2024, 5, 9), Rating = 5 },
                new Review { ReviewId = 5, UserId = 5, PsychologistId = 5, Comment = "Very understanding", ReviewDate = new DateTime(2024, 5, 10), Rating = 5 }
            );

            // -------------------- Problem --------------------
            builder.Entity<Problem>().HasData(
                new Problem { ProblemId = 1, UserId = 1, PsychologistId = 1, Description = "Severe anxiety issues", Type = "Anxiety", DiagnosisDate = new DateTime(2024, 4, 1) },
                new Problem { ProblemId = 2, UserId = 2, PsychologistId = 2, Description = "Depression symptoms", Type = "Depression", DiagnosisDate = new DateTime(2024, 3, 15) },
                new Problem { ProblemId = 3, UserId = 3, PsychologistId = 3, Description = "Stress at work", Type = "Stress", DiagnosisDate = new DateTime(2024, 2, 10) },
                new Problem { ProblemId = 4, UserId = 4, PsychologistId = 4, Description = "Childhood trauma", Type = "Trauma", DiagnosisDate = new DateTime(2024, 1, 25) },
                new Problem { ProblemId = 5, UserId = 5, PsychologistId = 5, Description = "Grieving loss of parent", Type = "Grief", DiagnosisDate = new DateTime(2024, 1, 5) }
            );

            // -------------------- Message --------------------
            builder.Entity<Message>().HasData(
                new Message { MessageId = 1, UserId = 1, PsychologistId = 1, ProblemId = 1, Content = "Feeling anxious today.", Timestamp = new DateTime(2024, 5, 1, 10, 0, 0) },
                new Message { MessageId = 2, UserId = 2, PsychologistId = 2, ProblemId = 2, Content = "I need help dealing with sadness.", Timestamp = new DateTime(2024, 5, 2, 11, 0, 0) },
                new Message { MessageId = 3, UserId = 3, PsychologistId = 3, ProblemId = 3, Content = "Can't sleep due to stress.", Timestamp = new DateTime(2024, 5, 3, 9, 30, 0) },
                new Message { MessageId = 4, UserId = 4, PsychologistId = 4, ProblemId = 4, Content = "Old memories resurfacing.", Timestamp = new DateTime(2024, 5, 4, 8, 45, 0) },
                new Message { MessageId = 5, UserId = 5, PsychologistId = 5, ProblemId = 5, Content = "Feeling very alone.", Timestamp = new DateTime(2024, 5, 5, 7, 15, 0) }
            );



        }

        public  DbSet<Admin> Admins { get; set; }
        public  DbSet<Article> Articles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Problem> Problem { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Psychologist> Psychologiest { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Message> Message { get; set; }
        
        
      

    }
}
