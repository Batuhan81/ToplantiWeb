using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
	public class UserInfo
	{
		public int Id { get; set; }


		[Required(ErrorMessage ="Ad Alanı Zorunludur")]
		public string? Name { get; set; }


        [Required(ErrorMessage = "Telefon Alanı Zorunludur")]
        public string? Phone { get; set; }


        [Required(ErrorMessage = "Email Alanı Zorunludur")]
        [EmailAddress(ErrorMessage = "Lütfen Gerçerli Bir Mail Girin ")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Lütfen Katılım Durumu Belirtiniz")]
        public bool? WhillAttend { get; set; }
	}
}
