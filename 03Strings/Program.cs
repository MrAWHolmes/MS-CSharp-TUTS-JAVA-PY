// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

static string ToTitle(string S)
{
    string T = "";
    for (int i = 0; i < S.Length; i++)
    {
        if (i == 0)
        {
            T = T + S.ToUpper()[i];
        } else if (S[i - 1] == ' ')
        {
            T = T + S.ToUpper()[i];
        }
        else
        {
            T = T + S[i];
        }


    }
    return T;
}

static void main()
{
    string firstName = "Archibald";
    string surname = "Holmes";
    Console.WriteLine($"My full name is {firstName} {surname}");
    Console.WriteLine($"{firstName} is of length {firstName.Length}");
    Console.WriteLine($"{surname} is on length {surname.Length}");

    //additional string handling with left and right stuff:
    string whiteSpace = "       Lots of leading and trailing white space         ";
    Console.WriteLine(whiteSpace);

    //trimming the white space
    string leftTrim = whiteSpace.TrimStart();
    string trimmed = whiteSpace.Trim();
    string rightTrim = whiteSpace.TrimEnd();


    Console.WriteLine($"left trim  = {leftTrim}");
    Console.WriteLine($" trimmed   = {trimmed}");
    Console.WriteLine($"right trim = {rightTrim}");

    // substitution i.e. replace
    string fullName = firstName + " " + surname;
    Console.WriteLine($"full name: {fullName}");

    fullName = fullName.Replace("Archibald", "Kate");
    Console.WriteLine($"full name: {fullName}");

    //changing cases
    Console.WriteLine($"full name to upper: {fullName.ToUpper()}");

    fullName = fullName.ToLower();
    Console.WriteLine($"full name to lower: {fullName.ToLower()}");

    Console.WriteLine($"Fullname is {fullName}");
    Console.WriteLine($"fulle name to title :" + ToTitle(fullName));

    Console.WriteLine($"Fullname is {fullName}");

    // and with input :)
    Console.Write("Enter a string to title case:");
    string demoString = Console.ReadLine();
    Console.WriteLine($"demoString to title :" + ToTitle(demoString));
    
}//main

main();
