namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trainer")]
    public partial class Trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            Skills = new HashSet<Skill>();
            Trainer_Details = new HashSet<Trainer_Details>();
        }

        public int Id { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        public int? Age { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(20)]
        public string Contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Skill> Skills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trainer_Details> Trainer_Details { get; set; }
    }
}
