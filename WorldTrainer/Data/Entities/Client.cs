namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Contact { get; set; }
    }
}
