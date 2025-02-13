using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace GPU_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetDataBase();
            setComboBox();
        }

        public string returnConString()
        {
            return @"DataSource="+System.IO.Path.GetDirectoryName(Application.ExecutablePath)+"\\GPU_Store.db";
        }

        public void setComboBox()
        {
            List<string> comboboxItems = new List<string>();

            for(int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].Name == "ID")
                {
                    continue;
                }
                comboboxItems.Add(dataGridView1.Columns[i].Name);
            }

            comboBox1.DataSource = comboboxItems;
        }

        public void resetDataBase()
        {
            SQLiteConnection sqlitecon = new SQLiteConnection(returnConString());

            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                sqlitecon.Open();
                cmd = sqlitecon.CreateCommand();
                cmd.CommandText = "SELECT * FROM video_cards";
                ad= new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlitecon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlitecon = new SQLiteConnection(returnConString());

            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                sqlitecon.Open();
                SQLiteCommand cmd;
                cmd= sqlitecon.CreateCommand();
                cmd.CommandText = "SELECT * FROM video_cards WHERE " + comboBox1.Text + " LIKE '" + textBox1.Text+"'";
                ad= new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataBase();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Insert insertForm = new Insert();
            insertForm.Region = this.Region;
            insertForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["ID"].Value.ToString();
                RowMenu rowMenu = new RowMenu(id);
                rowMenu.Region = this.Region;
                rowMenu.Show();
                this.Hide();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}