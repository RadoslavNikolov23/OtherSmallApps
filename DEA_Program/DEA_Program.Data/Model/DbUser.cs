namespace DEA_Program.Data.Model
{
    using DEA_Program.Common.Enums;
    using System.ComponentModel.DataAnnotations;

    public class DbUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        public Role Role { get; set; }

    }
}
