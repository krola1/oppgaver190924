namespace oppgaver190924;

class Program
{
    static void Main(string[] args)
    {
        Calucator calculator = new Calucator();
        Console.WriteLine("Første tall:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("operator");
        string o = Console.ReadLine();
        Console.WriteLine("Andre tall:");
        double b = Convert.ToDouble(Console.ReadLine());
     switch (o)
     {
        case "+":
            Console.WriteLine(calculator.Add(a,b));
            break;
        case "-":
            Console.WriteLine(calculator.Subtract(a,b));
            break;
        case "/":
            Console.WriteLine(calculator.Devide(a,b));
            break;
        case "*":
            Console.WriteLine(calculator.Multiply(a,b));
            break;
    
        
        default:
        Console.WriteLine("Ugyldig operator");
        break;
     }
        //Console.WriteLine(calculator.Multiply(Convert.ToDouble(Console.ReadLine()),Convert.ToDouble(Console.ReadLine())));
    }
}
