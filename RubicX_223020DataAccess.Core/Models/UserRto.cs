using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubicX_223020DataAccess.Core.Models
{
    [Table("User")]
    public class UserRto
    {
        [Key]  public int Id { get; set; }//столбец
        public string Email { get; set; }
        public string Login { get; set; }
        public bool IsBoy { get; set; }
        [Required] public string PhoneNumderPrefix { get; set; }
        [Required] public string PhoneNumder { get; set; }
        [Required, MinLength(7)] public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string AvatarUrl { get; set; }
        public UserRoleRto Role { get; set; }

        [NotMapped]
        public string GetFullName
        {//не колонка
            get => FirstName + " " + LastName + " " + Patronymic;
        }

    }
}
