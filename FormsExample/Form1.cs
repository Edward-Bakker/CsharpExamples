using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExample
{
    public partial class FormExample : Form
    {
        public FormExample()
        {
            //This is the start of a form, do not remove this. It will initialize all UI components.
            InitializeComponent();
        }

        /// <summary>
        /// Eventhandler for the plusCalculateButton click event.
        /// When the button is clicked, the calculation will be made
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plusCalculateButton_Click(object sender, EventArgs e)
        {
            //We need to convert the input of type "decimal" to "string" as that is what the label expects.
            plusOutputLabel.Text = Convert.ToString(plusInputL.Value + plusInputR.Value);
        }
    }
}
