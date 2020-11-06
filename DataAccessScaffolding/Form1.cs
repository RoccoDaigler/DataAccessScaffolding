using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessScaffolding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecuteScaffoldSQLSP_Click(object sender, EventArgs e)
        {
            Report Report = new Report();
            Scaffolding scaffolding = new Scaffolding();
            DataSet ds;
            string table_name = txtScaffoldSQLSPTable.Text;
            txtScaffoldSQLSPOutput.Text = "";
            string output = "";

            if (table_name == "")
            {
                //entire db
                Report.OpenConnections();
                ds = Report.retrieve_db_table_summary();
                Report.CloseConnections();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    output = output + scaffolding.WriteSQLSP((string)row["table_name"]);
                }
            }
            else
            {
                //just this table
                output = scaffolding.WriteSQLSP(table_name);
            }

            txtScaffoldSQLSPOutput.Text = output;
        }

        private void btnExecuteScaffoldModel_Click(object sender, EventArgs e)
        {
            Report Report = new Report();
            Scaffolding scaffolding = new Scaffolding();
            DataSet ds;

            string tableName = txtScaffoldModelsTable.Text;
            string ns = txtScaffoldModelNS.Text;
            bool isEntireDB = chkScaffoldModelEntireDB.Checked;

            if (isEntireDB)
            {
                Report.OpenConnections();
                ds = Report.retrieve_db_table_summary();
                Report.CloseConnections();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    scaffolding.buildModel((string)row["table_name"], ns);
                }
            }
            else
            {
                scaffolding.buildModel(tableName, ns);
            }

            MessageBox.Show("Complete!");
        }

        private void btnExecuteScaffodDataAccess_Click(object sender, EventArgs e)
        {
            Report Report = new Report();
            Scaffolding scaffolding = new Scaffolding();
            DataSet ds;

            string tableName = txtScaffoldDataAccessTable.Text;
            string ns = txtScaffoldDataAccessNS.Text;
            bool isEntireDB = chkScaffoldDataAccessEntireDB.Checked;

            if (isEntireDB)
            {
                Report.OpenConnections();
                ds = Report.retrieve_db_table_summary();
                Report.CloseConnections();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    scaffolding.buildDataAccess((string)row["table_name"], ns);
                }
            }
            else
            {
                scaffolding.buildDataAccess(tableName, ns);
            }

            MessageBox.Show("Complete!");
        }
    }
}