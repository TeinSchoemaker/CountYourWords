using System;
using System.IO;

public class ReadInput {

    private readonly string _inputPath;

    public ReadInput(string inputPath) {

        _inputPath = inputPath;
    }

    public string Read() { 

        return File.ReadAllText(_inputPath);
    }
}