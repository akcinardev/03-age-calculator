using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator.Models
{
	public class Age
	{
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }

        public Age(int years, int months, int days)
        {
            Years = years;
            Months = months;
            Days = days;
        }
    }
}
