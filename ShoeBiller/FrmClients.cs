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
    public partial class FrmClients : Form
    {

        #region attributes

        // define data navigator
        private FrmDataNavigator frmDataNavigator;
        // define DataManager object
        private DataManager dataManager;
        // position of current record
        private int position = 0;
        // define a client object to load data of saved record
        private Client client;

        #endregion

        public FrmClients()
        {
            InitializeComponent();

            // set dataManager object
            dataManager = new DataManager(Client.binaryFileName, Client.dataSize);

            // pending load last setup from system regis

            // calls
            setStateControls(false);
            mountDataNavigator();
            loadRecord();
        }

        #region private functions

        /// <summary>
        /// to set the enable state of controls
        /// </summary>
        /// <param name="state">the new state to set in each control</param>
        private void setStateControls(bool state)
        {
            txtNuip.Enabled = state;
            txtNames.Enabled = state;
            txtSurnames.Enabled = state;
            txtPhone.Enabled = state;
            txtEmail.Enabled = state;
        }

        /// <summary>
        /// to clear data of form
        /// </summary>
        private void clearDataForm()
        {
            txtNuip.Text = "";
            txtNames.Text = "";
            txtSurnames.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        /// <summary>
        /// to mount and show de data navigator form
        /// </summary>
        private void mountDataNavigator()
        {
            frmDataNavigator = new FrmDataNavigator(Client.binaryFileName, Client.dataSize, refreshPosition, (uint) position)
            {
                TopLevel = false,
                TopMost = true
            };
            // clear panel and mount DataNavigator form
            panel2.Controls.Clear();
            panel2.Controls.Add(frmDataNavigator);
            frmDataNavigator.Show();
        }

        #endregion

        #region public functions

        /// <summary>
        /// load the record at position
        /// </summary>
        public void loadRecord()
        {
            client = dataManager.readClient((uint) position);
            txtNuip.Text = client.Nuip;
            txtNames.Text = client.Names;
            txtSurnames.Text = client.Surnames;
            txtPhone.Text = client.Phone;
            txtEmail.Text = client.Email;
        }

        #endregion

        #region events

        /// <summary>
        /// event action to execute from child and update record position to read and edit if is necessary
        /// </summary>
        /// <param name="position"></param>
        public void refreshPosition(uint position)
        {
            this.position = (int) position;
            frmDataNavigator.setTxtRecord();
            loadRecord();
        }

        /// <summary>
        /// when btnAdd was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // enable controls and clear data of form
            setStateControls(true);
            clearDataForm();
            position = -1;
        }

        /// <summary>
        /// when btnEdit was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // enable controls of form
            setStateControls(true);
        }

        /// <summary>
        /// when btnSave was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // reset client object and put form data in attributes
            client = new Client();
            client.Nuip = txtNuip.Text;
            client.Names = txtNames.Text;
            client.Surnames = txtSurnames.Text;
            client.Phone = txtPhone.Text;
            client.Email = txtEmail.Text;

            // put form data into string array
            string[] data = client.dataAttributesToArray();
            // use dataManager object to save data
            dataManager.saveRecord(position, data);
            // disable controls and clear data of form
            setStateControls(false);
            // refresh data from frmDataNavigator
            frmDataNavigator.refreshTotalRecords();
            // set position at last position of frmDataNavigator
            if (position == -1)
            {
                frmDataNavigator.position = frmDataNavigator.totalRecords - 1;
                frmDataNavigator.setTxtRecord();
                position = (int) frmDataNavigator.position;
            }

            // note: when is new record is neccessary set position at last record
        }

        #endregion

    }
}
