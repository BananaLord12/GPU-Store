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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }
        public string returnConString()
        {
            return @"DataSource=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\GPU_Store.db";
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlitecon = new SQLiteConnection(returnConString());

            try
            {
                sqlitecon.Open();
                SQLiteCommand cmd;
                cmd = sqlitecon.CreateCommand();
                cmd.CommandText = "INSERT INTO video_cards(Brand, Model, Memory_Size, Memory_Type, TDP, Price) VALUES ('" +
                    Brand.Text+"','"+Model.Text+"','"+memorySize.Text + "','" + memoryType.Text + "','" + TDP.Text + "','" +Price.Text+ "')";
                cmd.ExecuteNonQuery();
            }catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlitecon.Close();

            Form1 form1 = new Form1();
            form1.Region = this.Region;
            form1.Show();
            this.Hide();
        }
    }
}
