using System;
using System.Collections.Generic;

using Vzp.Models;
using Vzp.Parsers;
using Vzp.Writers;

namespace Vzp
{
	class Program
	{
		static void Main(string[] args)
		{
			PlaybookConsructor consructor = new PlaybookConsructor();
			PlaybookWriter writer = new PlaybookWriter();
			TeachersWriter teachersWriter = new TeachersWriter();
			UserParser<Teacher> teacherParser = new UserParser<Teacher>();
			UserParser<Student> studentParser = new UserParser<Student>();
			string studentsAPI = "https://smiap.ru/api/v1/students/";
			string teachersAPI = "https://smiap.ru/api/v1/teachers/";
			
			List<Student> students = studentParser.ParseUserList(studentsAPI);
			List<Teacher> teachers = teacherParser.ParseUserList(teachersAPI);
			
			var yaml = consructor.SerializeToYaml(students);
			
			writer.WritePalybook(students, yaml);
			teachersWriter.WriteTeachersList(teachers);
			Console.Write(yaml);
		}
	}
}
