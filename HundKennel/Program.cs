using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(String[] args)
    {

        List<Dogs> listOfDogs = new List<Dogs>();

        Console.WriteLine("Welcome to my dog kennel!");
        bool start = true;
        while (start == true)
        {
            Console.WriteLine("What would yo like to do?");
            Console.WriteLine("1 - add dog");
            Console.WriteLine("2 - race dogs (not avalible if no dogs have been inputed");
            string input = GetUserInput();
           //double inputInt = GetUserInputInt();
            if (input == "1")
            {
                Console.WriteLine("How many dogs do you have?");
                int howManyDogs = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < howManyDogs; i++)
                {
                    Dogs myDog = AddDog();
                    listOfDogs.Add(myDog);

                }
                for (int i = 0; i < howManyDogs; i++)
                {
                    listOfDogs[i].PrintInfo();
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("how long is the track?");
                int trackLenght = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("This is the winner!!");
                raceResults(listOfDogs[0], listOfDogs[1], trackLenght).PrintInfo();

               
            }
        }

        
    }

    static string GetUserInput()
    {
        string input = "";
        bool wrongInput = true;

        while (wrongInput == true)
        {
            try
            {
                input = Console.ReadLine();
                Match match = Regex.Match(input, "^[a-zA-Z\\s]+$");
                if (match.Success)
                {
                    
                    wrongInput = false;
                }
                else
                {
                    throw new Exception();
                    // lägg till exception
                }
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return input;
    }
    static double GetUserInputInt()
    {
        bool wrongInput = true;
        double inputInt = 0;
        while (wrongInput == true)
        {
            
            try
            {
                inputInt = Convert.ToDouble(Console.ReadLine());
                if (inputInt > 0 && inputInt < 100)
                {

                    wrongInput = false;
                }
                else if (inputInt < 0 || inputInt > 100)
                {
                    Console.WriteLine("Your input was either too big or too small");
                }



            }
            catch (Exception e)
            {
                Console.WriteLine("int" + e.Message);
            }

        }
        return inputInt;
    }

    static Dogs AddDog()
    {
        Console.WriteLine("what is the dog's name?");
        string name = GetUserInput();

        Console.WriteLine("How old is your dog? ( in human years)");
        double age = GetUserInputInt();

        Console.WriteLine("What is the height of the dog? ( in cm)");
        double height = GetUserInputInt();

        Console.WriteLine("How much does your dog weigh? (in kg)");
        double weight = GetUserInputInt(); ;

        Console.WriteLine("How fast is yor dog? (top speed m/s");
        double speed = GetUserInputInt();

        Console.WriteLine("How fast does you dog reach top speed? (in secounds) ");
        double acceleration = GetUserInputInt();


        Dogs retval = new Dogs(age, height, weight, name, speed, acceleration);

        return retval;
    }


    static Dogs raceResults(Dogs dog1, Dogs dog2, int trackLenght)
    {
       

        if (dog1.calculateLapTime(trackLenght ) < dog2.calculateLapTime(trackLenght ))
        {

            return dog1;
        }
        else
        {
            return dog2;
        }

    }
    /*
    static Dogs raceAllDogs(List<Dogs> AllDogs)
    {
        Dogs winningDog = AllDogs[0];
        for (int i = 1; i < AllDogs.Count; i++)
        {
            if (AllDogs[i] < winningDog)
            {
                winningDog
            }
        }
    }
    */
}
    
    