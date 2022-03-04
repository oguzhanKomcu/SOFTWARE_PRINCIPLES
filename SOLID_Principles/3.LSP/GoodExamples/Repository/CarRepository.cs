﻿using SOLID_Principles._3.LSP.GoodExamples.Abstract;
using SOLID_Principles._3.LSP.GoodExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExamples.Repository
{
    public class CarRepository : BaseRepository, ICar
    {
        //A class inherits from only one class. Thanks to interfaces, I can implement multiple inheritance.
        //Here, I wrote the class's private methods in the interface.
        //I also applied it here. Thus, he did not keep methods that did not belong to him in his own repository.

        public string GetFuelType()
        {
            return "Bring cars that use diesel fuel.";
        }

        public override string GetPrice()
        {
            return "Bring the ones over $10000.";
        }
    }
}
