using HRAdministrationAPI;

namespace AdminApi.Models
{

	public class HeadOfDepartment : EmployeeBase
	{
		public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
	}
}
