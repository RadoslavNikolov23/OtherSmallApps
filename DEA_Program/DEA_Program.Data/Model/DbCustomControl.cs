
namespace DEA_Program.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DbCustomControl
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DayOfVerification { get; set; }


        [MaxLength(1200)]
        public string AdditionalInformationAboutTheControl { get; set; }

        [ForeignKey(nameof(Person))]
        public int? PersonId { get; set; }

        public virtual DbPerson Person { get; set; }


        [ForeignKey(nameof(Vehicle))]
        public int? VehicleId { get; set; }

        public virtual DbVehicle Vehicle { get; set; }

    }
}
