﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorUsingWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MathService.svc or MathService.svc.cs at the Solution Explorer and start debugging.
    public class MathService : IMathService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
