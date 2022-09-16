// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4

Console.WriteLine("Enter number :");
int number = Convert.ToInt32(Console.ReadLine ());

int number2 = 2;
while(number2 < number){
    System.Console.WriteLine(number2);
    number2 = (number2 + 2);
}