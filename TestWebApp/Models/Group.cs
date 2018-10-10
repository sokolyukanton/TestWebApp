using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestWebApp.Models
{
    public class Group
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}
