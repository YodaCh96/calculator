namespace ConsoleApp1
{
    class Calculator
    {

        int currentState = 0;

        public int Addition(int a, int b)
        {
            this.currentState = a + b;
            return a + b;
        }
        public int Subtraktion(int a, int b)
        {
            return a - b;
        }

        public int Multiplikation(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

    }
}
