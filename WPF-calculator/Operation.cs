﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_calculator
{
    class Operation
    {

        public string AddParenthesis(List<string> computeArray)
        {
            var parenthesis = "";

            return parenthesis;
        }
        public static bool IsOperation(string stringToCheck)
        {
            switch (stringToCheck)
            {
                case "+":
                case "-":
                case "×":
                case "÷":
                    return true;
                default:
                    return false;
            }
        }

        public static int Priority(string operatorString)
        {
            switch (operatorString)
            {
                case "+":
                case "-":
                    return 1;
                case "×":
                case "÷":
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
