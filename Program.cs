// using System;
// using System.Collections;
// using System.Data.Common;
// using System.Reflection.Metadata.Ecma335;
// using System.Collections.ObjectModel;


// namespace collectionsdemo
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//             // Queue myqueue = new Queue();
//             // myqueue.Enqueue("Maharashtra");
//             // myqueue.Enqueue(2000);
//             // myqueue.Enqueue(false);
//             // myqueue.Enqueue(45.23f);
//             // myqueue.Enqueue(null);
//             // Console.WriteLine($"Count of element in the Queue: {myqueue.Count}");
//             // Console.WriteLine("First item is: "+ myqueue.Dequeue());
//             // Console.WriteLine("Contains: "+ myqueue.Contains(2000));
//             // Console.WriteLine("First item is: "+ myqueue.Dequeue());
//             // Console.WriteLine("Contains: "+ myqueue.Contains(2001));



//             // //1 Generic Collection List
//             // List<string> fruits = new List<string>();
//             // //no boxing while adding
//             // //fruits.Add(12);
//             // fruits.Add("Mango");
//             // fruits.Add("Bananan");
//             // fruits.Add("Orange");
//             // //fruits.Add(new Employee() {Id = 1, Name = "Adnan"});
//             // //so no unboxing while retreving
//             // foreach(string fruit in fruits)
//             //     Console.WriteLine(fruit);

// //---------------------------------------------------------------
            // List<Students> stud = new List<Students>();
            // stud.Add(new Students() {id = 101, name= "Adnan"});
            // stud.Add(new Students() {id = 102, name= "Addy"});
            // stud.Add(new Students() {id = 103, name= "Tanmay"});
            // stud.Add(new Students() {id = 104, name= "Kimaya"});

            // foreach(var students in stud)
            // {
            //     Console.WriteLine(students);
            // }

            // Console.WriteLine("Sorted List");

            // stud.Sort();
            // foreach(var students in stud)
            // {
            //     Console.WriteLine(students);
            // }
// //-------------------------------------------------------------------------------------------
//             // List<Books> book = new List<Books>();
//             // book.Add(new Books() {Id = 1, Title = "Automic Habits", Author = "Adnan", Price = 200.20m});
//             // book.Add(new Books() {Id = 2, Title = "Half Girfriend", Author = "Tanmay", Price = 50.20m});
//             // book.Add(new Books() {Id = 3, Title = "Harry Potter", Author = "Kimaya", Price = 300.20m});
//             // book.Add(new Books() {Id = 4, Title = "Dengers", Author = "Viraj", Price = 50.20m});
//             // book.Add(new Books() {Id = 5, Title = "C", Author = "Viraj", Price = 50.20m});
            
//             // foreach(var Books in book)
//             // {
//             //     Console.WriteLine(Books);
//             // }

//             // Console.WriteLine("Sorted Books");

//             // book.Sort();

//             // foreach(var Books in book)
//             // {
//             //     Console.WriteLine(Books);
//             // }
//             // Console.WriteLine("Reverse Books");

//             // book.Reverse();

//             // foreach(var Books in book)
//             // {
//             //     Console.WriteLine(Books);
//             // }
// //------------------------------------------------------------------------------------------

//         // Queue<string>printQ = new Queue<string>();
//         // printQ.Enqueue("Dcument");
//         // printQ.Enqueue("Excel Sheet");
//         // printQ.Enqueue("Pdf File");
//         // printQ.Enqueue("Jpg");

//         // try
//         // {
//         //     Console.WriteLine(printQ.Dequeue());
//         //     Console.WriteLine(printQ.Dequeue());
//         //     Console.WriteLine(printQ.Dequeue());
//         //     Console.WriteLine(printQ.Dequeue());
//         //     Console.WriteLine(printQ.Dequeue());
//         //     Console.WriteLine(printQ.Dequeue());

//         // }
//         // catch(InvalidOperationException e)
//         // {
//         //     Console.WriteLine(e.Message);
//         // }
// //--------------------------------------------------------------------

//         // Collection<int> numbers = new Collection<int>() {1,2,3,4,5,6,7};
//         // foreach (int i in numbers)
//         // {
//         //     Console.Write($"{i} ");
//         // }
//         // numbers.Remove(3);
//         // Console.WriteLine("--------after removing 3-----------");
//         // foreach (int i in numbers)
//         // {
//         //     Console.Write($"{i} ");
//         // }
// //------------------------------------------------
//         // Books b = new Books(121,"adn");
//         // Books b1 = new Books();





//         }
//     }
// }
// // Nongeneric collecion - 1. Any kind of data accepted. 2. No size restiriction.

// //Generic collection - 1. No size restriction.  2. But data type declared at compile time in <>

//ICollection interface is inhetared from IEnumerable interface.

/*
1. Count Property
2. IsSynchronized Property
3. SyncRoot Property
4. CopyTo method
*/

// Icollection emplist = new List<Employee>();

// IQueryable exist in System.Lineq Namespace
// IEnumerable exist in System.Collection Namespace