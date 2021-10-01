using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;


namespace DataLayer.Repositories
{
    public interface ITrainerRepo
    {

        IEnumerable<Trainer> GetTrainer();
        void Add(Trainer trainer,TrainerDetails trainerDetails);
        Trainer Login(Trainer trainer);
        Trainer Display(int id);
        void EditTrainer(Trainer trainer);
        void AddSkill(Skill skill);

        int GetExp(int id);

        string GetQualification(int id);


    }
}
