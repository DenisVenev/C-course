using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class DialogDemo
{

    static void Main()
    {

        string name = Interaction.InputBox("What's your name?",
            "Let's meet...");

        MessageBox.Show($"Nice to meet you, {name}!", 
            "We are friends!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Asterisk);

    }

}