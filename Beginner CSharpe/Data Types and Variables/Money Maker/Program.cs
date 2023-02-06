namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // A bronze coin is worth 1 cent
            // A silver coin is worth 5 cents
            // A gold coin is worth 10 cents

            // welcome
            Console.WriteLine("Welcome to Money Maker!");

            // getting user input
            Console.Write("Enter Number of Cents : ");
            string input = Console.ReadLine();
            double inputNum = Math.Floor(Convert.ToDouble(input));

            // leading on the user
            Console.WriteLine($"{inputNum} Cents Equals...");

            // variable definitions
            int gold = 10;
            int silver = 5;

            // getting max gold coins
            int goldCoins = Convert.ToInt32(Math.Floor(inputNum / gold));

            // getting remainder amount
            double remaining = inputNum % gold;

            // getting max gold coins
            int silverCoins = Convert.ToInt32(Math.Floor(remaining / silver));

            // getting remainder amount
            double bronzeCoins = inputNum % silver;

            // printing output
            Console.WriteLine($"Gold Coins : {goldCoins}");
            Console.WriteLine($"Silver Coins : {silverCoins}");
            Console.WriteLine($"Bronze Coins : {bronzeCoins}");
        }
    }
}