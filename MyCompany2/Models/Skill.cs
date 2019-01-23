using MyCompany2.RelationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany2.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<SkillAndUser> Users { get; set; }
        public ICollection<ProjectsAndSkill> Projects { get; set; }  
    }
}
