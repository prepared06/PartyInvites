using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Введите ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Введите ваш эмайл")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Введите ваш номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Выберите ответ из предложенных вариантов")]
        public bool? WillAtend { get; set; }
    }
}
