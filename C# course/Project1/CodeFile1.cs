using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;

public class Project
{

    static void Main()
    {

        double n = 0;
        double sum = 0;
        double i = 0;

        n = Double.Parse(Interaction.InputBox("Input a number"));

        do
        {
            sum += i * i;
            i++;
        } while (i <= n);

        //(n*((n+1)*(2*n+1)))/6
        MessageBox.Show($"The sum of the even numbers is: {sum}");

    }

}