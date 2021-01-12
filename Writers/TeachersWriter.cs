using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Vzp.Models;

namespace Vzp.Writers
{
	public class TeachersWriter
	{
		public void WriteTeachersList(List<Teacher> teachers)
		{
			string path = @"D:\TeachersList.txt";
			using (FileStream fs = new FileStream(path, FileMode.Create))
			{
				foreach (var teacher in teachers)
				{
					var temp = JsonSerializer.Serialize<Teacher>(teacher);
					AddText (fs, temp + "\r\n");
				}
				fs.Close();
			}
		}
		private static void AddText(FileStream fs, string value)
		{
			byte[] info = System.Text.Encoding.Default.GetBytes(value);
			fs.Write(info, 0, info.Length);
		}
	}
}
