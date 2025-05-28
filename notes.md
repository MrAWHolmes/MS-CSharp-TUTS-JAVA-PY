REF: https://learn.microsoft.com/en-us/dotnet/csharp/

[A] C# 101  Video Series - Legacy with Creator Scott Hanselman --> https://www.youtube.com/playlist?list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN 
 >>> Videos:  https://youtu.be/BM4CHBmAPh4?si=KVm8iCLEvRo5Ln-Y 
 >>> NoteBooks : https://github.com/dotnet/csharp-notebooks?WT.mc_id=youtube-35129-website

[03] String Basics : w/s == white space i.e. " " --> https://youtu.be/uGlotGAv4o4 
    Some cool Java String notes here -> https://books.trinket.io/thinkjava/chapter9.html 

    STRING CONCEPTS:
     Concept                    C# Notes                                Java Notes                                  Python
      String Data Type          string                                      String                                      str()
      Concatenation             + and +=                                    + and +=                                    + and +=
      Length                    .Lenght // string property                  .length() // method                         len() # function
      Interpolated Strings      $"My string is {myStr}"                     String.format("My string is %s", myStr)     f"My string is {myStr}"
      Remove bookend w/s       .Trim()  // string method                   .trim() // String Method                     .strip()  # method
      Remove leading w/s       .TrimStart() // string method               .replaceAll("^\\s+", "") // uses RE          .lstrip() # method
      Remove trailing w/s      .TrimEnd()   // string method               .replaceAll("\\s+$", "") // uses RE          .rstrip() # method
      to upper case            .ToUpper()   // Method                      .toUpperCase()          // method            .upper()  # method
      to lower case            .ToLower()   // Method                      .toLowerCase()           // method           .lower()  # method     

    CODE ELEMENTS:
    Concept                    C# Notes                                Java Notes                                  Python
      output                    Console.WriteLine();                      system.out.println();                       print()
      input                     string inS = Console.ReadLine();          import java.util.Scanner;                   inStr = input()  
                                                                          Scanner scanner = new Scanner(System.in);       
                                                                          String inStr = scanner.nextLine();  
                                                                          Scanner.close();

                                                                                                                                                                                                                         public class Strings03 {         
     main                       static void main(){...}                  public static void main(String[] args) {..}    def main():
                                                                                                                            pass

    Title Text                  // user defined function                // user defined method                          .title() # method
                                static string ToTitle(string S){..}     public static String toTitle(String s) {..}

    iterate over string        for (int i = 0; i < S.Length; i++){..}  for (int i = 0; i < s.length(); i++) {..}     for i in range(len(s)):
                                                                                                                        pass

    Char by char iteration       T+= S[i];                              T+= S.charAt(i);// S[i] compole error!       T += S[i]

/!\ JAVA NOTE: Java class name must match the code file name Eg. class Strings03 for instance...

[04] Searching Strings --> https://www.youtube.com/watch?v=JL30gSE3WaQ&list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN&index=4&t=20s&pp=iAQB 
Concept                    C# Notes                                Java Notes                                  Python
Boolean data type         bool value = true;                       boolean value = true;                      value = True
string interpolation      var  value2 = false;                     boolean value2 = false;                    value2 = False
of boolean               // var dyn types?

contains                string.contians(substring)->bool        String.contains(substring) -> boolean     result = substring in string

starts with             string.StartsWith(substring)->bool      String.startsWith(substring) -> boolean   result = string.startswith(substring)

ends with               string.EndsWith(substring)->bool      String.endsWith(substring) -> boolean   result = string.endswith(substring)

[B] C# for Beginners - More recent - modernised --> links to CodeAcademy

[C] C# Code Academy Cert --> https://devblogs.microsoft.com/dotnet/announcing-foundational-csharp-certification/ 

