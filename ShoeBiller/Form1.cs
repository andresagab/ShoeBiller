using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeBiller
{
    public partial class Form1 : Form
    {

        #region attributes

        // define Clients form
        private FrmClients frmClientsForm;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region events

        /// <summary>
        /// when this button is clicked open your form into panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // set frmClientsForm with properties
            frmClientsForm = new FrmClients()
            {
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            // clear panel and add the form
            panel.Controls.Clear();
            panel.Controls.Add(frmClientsForm);
            frmClientsForm.Show();
        }


        #endregion

    }
}
