using System.ComponentModel.DataAnnotations;

namespace GraphFlix_FrontEnd.Models
{
	public class LoginModel
	{
		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Email address is not valid.")]
		public string Username { get; set; } // NOTE: email will be the username, too

		[Required(ErrorMessage = "Password is required.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
	public class RegModel : LoginModel
	{
		[Required(ErrorMessage = "Confirm password is required.")]
		[DataType(DataType.Password)]
		[Compare("password", ErrorMessage = "Password and confirm password do not match.")]
		public string confirmpwd { get; set; }
	}
}
