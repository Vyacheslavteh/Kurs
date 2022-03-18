using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kursdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        //Обрабочтик ответственный за выход в приложение
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            string log = "SELECT * FROM users WHERE name= '" + logname.Text + "' and password= '" + logpass.Text + "'";
            cmd = new OleDbCommand(log, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if(dr.Read()==true) 
            {
                new Mainform().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
            }
            }
            catch { MessageBox.Show("Неверный логин или парол", "Ошибка"); }
            con.Close();
        }
    }
}
