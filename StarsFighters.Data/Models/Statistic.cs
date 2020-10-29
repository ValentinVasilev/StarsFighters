using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class Statistic
    {
        public int Id { get; set; }

        public double Damage { get; set; }

        public double HealthPoints { get; set; }

        public double HullDamageReduce { get; set; }

        public double Shield { get; set; }

        public double Speed { get; set; }
    }
}
