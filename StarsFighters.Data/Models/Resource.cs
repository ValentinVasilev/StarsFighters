using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class Resource
    {
        public int Id { get; set; }

        public decimal? Minerals { get; set; }

        public decimal? Metal { get; set; }

        public decimal? Gas { get; set; }

        public decimal? Gold { get; set; }

        public decimal? StarsCredits { get; set; }

    }
}
