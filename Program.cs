using System;

class Program
{
    static void Main(string[] args)
    {
        // Mảng 10 pt số nguyên
        int[] array = new int[10];

        // Nhập gt
        inputArray(array);

        // In các pt
        printArray(array);

        // Tìm max
        int maxIndex = findMaxValue(array);
        System.Console.WriteLine($"Vi tri phan tu co gia tri lon nhat: {maxIndex + 1}");

        // Prime 
        bool hasPrime = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (isPrime(array[i]))
            {
                hasPrime = true;
                System.Console.WriteLine($"Vi tri so nguyen to: {i + 1}, Gia tri: {array[i]}");
                break;
            }
        }
        if (!hasPrime)
        {
            System.Console.WriteLine("Mang khong co so nguyen to nao!!");
        }
    }


    // Bai 1
    static void inputArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"Nhap phan tu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    // Bai 2
    static void printArray(int[] array)
    {
        System.Console.WriteLine("Mang:");
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]} ");
        }
        System.Console.WriteLine();
    }

    // Bai 3
    static int findMaxValue(int[] array)
    {
        int maxValue = array[0];
        int maxIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    // Bai 4
    static bool isPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
