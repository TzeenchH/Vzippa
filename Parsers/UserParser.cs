using System.IO;
using System.Net;
using System.Text.Json;
using System.Collections.Generic;

using Vzp.Models;

namespace Vzp.Parsers
{
	public class UserParser<TUser> where TUser : IUser
	{
		public List<TUser> ParseUserList(string API)
		{
			List<TUser> parsedUsers = new List<TUser>();

			WebRequest getUsers = WebRequest.Create(API);
			Stream usersStream;

			usersStream = getUsers.GetResponse().GetResponseStream();

			StreamReader usersStreamReader = new StreamReader(usersStream);
			string users = usersStreamReader.ReadLine();

			parsedUsers = JsonSerializer.Deserialize<List<TUser>>(users);

			return parsedUsers;
		}
	}
}
