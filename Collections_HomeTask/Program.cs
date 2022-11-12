using Collections_HomeTask.Models;
using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections_HomeTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //Employee employee = new Employee();

            //DateTime startDate = DateTime.Now.AddDays(2);
            //DateTime endDate = DateTime.Now.AddDays(25);

            //double salary = 2000;

            //IEmployeeService employeeService = new EmployeeService();

            //int result = employeeService.GetFilteredEmployeesCount(startDate, endDate, salary);

            //Console.WriteLine(result);



            //DateTime startDate = DateTime.Now.AddDays(-2);
            //DateTime endDate = DateTime.Now.AddDays(20);

            ////double salary = 2000;

            //var result = GetEmployeeCount(startDate, endDate);

            //Console.WriteLine("Persons count: " + result);
            #endregion

            #region Task

            //List<Author> authors = new List<Author>();

            //authors.Add(new Author { FullName1 = "Mirjalal Pashayev", Age = 42 });
            //authors.Add(new Author { FullName1 = "Afaq Magsud", Age = 43 });
            //authors.Add(new Author { FullName1 = "Jalil Mammadquluzade", Age = 46 });
            //authors.Add(new Author { FullName1 = "Ismayil Shixli", Age = 25 });

            //var result = authors.FindAll(m => m.Age > 40);

            //foreach (var author in result)
            //{
            //    Console.WriteLine("Fullname : {0}", author.FullName1);
            //}




            #endregion

            #region List
            ////List<int> nums = new List<int>() { 200, 300, 400, 500 };


            ////List<int> numbers = new List<int>();

            ////numbers.Add(5);
            ////numbers.Add(9);
            ////numbers.Add(11);
            ////numbers.Add(111);
            ////numbers.Add(112);
            ////numbers.Add(91);
            ////numbers.Add(3);

            ////numbers.AddRange(nums);

            ////foreach (var item in numbers)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////var result = numbers.Contains(5);

            ////var result = numbers.Find(m=> m > 100);

            ////var result = numbers.FindAll(m=> m > 100);

            ////var result = numbers.FindLastIndex(m=> m > 100);

            ////numbers.Sort();

            ////var result = numbers.ToArray();

            ////var result2 = result.ToList();

            ////var result = numbers.BinarySearch(11);
            ////var result2 = numbers.FindIndex(m=> m == 11);

            ////Console.WriteLine(result);
            ////Console.WriteLine(result2);

            ////foreach (var item in numbers)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////if (result)
            ////{
            ////    Console.WriteLine("yes");
            ////}

            ////Console.WriteLine(result);

            ////foreach (var item in numbers)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

            //////var result = names.FindAll(m => m == "Nicat");

            //////foreach (var item in result)
            //////{
            //////    Console.WriteLine(item);
            //////}

            ////var searchText = Console.ReadLine();

            ////var result = Search(searchText);

            ////if (result.Count == 0)
            ////{
            ////    Console.WriteLine("Not found");
            ////}
            ////else
            ////{
            ////    foreach (var item in result)
            ////    {
            ////        Console.WriteLine(item);
            ////    }
            ////}

            //List<Person> people = new List<Person>();

            //people.Add(new Person { FullName = "Qoshqar Nermanli", Birthday = DateTime.Now.AddDays(-10), Salary = 1500 });
            //people.Add(new Person { FullName = "Ramil Allahverdiyev", Birthday = DateTime.Now.AddDays(10), Salary = 1700 });
            //people.Add(new Person { FullName = "Nihad Veliyev", Birthday = DateTime.Now.AddDays(12), Salary = 1800 });
            //people.Add(new Person { FullName = "Gultac Ceferova", Birthday = DateTime.Now.AddDays(10), Salary = 2500 });

            //var result2 = people.FindAll(m => m.Salary > 1600 && m.FullName.StartsWith("R"));

            //foreach (var person in result2)
            //{
            //    Console.WriteLine("Fullname : {0}, Birthday : {1}, Salary : {2}", person.FullName, person.Birthday, person.Salary);
            //}
            #endregion


            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Resul");
            //hashtable.Add(2, "Nicat");
            //hashtable.Add(3, "Vuqar");


            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList sortedList = new SortedList();

            //sortedList.Add(1, "Resul");
            //sortedList.Add(2, "Nicat");
            //sortedList.Add(3, "Vuqar");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("salam");
            //arrayList.Add(155);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList<string, string> list = new SortedList<string, string>();

            //list.Add("Admin", "Qoshqar");
            //list.Add("Member", "Test");

            //foreach (KeyValuePair<string, string> item in list)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Dictionary<string, string> dictionaryList = new Dictionary<string, string>();

            //dictionaryList.Add("Admin", "Ramil");

            //foreach (KeyValuePair<string, string> item in dictionaryList)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Console.WriteLine(dictionaryList["Admin"]);

            //List<int> list1 = new List<int>();

            //List<string> list2 = new List<string>();

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(5);
            //queue.Enqueue(10);
            //queue.Enqueue(3);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();

            //stack.Push(11);
            //stack.Push(22);
            //stack.Push(3);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


        }












        private static List<string> Search(string str)
        {
            List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

            return names.FindAll(m => m.ToLower().Contains(str.ToLower()));
        }


        //public static int GetEmployeeCount(DateTime start, DateTime end)
        //{

        //    Person person1 = new Person(DateTime.Now.AddDays(5), 3000);
        //    Person person2 = new Person(DateTime.Now.AddDays(15), 6000);
        //    Person person3 = new Person(DateTime.Now.AddDays(10), 1000);
        //    Person person4 = new Person(DateTime.Now.AddDays(25), 2500);


        //    Person[] people = { person1, person2, person3, person4 };

        //    int empCount = 0;

        //    foreach (Person person in people)
        //    {
        //        if ((person.Birthday > start && person.Birthday < end) && person.Salary > 2000)
        //        {
        //            empCount++;
        //        }
        //    }
        //    return empCount;
        //}


    }
}
