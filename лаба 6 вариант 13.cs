using System;
using System.IO;
using Newtonsoft.Json;


interface IDataReader<T>
{
    T Read(string filePath);
}


class CsvReader<T> : IDataReader<T>
{
    public T Read(string filePath)
    {

        Console.WriteLine("Reading CSV file: " + filePath);

        return default(T);
    }
}


class JsonReaderDecorator<T> : IDataReader<T>
{
    private readonly IDataReader<T> _dataReader;

    public JsonReaderDecorator(IDataReader<T> dataReader)
    {
        _dataReader = dataReader;
    }

    public T Read(string filePath)
    {

        Console.WriteLine("Reading JSON file and decorating: " + filePath);
        T jsonData = JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        return jsonData;
    }
}

class Program
{
    static void Main()
    {

        IDataReader<string> csvReader = new CsvReader<string>();
        IDataReader<string> jsonDecorator = new JsonReaderDecorator<string>(csvReader);

        string csvData = csvReader.Read("example.csv");
        string jsonData = jsonDecorator.Read("example.json");

        Console.WriteLine("CSV Data: " + csvData);
        Console.WriteLine("JSON Data: " + jsonData);
    }
}
