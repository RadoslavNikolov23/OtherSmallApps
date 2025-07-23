namespace DEA_Program.Data.Model
{
    using DEA_Program.Common.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class DbPerson
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(120)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        public string PersonalId { get; set; }

        [Required]
        public DateTime DayofBirth { get; set; }

        [Required]
        public CountryCode CountryCode { get; set; }

        [MaxLength(1200)]
        public string AdditionInformation { get; set; }

        public virtual ICollection<DbVehicle> Vehicles { get; set; } = new HashSet<DbVehicle>();

        public virtual ICollection<DbCustomControl> CustomControls { get; set; } = new HashSet<DbCustomControl>();


    }
}
