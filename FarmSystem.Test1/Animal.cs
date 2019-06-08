﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    internal class Animal: IAnimal
    {
        private string _id;
        private int _noOfLegs;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public int NoOfLegs { get; set; } = 4;

        //public int NoOfLegs
        //{
        //    get
        //    {
        //        return _noOfLegs;
        //    }
        //    set
        //    {
        //        _noOfLegs = value;
        //    }
        //}

        public void Run()
        {
        }

        public virtual void Talk()
        {
        }
    }
}