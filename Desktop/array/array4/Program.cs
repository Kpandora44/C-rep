// Дано N гирь с разным весом в случайном порядке. Определить вес самой тяжелой гири.



int n = 10;
int[] array = { 5, 8, 9, 10, 50, 7, 99, 6, 56, 150 };

int i = 0;  // записываем "счётчик", чтобы сравнение шло с первого элемента массива
int max = array[0];  // приписываем для начала,что максимальное -первый элемент в массиве, чтобы начиналось сравнение первого и последующих

while (i < n)
{
    if (array[i] > max)
    {
      max = array[i];
    }
  
    i = i + 1;
}
Console.WriteLine(max);

// второй способ записи кода для задачи
max = array[0];
for(int j =0; j<n; j = j+1)
{
    if (array[j] > max)
    {
      max = array[j];
    }
  
  }
Console.WriteLine(max);

// третий способ записи кода для задачи

max = array[0];
foreach(int e in array)
{
    if (e > max)
    {
      max = e;
    }
  
  }
  
Console.WriteLine(max);    