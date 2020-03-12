using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BSugar
    {
        public double BloodSugar_ { get; set; }
        public DateTime Date_ { get; set; }

        public DTO_BSugar(double bloodSugar, DateTime date)
        {
            BloodSugar_ = bloodSugar;
            Date_ = date;
        }
    }
}