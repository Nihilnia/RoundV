using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_oneToOne
{
    internal class Information
    {
        [Key]
        public int ID { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int YearOfBirth { get; set; }
        public string Gender { get; set; }
        public Student Student { get; set; }
        public int StudentID { get; set; }
    }
}
