﻿namespace Aula72_Modificador_De_Parametros_Params
{
    public class Calculator
    {
        /*
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2;
        }

        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2;
        }*/

        //----------------------------------------------------------
        /*
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }*/

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;


        }
    }
}
