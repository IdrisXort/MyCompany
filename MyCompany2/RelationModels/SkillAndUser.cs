using MyCompany2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany2.RelationModels
{
    public class SkillAndUser
    {
        [Key]
        public int Id { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }    
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
