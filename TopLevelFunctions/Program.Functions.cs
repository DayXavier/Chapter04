partial class Program
{
    static void WhatsMyNamespace() // Define a static function
    {
        WriteLine("Namespace of a Program class: {0}",
            arg0: typeof(Program).Namespace ?? "Null");
    }
}