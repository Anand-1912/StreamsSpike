
using System.Text;

//using (FileStream fs = new("Input.txt", FileMode.Open, FileAccess.Read))
//{
//    byte[] bytes = new byte[fs.Length];

//    await fs.ReadAsync(bytes, 0, (int)fs.Length, CancellationToken.None);

//    Console.WriteLine(Encoding.UTF8.GetString(bytes, 0, bytes.Length));
//}

using (StreamReader sr = new("Input.txt"))
{
    string input = await sr.ReadToEndAsync();
    Console.WriteLine(input);
}

using (StreamReader sr = new("Input.txt"))
{   
    string? line;
    while((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

using (StreamReader sr = new("Input.txt"))
using (StreamWriter sw = new("Output.txt", true))
{
    string input = await sr.ReadToEndAsync();
    await sw.WriteLineAsync(input);
}

using (HttpClient httpClient = new())
{
    var stream = await httpClient.GetStreamAsync("https://www.google.com/");

    using StreamReader streamReader = new(stream);
    
    string? line = await streamReader.ReadToEndAsync();

    using StreamWriter streamWriter = new(path: "Google.txt", append: true);

    streamWriter.WriteLine(line);
}