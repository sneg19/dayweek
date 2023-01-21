
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.Clear();
// Console.Write("Введите число, обозначающее день недели: ");
// int day_number = int.Parse(Console.ReadLine()!);

// if (day_number < 8)
// {
//     if (day_number == 7)
//      {
//         Console.WriteLine($"{day_number} - выходной день");
//      }
//      else
//         {
//             if (day_number == 6)
//                 {
//                     Console.WriteLine($"{day_number} - выходной день");
//                 }
//             else
//                 {
//                     Console.WriteLine($"{day_number} - рабочий день");
//                 }
//         }
// }
// else
// {
//     // Console.WriteLine("Такого дня недели не существует!");
// }


Console.Clear();
Console.Write("Введите число, обозначающее день недели: ");
int day_number = int.Parse(Console.ReadLine()!);
if (day_number < 8 && day_number > 0)
{
    if (day_number == 7 || day_number == 6)
        {
            Console.WriteLine("выходной");
        }
    else
        {
            Console.WriteLine("рабочий");
        }
}
else
{
    Console.WriteLine("Такого дня недели не существует:(");
}