using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;

class DialogDemo
{

    static void Main()
    {

        string dayWeek = Interaction.InputBox("Day of the week (with words):", 
            "Day");
        string month = Interaction.InputBox("Month (with words):",
            "Month...");
        int date = Int32.Parse(Interaction.InputBox("Date (with number):",
            "Date"));

        MessageBox.Show($"Today is {dayWeek} {date} {month}",
            "Today",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);
        

    }

}