using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    [Table("tb_trainerdetails")]
    public class TrainerDetails
    {
        public int Id { get; set; }

        [ForeignKey("Trainer")]
        public int Trainer_Id { get; set; }

        public int Experience { get; set; }

        public string Qualification { get; set; }

        public Trainer Trainer { get; set; }
    }
}
