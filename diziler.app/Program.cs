namespace diziler.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Dizi/Array
            //int number = 10;
            ////int[] numbers = new int[3];
            ////numbers[0] = 10;
            ////numbers[1] = 20;
            ////numbers[2] = 30;

            //int[] numbers = { 10, 20, 30 };
            ////Console.WriteLine(numbers[0]);
            ////Console.WriteLine(numbers[1]);
            ////Console.WriteLine(numbers[2]);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Array.Sort(numbers); //SIRALAMA
            //Console.WriteLine();
            //for (int i = 0;i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // Console.WriteLine("How many name do you wanna sort");
            //byte count= byte.Parse(Console.ReadLine());
            // string[] names =new string[count];

            // for (int i = 0; i < names.Length; i++) 
            // {
            //     Console.WriteLine($"Enter {i + 1} name");
            //     names[i] = Console.ReadLine();              
            // }
            // Array.Sort(names);
            // for (int i = 0; i < names.Length; i++)
            // {
            //     Console.WriteLine($"{i + 1}- {names[i]}");
            // }

            //how many numbers do you want to sort 3
            //enter starting number =10
            //enter ending number = 20 
            // girilen sayıları sırala

            Console.WriteLine("How many number dou you want to sort");
            byte count = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number");
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number");
            byte end = byte.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                int sayi = rnd.Next(start, end);
                if (!numbers.Contains(sayi))
                {
                    numbers[i] = sayi;
                }
                else
                {
                    i = i - 1;
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        //generated random numbers must be unique

       
        







        }
    }
}