using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
	public class Student
	{

		private string name;
		private List<int> grades = new List<int>();
		//public List<string> listStudents = new List<string>();
		private string ds;

		public Student()
		{
		}

		public Student(string name, List<int> grades)
		{
			this.name = name;
			this.grades = grades;
		}

		public string Name { get => name; set => name = value; }
		public List<int> Grades { get => grades; set => grades = value; }

		public virtual string GetDisplayText()
		{
			string ds = "";
			ds += Name + "-";
			if (Grades != null)
			{
				foreach (int grade in grades)
				{
					ds += " " + grade.ToString();
				}
			}
			return ds;
			
		}

		



	}
}
