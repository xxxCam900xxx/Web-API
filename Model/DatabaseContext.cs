using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using M223PunchclockDotnet.Model;

namespace M223PunchclockDotnet.Model {

    public class DatabaseContext : DbContext 
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options){

        }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Chat>()
                .ToTable("Chat")
                .HasMany(chat => chat.Messages)
                .WithOne(message => message.Chat)
                .IsRequired(false);

            modelBuilder.Entity<Message>().ToTable("Message");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql("Host=db;Database=postgres;Username=postgres;Password=postgres");
    }
}