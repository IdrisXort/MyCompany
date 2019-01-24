using MyCompany2.RelationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany2.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastActivation { get; set; }
        public ICollection<UserAndProject> Projects { get; set; }
        public ICollection<SkillAndUser> Skills { get; set; }
        public ICollection<Car> Cars { get; set; }

    }
}
