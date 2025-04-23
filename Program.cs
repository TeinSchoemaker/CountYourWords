using System;
using System.Linq.Expressions;

class Program {

    static void Main(string[] args) {
        var reader = new ReadInput("Input/input.txt");

        string inputContent = reader.Read();

        Console.WriteLine(inputContent);
    }
}