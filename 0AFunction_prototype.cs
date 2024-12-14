// Function Prototype
//Addition using function

//1. Return Type +  ( Paramerter / Argument )
int PerformAddition( int a, int b){
    int sum = a + b;
    return sum;
}

int sum = PerformAddition(30, 30);
Console.WriteLine ("Addition: " + sum);


//2. Return Type + No ( Parameter / Argument )
int PerformSubtraction(){
    //initialization
    int a = 10;
    int b = 30;
    int sub = a - b;
    return sub;
}

int sub= PerformSubtraction();
Console.WriteLine("Subtraction " + sub );
// or instead ---> 
//Console.WriteLine(PerformSubtraction());


//3. No Return Type + ( Paramerter/Argument)

void PerformMultipication(int a, int b){
    int mul = a * b;
    Console.WriteLine("Subtraction:" + mul);
}

PerformMultipication(20,5);


// 4. No Return Type + No ( Parameter/Argument)
void PerformDivision(){
    int a = 10;
    int b = 100;
    int div = b/a;
    Console.WriteLine("Division: " + div);
}

PerformDivision();