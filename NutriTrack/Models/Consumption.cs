using System;
using System.Collections.Generic;
using SQLite;

namespace NutriTrack.Models
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        [Column("user_id")]
        public int UserId { get; set; }
        [Unique, NotNull]
        [Column("username")]
        public string UserName { get; set; }
        [NotNull]
        [Column("password_hash")]
        public string PasswordHash { get; set; }
        [Unique, NotNull]
        [Column("email")]
        public string Email { get; set; }
        [NotNull]
        [Column("current_weight")]
        public double CurrentWeight { get; set; }
        [NotNull]
        [Column("goal_weight")]
        public double GoalWeight { get; set; }
        [NotNull]
        [Column("height")]
        public double height { get; set; }
        [Column("calorie_intake")]
        public double CalorieIntake { get; set; }

    }

  
    }

