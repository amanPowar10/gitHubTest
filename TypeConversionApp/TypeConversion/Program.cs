


Console.Write("What is your age: ");
String? ageText = Console.ReadLine();
//Console.Write(ageText+15);

//int age = int.Parse(ageText);
bool isValidInt = int.TryParse(ageText, out int age);
//if (isValidInt)
  //  Console.WriteLine(age);
//else
  //  Environment.Exit(0);



Console.Write($"This is valid: {isValidInt}. The number was {age} ");
//if we enter invalid number it prints default value of integer as age which is zero
//Console.Write(age+15);


//another way for converting types
double testDouble = age; //works fine because you can store and int in double since nothing is getting lost here
decimal testDecimal = (decimal)testDouble; //this is called cast