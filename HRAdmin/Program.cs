using HRAdmin;
using HRAdministrationAPI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolHRAdministration
{

	class Program
	{
		static void Main(string[] args)
		{

			List<IEmployee> employees = FillData.SeedData();

			foreach (IEmployee employee in employees)
			{
				Console.WriteLine($"({employee.Type}). Employee: {employee.FullName}. Salary: { employee.Salary }");
			}

			Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(e => e.Salary)}");

			Console.ReadKey();

		}
	}

}
