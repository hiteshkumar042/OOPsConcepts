using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts.Polymorphism
{
    internal class Addition
    {
        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public float Add(int firstNum, float secondNum, long thirdNum)
        {
            float result = firstNum + secondNum + thirdNum;
            return result;
        }
        public float Add(float firstNum, float secondNum, float thirdNum)
        {
            float result = firstNum + secondNum + thirdNum;
            return result;
        }
    }
}
