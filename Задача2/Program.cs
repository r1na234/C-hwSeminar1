//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7

Console.WriteLine("Enter number 1:");
int numberA = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Enter number 2:");
int numberB = Convert.ToInt32(Console.ReadLine ());
if(numberA > numberB){
    System.Console.WriteLine("max "+ numberA);
}
else if(numberB > numberA){
    System.Console.WriteLine("max "+ numberB);
}
else{
    System.Console.WriteLine("error");
}