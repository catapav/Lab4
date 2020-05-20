using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace App1.Model
{
    public class User
    {
        public User(String name, int workshopNumber, int rank)
        {
            this.name = name;
            this.workshopNumber = workshopNumber;
            this.rank = rank;
        }
        public String name { get; set; }
        public int workshopNumber { get; set; }
        public int rank { get; set; }
    }
}