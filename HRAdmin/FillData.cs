using AdminApi;
using HRAdministrationAPI;
using System.Collections.Generic;

namespace HRAdmin
{
	public class FillData
	{
		private readonly static decimal _minimumWage = 500 * 14.5m;
		private static readonly List<IEmployee> _employees = new();

		public static List<IEmployee> SeedData()
		{
			IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob", "Fisher", _minimumWage);
			_employees.Add(teacher1);

			IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Jenny", "Thomas", _minimumWage);
			_employees.Add(teacher2);

			IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Brenda", "Mullins", _minimumWage);
			_employees.Add(headOfDepartment);

			IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Devlin", "Brown", _minimumWage);
			_employees.Add(deputyHeadMaster);

			IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Damien", "Jones", _minimumWage);
			_employees.Add(headMaster);

			return _employees;
		}
	}
}
