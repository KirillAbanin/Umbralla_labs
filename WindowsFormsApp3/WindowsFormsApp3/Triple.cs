using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Triple
    {
        private int[] _numbers;
        public Triple(string numbers)
        {
            _numbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != '0' && numbers[i] != '1' && numbers[i] != '2')
                    throw new ArgumentException("Unaccepted symbol");

                _numbers[i] = Convert.ToInt32(new string(numbers[i], 1));
            }
        }
        public Triple(int[] numbers)
        {
            _numbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != '0' && numbers[i] != '1' && numbers[i] != '2')
                    throw new ArgumentException("Unaccepted symbol");

                _numbers[i] = numbers[i];
            }
        }

        static public string Sum(Triple num1, Triple num2)
        {
            int[] tempNum1 = num1._numbers;
            int[] tempNum2 = num2._numbers;

            int[] tempMas;

            int diff = 0;
            int oldLength = 0;

            if (tempNum1.Length == tempNum2.Length)
            {
                tempMas = new int[tempNum1.Length];
            }
            else if (tempNum1.Length > tempNum2.Length)
            {
                tempMas = new int[tempNum1.Length];

                diff = tempNum1.Length - tempNum2.Length;
                oldLength = tempNum2.Length;

                Array.Resize(ref tempNum2, tempNum1.Length);

                for (int i = oldLength - 1; i >= 0 ; i--)
                {
                    tempNum2[i + diff] = tempNum2[i];
                    tempNum2[i] = 0;
                }
            }
            else
            {
                tempMas = new int[tempNum2.Length];

                diff = tempNum2.Length - tempNum1.Length;
                oldLength = tempNum1.Length;

                Array.Resize(ref tempNum1, tempNum2.Length);

                for (int i = oldLength - 1; i >= 0; i--)
                {
                    tempNum1[i + diff] = tempNum1[i];
                    tempNum1[i] = 0;
                }
            }

            for (int i = tempMas.Length - 1; i >= 0; i--)
            {
                tempMas[i] += tempNum1[i] + tempNum2[i];

                if (i == 0 && tempMas[i] >= 3)
                {
                    oldLength = tempMas.Length;

                    Array.Resize(ref tempMas, tempMas.Length + 1);

                    for (int j = oldLength - 1; j >= 0; j--)
                    {
                        tempMas[j + 1] = tempMas[j];
                        tempMas[j] = 0;
                    }

                    oldLength = tempNum1.Length;

                    Array.Resize(ref tempNum1, tempNum1.Length + 1);

                    for (int j = oldLength - 1; j >= 0; j--)
                    {
                        tempNum1[j + 1] = tempNum1[j];
                        tempNum1[j] = 0;
                    }

                    oldLength = tempNum2.Length;

                    Array.Resize(ref tempNum2, tempNum2.Length + 1);

                    for (int j = oldLength - 1; j >= 0; j--)
                    {
                        tempNum2[j + 1] = tempNum2[j];
                        tempNum2[j] = 0;
                    }

                    i++;
                }

                if (tempMas[i] == 3)
                {
                    tempMas[i] = 0;
                    tempMas[i - 1] += 1;
                }
                else if (tempMas[i] == 4)
                {
                    tempMas[i] = 1;
                    tempMas[i - 1] += 1;
                }
                else if (tempMas[i] == 5)
                {
                    tempMas[i] = 2;
                    tempMas[i - 1] += 1;
                }
                
            }

            string temp = "";

            for (int i = 0; i < tempMas.Length; i++)
            {
                temp += tempMas[i];
            }

            return temp;
        }
    }
}