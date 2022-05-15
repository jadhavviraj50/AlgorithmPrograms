using AlgorithmPrograms;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Algorithm Programs");
        bool end = true;
        Console.WriteLine("1.BinarySearch\n2.BubbleSort\n3.CheckAnagramOrNot\n4.PrimeNumber\n5.PrimePalindromeAnagram\n6.End the Program");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch binarySearch = new BinarySearch();
                    binarySearch.Binary();
                    break;
                case 2:
                    BubbleSort sort = new BubbleSort();
                    sort.Bubble();
                    break;
                case 3:
                    Anagram anagram = new Anagram();
                    anagram.AnagramOrNot();
                    break;
                case 4:
                    PrimeNumber number = new PrimeNumber();
                    number.PrimeNumberWithinRange();
                    break;
                case 5:
                    PrimePalindrome primePalindrome = new PrimePalindrome();
                    primePalindrome.PrimePalindromNumber();
                    break;
                case 6:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}