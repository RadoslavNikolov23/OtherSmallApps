namespace DEA_Program.Data.Model
{
    using DEA_Program.Common.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DbVehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [MaxLength(10)]
        public string RegistrationNumber { get; set; }

        [Required]
        [MaxLength(5)]
        public CountryCode CountryCode { get; set; }

        [MaxLength(1200)]
        public string AdditionalInformationAboutTheVehicle { get; set; }

        [Required]
        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }

        public virtual DbPerson Person { get; set; }

        public virtual ICollection<DbCustomControl> CustomControls { get; set; } = new HashSet<DbCustomControl>();


    }
}
