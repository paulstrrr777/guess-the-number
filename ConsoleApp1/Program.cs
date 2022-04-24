// See https://aka.ms/new-console-template for more information
Console.WriteLine("Угадай число от 0 до 100 [0,99]");
var random = new Random();
int number = random.Next(101);
Console.WriteLine("{0,11:N0}", number); // "{0,8:N0}"  

Console.Write(" Input integer Number [0,99] : ");
string input = Console.ReadLine();
Console.WriteLine();
int number1;
bool resultInput = int.TryParse(input, out number1);
while (!resultInput)
{
    Console.Write($"You input {input}, type integer number [0,99] : ");
    input = Console.ReadLine();
    resultInput = int.TryParse(input, out number1);
}
while (number1 != number)
{
    // if (number1 > number) { Console.WriteLine(" Input number is bigger then unknown number "); }
    if (number1 > number) { Console.WriteLine(" Try input something more smaller "); }
    //if (number1 < number) { Console.WriteLine("Input number is smaller then unknown number"); }
    if (number1 < number) { Console.WriteLine(" InTry input something more bigger "); }
    Console.Write(" Input another integer Number [0,99] ");
    input = Console.ReadLine();
    Console.WriteLine();
    resultInput = int.TryParse(input, out number1);


}
   Console.WriteLine(" You are right !\n You Win !!!"); 