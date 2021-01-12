using System.Diagnostics.CodeAnalysis;

namespace Vzp.Models
{
	public interface IUser
	{
		[NotNull]
		int id { get; set; }

		[NotNull]
		string firstname { get; set; }

		[NotNull]
		string lastname { get; set; }

		[NotNull]
		string middlename { get; set; }

		[NotNull]
		string linuxUsername { get; set; }
	}
}
