﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    [Table("tb_trainer")]
    public class Trainer
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Contact { get; set; }

        public ICollection<Skill> Skill { get; set; }
    }
}
