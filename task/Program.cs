// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//string [] arr1= new string [4];
//arr1 = new string[4] {"hello", "2", "world", ":-)" };
//string [] arr3= new string [3];
//arr3 = new string[3] {"Russia", "Denmark", "Kazan"};

string [] arr2= new string [4];
arr2 = new string[4] {"1234", "1567", "-2", "computer science"};

int numbersItems = ChekArray(arr2, 3);
string[] newArray2 = new string[numbersItems];

PrintArray(arr2);
Console.WriteLine();
ReplaceArray(arr2,newArray2,3);
PrintArray(newArray2);

void PrintArray(string [] array)
{
   for (int i=0; i<array.Length; i++)
   {
      Console.Write($" {array[i]}");
   }
}


int ChekArray(string [] array, int LimitLength)
{    
  int n = 0;
  for (int i=0; i<array.Length; i++)
  {    
    if (array[i].Length < LimitLength) n++;                                                  
  }  
  return n;
} 


void ReplaceArray(string[] oldArray, string[] newArray, int LimitLength)
{ 
   
  for (int i = 0; i < oldArray.Length; i++)
  {  
    int temp = 0;   
    if (oldArray[i].Length <= LimitLength)
    {
      newArray[temp] = oldArray[i];
      temp++;
    }
  }
};

//string[] newArray1 = new string[numbersItems];
//string[] newArray3 = new string[numbersItems];


//PrintArray(arr1);
//Console.WriteLine();
//PrintArray(arr3);
//Console.WriteLine();

//ReplaceArray(arr1,newArray1,3);
//ReplaceArray(arr3,newArray3,3);

//Console.WriteLine();
//PrintArray(newArray1);
//PrintArray(newArray3);

