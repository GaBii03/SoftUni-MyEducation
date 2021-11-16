using System;

namespace _08.GraduationPt._2
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int classes = 0;
			double avaregeGrade = 0;
			int failedClasses = 0;
			while (classes<12)
			{
				double grade = double.Parse(Console.ReadLine());
				
				if (grade<4.00)
				{
					failedClasses++;
				}

				if (failedClasses==2)
				{
					Console.WriteLine($"{name} has been excluded at {classes} grade");
					Environment.Exit(0);
				}
				classes++;
				avaregeGrade += grade;
			}
			Console.WriteLine($"{name} graduated. Average grade: {avaregeGrade / 12 :f2}");
		}
	}
}
