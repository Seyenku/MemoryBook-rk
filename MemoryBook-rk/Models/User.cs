using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryBook_rk.Models
{
    /// <summary>
    /// Модель для таблицы users.
    /// </summary>
    [Table("users")]
    public class User
    {
        // Первичный ключ
        [Key]
        [Column("id")]
        public int Id { get; set; }

        // Логин пользователя (до 50 символов)
        [Column("login")]
        [StringLength(50)]
        public string Login { get; set; }

        // Пароль пользователя (до 50 символов)
        [Column("pass")]
        [StringLength(50)]
        public string Password { get; set; }

        // Роль пользователя
        [Column("role")]
        public int Role { get; set; }
    }
}
