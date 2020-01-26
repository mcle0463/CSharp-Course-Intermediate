﻿using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            CalculateRating();
        }

        protected int CalculateRating()
        {
            return 0;
        }
    }
}