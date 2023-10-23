namespace Lab8_OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee { Gender = "Male", Id = 101, Name = "Mr Anderson", Salary = 34000 };
            Employee Employee2 = new Employee { Gender = "Female", Id = 102, Name = "Sara", Salary = 32000 };
            Employee Employee3 = new Employee { Gender = "Male", Id = 103, Name = "Hank", Salary = 28000 };
            Employee Employee4 = new Employee { Gender = "Male", Id = 104, Name = "Thomas", Salary = 42000 };
            Employee Employee5 = new Employee { Gender = "Female", Id = 105, Name = "Greta", Salary = 37000 };

            Stack <Employee> stack = new Stack<Employee>();
            stack.Push(Employee1);
            stack.Push(Employee2);
            stack.Push(Employee3);
            stack.Push(Employee4);
            stack.Push(Employee5);

            Console.WriteLine("-----Foreach loop stack-----");
            foreach (Employee emp in stack)
            {
                Console.WriteLine(emp.Id + " - " + emp.Name + " - " + emp.Gender + " - " +  emp.Salary + "\nItems left in stack = " + stack.Count);
            }
            Console.WriteLine("---------------------------------------------------------------");


            Console.WriteLine("-----Retrieve using Pop Method-----");
            Stack <Employee> stack2 = new Stack<Employee>();
            while (stack.Count > 0)
            {
                Employee emp = stack.Pop();
                stack2.Push(emp);
                Console.WriteLine(emp.Id + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary + " \nItems left in stack = " + (stack.Count));
            }

            Console.WriteLine("---------------------------------------------------------------");


            Console.WriteLine("-----Retrieve using Peek Method-----");
            for (int i = 0; i < 2; i++)
            {
                Employee emp2 = stack2.Peek();
                Console.WriteLine(emp2.Id + " - " + emp2.Name + " - " + emp2.Gender + " - " + emp2.Salary + " \nItems left in stack = " + (stack2.Count));
            }

            if(stack2.Contains(Employee3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }
            Console.WriteLine("---------------------------------------------------------------");

            
            List<Employee> empList = new List<Employee>();
            List<Employee> maleList = new List<Employee>();
            empList.Add(Employee1);
            empList.Add(Employee2);
            empList.Add(Employee3);
            empList.Add(Employee4);
            empList.Add(Employee5);

            if (empList.Contains(Employee2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }


            Console.WriteLine("-----List find first Male-----");
            Employee findMale = empList.Find(x => x.Gender == "Male");
            Console.WriteLine(findMale.Id + " - " + findMale.Name + " - " + findMale.Gender + " - " + findMale.Salary +" \n");



            Console.WriteLine("-----List find all Males-----");
            maleList = empList.FindAll(x => x.Gender == "Male");

            foreach (Employee emp in maleList)
            {
                Console.WriteLine(emp.Id + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
            }
        }
    }
}