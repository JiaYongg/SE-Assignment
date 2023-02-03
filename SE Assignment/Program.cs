while (true)
{

    int main_choice;
    // simple login option
    //Console.WriteLine();
    Console.WriteLine("------------Log in as------------");
    Console.WriteLine("1) Guest");
    Console.WriteLine("2) Hotel Administrator");
    Console.WriteLine("3) Exit");
    Console.WriteLine();

    // Validation to ensure the input are NUMBERS ONLY
    Console.Write("Enter choice: ");
    string main_input = Console.ReadLine();
    bool success = Int32.TryParse(main_input, out main_choice);
    if (!success)
    {
        Console.WriteLine();
        Console.WriteLine("Please Enter Integer Input only!");
        continue;
    }

    // choosing the options
    switch (main_choice)
    {
        case 1:
            Console.WriteLine();
    }
}