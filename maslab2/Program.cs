using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maslab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан одномерный массив числовых значений, насчитывающий N элементов.Поменять местами первую и вторую половины массива без использования дополнительных массивов

            int arrnum, inspos;
            float[] arr;

            Console.Write("Введите число N элементов массива: ");
            arrnum = Convert.ToInt32(Console.ReadLine());
            arr = new float[arrnum];

            Console.Write("Введите массив: ");
            arr = Console.ReadLine().Split().Select(float.Parse).ToArray();

            if(arrnum%2==0)inspos = arrnum/2;
            else inspos = arrnum / 2+1;

            Array.Resize(ref arr, arrnum+ arrnum/2);
            Array.ConstrainedCopy(arr, 0, arr, arrnum, arrnum/2);
            Array.ConstrainedCopy(arr, inspos, arr, 0, arrnum/2);
            
            Array.ConstrainedCopy(arr, arrnum, arr, inspos, arrnum / 2);
            Array.Resize(ref arr, arrnum);

            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
