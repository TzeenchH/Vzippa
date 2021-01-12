using System.IO;
using System.Collections.Generic;

using Vzp.Models;

namespace Vzp.Writers
{
	public class PlaybookWriter
	{
		public void WritePalybook(List<Student> students, List<string> records)
		{
			for( int i=0; i<records.Count; i++)
			{
				using (FileStream fs = new FileStream("D:" + @"\" + $"{students[i].lastname}.yaml", FileMode.Create))
				{
					fs.Write(System.Text.Encoding.Default.GetBytes(records[i]));
					fs.Close();
				}
			}
		}
	}
}
