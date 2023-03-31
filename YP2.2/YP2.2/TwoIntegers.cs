using System;

namespace ConsoleApp3
{
    class TwoIntegers
    {
        public int firstInteger;
        public int secondInteger;
        
        
        public void PrintIntegers()
        {
            Console.WriteLine("Первое число: " + firstInteger);
            Console.WriteLine("Второе число: " + secondInteger);
        }
        
        public void ChangeIntegers(int newFirst, int newSecond)
        {
        
            firstInteger = newFirst;
            secondInteger = newSecond;
        }
        
        public int SumIntegers()
        {
            return firstInteger + secondInteger;
        }
        
        public int MaxInteger()
        {
            if (firstInteger < secondInteger)
            {
                return (secondInteger);
            }
            else
            {
                return (firstInteger);
            }
        }
    }
}