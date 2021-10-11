using HRAdministrationAPI;

namespace AdminApi.Models
{

	public class HeadMaster : EmployeeBase
	{
		public override decimal Salary { get => base.Salary + (base.Salary * 0.06m); }
	}
}
