using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Tasks
{

    static void Main()
    {

        int num, reminder5, reminder7;
        string result5, result7;

        num = Int32.Parse(Interaction.InputBox("Input a whole number", "A Project"));

        reminder5 = num % 5;
        reminder7 = num % 7;

        bool remi = num % 5 == 2 && num % 7 == 1;

        result5 = remi == true ? "Yuor number meet the requirement!" : "Your number doesn't meet the requirements!";

        MessageBox.Show($"{result5}", "Dividing by 5 and 7", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);

    }

}