//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

Console.WriteLine("Enter number 1:");
int numberA = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Enter number 2:");
int numberB = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Enter number 3:");
int numberC = Convert.ToInt32(Console.ReadLine ());

if(numberA > numberB && numberA > numberC){
     System.Console.WriteLine("max "+ numberA);
}
else if(numberB > numberA && numberB > numberC){
    System.Console.WriteLine("max "+ numberB);
}
else if(numberC > numberA && numberC > numberB){
    System.Console.WriteLine("max "+ numberC);
}
else{
    System.Console.WriteLine("error");
}