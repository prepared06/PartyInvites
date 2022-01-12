using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Введите ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Введите ваш эмайл")]
        //[RegularExpression(".+\\@.+\\ .. +", ErrorMessage = "Please enter а valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Введите ваш номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Выберите ответ из предложенных вариантов")]
        public bool? WillAtend { get; set; }
    }
}
