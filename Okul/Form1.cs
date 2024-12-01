using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=PC105E\\SQLEXPRESS;Initial Catalog=okulum;Integrated Security=True;TrustServerCertificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
            doldursehir();
        }
        private void temizle()
        {
            //comboBox1.Clear();
            //textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        private void doldur()
        {
            string sorgu = "Select * from okul";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "insert into okul (ili,ilcesi,okulad,vergino,kurumno) values (@ili,@ilcesi,@okulad,@vergino,@kurumno)";
                conn.Open();
                //ekleme silme işlemlerin command
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ili", comboBox1.Text);
                cmd.Parameters.AddWithValue("@ilcesi", comboBox2.Text);
                cmd.Parameters.AddWithValue("@okulad", textBox3.Text);
                cmd.Parameters.AddWithValue("@vergino", textBox4.Text);
                cmd.Parameters.AddWithValue("@kurumno", textBox5.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklenmiştir");
                conn.Close();
                doldur();
                temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;
            comboBox1.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.Rows[satir].Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Kayıt Silinsin mi", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (cevap == DialogResult.Yes)
                {
                    string sorgu = "delete from okul where okulId=@Id";
                    conn.Open();
                    //ekleme silme işlemlerin command
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Id", textBox6.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklenmiştir");
                    conn.Close();
                    doldur();
                    temizle();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "update okul set ili=@ili,ilcesi=@ilcesi,okulad=@okulad,vergino=@vergino,kurumno=@kurumno where okulId=@Id";
                conn.Open();
                //ekleme silme işlemlerin command
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ili", comboBox1.Text);
                cmd.Parameters.AddWithValue("@ilcesi", comboBox2.Text);
                cmd.Parameters.AddWithValue("@okulad", textBox3.Text);
                cmd.Parameters.AddWithValue("@vergino", textBox4.Text);
                cmd.Parameters.AddWithValue("@kurumno", textBox5.Text);
                cmd.Parameters.AddWithValue("@Id", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklenmiştir");
                conn.Close();
                doldur();
                temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from okul where okulad like '%" + textBox7.Text + "%'";
            SqlDataAdapter da=new SqlDataAdapter(sorgu, conn);
            DataTable dt=new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Kayıt Bulunmadı!!!");
            }
        }

        private void doldursehir()
        {
            try
            {
                string cumle = "Select ilId,ilAd from sehir order by ilAd Asc";
                SqlDataAdapter da=new SqlDataAdapter(cumle, conn);
                DataTable dt=new DataTable();   
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ilId";
                comboBox1.DisplayMember = "ilAd";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kayıt Bulunmadı");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name=="guncelle")
            {
                try
                {
                    string sorgu = "update okul set ili=@ili,ilcesi=@ilcesi,okulad=@okulad,vergino=@vergino,kurumno=@kurumno where okulId=@Id";
                    conn.Open();
                    //ekleme silme işlemlerin command
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ili", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@ilcesi", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@okulad", textBox3.Text);
                    cmd.Parameters.AddWithValue("@vergino", textBox4.Text);
                    cmd.Parameters.AddWithValue("@kurumno", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Id", textBox6.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklenmiştir");
                    conn.Close();
                    doldur();
                    temizle();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if(dataGridView1.Columns[e.ColumnIndex].Name == "silme")
            {
                try
                {
                    DialogResult cevap = MessageBox.Show("Kayıt Silinsin mi", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (cevap == DialogResult.Yes)
                    {
                        string sorgu = "delete from okul where okulId=@Id";
                        conn.Open();
                        //ekleme silme işlemlerin command
                        SqlCommand cmd = new SqlCommand(sorgu, conn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Id", textBox6.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Eklenmiştir");
                        conn.Close();
                        doldur();
                        temizle();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string cumle = "Select ilceId,ilceAd from ilce where ilId=" + comboBox1.SelectedValue;
            SqlDataAdapter da = new SqlDataAdapter(cumle, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "ilceId";
            comboBox2.DisplayMember = "ilceAd";
        }

        private void comboBox1_Click_1(object sender, EventArgs e)
        {
            string cumle = "Select ilceId,ilceAd from ilce where ilId=" + comboBox1.SelectedValue;
            SqlDataAdapter da = new SqlDataAdapter(cumle, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "ilceId";
            comboBox2.DisplayMember = "ilceAd";
        }
    }
}
