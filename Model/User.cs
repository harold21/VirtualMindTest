
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string UserName { get; set; }
        [StringLength(8)]
        public string Password { get; set; }
    }
}
