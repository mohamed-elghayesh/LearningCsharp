using System;
using System.Windows.Forms;

namespace LearningCsharp
{
    class myEvents
    {
        static void Main(string[] args)
        {
            #region GUI Button click event
            Button button = new Button();
            button.Text = "Press Me";
            button.Click += Button_Click;

            // Button_Click(button, null);

            Form form = new Form();
            form.Controls.Add(button);
            Application.Run(form);
            #endregion

            #region Console events
            

            #endregion
        }

        private static void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The button was clicked!");
        }
    }
}
