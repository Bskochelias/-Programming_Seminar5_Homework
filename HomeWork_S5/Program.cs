// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// Написать программу масштабирования фигуры
// Написать программу копирования массива


int Proverca_chisla()
{ 
  int num;
  while (true)
    {   
      var input = Console.ReadLine();

    if (int.TryParse(input, out num))
        break;                                                   // обработка при успехе и выход из цикла
    else                                                         // обработка при ошибке
    {
        Console.WriteLine("[ERROR]: Некоректные данные по пробуйте еще раз!");
        Console.Write("Введите число: ");
    }
    }
  return num;
}

//Функция для заполнения массива рандомом c вводам переменых
int[] R_Mas_Write()
{
  Console.Write("Введите размер массива: ");
  int n = Proverca_chisla();
  int[] f  = new int [n];
  Console.Write("Введите минимальное значения рандома для массива: ");
  int min = Proverca_chisla();
  Console.Write("Введите максимальное значения рандома для массива: ");
  int max = Proverca_chisla();

  int j=0;
  while (j < f.Length)
      {
        f[j]= new Random().Next(min,max);
        j++;        
      }
  return f;
}

//Функция для заполнения массива рандомом 
int[] R_Mas(int[] f,int min,int max)
{
  int j=0;
  while (j < f.Length)
      {
        f[j]= new Random().Next(min,max);
        j++;        
      }
  return f;
}


// Функция вывода
void PrintMas(int[] arr){
    for(int j=0;j<arr.Length;j++)
        {
            System.Console.WriteLine($"Вывод {j} элемента: {arr[j]}");
        }
    System.Console.WriteLine();
}

int otvet1 = 0;
string? otvet2 = " ";
do
{
  do
  { 
    Console.Clear();

    Console.WriteLine("Добрый день прошу выбрать цифру из списка что Вы хотите сделать?");
    Console.WriteLine("__________");
    Console.WriteLine("1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
    Console.WriteLine("2. Написать программу масштабирования фигуры");
    Console.WriteLine("3. Написать программу копирования массива");
    Console.WriteLine(" ");
    Console.Write("Ваш ответ: ");

    otvet1 = Proverca_chisla();

    if (otvet1 > 14 ^ otvet1 < 1)
    {
      Console.WriteLine("Такой задачи тут нету!");
      Console.Write("Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}      
    }

  } while (otvet1 > 14 ^ otvet1 < 1);

  Console.Clear();

//Начало тела задач

//1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

if (otvet1 == 1)
    { double k1,k2,b1,b2;        //Переменный ввода
      double x1,y1;              //Переменные вычисления

      System.Console.Write("Введите K1:");
      k1=Proverca_chisla();
      System.Console.Write("Введите B1:");
      b1=Proverca_chisla();
      System.Console.Write("Введите K2:");
      k2=Proverca_chisla();
      System.Console.Write("Введите B2:");
      b2=Proverca_chisla();
      
      if (k1==k2 && b1==b2){
        System.Console.WriteLine("Прямые совпадают");
      }
      else{
        if (k1==k2){
          System.Console.WriteLine("Прямые параллельны");
        }
        else{
          x1 = (b2-b1)/(k1-k2);
          y1 = (k1*(b2-b1))/(k1-k2)+b1;
          System.Console.WriteLine($"Точки пересечения: X = {x1}, Y = {y1}.");
        }
      }               
    }

//2. Написать программу масштабирования фигуры
if (otvet1 == 2)
    { 
      int per=0,vershiny=0; //Счетчики
      int[] arra = new int[8]; //Массив вершин


      while (per<8){
       System.Console.Write($"Введите {vershiny+1} вершину X,Y через пробел: ");
       string? test = Console.ReadLine();
       string[] temp = test.Split(new Char[] {' '});
          foreach(string item in temp) //Обрабатываем каждое число отдельно.
              {
              if (per==8) {break;} 
              arra[per] = int.Parse(item);
              per++;                    
              }
       vershiny++;
       if (per==8) {break;} 
      }

      System.Console.Write("Введите койфицент маштабирования");
      int k = Proverca_chisla();

      for(int i=0;i<arra.Length;i++){
        if(arra[i]>0){arra[i]+=k;}
        else{
          if(arra[i]<0){arra[i]-=k;}
          }
      }

      System.Console.Write($"После маштабирования получаем: ");
      for(int i=0;i<arra.Length;i++){
        System.Console.Write($"({arra[i]},{arra[i+1]}) ");
        i++;
      }
      System.Console.WriteLine();
    }



//Конец тела задач    
  Console.Write("Нажмите <Enter> для продолжения... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  do
  {
    Console.Clear();
    Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();

    if (otvet2 != "No" && otvet2 != "no" && otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y")
    {
    Console.WriteLine("Некоректный ответ");
    Console.Write(" Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }
  }
  while (otvet2 != "No" && otvet2 != "no" & otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y");

}
while (otvet2 != "No" & otvet2 != "no" & otvet2 != "NO" & otvet2 !="n" & otvet2 !="N");

Console.Clear();

Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
Console.Write("Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();

