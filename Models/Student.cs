using System.ComponentModel.DataAnnotations;

namespace DotnetDeneme1.Models
{
    public class Student
    {
        [Required(ErrorMessage ="ismini gir")]
        public string name { get; set; }
        [Required(ErrorMessage ="mailini gir")]
        [EmailAddress(ErrorMessage ="düzgün mail yaz ?")]
        public string email { get; set; }
        [Required(ErrorMessage ="gir telefon")]
        public string phone { get; set; }
        [Required(ErrorMessage ="seç ?")]
        public bool? confirm { get; set; }
    }
}