using AdminApi;

namespace HRAdministrationAPI
{
	public interface IEmployee
	{
		EmployeeType Type { get; set; }
		int Id { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		decimal Salary { get; set; }
		string FullName{ get; }
	}
}
