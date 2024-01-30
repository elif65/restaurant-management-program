using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1;

namespace Restorant
{
    public partial class Items : Form
    {

        Functions Con;
        private int key = 0;

        public Items()
        {
            InitializeComponent();
            Con = new Functions();
            ShowItems();
            GetCategories();
        }


        private void ShowItems()
        {
            try
            {
                string Query = "select * from ItemTbl";
                ItemsList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //private void GetCategories()
        //{
        //    try
        //    {
        //        string Query = "select * from CategoryTbl";


        //        DataTable categories = Con.GetData(Query);

        //        if (categories != null && categories.Columns.Count > 0)
        //        {
        //            CatCb.ValueMember = categories.Columns["CatCode"].ToString();
        //            CatCb.DisplayMember = categories.Columns["CatName"].ToString();
        //            CatCb.DataSource = categories;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Veritabanından kategori verileri alınamadı veya sütunlar eksik.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        private void GetCategories()
        {
            string Query = "select * from CategoryTbl";
            CatCb.ValueMember = Con.GetData(Query).Columns["CatCode"].ToString();
            CatCb.DisplayMember = Con.GetData(Query).Columns["CatName"].ToString();
            CatCb.DataSource = Con.GetData(Query);
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTb.Text) || string.IsNullOrEmpty(PriceTb.Text) || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Category = CatCb.SelectedValue.ToString();
                    int Price = Convert.ToInt32(PriceTb.Text);

                    string Query = "UPDATE ItemTbl SET ItName='{0}', ItPrice={1}, ItCategory={2} WHERE ItNum={3}";
                    Query = string.Format(Query, Name, Price, Category, key);

                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Item Updated!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //private void ItemsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (ItemsList is DataGridView dataGridView)
        //    {
        //        NameTb.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
        //        CatCb.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
        //        PriceTb.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();

        //        if (string.IsNullOrEmpty(NameTb.Text))
        //        {
        //            key = 0;
        //        }
        //        else
        //        {
        //            key = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
        //        }
        //    }
        //}

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTb.Text) || string.IsNullOrEmpty(PriceTb.Text) || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Category = CatCb.SelectedValue.ToString();
                    int Price = Convert.ToInt32(PriceTb.Text);

                    string Query = "UPDATE ItemTbl SET ItName='{0}', ItPrice={1}, ItCategory={2} WHERE ItNum={3}";
                    Query = string.Format(Query, Name, Price, Category, key);

                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Item Updated!");
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
                    int Category = Convert.ToInt32(CatCb.SelectedValue.ToString);
                    int Price = Convert.ToInt32(PriceTb.Text);
                    string Query = "delete * from ItemTbl where ItCode={0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);

                    ShowItems();
                    MessageBox.Show("Item deleted!");

                    //string Query = "DELETE FROM ItemTbl WHERE ItNum={0}";
                    //Query = string.Format(Query, key);

                    //Con.SetData(Query);
                    //ShowItems();
                    //MessageBox.Show("Item deleted!");


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UserLbl_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void CatLbl_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void ItemsList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = ItemsList.SelectedRows[0].Cells[1].Value.ToString();
            CatCb.Text = ItemsList.SelectedRows[0].Cells[2].Value.ToString(); // Buradaki indeks 2 olmalı, çünkü açıklama alanı için 2. hücre kullanılıyor.
            PriceTb.Text = ItemsList.SelectedRows[0].Cells[3].Value.ToString();
            if (NameTb.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(ItemsList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
