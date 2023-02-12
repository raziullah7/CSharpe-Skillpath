namespace AlternateExpressions
{
    class Program
    {
        // Method to be used as second argument
        public static bool IsLong(string word)
        {
            return word.Length > 8;
        }

        static void Main(string[] args)
        {
            // Array to be used as first argument
            string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };

            // Call Array.Find() and 
            // Pass in the array and method as arguments
            string firstLongAdjective = Array.Find(adjectives, IsLong);

            // or just use the inline notation using aynonmyous method
            string firstLongAdjective2 = Array.Find(adjectives, word => word.Length > 8);

            Console.WriteLine($"The first long word is: {firstLongAdjective}.");
        }
    }
}
