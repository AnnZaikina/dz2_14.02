//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое число:");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num<=99){
    Console.WriteLine("Третьей цифры нет");
}else{
    while(num>1000){
      num/=10;
    }
Console.Write("Третья цифра вашего числа ");
Console.Write(num%10);
}