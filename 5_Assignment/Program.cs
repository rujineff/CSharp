//Un-comment below code and fix the issues
//Push to github

int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    int nextnumber = first + second;
    first = second;
    second = nextnumber;
    
    
    if(count == 0) {
        return nextnumber;
    
    }else{
        return RecursiveFibonacci(first, second, count);
    }
}

int lastFibo = RecursiveFibonacci(1,1,5);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine(); 



