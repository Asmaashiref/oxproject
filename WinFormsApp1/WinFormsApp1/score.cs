using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class score : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        int lastId = 0;
        public score()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=oxdatabase;Trusted_Connection=True;TrustServerCertificate=True");
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();
        }

        private void score_Load(object sender, EventArgs e)
        {
            Getplayers();
        }
        private void Getplayers()
        {
            // select command
            SqlCommand selectCmd = new SqlCommand("select [Id],[p1name],[score1],[p2name],[score2],[gamedate] from gamedata", con);

            // adaptor
            adapter.SelectCommand = selectCmd;

            dataTable.Clear();
            adapter.Fill(dataTable);
            lastId = (int)dataTable.Rows[dataTable.Rows.Count - 1]["Id"];

            // display in UI
            dataGridView1.DataSource = dataTable;
      
        }
        int currentId = 3;
        private void delete_Click(object sender, EventArgs e)
        {
            //DataRow dataRow = dataTable.NewRow();
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    if (row.RowState != DataRowState.Deleted && (int)row["Id"] == currentId)
            //    {
            //        dataRow = row; break;
            //    }
            //}
            //dataRow.Delete();
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void save_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Debug.WriteLine($"RowState: {row.RowState}");
            }


            SqlCommand DeleteCmd = new SqlCommand("delete from gamedata where Id = @Id", con);
            DeleteCmd.Parameters.Add("Id", SqlDbType.Int, 4, "Id");


            adapter.DeleteCommand = DeleteCmd;

            adapter.Update(dataTable);

            Getplayers();
        }

       

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).SelectedRows[0];
            currentId = (int)row.Cells["Id"].Value;
        }
    }
}
