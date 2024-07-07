using System;
namespace MVC.Models
{
	public class Person
	{
		public string? Name { get; set; }
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public DateTime? Dob { get; set; }

	}
    public enum Gender
    {
        Male, Female, Other
    }

}


