using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeStore
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            tbxDestination.Text = Environment.CurrentDirectory;
            ActiveControl = tabScript;
        }

        private void cbxSpecifyDestination_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSpecifyDestination.Checked)
            {
                tbxDestination.Enabled = true;
                btnSetDestinationFolder.Enabled = true;
            }
            else
            {
                tbxDestination.Enabled = false;
                btnSetDestinationFolder.Enabled = false;
            }
        }

        private void btnScript_Click(object sender, EventArgs e)
        {
            GoScript();
        }

        private void tbxServerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Note: This KeyPress event is called when a KeyPress event occurs in *
             * any of the three textboxes on frmSplash. If the key pressed is the  *
             * enter key, this has the same result as clicking the "Script" button */
            if (e.KeyChar == (char)13)
            {
                GoScript();
            }
        }

        public void GoScript()
        {
            /* Note: This class is how to progress in to the program.   *
             * It has been placed in a separate class from the "Script" *
             * button so that it can be called from more than one user  *
             * interaction method.                                      */
            if (tbxServerName.Text != "" && cbxDatabaseName.Text != "")
            {
                frmScript ScriptForm = new frmScript(tbxServerName.Text, cbxDatabaseName.Text, tbxDestination.Text);
                this.Hide();
                ScriptForm.ShowDialog();//Loads the new form as a modal window
                ScriptForm.Dispose();
                this.Show();
            }
            else if (tbxServerName.Text == "")
            {
                lblStatus.Text = "Please input a server name...";
                lblStatus.Update();
                ActiveControl = tbxServerName;
            }
            else if (cbxDatabaseName.Text == "")
            {
                lblStatus.Text = "Please select a database...";
                lblStatus.Update();
                ActiveControl = cbxDatabaseName;
            }
        }

        private void tbxServerName_Leave(object sender, EventArgs e)
        {
            lblStatus.Text = "Retrieving list of available databases...";
            lblStatus.Update();
            cbxDatabaseName.Items.Clear(); //Clear ComboBox of old values

            /* Note: This script currently only supports Windows Integrated Security connections *
             * Support for other kinds of security may be added in a later version.              */
            string ConnectionString = "Data Source=" + tbxServerName.Text + "; Integrated Security=True;";

            DataTable tblDatabases = new DataTable(); //DataTable to hold list of Databases on server
            try
            {
                /* Retrieve list of all databases on specified server */
                using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
                {
                    sqlConn.Open();
                    tblDatabases = sqlConn.GetSchema("Databases");
                    sqlConn.Close();
                }

                /* Remove System Databases */
                string[] arrDelete = new string[5] { "master", "tempdb", "model", "msdb", "SSISDB" };
                foreach (string name in arrDelete)
                {
                    DataRow[] rows = tblDatabases.Select("database_name = '" + name + "'");
                    foreach (DataRow row in rows)
                        row.Delete();
                }

                /* Add databases to ComboBox */
                foreach (DataRow row in tblDatabases.Rows)
                {
                    cbxDatabaseName.Items.Add(row["database_name"]);
                }
                lblStatus.Text = ""; //Clear status
                lblStatus.Update();
            }
            catch (SqlException)//Exceptions thrown by incorrect connection parameters
            {
                MessageBox.Show("Failed to connect to the specified server. Please input a new server name.");
                lblStatus.Text = "Please input a new server name...";
                lblStatus.Update();
                ActiveControl = tbxServerName;
            }
            catch
            {
                throw;
            }
        }

        private void cbxDatabaseName_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = ""; //Clear status
            lblStatus.Update();
        }

        private void btnFindScriptLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();

            myOpenFileDialog.InitialDirectory = Environment.CurrentDirectory;
            myOpenFileDialog.Filter = "CodeStore Master Script File|*_FULL.sql";
            myOpenFileDialog.FilterIndex = 1;
            myOpenFileDialog.RestoreDirectory = true;

            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxDeployScriptLocation.Text = myOpenFileDialog.FileName;
            }
        }

        private void btnSetDestinationFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdDestinationFolder = new FolderBrowserDialog();

            if (fbdDestinationFolder.ShowDialog() == DialogResult.OK)
            {
                tbxDestination.Text = fbdDestinationFolder.SelectedPath;
            }
        }
    }
}