﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_oneToMany
{
    internal class Adress
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
    }
}
