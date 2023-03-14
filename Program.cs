Console.WriteLine("Программа  из случайного строкового массива заданной длины, формирует новый "+"\n"+
"массив строк состоящий из элементов случайного массива длиной меньше либо равно 3 символа.");
Console.WriteLine();

string [] array = CreateArrayRandomString(OutIntDigit("Введите длину массива = "));
PrintArrayString("Получен случайный массив", array);
int lengthnewarray = FindElementsArrayLengthLessFour(array);
string [] newarray = CreateShortArray(array, lengthnewarray);
PrintArrayString("Получен новый массив", newarray);
Console.WriteLine();


 
int OutIntDigit(string info)
{
 int i;   
 Console.Write(info);
 
 while (!int.TryParse(Console.ReadLine(), out i))
 {
  Console.WriteLine("Вы ввели не целое число повторите еще раз");
 }
 return i;
}
 
string [] CreateArrayRandomString(int n)
 {
  Random rnd = new Random();
  string[] array = new string[n];
  
  for(int j = 0; j < array.Length; j++)
   { 
     array[j] = String.Empty;
     int lengthstring = rnd.Next(1,10);
     for(int i = 0; i < lengthstring; i++)
      {
       array[j] = array[j] + (char)rnd.Next(1040,1104); 
      }
   }
    Console.WriteLine();
   return array;
 } 

string [] CreateShortArray(string [] array, int lengthnewarray)
 {
  Random rnd = new Random();
  string[] newarray = new string[lengthnewarray];
  int i = 0;
  for(int j = 0; j < array.Length; j++)
   { 
    if (array[j].Length < 4)
      {
        newarray[i]=array[j];
        i = i + 1;
      }
   }
   Console.WriteLine();
   return newarray;
 } 


 void PrintArrayString(string info, string[] array)
 {
 Console.WriteLine(info);
 for(int i = 0; i < array.Length; i++)
  {
     Console.Write($" {array[i]};");
  }
    Console.WriteLine();
  } 

int FindElementsArrayLengthLessFour(string [] array)
 {
  int count = 0, limitLength = 4;

  for(int j = 0; j < array.Length; j++)
   { 
     if (array[j].Length < limitLength)
     {
      count = count+1;
     }
   }
    Console.WriteLine();
    Console.WriteLine($"кол-во элементов с длиной 3 символа или меньше = {count}");
   return count;
 } 
 