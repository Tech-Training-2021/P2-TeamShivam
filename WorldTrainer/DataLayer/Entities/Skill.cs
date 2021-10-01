using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    [Table("tb_skills")]
    public class Skill
    {
        public int Id { get; set; }

        [ForeignKey("Trainer")]
        public int Trainer_Id { get; set; }
        public string Skills { get; set; }
        public Trainer Trainer { get; set; }
    }
}
