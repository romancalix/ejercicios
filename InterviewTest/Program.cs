// See https://aka.ms/new-console-template for more information
using InterviewTest;
using InterviewTest.Strategies;

Console.WriteLine("Hello, World!");


//var  strategy = new FizzBuzz();
var strategy = new Anagrama();
var context = new Context(strategy);
context.ExecuteStrategy();