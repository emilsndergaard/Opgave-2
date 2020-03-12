using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Weight
    {
        public double Weight_ { get; set; }
        public int BMI_ { get; set; }
        public DateTime Date_ { get; set; }

        public DTO_Weight(double weight, int BMI, DateTime date)
        {
            Weight_ = weight;
            BMI_ = BMI;
            Date_ = date;
        }
    }
}