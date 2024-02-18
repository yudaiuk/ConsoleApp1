namespace ConsoleApp1
{
    internal class ABC081A_PlacingMarbles
    {
        public void Execlusion()
        {
            string input = Console.ReadLine();

            int resultCnt = input.Count(x => x == '1');

            Console.WriteLine(resultCnt);
        }
    }
}
