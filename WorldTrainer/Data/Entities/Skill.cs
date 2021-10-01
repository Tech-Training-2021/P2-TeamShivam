namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Skill
    {
        public int Id { get; set; }

        public int? Trainer_Id { get; set; }

        [StringLength(50)]
        public string Skills { get; set; }

        public virtual Trainer Trainer { get; set; }
    }
}
