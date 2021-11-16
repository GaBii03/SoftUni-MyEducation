using System;

namespace _02.ExamPreparation
{
	class Program
	{
		static void Main(string[] args)
		{
			int notGoodGradesPr = int.Parse(Console.ReadLine());
			string nameEx =Console.ReadLine();
			string lastBookName = "";
			double avarageGrade = 0;
			int notGoodGradesHis = 0;
			int numberProblems = 0;
			bool failed = false;
			while (nameEx!="Enough")
			{
				int grade = int.Parse(Console.ReadLine());
				avarageGrade += grade;
				numberProblems++;

				if (grade<=4)
				{
					notGoodGradesHis++;
				}

				if (notGoodGradesHis>=notGoodGradesPr)
				{
					failed = true;
					break;
				}
				 lastBookName = nameEx;
				nameEx =Console.ReadLine();
				
			}

			if (failed==true)
			{
				Console.WriteLine($"You need a break, {notGoodGradesHis} poor grades.");
			}
			else 
			{
				Console.WriteLine($"Average score: {avarageGrade/numberProblems:f2}");
				Console.WriteLine($"Number of problems: {numberProblems}");
				Console.WriteLine($"Last problem: {lastBookName}");
			}
		}
	}
}
