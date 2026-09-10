namespace progarm.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int alder = 20;
            //if (alder >= 18)
            //{
            //    Console.WriteLine("myndig");
            //}
            //else
            //{
            //    Console.WriteLine("inte myndig");
            //}

            //int poeng = 40;
            //if (poeng >= 90)
            //{
            //    Console.WriteLine("godkänt med beröm");
            //}
            //else if (poeng >= 50)
            //{
            //    Console.WriteLine("godkänt");
            //}
            //else
            //{
            //    Console.WriteLine("underkänt");
            //}

            //int alder = 11;
            //int langd = 140;

            //if (alder >= 12 && langd >= 140)
            //{
            //    Console.WriteLine("får åka");
            //}
            //else
            //{
            //    Console.WriteLine("får inte åka");
            //}

            //string ljus = "blå";

            //switch (ljus)
            //{
            //    case "röd":
            //        Console.WriteLine("stanna");
            //        break;


            //    case "gul":
            //        Console.WriteLine("sakta ner");
            //        break;

            //    case "grön":
            //        Console.WriteLine("kör");
            //        break;

            //    default: 
            //        Console.WriteLine("okänd färg");
            //        break;
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i + "tre");
            //    }
            //    else if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + "jämnt");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + "udda");
            //    }
            //}

            //int countDown = 5;
            //while(countDown > 0)
            //{
            //    Console.WriteLine("count down : " + countDown);

            //    countDown--;

            //}
            //int attempt = 1;
            //do
            //{
            //    Console.WriteLine("attempt number : " + attempt);
            //    attempt++; 

            //} while (attempt <= 3);

            //for (int number = 1; number <= 5; number++)
            //{
            //    Console.WriteLine("number is " + number);
            //}

            //string[] Fruits = { "apple", "banan", "oranges" };
            //int[] Numbers = { 20, 30, 40 };

            //foreach (string Number in Fruits) 
            //{
            //    Console.WriteLine("number = " + Numbers);
            //}

            //for (int i = 1; i <= 10; i++)    
            //    if (i % 10 == 0)

            //int valueInt = 50;
            //Double valueDouble = valueInt;

            //Console.WriteLine(valueDouble GetType());


            //Decimal Fnumber =57893453 20f;

            //int InNumber = (int)Fnumber;
            //int InNumber2 = (int)Fnumber;
            
            int Result = 0;
            string stringValue = "123ABC";
            int ConResult = int.Parse(stringValue); 
            Console.WriteLine(ConResult.GetType());

            bool InConverted = int.TryParse(stringValue,out Result);

            if (InConverted)
            {
                Console.WriteLine("result is = {0}",Result);
            }
            else
            {

            }


            Console.Readkey();


            //Console.WriteLine("det var alt");
            //Console.ReadKey();
        }
    }
}

   
        





