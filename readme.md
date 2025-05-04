## C# Tutorials

1. Resources to learn C#
    - on your browser type www.dot.net 
    - browse and click on learning portal
    - click on [docs] at the top --> click on [C#]

> [!NOTE]
> this will take you straight to the C# learning portal

> [!IMPORTANT]
> We assume you do have dotnet setup on your system. Using visual studio or visual studio code to carry out this exercises

1. Creating a project in C#.
    - create a folder $mkdir -p tutorials/01-hello-world
    - navigate to the hello-world folder (cd tutorials/hello-world)
    - run the command ``` dotnet run ```

2. Working with [Strings]
   a. Concatenation
   - C# is a strongly type language.
   - the '$' sign help to concatenate a string and interpolation of strings occurs by inserting either variables in curly braces {}"
     e.g. Console.WriteLine($("This is string concatenation with interpolation. My name is {firstName} and {lastName}"))

   b. Trimming Strings (removing unwanted spaces)
      syntax: ``` stringToTrim.TrimStart() ```
      > [!NOTE]
      > this is when trimming extra spaces from the start of the string.

