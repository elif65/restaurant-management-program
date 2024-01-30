using Restorant;
using System.Drawing;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();

            Con = new Functions();

            ShowUsers();

        }
        Functions Con;
        private void ShowUsers()
        {
            try
            {
                string Query = " select * from UsersTbl";
                UsersList.DataSource = Con.GetData(Query);


            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PasswordTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == " " || AddTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Password = PasswordTb.Text;
                    string Phone = PhoneTb.Text;
                    string Adress = AddTb.Text;

                    string Query = "insert into UsersTbl values ('{0}', '{1}' ,'{2}', '{3}','{4}')";
                    Query = string.Format(Query, Name, Gender, Password, Phone, Adress);
                    Con.SetData(Query);
                    ShowUsers();
                    MessageBox.Show("User Added!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }
        int key = 0;
        //private object UsersList;

        //private void UsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{


        //    NameTb.Text = UsersList.SelectedRows[0].Cells[1].Value.ToString();

        //    GenCb.Text = UsersList.SelectedRows[0].Cells[2].Value.ToString();
        //    PasswordTb.Text = UsersList.SelectedRows[0].Cells[3].Value.ToString();
        //    PhoneTb.Text = UsersList.SelectedRows[0].Cells[4].Value.ToString();
        //    AddTb.Text = UsersList.SelectedRows[0].Cells[5].Value.ToString();
        //    if (NameTb.Text == "")
        //    {
        //        key = 0;
        //    }
        //    else
        //    {

        //        key = Convert.ToInt32(UsersList.SelectedRows[0].Cells[0].Value.ToString());
        //    }
        //}
        private void UsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = UsersList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = UsersList.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTb.Text = UsersList.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = UsersList.SelectedRows[0].Cells[4].Value.ToString();
            AddTb.Text = UsersList.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                key = 0;
            }
            else
            {

                key = Convert.ToInt32(UsersList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PasswordTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == " " || AddTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Password = PasswordTb.Text;
                    string Phone = PhoneTb.Text;
                    string Adress = AddTb.Text;

                    string Query = "Update UsersTbl set UName='{0}',UGen= '{1}' ,UPass='{2}', UPhone='{3}',UAdress='{4}' where UId={5}";
                    Query = string.Format(Query, Name, Gender, Password, Phone, Adress, key);
                    Con.SetData(Query);
                    ShowUsers();
                    MessageBox.Show("User Updated!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Password = PasswordTb.Text;
                    string Phone = PhoneTb.Text;
                    string Adress = AddTb.Text;

                    string Query = "delete from UsersTbl  where UId={0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowUsers();
                    MessageBox.Show("User Deleted!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Yeni bir form oluþtur
            Items yeniForm = new Items();

            // Yeni formu göster
            yeniForm.Show();

            // Eðer eski formun kapanmasýný istiyorsan:
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Yeni bir form oluþtur
            category yeniForm = new category();

            // Yeni formu göster
            yeniForm.Show();

            // Eðer eski formun kapanmasýný istiyorsan:
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}