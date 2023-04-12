using System.ComponentModel.DataAnnotations;

namespace BlogDemooApi.DataLayer
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
