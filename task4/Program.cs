// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Console.Clear();
Console.WriteLine("Введите число K, на которое нужно сделать сдвиг:");
int K = Convert.ToInt32(Console.ReadLine());
int [] array = {5, 3, 7, 4, 6};
Console.WriteLine("[" + string.Join(", ", array) + "]");
if (K<0)
{
    for (int i = 0; i < Math.Abs(K); i++)
    {
        for (int j = array.Length - 1; j >= 0; j--)
            {
                int temp1 = array[array.Length - 1];
                array[array.Length - 1] = array[j];
                array[j] = temp1;
            }
    }
}
else 
{ 

     for (int i = 0; i < array.Length - K; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                int temp2 = array[j+1];
                array[j+1] = array[j];
                array[j] = temp2;
            }
        }

}
Console.WriteLine("[" + string.Join(", ", array) + "]");