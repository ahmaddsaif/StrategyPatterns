// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using BehaviourPattern;

Context context = new Context(new ConcreteStrategyA());
context.DoWork();

context.SetStrategy(new ConcreteStrategyB());
context.DoWork();