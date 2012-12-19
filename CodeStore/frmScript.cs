#region Namespaces
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace CodeStore
{
    public partial class frmScript : Form
    {
        /* **************** */
        /* GLOBAL VARIABLES */
        /* **************** */
        static List<string> newFolders = new List<string>();
        static string strServerName;
        static string strDatabaseName;
        static string strDestination;
    
        public frmScript(string srvname, string dbName, string destination)
        {
            InitializeComponent();
            ActiveControl = btnContinue;

            strServerName = srvname;
            strDatabaseName = dbName;
            strDestination = destination;

            tbxServerName.Text = strServerName;
            tbxDBName.Text = strDatabaseName;
            tbxDestination.Text = strDestination;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            lblSubHead.Text = "Scripting " + strDatabaseName;
            grpConfirm.Visible = false;
            grpScript.Visible = true;

            lblSubHead.Update();
            grpConfirm.Update();
            grpScript.Update();
            Script(strServerName, strDatabaseName, strDestination);
            btnClose.Enabled = true;
        }

        private void tbxOutput_TextChanged(object sender, EventArgs e)
        {
            tbxOutput.SelectionStart = tbxOutput.Text.Length;
            tbxOutput.ScrollToCaret();
            tbxOutput.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Scripting the DB
        public void Script(string srvname, string dbName, string destination)
        {
            tbxOutput.Text = "Scripting the " + dbName + " database." + "\r\n";
            if (destination == "")
            {
                destination = Environment.CurrentDirectory + "\\";
            }
            else
            {
                if (destination[destination.Length - 1] != Convert.ToChar("\\"))
                {
                    destination += "\\";
                }
            }

            tbxOutput.Text += "Output directory set to " + destination + "\r\n";

            /* *************************** */
            /* CHECK FOR VALID DESTINATION */
            /* *************************** */

            tbxOutput.Text += "Checking for valid destination directory...\r\n";
            if (!Directory.Exists(destination))
            {
                throw new DirectoryNotFoundException("The specified destination directory does not exist.");
            }
            else
            {
                tbxOutput.Text += "Destination directory is valid.\r\n";
                /* *********************** */
                /* CREATE FOLDER STRUCTURE */
                /* *********************** */
                tbxOutput.Text += "Establishing folder structure...\r\n";
                newFolders.Clear();
                try
                {
                    if (!Directory.Exists(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd")))
                    {
                        Directory.CreateDirectory(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd"));
                        newFolders.Add(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd"));
                        tbxOutput.Text += "Folder Created: " + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + "\r\n";
                    }
                    if (!Directory.Exists(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Tables\"))
                    {
                        Directory.CreateDirectory(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Tables\");
                        newFolders.Add(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Tables\");
                        tbxOutput.Text += "Folder Created: " + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Tables\" + "\r\n";
                    }
                    if (!Directory.Exists(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Views\"))
                    {
                        Directory.CreateDirectory(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Views\");
                        newFolders.Add(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Views\");
                        tbxOutput.Text += "Folder Created: " + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Views\" + "\r\n";
                    }
                    if (!Directory.Exists(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Stored Procedures\"))
                    {
                        Directory.CreateDirectory(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Stored Procedures\");
                        newFolders.Add(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Stored Procedures\");
                        tbxOutput.Text += "Folder Created: " + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Stored Procedures\" + "\r\n";
                    }
                    if (!Directory.Exists(destination + dbName + @"\Programmability\Functions\"))
                    {
                        Directory.CreateDirectory(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Functions\");
                        newFolders.Add(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Functions\");
                        tbxOutput.Text += "Folder Created: " + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Functions\" + "\r\n";
                    }
                }
                catch
                {
                    throw new UnauthorizedAccessException("The program failed to create the backup folders in the specified directory. Please check security settings.");
                }
                tbxOutput.Text += "Folder structure established \r\n";
            }


            /* *************** */
            /* Generate Script */
            /* *************** */
            try //Wrap in try statement to catch incorrect server errors
            {
                tbxOutput.Text += "Connecting to server " + srvname + "...\r\n";
                Server srv;
                srv = new Server(srvname);
                srv.ConnectionContext.LoginSecure = true;

                if (!srv.Databases.Contains(dbName))
                {
                    RemoveFolders();//Clean out folders creating during this run

                    throw new ArgumentException("The specified database could not be found.");
                }

                Database db = new Database();

                db = srv.Databases[dbName];



                Scripter scr = new Scripter(srv);
                Scripter scrFullScript = new Scripter(srv);

                srv.SetDefaultInitFields(typeof(StoredProcedure), "IsSystemObject");

                /* Create Options for the scr Scripter */
                ScriptingOptions options = new ScriptingOptions();
                options.IncludeHeaders = true;
                options.AppendToFile = false;
                options.ToFileOnly = true;
                options.DriAll = true;
                options.IncludeDatabaseContext = true;
                //options.ScriptDrops = true;
                scr.Options = options; //Assign options to scr

                /* Create options for the scrFullScript Scripter */
                ScriptingOptions scopFull = new ScriptingOptions();
                scopFull.IncludeHeaders = true;
                scopFull.AppendToFile = true;
                scopFull.ToFileOnly = true;
                scopFull.DriAll = true;
                scopFull.IncludeDatabaseContext = true;
                scopFull.FileName = destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\"
                    + dbName + "_FULL.sql";
                scrFullScript.Options = scopFull; //Assign options to scrFullScript


                /* ******************* */
                /* CREATE SCRIPT FILES */
                /* ******************* */
                List<string> lstErrors = new List<string>();

                //SCRIPT DATABASE
                Microsoft.SqlServer.Management.Smo.Database[] dbs = new Microsoft.SqlServer.Management.Smo.Database[1];
                tbxOutput.Text += "Scripting Database: " + db + "\r\n";
                dbs[0] = db;

                options.FileName = destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\"
                    + dbName + ".sql";

                scr.Script(dbs);
                scrFullScript.Script(dbs);
                tbxOutput.Text += "Scripting Database Complete.\r\n";

                //SCRIPT TABLES
                Microsoft.SqlServer.Management.Smo.Table[] tbl = new Microsoft.SqlServer.Management.Smo.Table[1];
                tbxOutput.Text += "Scripting Tables...\r\n";
                for (int idx = 0; idx < db.Tables.Count; idx++)
                {
                    if (!db.Tables[idx].IsSystemObject)
                    {
                        tbxOutput.Text += "Scripting Table: " + db.Tables[idx] + "\r\n";
                        tbl[0] = db.Tables[idx];

                        options.FileName = destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Tables\"
                                + tbl[0].Name + ".sql";

                        scr.Script(tbl);
                        scrFullScript.Script(tbl);
                    }
                }
                tbxOutput.Text += "Scripting Tables Complete.\r\n";

                //SCRIPT VIEWS
                Microsoft.SqlServer.Management.Smo.View[] vw = new Microsoft.SqlServer.Management.Smo.View[1];
                tbxOutput.Text += "Scripting Views...\r\n";
                for (int idx = 0; idx < db.Views.Count; idx++)
                {
                    if (!db.Views[idx].IsSystemObject)
                    {
                        tbxOutput.Text += "Scripting View: " + db.Views[idx] + "\r\n";
                        vw[0] = db.Views[idx];
                        
                        options.FileName = destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Views\"
                            + vw[0].Name + ".sql";

                        scr.Script(vw);
                        scrFullScript.Script(vw);
                    }
                }
                tbxOutput.Text += "Scripting Views Complete.\r\n";

                //SCRIPT STORED PROCEDURES
                Microsoft.SqlServer.Management.Smo.StoredProcedure[] proc = new Microsoft.SqlServer.Management.Smo.StoredProcedure[1];
                tbxOutput.Text += "Scripting Stored Procedures...\r\n";
                for (int idx = 0; idx < db.StoredProcedures.Count; idx++)
                {

                    if (!db.StoredProcedures[idx].IsSystemObject)
                    {
                        tbxOutput.Text += "Scripting Stored Procedure: " + db.StoredProcedures[idx] + "\r\n";
                        proc[0] = db.StoredProcedures[idx];

                        options.FileName = destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Stored Procedures\"
                                + proc[0].Name + ".sql";

                        scr.Script(proc);
                        scrFullScript.Script(proc);
                    }

                }
                tbxOutput.Text += "Scripting Stored Procedures Complete.\r\n";

                //SCRIPT FUNCTIONS
                Microsoft.SqlServer.Management.Smo.UserDefinedFunction[] udf = new Microsoft.SqlServer.Management.Smo.UserDefinedFunction[1];
                tbxOutput.Text += "Scripting User Defined Functions...\r\n";
                for (int idx = 0; idx < db.UserDefinedFunctions.Count; idx++)
                {
                    if (!db.UserDefinedFunctions[idx].IsSystemObject)
                    {
                        tbxOutput.Text += "Scripting User Defined Function: " + db.UserDefinedFunctions[idx] + "\r\n";
                        udf[0] = db.UserDefinedFunctions[idx];

                        options.FileName = destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\Programmability\Functions\"
                            + udf[0].Name + ".sql";

                        scr.Script(udf);
                        scrFullScript.Script(udf);
                    }
                }
                tbxOutput.Text += "Scripting User Defined Functions complete.\r\n";

                tbxOutput.Text += "Scripting master file...\r\n";
                try
                {
                    String strFullScript = "";
                    String strFullOutput = "";

                    tbxOutput.Text += "Retrieving full script...\r\n";
                    using (StreamReader sr = new StreamReader(scopFull.FileName))
                    {
                        strFullScript = sr.ReadToEnd();
                    }
                    tbxOutput.Text += "Full script retrieved.\r\n";

                    //strFullOutput = strFullScript;//Temporary

                    string[] arrFullScript = Regex.Split(strFullScript, "GO");

                    foreach (string line in arrFullScript)
                    {
                        if(!line.StartsWith("\r\nALTER TABLE"))
                            strFullOutput += line + "GO\r\n";
                    }

                    foreach (string line in arrFullScript)
                    {
                        if (line.StartsWith("\r\nALTER TABLE"))
                            strFullOutput += line + "GO\r\n";
                    }
                    string strConditionalDrop = "\r\n\r\nIF DB_ID('" + dbName + "') IS NOT NULL\r\nBEGIN\r\n"
                        + "  ALTER DATABASE " + dbName + "\r\n"
                        + "  SET SINGLE_USER\r\n"
                        + "  WITH ROLLBACK IMMEDIATE;\r\n"
                        + "  DROP DATABASE " + dbName + ";\r\n"
                        + "END\r\n";

                    strFullOutput = strFullOutput.Insert(strFullOutput.IndexOf("GO") + 2, strConditionalDrop);

                    tbxOutput.Text += "Writing corrected full script...\r\n";
                    using (StreamWriter sw = new StreamWriter(destination + dbName + "_" + DateTime.Now.ToString("yyyyMMdd") + @"\" + dbName + "_FULL.sql"))
                    {
                        sw.Write(strFullOutput);
                    }
                    tbxOutput.Text += "Full script successfully written.\r\n";
                    tbxOutput.Text += "Scripting master file complete.\r\n";
                }
                catch
                {
                    tbxOutput.Text += "ERROR Scripting Master File Failed.\r\n";
                    lstErrors.Add("Scripting Master File Failed.");
                }

                tbxOutput.Text += "=================================\r\n";
                if (lstErrors.Count == 0)
                    tbxOutput.Text += "SCRIPTING COMPLETED SUCCESSFULLY.\r\n";
                else
                {
                    tbxOutput.Text += "SCRIPTING COMPLETED WITH ERRORS.\r\n";
                    tbxOutput.Text += String.Format("The following {0} errors occurred:\r\n", lstErrors.Count);
                    foreach (string error in lstErrors)
                    {
                        tbxOutput.Text += error + "\r\n";
                    }
                }
                ActiveControl = btnClose;
            }
            catch (ConnectionFailureException) //Error type thrown by attempt to bind invalid server name
            {
                //throw new ConnectionFailureException("A connection to the specified server could not be made. Please check the supplied server name and try again.");
                tbxOutput.Text += "Connection to server failed.\r\n";
                
                RemoveFolders();//Clean out folders creating during this run
                
                tbxOutput.Text += "A connection to the specified server could not be made. Please check the supplied server name and try again.\r\n";
            }
            catch //General Catch-All re-throws error without further handling
            {
                RemoveFolders();//Clean out folders creating during this run
                throw;
            }
        }

        public void RemoveFolders()//Removes folders created during an aborted run of the Script class
        {
            tbxOutput.Text += "Removing new folders...\r\n";
            for (int i = newFolders.Count - 1; i >= 0; i--)
            {
                Directory.Delete(newFolders[i], true);
                tbxOutput.Text += "Folder Removed: " + newFolders[i] + "\r\n";
            }
            tbxOutput.Text += "New folders removed.\r\n";
        }
        #endregion
    }
}
