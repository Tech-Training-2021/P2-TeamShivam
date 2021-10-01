using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldTrainer.Models
{
    public class SkillModel
    {
        public int id { get; set; }
        public string skill { get; set; }
        public int trainerid { get; set; }
    }
}
