namespace Vzp.Models
{
	public class Student : IUser
	{
		public int id { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string middlename { get; set; }
		public int? group { get; set; }
		public string linuxUsername { get; set; }
	}
}
