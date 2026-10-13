using System.ComponentModel.DataAnnotations;

namespace wt_lab4_4mvc_liger.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите ФИО")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "ФИО от 3 до 100 символов")]
        [Display(Name = "ФИО")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите специальность")]
        [StringLength(50)]
        [Display(Name = "Специальность")]
        public string Faculty { get; set; } = string.Empty;

        [Range(1, 4, ErrorMessage = "Курс от 1 до 4")]
        [Display(Name = "Курс")]
        public int Course { get; set; }

        [Range(0.0, 10.0, ErrorMessage = "Средний балл от 0 до 10")]
        [Display(Name = "Средний балл")]
        public double AverageGrade { get; set; }

        [Display(Name = "Зачислен")]
        public bool IsEnrolled { get; set; }
    }
}
