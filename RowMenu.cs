using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPU_Store
{
    public partial class RowMenu : Form
    {
        public RowMenu(string ID)
        {
            InitializeComponent();
            returnProductModel(ID);
            productID.Text = ID;
        }

        public string returnConString()
        {
            return @"DataSource=C:\Users\Atanas\Documents\My Projects\GPU Store\GPU Store\GPU_Store.db";
        }

        public void returnProductModel(string id)
        {
            SQLiteConnection sqlitecon = new SQLiteConnection(returnConString());

            try
            {
                sqlitecon.Open();
                SQLiteCommand cmd;
                cmd = sqlitecon.CreateCommand();
                cmd.CommandText = "SELECT Model FROM video_cards where ID = '"+id+"'";
                var result = cmd.ExecuteScalar();
                productName.Text = result.ToString();
            }catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update updateForm = new Update(productID.Text);
            updateForm.Region = this.Region;
            updateForm.Show();
            this.Hide();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlitecon = new SQLiteConnection(returnConString());

            try
            {
                sqlitecon.Open();
                SQLiteCommand cmd;
                cmd = sqlitecon.CreateCommand();
                cmd.CommandText = "DELETE FROM video_cards WHERE ID = "+productID.Text;
                cmd.ExecuteNonQuery();
                sqlitecon.Close();

                Form1 form = new Form1();
                form.Region = this.Region;
                form.Show();
                this.Hide();

            }catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
