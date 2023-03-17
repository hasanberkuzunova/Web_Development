﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityStudent
    {
        private string name;
        private string surname;
        private int id;
        private string password;
        private string number;
        private string photo;
        private double balance;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Id { get => id; set => id = value; }
        public string Number { get => number; set => number = value; }
        public string Photo { get => photo; set => photo = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Password { get => password; set => password = value; }
    }
}
