using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2Exam.Models
{
    public class Final
    {
        private int no;
        private string name;
        private string rate;
        private string category;

        public Final(int no, string name, string rate, string description, string category)
        {
            this.no = no;
            this.name = name;
            this.rate = rate;
            Description = description;
            this.category = category;
        }

        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public decimal RateDecimal { get; set; }
        public String Description { get; set; }

        public String CategoryName { get; set; }


    }
}