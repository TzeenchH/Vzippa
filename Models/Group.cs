using System.Collections.Generic;

namespace Vzp.Models
{
	public class Group
	{
		public int id { get; set; }
		public string name { get; set; }
		public IList<string> subjects { get; set; }
		public IList<string> students { get; set; }
	}
}
