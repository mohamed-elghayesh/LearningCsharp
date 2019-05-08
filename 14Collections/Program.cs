using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accepts any type and is unordered (no indexing)
            ArrayList myArrList = new ArrayList();
            myArrList.Add("Ahmed");
            myArrList.Add(DateTime.Now);
            myArrList.Add(25);

            DateTime date = (DateTime)myArrList[1];

            foreach (var item in myArrList)
            {
                Console.WriteLine("ArrayList: " + item);
            }
            Console.WriteLine("--------------------------");

            // safe typed (indexed)
            List<string> myList = new List<string>();
            myList.Add("Hello");
            myList.Add("World");
            myList.Add("Wide");
            myList.Remove("Hello");
            myList.ForEach(el => Console.WriteLine("List: " + el));
            myList.ElementAt(1); 
            Console.WriteLine("--------------------------");

            // FIFO (indexed)
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            string removed = myQueue.Dequeue();
            Console.WriteLine("Queue removed: " + removed);
            Console.WriteLine("--------------------------");

            // LIFO (indexed)
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            removed = myStack.Pop();
            Console.WriteLine("Stack removed: " + removed);
            Console.WriteLine("--------------------------");

            // key/value with linq to retrieve (indexed)
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            myDict.Add(1, "Dict number one");
            myDict.Add(2, "Dict number two");
            myDict.Add(3, "Dict number three");
            myDict.Remove(2);
            KeyValuePair<int, string> keyValue = myDict.ElementAt(0);

            // using key
            Console.WriteLine(myDict[1]);
            Console.WriteLine(myDict[3]);
            Console.WriteLine("key value pair: " + keyValue.Key + "|" + keyValue.Value);

            // retrieving from dictionary using linq
            var myKey = from row in myDict
                        where row.Value.Equals("Dict number three")
                        orderby row.Value
                        select row.Key;
            Console.WriteLine(myKey.Single());

            Console.WriteLine("--------------------------");

            // HashTable accepts any type and is unordered (no indexing)
            Console.WriteLine("Hash Table");
            Hashtable myHashTable = new Hashtable(myDict);
            myHashTable.Add(DateTime.Now, 1.5f);

            foreach (DictionaryEntry item in myHashTable)
            {
                Console.WriteLine("HashTable: " + item.Key + " | " + item.Value);
            }

            // hashtable example 2
            Hashtable newHashTable = new Hashtable();
            newHashTable.Add(3, 20);
            newHashTable.Add("third", DateTime.Today);

            DateTime value = (DateTime)newHashTable["third"];

            foreach (DictionaryEntry item in newHashTable)
            {
                Console.WriteLine("New HashTable: " + item.Key + " : " + item.Value);
            }

            Console.WriteLine("--------------------------");

            // accepts any type (no indexing)
            HybridDictionary hDict = new HybridDictionary();
            hDict.Add("one", "Mohamed");
            hDict.Add(2, "Ali");
            hDict.Add("three", "Kamal");
            hDict.Add(DateTime.Today.ToShortDateString(), 3);

            foreach (DictionaryEntry line in hDict)
            {
                Console.WriteLine(line.Key.ToString().PadRight(10) + " | " + line.Value.ToString().PadRight(10));
            }
            Console.WriteLine("--------------------------");

            // implements binary search on sorted list (indexed)
            SortedList<string,string> sortedList = new SortedList<string,string>();
            sortedList.Add("Mocca", "Ingradients of Mocca");
            sortedList.Add("Cappuccino", "Ingradients of Cappuccino");
            sortedList.Add("Turkish", "Ingradients of Turkish");
            sortedList.Add("Tea", "Ingradients of Tea");

            KeyValuePair<string,string> myElement = sortedList.ElementAt(2);
            string mocIngradients = sortedList["Mocca"];

            foreach (var item in sortedList)
            {
                Console.WriteLine(item.Key + " | " + item.Value);
            }
            Console.WriteLine("--------------------------");

            // BitVector32 https://docs.microsoft.com/en-us/dotnet/api/system.collections.specialized.bitvector32?view=netframework-4.7.2
            // BitVector32.Section https://docs.microsoft.com/en-us/dotnet/api/system.collections.specialized.bitvector32.section?view=netframework-4.7.2

            // linq example
            // Create a new Hashtable.
            Hashtable prices = new Hashtable();
            prices.Add("Café au Lait", 1.99M);
            prices.Add("Caffe Americano", 1.89M);
            prices.Add("Café Mocha", 2.99M);
            prices.Add("Cappuccino", 2.49M);
            prices.Add("Espresso", 1.49M);
            prices.Add("Espresso Romano", 1.59M);
            prices.Add("English Tea", 1.69M);
            prices.Add("Juice", 2.89M);

            // Select all the drinks that cost less than $2.00 
            // and order them by cost.
            var bargains = from string drink in prices.Keys
                           where (Decimal)prices[drink] < 2.00M
                           orderby prices[drink] ascending
                           select drink;
            
            // Display the results.
            foreach (string bargain in bargains)
            {
                Console.WriteLine(bargain);
            }

            // Query the Hashtable to order drinks by cost.
            var drinks = from string drink in prices.Keys
                         orderby prices[drink] ascending
                         select drink;

            Console.WriteLine("The cheapest drink is {0} ", drinks.FirstOrDefault());
            Console.WriteLine("The most expensive drink is {0} ", drinks.Last());
            Console.WriteLine("The maximum is {0} ", drinks.Max());
            Console.WriteLine("The minimum is {0} ", drinks.Min());

            Console.ReadLine();
        }
    }
}
