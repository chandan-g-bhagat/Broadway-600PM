﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.CodeFirst.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }

        public int? ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Classes Classes { get; set; }

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User StudentUser { get; set; }
    }

    public class Classes
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Student> Students { get; set; } //

        public virtual ICollection<Teacher> ClassTeacher { get; set; }
    }
}