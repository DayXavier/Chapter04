double a = 4.5;
double b = 2.5;
double anwser = Add(a, b);

WriteLine($"{a} + {b} = {anwser}");
WriteLine("Press Enter to end the app.");
ReadLine(); // Wait for user to press Enter.

double Add(double a, double b)
{
    return a + b; // Delibrate bug!
}
    