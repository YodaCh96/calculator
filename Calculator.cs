namespace ConsoleApp1
{
    class Calculator
    {

        private int result = 0;

        #region ONE PARAMETER
        public int Addition(int b)
        {

            return result += b;
        }
        public int Subtraktion(int b)
        {
            return result -= b;
        }
        public int Multiplikation(int b)
        {
            return result *= b;
        }
        public int Division(int b)
        {
            return result /= b;
        }
        #endregion

        #region TWO PARAMETER
        public int Addition(int a, int b)
        {

            return a + b;
        }
        public int Subtraktion(int a, int b)
        {
            return a -b;
        }
        public int Multiplikation(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
        #endregion

        public void Test(char a, int b, params float[] c)
        {

        }

        // Wie oft und wo können Sie bei einer Methode PARAMS verwenden?
        // Nur 1x; am Schluss  der Parameterliste 
        public int Add(params int[] operands)
        {
            int sum = 0;

            foreach (int operand in operands)
            {
                sum += operand;
            }
            result = sum;
            return result;
            
        }

    }
}
