using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINand_Max
{
	class studentList
	{
		public void Run()

		{

			MinMaxGrades();

			Console.ReadLine();

		}



		public void MinMaxGrades()

		{

			List<Student> students = new List<Student>();

			string line;

			StreamReader file = new StreamReader(@"C:\Users\agatha\Source\Repos\TextFile1.txt");

			while ((line = file.ReadLine()) != null)

			{

				string[] lines = line.Split(' ');

				string studentName = lines[0];

				List<int> gradesList = new List<int>();

				int minGrade = 0;

				int maxGrade = 0;

				foreach (string grade in lines.Skip(1))

				{

					int grades = int.Parse(grade);

					gradesList.Add(grades);

				}

				minGrade = gradesList.Min();

				maxGrade = gradesList.Max();



				Student newStudent = new Student(studentName, minGrade, maxGrade);

				students.Add(newStudent);

			}



			foreach (Student student in students)

			{

				Console.WriteLine($"{student.Name} has a minimum score of {student.MinGrade}" +

					$" and a maximum score of {student.MaxGrade}");

			}

		}

	}

}
	

