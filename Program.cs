using System;



//DZ 1
//namespace NS1
//{
//    class Write
//    {
//        public string Output()
//        {
//            return "Hello from Namespace1"; 
//        }
//    }
//}

//namespace NS2
//{
//    class Write
//    {
//        public string Output()
//        {
//            return "Hello from Namespace2";
//        }
//    }
//}


//DZ 2
//namespace Company
//{
//    namespace Department
//    {
//        class Employee
//        {
//           public void ShowDepartment()
//            {
//                Console.WriteLine("Employee belongs to Sales Department");
//            }
//        }
//    }
//}


//DZ 3
//namespace MathOperations
//{
//    public class Calculator
//    {
//        public int Add(int num1, int num2)
//        {
//            return num1 + num2;
//        }
//    }
//}
//namespace StringOperations
//{
//    public class Concatenator
//    {
//        public string Concatenate(string str1, string str2)
//        {
//            return str1 + str2;
//        }
//    }
//}


//DZ 4
//namespace Ukraine
//{
//    public class Kiev
//    {
//        int population = 2900000;
//        public int GetPopulation()
//        {
//            return population;
//        }
//    }
//}
//namespace Denmark
//{
//    public class Copenhagen
//    {
//        int population = 602000;
//        public int GetPopulation()
//        {
//            return population;
//        }
//    }
//}
//namespace Moldova
//{
//    public class Chisinau
//    {
//        int population = 513000;
//        public int GetPopulation()
//        {
//            return population;
//        }
//    }
//}


class Program
{
    static void Main()
    {
        //NS1.Write obj1 = new NS1.Write();
        //NS2.Write obj2 = new NS2.Write();
        //Console.WriteLine(obj1.Output());
        //Console.WriteLine(obj2.Output());

        //Company.Department.Employee obj = new Company.Department.Employee();
        //obj.ShowDepartment();

        //MathOperations.Calculator num = new MathOperations.Calculator();
        //Console.WriteLine(num.Add(2, 2));
        //StringOperations.Concatenator str = new StringOperations.Concatenator();
        //Console.WriteLine(str.Concatenate("Hello,", "World!"));


        //Ukraine.Kiev ki = new Ukraine.Kiev();
        //Denmark.Copenhagen co = new Denmark.Copenhagen();
        //Moldova.Chisinau ch = new Moldova.Chisinau();

        //int KievPopulation = ki.GetPopulation();
        //int CopenhagenPopulation = co.GetPopulation();
        //int ChisinauPopulation = ch.GetPopulation();

        //if (KievPopulation > CopenhagenPopulation && KievPopulation > ChisinauPopulation)
        //{
        //    Console.WriteLine("Киев имеет самое большое население.");
        //}
        //else if (CopenhagenPopulation > KievPopulation && CopenhagenPopulation > ChisinauPopulation)
        //{
        //    Console.WriteLine("Копенгаген имеет самое большое население.");
        //}
        //else
        //{
        //    Console.WriteLine("Кишинев имеет самое большое население.");
        //}

    }
}

