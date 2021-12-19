using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Korol
{
    public partial class Menu : Form
    {
        Point LastPoint;
        public Menu(Form1 form1)
        {
            InitializeComponent();
            listfio.Text = form1.User.FIONepolnoe;
            ReverseLabel(listfio);
            comboBox1.Items.Add("Пользователи");
            comboBox1.Items.Add("Группа");
            comboBox1.Items.Add("Менеджер");
            comboBox1.Items.Add("Маршрут");
            comboBox1.Items.Add("Секция");
            comboBox1.Items.Add("Тип");
            comboBox1.Items.Add("Тренер");
            comboBox1.Items.Add("Турист");
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
            ONE.Visible = false;
            TWO.Visible = false;
            THREE.Visible = false;
            FOUR.Visible = false;
            FIVE.Visible = false;
            SIX.Visible = false;
            SEVEN.Visible = false;
            ONEBOX.Visible = false;
            TWOBOX.Visible = false;
            THREEBOX.Visible = false;
            FOURBOX.Visible = false;
            FIVEBOX.Visible = false;
            SIXBOX.Visible = false;
            CREATE.Visible = false;
            UPDATE.Visible = false;
            DELETE.Visible = false;
            FULL1.Visible = false;
            FULL2.Visible = false;
            FULL3.Visible = false;
            FULL4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

        }
        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem as String == "Пользователи")
            {
                FilDT.DataSource = Database.SECURITY();
                FilDT.Columns[0].Visible = true;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = true;
                FIVE.Visible = true;
                SIX.Visible = true;
                SEVEN.Visible = true;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                FOURBOX.Visible = false;
                FIVEBOX.Visible = false;
                SIXBOX.Visible=false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            if (comboBox1.SelectedItem as String == "Группа")
            {
                FilDT.DataSource = Database.GROUV();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                TWO.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
    
            }
            if (comboBox1.SelectedItem as String == "Менеджер")
            {
                FilDT.DataSource = Database.MANAAGER();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;

            }
            if (comboBox1.SelectedItem as String == "Маршрут")
            {
                FilDT.DataSource = Database.MAXHIKE();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = true;
                TWOBOX.Visible = true;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                FIVEBOX.Visible = false;
                SIXBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = true;
                FULL2.Visible = true;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
                label2.Text = "Тип";
                label3.Text = "Тренер";
                MySqlConnection con1 = new MySqlConnection
               ("server= 127.0.0.1;database=turist; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tip", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONEBOX.DataSource = dt1;
                ONEBOX.DisplayMember = "Naim";
                ONEBOX.ValueMember = "ID_TIP";
                /////////////////////////////////////////
                MySqlConnection con2 = new MySqlConnection
              ("server= 127.0.0.1;database=turist; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da2 = new MySqlDataAdapter
                    ("Select * From trainer", con1);
                DataTable dt2= new DataTable();
                da2.Fill(dt2);
                TWOBOX.DataSource = dt2;
                TWOBOX.DisplayMember = "FIO";
                TWOBOX.ValueMember = "ID_Trainer";
            }
            if (comboBox1.SelectedItem as String == "Секция")
            {
                FilDT.DataSource = Database.SECTION();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                FIVEBOX.Visible = false;
                SIXBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            if (comboBox1.SelectedItem as String == "Тип")
            {
                FilDT.DataSource = Database.TIP();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                FIVEBOX.Visible = false;
                SIXBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            if (comboBox1.SelectedItem as String == "Тренер")
            {
                FilDT.DataSource = Database.TRAINER();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                FIVEBOX.Visible = false;
                SIXBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            if (comboBox1.SelectedItem as String == "Турист")
            {
                FilDT.DataSource = Database.TURIST();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = true;
                TWOBOX.Visible = true;
                THREEBOX.Visible = true;
                FOURBOX.Visible = true;
                FIVEBOX.Visible = true;
                SIXBOX.Visible = true;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = true;
                FULL2.Visible = true;
                FULL3.Visible = true;
                FULL4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label2.Text = "Группа";
                label3.Text = "Секция";
                label4.Text = "Тип";
                label5.Text = "Менеджер";
                MySqlConnection con1 = new MySqlConnection
              ("server= 127.0.0.1;database=turist; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From grouv", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONEBOX.DataSource = dt1;
                ONEBOX.DisplayMember = "Naim";
                ONEBOX.ValueMember = "ID_Group";
                /////////////////////////////////////////
                MySqlConnection con2 = new MySqlConnection
              ("server= 127.0.0.1;database=turist; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da2 = new MySqlDataAdapter
                    ("Select * From section", con2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                TWOBOX.DataSource = dt2;
                TWOBOX.DisplayMember = "Naim";
                TWOBOX.ValueMember = "ID_Section";
                /////////////////////////////////////////
                MySqlConnection con3 = new MySqlConnection
              ("server= 127.0.0.1;database=turist; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da3 = new MySqlDataAdapter
                    ("Select * From tip", con3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                THREEBOX.DataSource = dt3;
                THREEBOX.DisplayMember = "Naim";
                THREEBOX.ValueMember = "ID_TIP";
                /////////////////////////////////////////
                MySqlConnection con4 = new MySqlConnection
              ("server= 127.0.0.1;database=turist; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da4 = new MySqlDataAdapter
                    ("Select * From manager", con4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                FOURBOX.DataSource = dt4;
                FOURBOX.DisplayMember = "FIO";
                FOURBOX.ValueMember = "ID_Manager";
                /////////////////////////////////////////
                MySqlConnection con5 = new MySqlConnection
              ("server= 127.0.0.1;database=turist; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da5 = new MySqlDataAdapter
                    ("Select * From trainer", con5);
                DataTable dt5 = new DataTable();
                da5.Fill(dt5);
                FIVEBOX.DataSource = dt5;
                FIVEBOX.DisplayMember = "FIO";
                FIVEBOX.ValueMember = "ID_Trainer";
                /////////////////////////////////////////
                MySqlConnection con6 = new MySqlConnection
              ("server= 127.0.0.1;database=turist; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da6 = new MySqlDataAdapter
                    ("Select * From maxhike", con6);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);
                SIXBOX.DataSource = dt6;
                SIXBOX.DisplayMember = "Naim";
                SIXBOX.ValueMember = "ID_Maxhike";
            }
        }

        private void ReverseLabel(Label label)
        {
            int witdh = label.Width;
            label.Location = new Point(label.Location.X - witdh, label.Location.Y);
            label.TextAlign = ContentAlignment.MiddleRight;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {

            LastPoint = new Point(e.X, e.Y);
        }
        int idd;
        public void SECDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idd = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
            if (comboBox1.Text == "Пользователи")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From sec " +
                    "where ID_SEC=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
                THREE.Text = dt1.Rows[0][3].ToString();
                FOUR.Text = dt1.Rows[0][4].ToString();
                FIVE.Text = dt1.Rows[0][5].ToString();
                SIX.Text = dt1.Rows[0][6].ToString();
                SEVEN.Text = dt1.Rows[0][7].ToString();
            }
            if (comboBox1.Text == "Группа")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From grouv " +
                    "where ID_Group=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
            }
            if (comboBox1.Text == "Менеджер")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From manager " +
                    "where ID_Manager=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
            }

            if (comboBox1.Text == "Маршрут")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From maxhike " +
                    "where ID_Maxhike=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                ONEBOX.SelectedValue = dt1.Rows[0][2].ToString();
                TWOBOX.SelectedValue = dt1.Rows[0][3].ToString();
                TWO.Text = dt1.Rows[0][4].ToString();
                THREE.Text = dt1.Rows[0][5].ToString();
            }
            if (comboBox1.Text == "Секция")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From section " +
                    "where ID_Section=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();


            }
            if (comboBox1.Text == "Тип")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tip " +
                    "where ID_TIP=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
            }
            if (comboBox1.Text == "Тренер")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From trainer " +
                    "where ID_Trainer=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
            }
            if (comboBox1.Text == "Турист")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From turist " +
                    "where ID_Turist=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                ONEBOX.SelectedValue = dt1.Rows[0][2].ToString();
                TWOBOX.SelectedValue = dt1.Rows[0][3].ToString();
                THREEBOX.SelectedValue = dt1.Rows[0][4].ToString();
                FOURBOX.SelectedValue = dt1.Rows[0][5].ToString();
                FIVEBOX.SelectedValue = dt1.Rows[0][6].ToString();
                SIXBOX.SelectedValue = dt1.Rows[0][7].ToString();
            }

        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"Insert into security.sec(FIO,FIONepolnoe,Dolg,Login,Password,level,Mesto)\n" +
                    $"values ('{ONE.Text}', '{TWO.Text}', '{THREE.Text}', '{FOUR.Text}', '{FIVE.Text}', {SIX.Text}, '{SEVEN.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECURITY();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Группа")
            {
                var q = $"Insert into turist.grouv(Naim)\n" +
                    $"values ('{ONE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.GROUV();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Менеджер")
            {
                var q = $"Insert into turist.manager(FIO)\n" +
                    $"values ('{ONE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MANAAGER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Маршрут")
            {
                var q = $"Insert into turist.maxhike(Naim, ID_Tip, ID_Trainer, Route, Complexity)\n" +
                    $"values ('{ONE.Text}', '{ONEBOX.SelectedValue}', '{TWOBOX.SelectedValue}', '{TWO.Text}', '{THREE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                       dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MAXHIKE();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Секция")
            {
                var q = $"Insert into turist.section(Naim)\n" +
                    $"values ('{ONE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECTION();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"Insert into turist.tip(Naim)\n" +
                    $"values ('{ONE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TIP();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тренер")
            {
                var q = $"Insert into turist.trainer(FIO)\n" +
                    $"values ('{ONE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TRAINER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Турист")
            {
                var q = $"Insert into turist.turist(FIO,ID_Group ,ID_Section, ID_Tip, ID_Manager, ID_Trainer, ID_Maxhike)\n" +
                    $"values ('{ONE.Text}','{ONEBOX.SelectedValue}','{TWOBOX.SelectedValue}','{THREEBOX.SelectedValue}','{FOURBOX.SelectedValue}','{FIVEBOX.SelectedValue}','{SIXBOX.SelectedValue}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TURIST();

                }
            }

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"UPDATE `sec` SET `FIO`='{ONE.Text}',`FIONepolnoe`='{TWO.Text}',`Dolg`='{THREE.Text}',`Login`='{FOUR.Text}',`Password`='{FIVE.Text}',`level`='{SIX.Text}',`Mesto`='{SEVEN.Text}' WHERE ID_SEC = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECURITY();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Группа")
            {
                var q = $"UPDATE `grouv` SET `Naim`='{ONE.Text}' WHERE ID_Group = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.GROUV();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Менеджер")
            {

                var q = $"UPDATE `manager` SET `FIO`='{ONE.Text}' WHERE ID_Manager = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MANAAGER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Маршрут")
            {
                var q = $"UPDATE `maxhike` SET `Naim`='{ONE.Text}',`ID_Tip`='{ONEBOX.SelectedValue}',`ID_Trainer`='{TWOBOX.SelectedValue}',`Route`='{TWO.Text}',`Complexity`='{THREE.Text}' WHERE ID_Maxhike = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MAXHIKE();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Секция")
            {
                var q = $"UPDATE `section` SET `Naim`='{ONE.Text}' WHERE ID_Section = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECTION();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"UPDATE `tip` SET `Naim`='{ONE.Text}' WHERE ID_TIP = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TIP();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тренер")
            {
                var q = $"UPDATE `trainer` SET `FIO`='{ONE.Text}' WHERE ID_Trainer = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TRAINER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Турист")
            {
                var q = $"UPDATE `turist` SET `FIO`='{ONE.Text}',`ID_Group`='{ONEBOX.SelectedValue}',`ID_Section`='{TWOBOX.SelectedValue}',`ID_Tip`='{THREEBOX.SelectedValue}',`ID_Manager`='{FOURBOX.SelectedValue}',`ID_Trainer`='{FIVEBOX.SelectedValue}',`ID_Maxhike`='{SIXBOX.SelectedValue}' WHERE ID_Turist = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TURIST();

                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"DELETE FROM `sec` WHERE ID_SEC = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECURITY();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Группа")
            {
                var q = $"DELETE FROM `grouv` WHERE ID_Group = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.GROUV();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Менеджер")
            {

                var q = $"DELETE FROM `manager` WHERE ID_Manager = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MANAAGER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Маршрут")
            {
                var q = $"DELETE FROM `maxhike` WHERE ID_MAxhike = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MAXHIKE();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Секция")
            {
                var q = $"DELETE FROM `section` WHERE ID_Section = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECTION();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"DELETE FROM `tip` WHERE ID_TIP = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TIP();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тренер")
            {
                var q = $"DELETE FROM `trainer` WHERE ID_Trainer = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TRAINER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Турист")
            {
                var q = $"DELETE FROM `turist` WHERE ID_Turist = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TURIST();

                }
            }
        }

    }
}