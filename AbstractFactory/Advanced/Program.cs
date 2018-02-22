using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DoFactory.GangOfFour.Abstract.Structural
{
    /// MainApp startup class for Structural

    /// Abstract Factory Design Pattern.
    class MainApp

    {
        /// Entry point into console application.

        public static void Main()
        {
            // Abstract factory #1

            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input

            Console.ReadKey();
        }
    }

    /// The 'AbstractFactory' abstract class określa interface
    /// dla operacji tworzących abstrakcyjne produkty
    /// eg. KONTYNENTY

    abstract class AbstractFactory

    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    /// The 'ConcreteFactory1' class dziedziczy z klasy abstract factory
    /// implementuje operacje do stworzenia objektow konkretynch produktow
    /// eg. konkretny KONTYNENT

    class ConcreteFactory1 : AbstractFactory

    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    /// The 'ConcreteFactory2' class

    class ConcreteFactory2 : AbstractFactory

    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    /// The 'AbstractProductA' abstract class
    /// Interfejs dla typu produktu obiektu ROSLINO-MIESO-zerne

    abstract class AbstractProductA

    {
    }

    /// The 'AbstractProductB' abstract class

    abstract class AbstractProductB

    {
        public abstract void Interact(AbstractProductA a);
    }

    /// The 'ProductA1' class

    class ProductA1 : AbstractProductA

    {
    }

    /// The 'ProductB1' class

    class ProductB1 : AbstractProductB

    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    /// The 'ProductA2' class

    class ProductA2 : AbstractProductA

    {
    }

    /// The 'ProductB2' class

    class ProductB2 : AbstractProductB

    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    /// The 'Client' class. Interaction environment for the products.

    class Client

    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        // Constructor

        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}