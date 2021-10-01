using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldTrainer.Models
{
    public class Mapper
    {
        public static DataLayer.Entities.Trainer Map(Models.TrainerModel trainer)
        {
            return new DataLayer.Entities.Trainer()
            {
                Id = trainer.id,
                Name = trainer.name,
                Username = trainer.username,
                Password = trainer.password,
                Age = trainer.age,
                Contact = trainer.contact,
                Email = trainer.email,
                Gender = trainer.gender,
            };
        }

        public static Models.TrainerModel Map(DataLayer.Entities.Trainer trainer)
        {
            return new Models.TrainerModel()
            {
                id = trainer.Id,
                name = trainer.Name,
                username = trainer.Username,
                password = trainer.Password,
                age = trainer.Age,
                contact = trainer.Contact,
                email = trainer.Email,
                gender = trainer.Gender,
                skill= (Map(trainer.Skill).ToList() == null) ? null : Map(trainer.Skill).ToList()
            };
        }


        public static DataLayer.Entities.TrainerDetails MapDetails(Models.TrainerModel trainer)
        {
            return new DataLayer.Entities.TrainerDetails()
            {
                Experience = trainer.experience,
                Qualification = trainer.qualification
            };
        }


        public static DataLayer.Entities.Trainer MapLogin(TrainerModel trainer)
        {
            return new DataLayer.Entities.Trainer()
            {
                Username = trainer.username,
                Password = trainer.password
            };
        }
        public static DataLayer.Entities.Skill MapSkill(Models.SkillModel skill, int id)
        {
            return new DataLayer.Entities.Skill()
            {

                Skills = skill.skill,
                Trainer_Id = id
            };

        }
        public static Models.SkillModel MapSkill(DataLayer.Entities.Skill skill)
        {
            return new Models.SkillModel()
            {
                id = skill.Id,
                skill = skill.Skills,
                trainerid = skill.Trainer.Id
            };

        }
        public static IEnumerable<Models.SkillModel> Map(IEnumerable<DataLayer.Entities.Skill> skill) => skill.Select(MapSkill);
        public static IEnumerable<Models.TrainerModel> Map(IEnumerable<DataLayer.Entities.Trainer> trainer) => trainer.Select(Map);
    }
}
