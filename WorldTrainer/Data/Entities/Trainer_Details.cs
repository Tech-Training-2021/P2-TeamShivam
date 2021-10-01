namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trainer_Details
    {
        public int Id { get; set; }

        public int? Trainer_Id { get; set; }

        public int? Experience { get; set; }

        [StringLength(50)]
        public string Qualification { get; set; }

        public virtual Trainer Trainer { get; set; }
    }
}
