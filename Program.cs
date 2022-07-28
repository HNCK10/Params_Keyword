// See https://aka.ms/new-console-template for more information
//Params keyword = a method parameter that takes a variable number of arguements.
//The parameter must be a single dimensional array.
//----------------------------------------------------------------------------------
//now after you have created the params keyword method you can add any number of inputs 
//and it will just add to the arraye
//-------------------------------------------
double total = CheckOut(3.88, 5.75, 15);
Console.WriteLine(total);
total = CheckOut(3.88, 5.75, 15,58);
Console.WriteLine(total);
total = CheckOut(3.88, 5.75, 15, 58, 60);
Console.WriteLine(total);
Console.ReadKey();
//static double CheckOut(double a)
//{
//    return a;
//}
//instead of doing this we use the params keyword
//-----------------------------------------------------
//static double Checkout(double a, double b)
//{
//    return a + b;
//}
//static double Checkout(double a, double b, double c)
//{
//    return a + b + c;
//}
//static double Checkout(double a, double b, double c, double d)
//{
//    return a + b + c + d;
//}
//need to iterate over this array and create a total
static double CheckOut(params double[] prices)
{
    double total = 0;
    foreach(double price in prices)
    {
        total += price;
    }
    return total;
}