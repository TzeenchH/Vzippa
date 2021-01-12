using System.Collections.Generic;

namespace Vzp.Models
{
	public class Teacher : IUser
	{
		public int id { get; set; }

		public string firstname { get; set; }
		public string lastname { get; set; }
		public string middlename { get; set; }

		public string linuxUsername { get; set; }

		public IList<int?> subjects { get; set; }
	}
}
