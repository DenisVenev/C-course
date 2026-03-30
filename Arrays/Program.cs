using System;

class Arrays {

    static void Main() {

        int n = 10;
        char[] symbs = new char[n];
        symbs[0] = 'a';

        for (int i = 1; i < n; i++) {
            symbs[i] = (char)(symbs[i - 1] + 2);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(symbs[i]);
        }

        for (int i = n-1; i >= 0; i--)
        {
            Console.WriteLine(symbs[i]);
        }

    }

}