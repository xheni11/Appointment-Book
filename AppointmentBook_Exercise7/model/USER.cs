namespace AppointmentBook_Exercise7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        [Required]
        [StringLength(10)]
        public string Username { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }

        public int IdRole { get; set; }
    }
}
