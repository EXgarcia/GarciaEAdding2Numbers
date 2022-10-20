//Elizar Garcia
//10-18-22
//Mini challenge #2 "Add 2 Numbers"
//We will prompt the user to enter two number so we can add them and then display the sum in the console


Console.Clear();

string numOne ="";
string numTwo ="";
int num1 = 0;
int num2 = 0;
string end ="";
int t = 0;
bool realNum1 = true;
bool realNum2 = true;

while(end != "STOP"){
    Console.WriteLine("Ay Foo let's add some numbers.\nGive me your first number Foo. ");
    numOne = Console.ReadLine();
    realNum1 = Int32.TryParse(numOne, out num1);

    if(realNum1 == false)
    {
        Console.WriteLine("Okay foo stop playing. Game over aye.");
        break;
    }

    Console.WriteLine("Okay, now your next number Foo. *whistle noises*");
    numTwo = Console.ReadLine();
    realNum2 = Int32.TryParse(numTwo, out num2);

    if(realNum1 == true && realNum2 == true )
    {
        t = num1 + num2;

        Console.WriteLine("The sum of your numbers is " + (num1 + num2) );
    }else{
        Console.WriteLine("Stop playing around eyy. Game over Foo.");
        break;
    }
    Console.WriteLine("To end this foo, just enter STOP eyy.");
    end = Console.ReadLine().ToUpper();
}

