// See https://aka.ms/new-console-template for more information

static void main()
{
    // declare and simple processing    
    Console.WriteLine("Static assignments : ");
    int a = 18;
    int b = 6;
    string op = "?";

    //addition
    int result = a + b;
    op = "+";
    Console.WriteLine($"{a}{op}{b} = {result}");

    // subtraction:
    result = a - b;
    op = "-";
    Console.WriteLine($"{a}{op}{b} = {result}");

    // multiplication:
    result = a * b;
    op = "*";
    Console.WriteLine($"{a}{op}{b} = {result}");


    // division: int / int is div!
    result = a / b;
    op = "/";
    Console.WriteLine($"{a}{op}{b} = {result}");

    // floating point division with ints
    float fresult = (float)a / (float)b;
    op = "/";
    Console.WriteLine($"{a}{op}{b} = {fresult}");

    // mod:
    result = a % b;
    op = "%";
    Console.WriteLine($"{a}{op}{b} = {result}");

    // interactive input now:
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("User inputs  : ");
    Console.Write("Enter integer value for a:");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter integer value for b:");
    b = Convert.ToInt32(Console.ReadLine());
    
    //addition
    result = a + b;
    op = "+";
    Console.WriteLine($"{a}{op}{b} = {result}");

    // subtraction:
    result = a - b;
    op = "-";
    Console.WriteLine($"{a}{op}{b} = {result}");

    // multiplication:
    result = a * b;
    op = "*";
    Console.WriteLine($"{a}{op}{b} = {result}");


    // division: int / in tis div!
    result = a / b;
    op = "/";
    Console.WriteLine($"{a}{op}{b} = {result}");

    // floating point division with ints
    fresult = (float)a / (float) b;
    op = "/";
    Console.WriteLine($"{a}{op}{b} = {fresult}");

    // mod:
    result = a % b;
    op = "%";
    Console.WriteLine($"{a}{op}{b} = {result}");
    
}


main();
