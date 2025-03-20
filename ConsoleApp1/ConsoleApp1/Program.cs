using ConsoleApp1.BehavioralPatterns.Command;
using ConsoleApp1.BehavioralPatterns.Observer;
using ConsoleApp1.BehavioralPatterns.Strategy;
using ConsoleApp1.CreationalPatterns.AbstractFactory;
using ConsoleApp1.CreationalPatterns.FactoryMethod;
using ConsoleApp1.CreationalPatterns.Singleton;
using ConsoleApp1.StructuralPatterns.Adapter;
using ConsoleApp1.StructuralPatterns.Composite;
using ConsoleApp1.StructuralPatterns.Facade;

bool executeAgain = true;

do
{
    Console.WriteLine("Qual projeto você quer testar?");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Padrões Criacionais");
    Console.WriteLine("------------------------------");
    Console.WriteLine("A - Abstract Factory");
    Console.WriteLine("B - Factory Method");
    Console.WriteLine("C - Singleton");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Padrões Estruturais");
    Console.WriteLine("------------------------------");
    Console.WriteLine("D - Adapter");
    Console.WriteLine("E - Facade");
    Console.WriteLine("F - Composite");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Padrões Comportamentais");
    Console.WriteLine("------------------------------");
    Console.WriteLine("G - Command");
    Console.WriteLine("H - Strategy");
    Console.WriteLine("I - Observer");
    Console.Write("Resposta: ");
    string answer = Console.ReadLine()!;
    Console.Clear();

    switch (answer.ToUpper())
    {
        case "A":
            executeAgain = false;
            AbstractFactoryExecutor.Execute();
            break;
        case "B":
            executeAgain = false;
            FactoryMethodExecutor.Execute();
            break;
        case "C":
            executeAgain = false;
            SingletonExecutor.Execute();
            break;
        case "D":
            executeAgain = false;
            AdapterExecutor.Execute();
            break;
        case "E":
            executeAgain = false;
            FacadeExecutor.Execute();
            break;
        case "F":
            executeAgain = false;
            CompositeExecutor.Execute();
            break;
        case "G":
            executeAgain = false;
            CommandExecutor.Execute();
            break;
        case "H":
            executeAgain = false;
            StrategyExecutor.Execute();
            break;
        case "I":
            executeAgain = false;
            ObserverExecutor.Execute();
            break;
        default:
            executeAgain = true;
            Console.WriteLine("Padrão escolhido errado. Para escolher novamente, aperte um botão...");
            Console.ReadKey();
            Console.Clear();
            break;
    }
} while (executeAgain); 
