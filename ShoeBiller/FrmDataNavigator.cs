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
    public partial class FrmDataNavigator : Form
    {


        #region attributes

        // define a DataManager object
        private DataManager dataManager;
        // define position of current record
        public uint position = 0;
        // define totalRecords counter
        public uint totalRecords;
        // define Action to refresh position in parent form
        private Action<uint> action;

        #endregion

        public FrmDataNavigator(string binaryFileName, uint dataSize, Action<uint> action, uint position = 0)
        {
            InitializeComponent();

            // set dataManager object
            dataManager = new DataManager(binaryFileName, dataSize);
            // set position of current record
            this.position = position;
            // set action
            this.action = action;

            // load at first time the total of records
            refreshTotalRecords();
            setTxtRecord();
        }

        #region private functions
        #endregion

        #region public functions

        /// <summary>
        /// refresh totalRecords with data from loaded binary file
        /// </summary>
        public void refreshTotalRecords()
        {
            totalRecords = dataManager.getTotalRecords();
            lblTotalRecords.Text = "N° de registros: " + totalRecords;
        }

        public void setTxtRecord()
        {
            txtRecord.Text = (position + 1).ToString();
        }

        #endregion

        #region events

        /// <summary>
        /// when btnNext was clicked, then increase the position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (position < totalRecords - 1)
            {
                position++;
                action(position);
            }
        }


        #endregion

        /// <summary>
        /// when btnBefore was clicked, then reduce the position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position--;
                action(position);
            }
        }

        /// <summary>
        /// when btnLast was clicked, then set the position at the last position of saved record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            position = totalRecords - 1;
            action(position);
        }

        /// <summary>
        /// when btnFirts was clicked, then set the position at the first position of saved record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            position = 0;
            action(position);
        }

        /// <summary>
        /// when enter key is pressend in txtRecord, then parse position to send in action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecord_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only if key press was enter then refresh position of record to load
            if (e.KeyChar == (char) 13)
            {
                if (int.Parse(txtRecord.Text) > 0 && int.Parse(txtRecord.Text) <= totalRecords)
                {
                    position = uint.Parse(txtRecord.Text) - 1;
                    action(position);
                }
                else
                    MessageBox.Show("El registro número " + txtRecord.Text + " esta fuera de rango, recuerda que solo hay " + totalRecords + " registros guardados.");
            }
        }
    }
}
