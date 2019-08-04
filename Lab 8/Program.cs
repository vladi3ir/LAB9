using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] a = new int[20];

                Console.WriteLine("Welcome to our C# class.  Which student would you like to learn more about? (enter a  number 1-20): ");
                string input = Console.ReadLine();
                int tnum;
                tnum = a[int.Parse(input)];

                RunApp(input);

            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Something went wrong - heres the exception {e.Message}");
            }

            catch (FormatException e2)
            {
                Console.WriteLine($"Something went wrong - heres the exception {e2.Message}");

            }
            finally
            {

            }


        }

        public static string RunApp(string input)
        {


            #region
            //string[,] students = new string[21, 3] {
            //                          {"Name","Hometown","Favorite Food" },
            //                          {"Vlad","Windsor","Pizza"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Frank","Detroit","Thai"},
            //                          {"Fis","China","Fish"},
            //                          {"James","Greece","greek"},
            //                          {"Marko","Bosnia","Thai"},
            //                          {"Tony","Macedonia","Thai"},
            //                          {"Tony","Serbia","Thai"},
            //                          {"Tony","Croatia","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Tony","Detroit","Thai"},
            //                          {"Linda","Chicago","Burger"} };
            #endregion



            int studentID = IndexOutOfRange(input);

            var studentName = DataSet(1, studentID);
            //var hometown = DataSet(2, studentID);
            var favoriteFood = DataSet(3, studentID);
            var favoriteColor = DataSet(4, studentID);
            var favoritenumber = DataSet(5, studentID);
            //array Code   
            //var studentname = students[studentID, 0];
            //var homeTown = students[studentID, 1];
            //var favFood = students[studentID, 2];

            //Array code
            //Console.WriteLine($"Student {studentID + 1} is {studentname}.  What would you like to know about {studentname}? (enter or \"hometown\" or \"favorite food\"");

            Console.WriteLine($"Student {studentID + 1} is {studentName}.  What would you like to know about {studentName}? (enter or \"hometown\" or \"favorite food\" or \"favorite color\" or \"favorite number\")");

            string nothing = "0";
            bool isValidInput = false;

            while (!isValidInput)
            {
                int ID = 0;


                string userInput = (Console.ReadLine());
                //string userInput = askForNumber(Console.ReadLine());



                if (userInput == "hometown")
                {
                    Console.WriteLine($"{studentName} is from {DataSet(2, studentID)}. Would you like to know more [y,n] or enter a number [1-20] to seach another student");
                    string secondInput = knowMoreYesOrNo(Console.ReadLine());
                    if (secondInput == "exit")
                    {

                        break;
                    }

                }
                else if (userInput == "favorite food")
                {
                    Console.WriteLine($"{studentName}'s favorite food is {DataSet(3, studentID)} Would you like to know more about this student [y,n] or enter a number [1-20] to seach another student");
                    string secondInput = knowMoreYesOrNo(Console.ReadLine());
                    if (secondInput == "exit")
                    {
                        break;
                    }
                }

                else if (userInput == "favorite color" | userInput == "Favorite Color")
                {
                    Console.WriteLine($"{studentName}'s favorite color is {favoriteColor} Would you like to know more [y,n] or enter a number [1-20] to seach another student");
                    string secondInput = knowMoreYesOrNo(Console.ReadLine());
                    if (secondInput == "exit")
                    {
                        break;
                    }
                }
                else if (userInput == "favorite number" | userInput == "Favorite Number")
                {
                    Console.WriteLine($"{studentName}'s favorite number is {favoritenumber} Would you like to know more [y,n] or enter a number [1-20] to seach another student");
                    string secondInput = knowMoreYesOrNo(Console.ReadLine());
                    if (secondInput == "exit")
                    {
                        break;
                    }
                }
                else if (userInput == "add" | userInput == "Add")
                {

                    while (true)
                    {
                        Console.WriteLine("Enter the persons name");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Enter persons home town");
                        string newHomeTown = Console.ReadLine();
                        Console.WriteLine("Enter persons favorite food");
                        string newFavFood = Console.ReadLine();
                        Console.WriteLine("Enter persons favorite color");
                        string newFavColor = Console.ReadLine();
                        Console.WriteLine("Enter persons favorite number");
                        string newFavNumber = Console.ReadLine();

                        //names.Add();
                        //ListhomeTown.Add();
                        //ListfavFood.Add();
                        //ListFavColor.Add();
                        //ListFavNumber.Add();

                    }
                }



                else
                {
                    Console.WriteLine("That data does not exist.  Please try again. (enter or \"hometown\" or \"favorite food\" or \"favorite color\" or \"favorite number\")");
                }

            }

            return nothing;

        }

        public static string askForNumber(string words)
        {
            string cya = "ok";
            try
            {
                string word = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid number. Please try again.");
            }
            return cya;

        }
        public static string DataSet(int input, int index)
        {

            var value = "thing";
            List<string> names = new List<string>()

            { "person1","person2","person3","person4","person5","person6","person7","person8","person9","person10","person11","person12","person13","person14","person15","person16","person17","person18","person19","person20"};
            List<string> ListhomeTown = new List<string>()
            { "place1","place2","place3","place4","place5","place6","place7","place8","place9","place10","place11","place12","place13","place14","place15","place16","place17","place18","place19","place20"};
            List<string> ListfavFood = new List<string>()
            { "food1","food2","food3","food4","food5","food6","food7","food8","food9","food10","food11","food12","food13","food14","food15","food16","food17","food18","food19","food20"};
            List<string> ListFavColor = new List<string>()
            { "color1","color2","color3","color4","color5","color6","color7","color8","color9","color10","color11","color12","color13","color14","color15","color16","color17","color18","color19","color20"};
            List<string> ListFavNumber = new List<string>
            { " 1"," 2"," 3"," 4"," 5"," 6"," 7"," 8"," 9"," 10"," 11"," 12"," 13"," 14"," 15"," 16"," 17"," 18"," 19"," 20"};


            if (input == 1)
            {
                value = names[index];
            }
            else if (input == 2)
            {
                value = ListhomeTown[index];
            }
            else if (input == 3)
            {
                value = ListfavFood[index];
            }
            else if (input == 4)
            {
                value = ListFavColor[index];
            }
            else if (input == 5)
            {
                value = ListFavNumber[index];
            }

            return value;

        } //

        public static string knowMoreYesOrNo(string input)
        {
            string Input = input;
            string response = "stuff";
            bool isValidResponse = false;
            while (!isValidResponse)
            {
                int ID = 0;
                if (Input == "y" | Input == "Y")
                {
                    Console.WriteLine("what would you like to know about? \"hometown\" or \"favorite food\" or \"favorite color\" or \"favorite number\"");
                    isValidResponse = true;
                }
                else if (Input == "n" | Input == "N")
                {
                    Console.WriteLine("Thanks!");
                    isValidResponse = true;
                    response = "exit";
                    Environment.Exit(0);
                    break;
                }
                else if (int.TryParse(Input, out ID))
                {
                    response = Convert.ToString(IndexOutOfRange(Input));
                    RunApp(Convert.ToString(ID));
                    //isValidResponse = true;

                    //else if (int.TryParse(Input, out ID))
                    //{
                    //string secondInput = knowMoreYesOrNo(Console.ReadLine());
                    //RunApp(.Parse(secondInput));
                    //RunApp(Convert.ToString(ID));
                    //}


                }
                else
                {
                    Console.WriteLine("didnt accept that, would you like to know more about this student [y/n] or enter a number [1-20] to seach another student");
                    isValidResponse = false;
                    Input = Console.ReadLine();
                }

            }

            return response;

        }
        public static int IndexOutOfRange(string input)
        {
            int ID = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {


                string message = "That student does not exist.  Please try again. (enter a number 1-20):";

                if (!int.TryParse(input, out ID) | (Convert.ToInt32(input)) > 20 | (Convert.ToInt32(input)) < 1)
                {
                    //throw new IndexOutOfRangeException();

                    Console.WriteLine(message);
                    input = Console.ReadLine();


                }
                else
                {

                    isValidInput = true;
                }

            }

            return ID = ID - 1;
        }

        //public static string AddNewUser(string a, string b, string c, string d, string e)
        //{
        //    Console.WriteLine("Enter the persons name");
        //    newName = Console.ReadLine();
        //    Console.WriteLine("Enter persons home town");
        //    newHomeTown = Console.ReadLine();
        //    Console.WriteLine("Enter persons favorite food");
        //    newFavFood = Console.ReadLine();
        //    Console.WriteLine("Enter persons favorite color");
        //    newFavColor = Console.ReadLine();
        //    Console.WriteLine("Enter persons favorite number");
        //    newFavNumber = Console.ReadLine();


        //    return (newName,newHomeTown,newFavFood,newFavColor,newFavNumber)

        //    names.Add();
        //    ListhomeTown.Add();
        //    ListfavFood.Add();
        //    ListFavColor.Add();
        //    ListFavNumber.Add()

        //}


    }
}
