using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINand_Max
{
	class Student
	{
		public string Name { get; set; }

		public int MinGrade { get; set; }

		public int MaxGrade { get; set; }

		public Student(string name, int minGrade, int maxGrade)

		{
			Name = name;

			MinGrade = minGrade;

			MaxGrade = maxGrade;
		}
	}
}
		

