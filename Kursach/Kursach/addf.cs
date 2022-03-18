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
    public partial class addf : Form
    {
        public addf()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kursdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
       
        private void addavt_Click(object sender, EventArgs e)
        {
            Mainform main = this.Owner as Mainform;
            DataRow nRow = main.kursdbDataSet1.Tables[1].NewRow();
            int rc = main.dataGridView1.RowCount + 1;
            con.Open();
            string adda = "INSERT INTO Автомобили VALUES('" + rc + "','" + avt2.Text + "','" + avt3.Text + "','" + avt4.Text + "')";
            cmd = new OleDbCommand(adda, con);
            cmd.ExecuteNonQuery();
            con.Close();       
                nRow[0] = rc;
                nRow[1] = avt2.Text;
                nRow[2] = avt3.Text;
                nRow[3] = avt4.Text;
                main.kursdbDataSet1.Tables[1].Rows.Add(nRow);
                main.автомобилиTableAdapter1.Update(main.kursdbDataSet1.Автомобили);
                main.kursdbDataSet1.Tables[1].AcceptChanges();
                main.dataGridView1.Update();
                main.dataGridView1.Refresh();
        }

        private void addzak_Click(object sender, EventArgs e)
        {
            try { 
            Mainform main = this.Owner as Mainform;
            DataRow nRow = main.kursdbDataSet1.Tables[2].NewRow();
            int rcz = main.dataGridView2.RowCount + 1;
            con.Open();
            string adda = "INSERT INTO Заказы VALUES('" + rcz + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";

            cmd = new OleDbCommand(adda, con);



            cmd.ExecuteNonQuery();
            con.Close();



            nRow[0] = rcz;
            nRow[1] = dateTimePicker1.Text;
            nRow[2] = dateTimePicker2.Text;
            nRow[3] = textBox1.Text;
            nRow[4] = textBox4.Text;
            nRow[5] = textBox5.Text;

            main.kursdbDataSet1.Tables[2].Rows.Add(nRow);
            main.заказыTableAdapter1.Update(main.kursdbDataSet1.Заказы);
            main.kursdbDataSet1.Tables[2].AcceptChanges();


            main.dataGridView2.Update();

            main.dataGridView2.Refresh();
            }
            catch { MessageBox.Show("Неверный формат данных", "Ошибка"); }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainform main = this.Owner as Mainform;
            DataRow nRow = main.kursdbDataSet1.Tables[3].NewRow();
            int rcz = main.dataGridView3.RowCount + 1;
            con.Open();
            string adda = "INSERT INTO Клиенты VALUES('" + rcz + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";

            cmd = new OleDbCommand(adda, con);



            cmd.ExecuteNonQuery();
            con.Close();



            nRow[0] = rcz;
            nRow[1] = textBox2.Text;
            nRow[2] = textBox3.Text;
            nRow[3] = textBox6.Text;
            nRow[4] = textBox7.Text;

            main.kursdbDataSet1.Tables[3].Rows.Add(nRow);
            main.клиентыTableAdapter1.Update(main.kursdbDataSet1.Клиенты);
            main.kursdbDataSet1.Tables[3].AcceptChanges();


            main.dataGridView3.Update();

            main.dataGridView3.Refresh();
        }
        //Закрытие формы
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mainform main = this.Owner as Mainform;
            DataRow nRow = main.kursdbDataSet1.Tables[4].NewRow();
            int rcz = main.dataGridView4.RowCount + 1;
            con.Open();
            string adda = "INSERT INTO Механики VALUES('" + rcz + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox8.Text + "')";

            cmd = new OleDbCommand(adda, con);



            cmd.ExecuteNonQuery();
            con.Close();



            nRow[0] = rcz;
            nRow[1] = textBox9.Text;
            nRow[2] = textBox10.Text;
            nRow[3] = textBox11.Text;
            nRow[4] = textBox8.Text;

            main.kursdbDataSet1.Tables[4].Rows.Add(nRow);
            main.механикиTableAdapter1.Update(main.kursdbDataSet1.Механики);
            main.kursdbDataSet1.Tables[4].AcceptChanges();


            main.dataGridView4.Update();

            main.dataGridView4.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainform main = this.Owner as Mainform;
            DataRow nRow = main.kursdbDataSet1.Tables[5].NewRow();
            int rcu = main.dataGridView5.RowCount  ;
            con.Open();
            string adda = "INSERT INTO Услуги VALUES('" + rcu + "','" + textBox13.Text + "','" + textBox14.Text + "')";

            cmd = new OleDbCommand(adda, con);


            cmd.ExecuteNonQuery();
            con.Close();

       
            nRow[0] = rcu;
            nRow[1] = textBox13.Text;
            nRow[2] = textBox14.Text;


            main.kursdbDataSet1.Tables[5].Rows.Add(nRow);
            main.kursdbDataSet1.Tables[5].AcceptChanges();

            main.dataGridView5.Update();

            main.dataGridView5.Refresh();
        }
    }
}
