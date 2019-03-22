namespace Classes.Library
{
    public class FizzBuzzService
    {
        public string Print(int n)
        {
            if (IsDivisibleByThree(n) && IsDivisibleByFive(n)) {
                return "FizzBuzz";
            } else if (IsDivisibleByFive(n)) {
               return "Buzz"; 
            } else if (IsDivisibleByThree(n)) {
               return "Fizz"; 
            } else {
                return n.ToString();
            }
        }

        private bool IsDivisibleByThree(int n)
        {
            return n % 3 == 0;
        }

        private bool IsDivisibleByFive(int n)
        {
            return n % 5 == 0;
        }
    }
}