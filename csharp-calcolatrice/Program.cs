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


// Dichiaro i miei numeri double

double e = -1.2;
double f = 3.5;
double g = -2.5;
double h = 6.5;

Console.WriteLine("----------------------------------------------------");

Console.WriteLine($"The sum of these two numbers {f} e {h} is: {CalcoliHelper.SumNumber(f, h)};");

Console.WriteLine($"The subtraction of these two numbers {h} e {f} is: {CalcoliHelper.SubNumber(h, f)};");

Console.WriteLine($"The multiplication of these two numbers {f} e {h} is: {CalcoliHelper.MultiNumber(f, h)};");

Console.WriteLine($"The absolute value of {e} is : {CalcoliHelper.AbsoluteNumber(e)};");

Console.WriteLine($"The smaller of these two numbers {f} e {h} is: {CalcoliHelper.MinNumber(f, h)};");

Console.WriteLine($"The greater of these two numbers {f} e {h} is: {CalcoliHelper.MaxNumber(f, h)};");