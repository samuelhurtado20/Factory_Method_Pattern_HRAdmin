using HRAdministrationAPI;

namespace AdminApi.Models
{

	public class DeputyHeadMaster : EmployeeBase
	{
		public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
	}
}