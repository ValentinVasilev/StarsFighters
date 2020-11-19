﻿namespace StarsFighters.Controllers.Models
{
    using StarsFighters.Data.Models;
    public class LoggedInViewModel
    {

        public double Minerals { get; set; }

        public double Metal { get; set; }

        public double Gas { get; set; }

        public double Gold { get; set; }

        public int StarsCredits { get; set; }
    }
}
