

// F(0) = 0, F(1) = 1
// F(n) = F(n - 1) + F(n - 2), for n > 1.
public class Fibonacci {
    public int Fib(int n) {

        if (n == 0)
            return 0;
        
        if (n == 1)
            return 1;
        
        return Fib(n-1) + Fib(n-2);
    }
}