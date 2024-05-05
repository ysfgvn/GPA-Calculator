// See https://aka.ms/new-console-template for more information
Console.WriteLine("For each exam/assignment you will take, a separate percentage will be requested from you. Your average passing grade will be calculated according to the percentage you enter.");
Console.WriteLine("How many exam/assigment you will add?");
int Counter = Convert.ToInt32(Console.ReadLine());

double TotalPoint =0;
double Avarage =0;
for (int i = 0; i < Counter; i++)
{
    Console.WriteLine($"Please enter your {i+1}. exam/assigment point");  double Point = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Please enter {i+1} exam/assigment % (percent)"); double Percent = Convert.ToDouble(Console.ReadLine());
    Percent /=100;
    TotalPoint += (Point*Percent);
    Avarage += Percent;
}

double Final = TotalPoint/Avarage;
if (Final < 29)       { Console.WriteLine("Your Point is " + Final + " (FF). Unfortunately you didint pass the lesson. See you next year... ");}
else if (Final <= 39) { Console.WriteLine("Your Point is " + Final + " (FD) Unfortunately you didint pass the lesson. See you next year... ");}
else if (Final == 49) { Console.WriteLine("Your Point is " + Final + " (DD). Almost you didint pass the lesson mate. You must do your best... ");}
else if (Final <= 59) { Console.WriteLine("Your Point is " + Final + " (DC). Bro you should forget the ex gf just focus your lesson and gym bro... ");}
else if (Final <= 69) { Console.WriteLine("Your Point is " + Final + " (CC). its okey no worries... ");}
else if (Final <= 74) { Console.WriteLine("Your Point is " + Final + " (CB). Well done mate... ");}
else if (Final <= 79) { Console.WriteLine("Your Point is " + Final + " (BB). Wow you almost perfect... ");}
else if (Final <= 89) { Console.WriteLine("Your Point is " + Final + " (BA). You are the best... ");}
else if (Final <= 100){ Console.WriteLine("Your Point is " + Final + " (AA).  You are a masterclass... ");}
else                  { Console.WriteLine("You did a misstake please restart the program");}





