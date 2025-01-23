// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// STEP 1
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

// STEP 2
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

// STEP 3
int p = (l + m) / n;
int q = (l + m) % n;
Console.WriteLine($"quotient: {p}");
Console.WriteLine($"remainder: {q}");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}.");
int what = min - 3;
Console.WriteLine($"This is an example of underflow: {what}");

//STEP 4
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

// STEP 5
decimal MAX = decimal.MaxValue;
decimal MIN = decimal.MinValue;
Console.WriteLine($"The range of decimal is {MIN} to {MAX}.");
r = 1.0;
s = 3.0;
Console.WriteLine(r / s);
decimal v = 1.0M;
decimal w = 3.0M;
Console.WriteLine(v / w);
double radius = 2.50;
double area = Math.PI*(Math.Pow(radius,2));
Console.WriteLine(area);

// STEP 6
radius = 2.50;
area = Math.PI*radius*radius;
Console.WriteLine(area);