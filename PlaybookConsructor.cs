using YamlDotNet.Serialization;
using System.Collections.Generic;
using YamlDotNet.Serialization.NamingConventions;

using Vzp.Models;
namespace Vzp
{
	public class PlaybookConsructor
	{
		public List<string> SerializeToYaml(List<Student> users)
		{
			List<string> temp = new List<string>();
			foreach (IUser user in users)
			{
				var serializer = new SerializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
				temp.Add(serializer.Serialize(user));
			}

			return temp;
		}
	}
}
