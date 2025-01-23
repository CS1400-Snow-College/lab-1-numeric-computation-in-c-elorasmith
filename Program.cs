// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);
int d = a - b;
Console.WriteLine(d);
int e = a * b;
Console.WriteLine(e);
int f = a/b;
Console.WriteLine(f);

int g = 5;
int h = 4;
int i = 2;
int j = (g + h) * i;
Console.WriteLine(j);
int k = 6 + h *(a/i)-12 * g;
Console.WriteLine(k);
int l = 7;
int m = 4;
int n = 3;
int o = (l + m)/n;
Console.WriteLine(o);

int p = (l + m) / n;
int q = (l + m) % n;
Console.WriteLine($"quotient: {p}");
Console.WriteLine($"remainder: {q}");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}.");
int what = min - 3;
Console.WriteLine($"This is an example of underflow: {what}");

double r = 5;
double s = 4;
double t = 2;
double u = (r + s) / t;
Console.WriteLine(u);
r = 19;
s = 23;
t = 8;
u = (r + s) / t;
Console.WriteLine(u);
double Max = double.MaxValue;
double Min = double.MinValue;
Console.WriteLine($"The range of double is {Min} to {Max}");
double third = 1.0/3.0;
Console.WriteLine(third);
int Third = 1/3;
Console.WriteLine(Third);
r = 56.89;
s = 63;
u = r-s;
Console.WriteLine(u);
