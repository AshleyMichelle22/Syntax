// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





var answer = 4;  // inferred
var response ="";

if (answer < 9)
{
    response = answer + " is less than nine";
}
else
{
    response = answer + "greater than or equal to nine";
}
 Console.WriteLine(response);



var answer = 4;  //string interpolation
var response = "";

if (answer < 9)
{
    response = ($"{answer} is less than nine");
}
else
{
    response = ($"{answer} is greater than or equal to nine";
}
Console.WriteLine(response);



var response2 = (answer < 9) ?  // Ternary Operator
    $"{answer} is less then nine" :
    $"{answer} is greater then or equal to nine"; 
