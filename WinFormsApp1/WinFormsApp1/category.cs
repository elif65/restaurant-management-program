using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Restorant
{


    public partial class category : Form
    {

        Functions Con;
        public category()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCategories();

        }
     

        private void ShowCategories()
        {
            try
            {
                string Query = " select * from CategoryTbl";
                CategoriesList.DataSource = Con.GetData(Query);

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }



        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CatNameTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Category = CatNameTb.Text;
                    string Desc = DescTb.Text;
                    string Query = "insert into CategoytTbl values ('{0}', '{1}')";
                    Query = string.Format(Query, Category, Desc);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Added!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }



        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CatNameTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Category = CatNameTb.Text;
                    string Desc = DescTb.Text;
                    string Query = "Update CategoytTbl set CatName ='{0}', CatDesc='{1}' where CatCode = '{2}'";
                    Query = string.Format(Query, Category, Desc, key);
                    Con.SetData(Query);
                    ShowCategories();

                    MessageBox.Show("Category Updated!");
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
                    string Query = "Delete from CategoytTbl where CatCode = {0}"; // Burada 'Delete from CategoytTbl where' kullanılmalı.
                    Query = string.Format(Query,key);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Deleted!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
               
            } 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int key = 0;
        private void CategoriestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatNameTb.Text = CategoriesList.SelectedRows[0].Cells[1].Value.ToString();
            DescTb.Text = CategoriesList.SelectedRows[0].Cells[2].Value.ToString(); // Buradaki indeks 2 olmalı, çünkü açıklama alanı için 2. hücre kullanılıyor.

            if (CatNameTb.Text == "")
            {

                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CategoriesList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


