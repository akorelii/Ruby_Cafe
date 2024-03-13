namespace Ruby_Cafe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            moneyLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            pizzaPictBox = new PictureBox();
            pancakePictBox = new PictureBox();
            hotdogPictBox = new PictureBox();
            hamburgerPictBox = new PictureBox();
            cupcakePictBox = new PictureBox();
            cheesePictBox = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            payButton = new Button();
            cartListBox = new ListBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pizzaPictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pancakePictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotdogPictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hamburgerPictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cupcakePictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cheesePictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(moneyLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 291);
            panel1.TabIndex = 0;
            // 
            // moneyLabel
            // 
            moneyLabel.Dock = DockStyle.Bottom;
            moneyLabel.ForeColor = Color.FromArgb(255, 92, 83);
            moneyLabel.Location = new Point(0, 257);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(125, 34);
            moneyLabel.TabIndex = 3;
            moneyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 92, 83);
            label1.Location = new Point(3, 62);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Ruby Cafe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(125, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 291);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(pictureBox7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(557, 291);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(pictureBox8);
            panel5.Controls.Add(pictureBox9);
            panel5.Controls.Add(pictureBox10);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(557, 291);
            panel5.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(pizzaPictBox);
            panel6.Controls.Add(pancakePictBox);
            panel6.Controls.Add(hotdogPictBox);
            panel6.Controls.Add(hamburgerPictBox);
            panel6.Controls.Add(cupcakePictBox);
            panel6.Controls.Add(cheesePictBox);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(557, 291);
            panel6.TabIndex = 9;
            panel6.Paint += panel6_Paint;
            // 
            // pizzaPictBox
            // 
            pizzaPictBox.Image = Properties.Resources.pizza;
            pizzaPictBox.Location = new Point(282, 150);
            pizzaPictBox.Name = "pizzaPictBox";
            pizzaPictBox.Size = new Size(144, 141);
            pizzaPictBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pizzaPictBox.TabIndex = 10;
            pizzaPictBox.TabStop = false;
            pizzaPictBox.Click += pizzaPictBox_Click;
            // 
            // pancakePictBox
            // 
            pancakePictBox.Image = Properties.Resources.pancake;
            pancakePictBox.Location = new Point(139, 150);
            pancakePictBox.Name = "pancakePictBox";
            pancakePictBox.Size = new Size(144, 141);
            pancakePictBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pancakePictBox.TabIndex = 9;
            pancakePictBox.TabStop = false;
            pancakePictBox.Click += pancakePictBox_Click;
            // 
            // hotdogPictBox
            // 
            hotdogPictBox.Image = Properties.Resources.hotdog;
            hotdogPictBox.Location = new Point(0, 150);
            hotdogPictBox.Name = "hotdogPictBox";
            hotdogPictBox.Size = new Size(144, 141);
            hotdogPictBox.SizeMode = PictureBoxSizeMode.CenterImage;
            hotdogPictBox.TabIndex = 8;
            hotdogPictBox.TabStop = false;
            hotdogPictBox.Click += hotdogPictBox_Click;
            // 
            // hamburgerPictBox
            // 
            hamburgerPictBox.Image = Properties.Resources.hamburger;
            hamburgerPictBox.Location = new Point(282, 0);
            hamburgerPictBox.Name = "hamburgerPictBox";
            hamburgerPictBox.Size = new Size(144, 141);
            hamburgerPictBox.SizeMode = PictureBoxSizeMode.CenterImage;
            hamburgerPictBox.TabIndex = 7;
            hamburgerPictBox.TabStop = false;
            hamburgerPictBox.Click += hamburgerPictBox_Click;
            // 
            // cupcakePictBox
            // 
            cupcakePictBox.Image = Properties.Resources.cupcake;
            cupcakePictBox.Location = new Point(139, 0);
            cupcakePictBox.Name = "cupcakePictBox";
            cupcakePictBox.Size = new Size(144, 141);
            cupcakePictBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cupcakePictBox.TabIndex = 6;
            cupcakePictBox.TabStop = false;
            cupcakePictBox.Click += cupcakePictBox_Click;
            // 
            // cheesePictBox
            // 
            cheesePictBox.Image = Properties.Resources.cheese;
            cheesePictBox.Location = new Point(0, 0);
            cheesePictBox.Name = "cheesePictBox";
            cheesePictBox.Size = new Size(144, 141);
            cheesePictBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cheesePictBox.TabIndex = 5;
            cheesePictBox.TabStop = false;
            cheesePictBox.Click += cheesePictBox_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(282, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(144, 141);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(139, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(144, 141);
            pictureBox9.TabIndex = 6;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(144, 141);
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(282, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(144, 141);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(139, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(144, 141);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(144, 141);
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(282, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(144, 141);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(139, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(144, 141);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 141);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(payButton);
            panel3.Controls.Add(cartListBox);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(557, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(125, 291);
            panel3.TabIndex = 2;
            // 
            // payButton
            // 
            payButton.BackColor = Color.LightGray;
            payButton.FlatAppearance.BorderSize = 0;
            payButton.FlatStyle = FlatStyle.Flat;
            payButton.ForeColor = Color.FromArgb(255, 92, 83);
            payButton.Location = new Point(0, 237);
            payButton.Name = "payButton";
            payButton.Size = new Size(125, 54);
            payButton.TabIndex = 5;
            payButton.Text = "Pay";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // cartListBox
            // 
            cartListBox.BackColor = Color.LightGray;
            cartListBox.BorderStyle = BorderStyle.None;
            cartListBox.Dock = DockStyle.Top;
            cartListBox.ForeColor = Color.FromArgb(255, 92, 83);
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 25;
            cartListBox.Location = new Point(0, 37);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(125, 200);
            cartListBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.FromArgb(255, 92, 83);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 4;
            label2.Text = "Cart";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(682, 291);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ruby Cafe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pizzaPictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pancakePictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotdogPictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hamburgerPictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cupcakePictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cheesePictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label moneyLabel;
        private Label label2;
        private PictureBox pictureBox2;
        private ListBox cartListBox;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pizzaPictBox;
        private PictureBox pancakePictBox;
        private PictureBox hotdogPictBox;
        private PictureBox hamburgerPictBox;
        private PictureBox cupcakePictBox;
        private PictureBox cheesePictBox;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Button payButton;
    }
}
