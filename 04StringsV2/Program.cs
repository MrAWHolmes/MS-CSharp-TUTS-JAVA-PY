// See https://aka.ms/new-console-template for more information

static void main()
{
    string songLyrics = "You say goodbye, and I say hello.";
    bool value1 = true;
    var value2 = false;

    //.Contains() method
    var result = songLyrics.Contains("goodbye");
    Console.WriteLine(result);
    Console.WriteLine(songLyrics.Contains("greetings"));

    //StartsWith()
    var begin1 = songLyrics.StartsWith("You");
    Console.WriteLine($"\"{songLyrics}\" starts with \"You\" : {begin1}");

    bool begin2 = songLyrics.StartsWith("hello");
    Console.WriteLine($"\"{songLyrics}\" starts with \"hello\" : {begin2}");

    //EndsWith()
    var end1 = songLyrics.EndsWith("hello.");
    Console.WriteLine($"\"{songLyrics}\" ends with \"hello.\" : {end1}");

    var end2 = songLyrics.EndsWith("say");
    Console.WriteLine($"\"{songLyrics}\" ends with \"say\" : {end2}");
}

main();