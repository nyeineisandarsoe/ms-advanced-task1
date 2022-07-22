﻿using Microsoft.EntityFrameworkCore;

namespace TaskManager.Model
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }
        public DbSet<Task> Tasks { get; set; } = null!;
    }
}
