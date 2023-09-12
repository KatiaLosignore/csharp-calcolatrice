// See https://aka.ms/new-console-template for more information

using csharp_calcolatrice;

// Dichiaro i miei numeri interi

int a = -5;
int b = 10;
int c = 20;
int d = 15;



Console.WriteLine($"The sum of these two numbers {b} e {c} is: {CalcoliHelper.SumNumber(b, c)};");

Console.WriteLine($"The subtraction of these two numbers {c} e {d} is: {CalcoliHelper.SubNumber(c, d)};");

Console.WriteLine($"The multiplication of these two numbers {b} e {c} is: {CalcoliHelper.MultiNumber(b, c)};");

Console.WriteLine($"The absolute value of {a} is : {CalcoliHelper.AbsoluteNumber(a)};");

Console.WriteLine($"The smaller of these two numbers {b} e {c} is: {CalcoliHelper.MinNumber(b, c)};");

Console.WriteLine($"The greater of these two numbers {c} e {d} is: {CalcoliHelper.MaxNumber(c, d)};");

