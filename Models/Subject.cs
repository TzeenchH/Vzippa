using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Vzp.Models
{
	public class Subject
	{
		[NotNull]
		public int Id { get; set; }

		[NotNull]
		public string name { get; set; }

		public IList<int?> group { get; set; }

		public IList<int> teachers { get; set; }

	}
}
