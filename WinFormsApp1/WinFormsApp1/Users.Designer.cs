namespace WinFormsApp1
{
    partial class Users
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            panel3 = new Panel();
            GenCb = new ComboBox();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            AddTb = new TextBox();
            PhoneTb = new TextBox();
            NameTb = new TextBox();
            PasswordTb = new TextBox();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            colorDialog1 = new ColorDialog();
            UsersList = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersList).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Fuchsia;
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 597);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(53, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(81, 76);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(74, 548);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 10;
            label5.Text = "Logout";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(21, 535);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 427);
            label4.Name = "label4";
            label4.Size = new Size(42, 18);
            label4.TabIndex = 8;
            label4.Text = "Users";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(21, 415);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 355);
            label3.Name = "label3";
            label3.Size = new Size(72, 18);
            label3.TabIndex = 6;
            label3.Text = "Categories";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 333);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 274);
            label2.Name = "label2";
            label2.Size = new Size(40, 18);
            label2.TabIndex = 4;
            label2.Text = "İtems";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 262);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 40);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 192);
            label1.Name = "label1";
            label1.Size = new Size(42, 18);
            label1.TabIndex = 3;
            label1.Text = "Users";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 40);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 38);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(689, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Fuchsia;
            label6.Location = new Point(18, 9);
            label6.Margin = new Padding(6, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(318, 24);
            label6.TabIndex = 0;
            label6.Text = "Restoraurant Management System";
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 182, 217);
            panel3.Controls.Add(GenCb);
            panel3.Controls.Add(DeleteBtn);
            panel3.Controls.Add(EditBtn);
            panel3.Controls.Add(AddBtn);
            panel3.Controls.Add(AddTb);
            panel3.Controls.Add(PhoneTb);
            panel3.Controls.Add(NameTb);
            panel3.Controls.Add(PasswordTb);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(218, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 528);
            panel3.TabIndex = 3;
            // 
            // GenCb
            // 
            GenCb.BackColor = Color.FromArgb(255, 182, 217);
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Femele" });
            GenCb.Location = new Point(29, 209);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(246, 26);
            GenCb.TabIndex = 22;
            GenCb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(161, 485);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 24);
            DeleteBtn.TabIndex = 21;
            DeleteBtn.Text = "Delete User";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(46, 485);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(100, 24);
            EditBtn.TabIndex = 20;
            EditBtn.Text = "Edit User";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(46, 450);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(215, 29);
            AddBtn.TabIndex = 19;
            AddBtn.Text = "Add User";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddTb
            // 
            AddTb.BackColor = Color.FromArgb(255, 182, 217);
            AddTb.Location = new Point(29, 386);
            AddTb.Multiline = true;
            AddTb.Name = "AddTb";
            AddTb.PlaceholderText = "User Address";
            AddTb.Size = new Size(246, 33);
            AddTb.TabIndex = 18;
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = Color.FromArgb(255, 182, 217);
            PhoneTb.Location = new Point(29, 324);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.PlaceholderText = "User Phone";
            PhoneTb.Size = new Size(246, 33);
            PhoneTb.TabIndex = 17;
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.FromArgb(255, 182, 217);
            NameTb.Location = new Point(29, 151);
            NameTb.Multiline = true;
            NameTb.Name = "NameTb";
            NameTb.PlaceholderText = "User Name";
            NameTb.Size = new Size(246, 33);
            NameTb.TabIndex = 16;
            // 
            // PasswordTb
            // 
            PasswordTb.BackColor = Color.FromArgb(255, 182, 217);
            PasswordTb.Location = new Point(29, 265);
            PasswordTb.Multiline = true;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PlaceholderText = "User Password";
            PasswordTb.Size = new Size(246, 33);
            PasswordTb.TabIndex = 14;
            PasswordTb.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(29, 39);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(76, 67);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Fuchsia;
            label7.Location = new Point(12, 14);
            label7.Name = "label7";
            label7.Size = new Size(117, 22);
            label7.TabIndex = 12;
            label7.Text = "Users Datails";
            label7.Click += label7_Click;
            // 
            // UsersList
            // 
            UsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersList.Location = new Point(538, 57);
            UsersList.Name = "UsersList";
            UsersList.RowTemplate.Height = 25;
            UsersList.Size = new Size(369, 528);
            UsersList.TabIndex = 4;
            UsersList.CellContentClick += UsersList_CellContentClick;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(935, 597);
            Controls.Add(UsersList);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Users";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersList).EndInit();
            ResumeLayout(false);
        }

        private void UsersList_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox7;
        private Panel panel3;
        private Label label7;
        private PictureBox pictureBox8;
        private TextBox PasswordTb;
        private TextBox PhoneTb;
        private TextBox NameTb;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private TextBox AddTb;
        private ComboBox GenCb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ColorDialog colorDialog1;
        private DataGridView UsersList;
    }
}