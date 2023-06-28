class Program
{
    public static void QuickSortInitialize(int[] items)
    {
        QuickSort(items, 0, items.Length - 1);
    }
    /// <summary>
    /// метод быстрой сортировки массива
    /// </summary>
    /// <param name="items">массив</param>
    /// <param name="first">первый элемент сортировки</param>
    /// <param name="last">последний элемент сортировки</param>
    public static void QuickSort(int[] items, int first, int last)
    {
        int i = first, j = last;
        int state = items[(first + last) >> 1];                 //опорный элемент в середине массива

        while (i <= j)
        {
            while (items[i] < state) { i++; }                   //перебор с приближением к опорному элементу
            while (items[j] > state) { j--; }
            if (i <= j)                                          //обмен значениями
            {
                (items[i], items[j]) = (items[j], items[i]);
                i++;
                j--;
            }
        }
        if (first < j)
        {
            QuickSort(items, first, j);     //рекурсия
        }
        if (i < last)
        {
            QuickSort(items, i, last);      //рекурсия
        }
    }
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = Enumerable.Range(1, 9).Select(x => random.Next(10)).ToArray();
        foreach (int i in array) { Console.Write($"{i} "); }

        QuickSortInitialize(array);

        foreach (int i in array) { Console.Write($"{i} "); }
    }
}