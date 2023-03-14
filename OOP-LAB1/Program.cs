using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    internal class Program
    {
        public struct Person
        {
            string _name;
            int _mark;

            public Person(string name, int mark)
            {
                _name = name;
                _mark = mark;
            }
            public string Passed()
            {
                if (_mark >= 25) return $"Имя: {_name}; Оценка: {_mark}";
                else return("");
            }
        }
            static void Main(string[] args)
        {
            int action, count = 0;
            Console.Write("Выберите номер задачи: ");
            string firstString = Console.ReadLine();
            action = Convert.ToInt32(firstString);
            switch (action)
            {
                case (1):
                    int[] arr;
                    arr = new int[20];
                    Random rand = new Random();
                    for (int x = 0; x < arr.Length; x++)
                    {
                        arr[x] = rand.Next(-100, 100);
                    }
                    var str = string.Join(" ", arr);
                    Console.WriteLine(str);
                    for (int i = 0; i < arr.Length - 1; i++)
                        if (arr[i] <= 25) count++;
                    Console.Write("Количество элементов: ");
                    Console.WriteLine(count);
                    break;

                case (2):
                    decimal[,] array = new decimal[4, 5];
                    Random random = new Random();
                    for (var i = 0; i < array.GetLength(0); i++)
                        for (var j = 0; j < array.GetLength(1); j++)
                        {
                            array[i, j] = random.Next(-2, 1);
                        }
                    for (var i = 0; i < array.GetLength(0); i++)
                    {
                        for (var j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write(array[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    count = 0;
                    bool flag = false;
                    for (int i = 0; i < 4; i++) { 
                        for (int j = 0; j < 5; j++) {
                            if (array[i, j] == 0)
                            {
                                flag = true;
                                break;
                            } 
                        }
                        if (flag == false) count++;
                        flag = false;
                    }
                    Console.Write("Количество строк: ");
                    Console.WriteLine(count);
                    break;

                case (3):
                    List<Person> students = new List<Person>();
                    var student1 = new Person("Владислав", 36);
                    students.Add(student1);
                    students.Add(new Person("Денис", 15));
                    students.Add(new Person("Мария", 40));
                    students.Add(new Person("Иван", 25));
                    students.Add(new Person("Никита", 45));
                    students.Add(new Person("Андрей", 24));
                    students.ForEach(s => Console.WriteLine(s.Passed()));
                    break;
            }

            
        }
    }
}
