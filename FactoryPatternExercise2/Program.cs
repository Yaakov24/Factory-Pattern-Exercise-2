namespace FactoryPatternExercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What Database would you like to use?");
            var input = Console.ReadLine();
          var type = DataAccessFactory.GetDataAccessType(input);
            type.LoadData();
            type.SaveData();
        }
    }
}
