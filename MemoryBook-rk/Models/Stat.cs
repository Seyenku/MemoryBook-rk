using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryBook_rk.Models
{
    /// <summary>
    /// Модель для таблицы stat.
    /// </summary>
    [Table("stat")]
    public class Stat
    {
        // Ключ статистики (до 50 символов)
        [Key]
        [Column("tkey")]
        [StringLength(50)]
        public string TKey { get; set; }

        // Значение статистики
        [Column("value")]
        public int? Value { get; set; }
    }
}
