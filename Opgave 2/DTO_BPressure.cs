using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    public class DTO_BPressure
    {
        public int Systolic_ { get; set; }
        public int Diastolic_ { get; set; }
        public DateTime Date_ { get; set; }

        public DTO_BPressure(int systolic, int diastolic, DateTime date)
        {
            Systolic_ = systolic;
            Diastolic_ = diastolic;
            Date_ = date;
        }
    }
}