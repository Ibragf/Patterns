using System;
using Patterns.Singleton;
using Patterns.AbsractFactory;
using Patterns.TemplateMethod;
using Patterns.Adapter;
using Patterns.Visitor;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonPattern();
            //AbstractFactoryPattern();
            //TemplateMethodPattern();
            //AdapterPattern();
            //VisitorPattern();
        }

        static void SingletonPattern()
        {
            MySingleton singleton = MySingleton.getInstance();
            Console.WriteLine("Singleton1:{0}",singleton.GetHashCode());

            MySingleton singleton2 = MySingleton.getInstance();
            Console.WriteLine("Singleton2:{0}",singleton2.GetHashCode());
        }

        static void AbstractFactoryPattern()
        {
            InterfaceOS windows = new InterfaceOS(new WinFactory());
            windows.createButton();
            windows.createTextBox();
            Console.WriteLine();

            InterfaceOS mac = new InterfaceOS(new MacFactory());
            mac.createButton();
            mac.createTextBox();
            Console.WriteLine();
        }

        static void TemplateMethodPattern()
        {
            School school = new School();
            school.Learning();

            Console.WriteLine();

            University university = new University();
            university.Learning();
        }

        static void AdapterPattern()
        {
            Computer computer = new Computer();
            computer.connect(new USB());

            MemoryCard memoryCard = new MemoryCard();
            AdapterUSB adapterUSB = new AdapterUSB(memoryCard);

            computer.connect(adapterUSB);
        }

        static void VisitorPattern()
        {
            Project project = new Project();

            JuniorDev junior = new JuniorDev();
            SeniorDev senior = new SeniorDev();

            project.writtenBy(junior);

            Console.WriteLine();

            project.writtenBy(senior);
        }
    }
}
