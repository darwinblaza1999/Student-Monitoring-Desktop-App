using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class StudentModel : StudentPartial
    {
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string conNo { get; set; }
        public string gender { get; set; }
        public int type { get; set; }

    }
    public class StudentPartial
    {
        public int gradelevel { get; set; }
    }
    public class PartialModel : StudentModel
    {
        public string studentId { get; set; }
        public int status { get; set; }
    }
    public class ScoreModel
    {
        public int StudentName { get; set; }
        public int Subject { get; set; }
        public int Section { get; set; }
        public int Component { get; set; }
        public int Grading { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public int PerfectScore { get; set; }
    }

}
