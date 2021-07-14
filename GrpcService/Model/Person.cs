using System.ComponentModel.DataAnnotations;

namespace testt.Model
{
    public class Person
    {
        public Person()
        { }
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
