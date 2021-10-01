using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldTrainer.Models;
using Data.Entities;

namespace WorldTrainer.Models
{
    public class Mapper
    {
        public static TrainerModel Map(Trainer trainer)
        {
            return new TrainerModel()
            {
                Username = trainer.Username,
                Password = trainer.Password
            };
        }
    }
}
