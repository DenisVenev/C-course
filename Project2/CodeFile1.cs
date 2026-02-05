using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Tasks
{

    static void Main()
    {

		int n;
		int curr = 1;
		int prev = 1;

		try
		{

			n = Int32.Parse(Interaction.InputBox("How much numbers do you want to calculate?", "Fibbonachi"));
			for (int i = 0; i < n; i++) {

				MessageBox.Show($"{curr}");
				prev = curr - prev;
				curr = prev + curr;
				
			}
			

		}
		catch
		{
			MessageBox.Show("Maika ti", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
        
    }

}