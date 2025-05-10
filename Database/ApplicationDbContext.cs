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
