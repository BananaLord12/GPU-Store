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
    public partial class Update : Form
    {
        public Update(string ID)
        {
            InitializeComponent();
            fillForm(ID);
            productID.Text = ID;
        }
        public string returnConString()
        {
            return @"DataSource=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\GPU_Store.db";
        }

        public void fillForm(string ID)
        {
            SQLiteConnection sqlitecon = new SQLiteConnection(returnConString());
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            try
            {
                sqlitecon.Open();
                SQLiteCommand cmd;
                cmd = sqlitecon.CreateCommand();
                cmd.CommandText = "SELECT * FROM video_cards WHERE ID = '" + ID + "'";
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                var row = dt.Rows[0];
                Brand.Text = row["Brand"].ToString();
                Model.Text = row["Model"].ToString();
                memorySize.Text = row["Memory_Size"].ToString();
                memoryType.Text = row["Memory_Type"].ToString();
                TDP.Text = row["TDP"].ToString();
                Price.Text = row["Price"].ToString();
                
            }catch(SQLiteException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlitecon = new SQLiteConnection(returnConString());

            try
            {
                sqlitecon.Open();
                SQLiteCommand cmd;
                cmd = sqlitecon.CreateCommand();
                cmd.CommandText = "UPDATE video_cards SET " +
                    "Brand = '"+Brand.Text+"', "+
                    "Model = '"+Model.Text+"', "+
                    "Memory_Size = '"+memorySize.Text+"', "+
                    "Memory_Type = '"+memoryType.Text+"', "+
                    "TDP = '"+TDP.Text+"', "+
                    "Price = '"+Price.Text+"' WHERE ID = "+productID.Text+"";
                cmd.ExecuteNonQuery();

            }catch(SQLiteException er)
            {
                MessageBox.Show(er.Message);
            }
            sqlitecon.Close();

            Form1 form1 = new Form1();
            form1.Region = this.Region;
            form1.Show();
            this.Hide();
        }
    }
}
