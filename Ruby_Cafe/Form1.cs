namespace Ruby_Cafe
{
    public partial class Form1 : Form
    {
        /* MONEY */
        int money = 1000;


        /* FOOD PRICES */
        int Cheese = 150;
        int Cupcake = 50;
        int Hamburger = 120;
        int Pizza = 150;
        int Hotdog = 80;
        int Pancake = 60;

        /* TOTAL PRICE */
        int totalPrice = 0;





        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moneyLabel.Text = money.ToString() + "TL";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cheesePictBox_Click(object sender, EventArgs e)
        {
            totalPrice += Cheese;
            cartListBox.Items.Add("Cheese");
        }

        private void cupcakePictBox_Click(object sender, EventArgs e)
        {
            totalPrice += Cupcake;
            cartListBox.Items.Add("Cupcake");
        }

        private void hamburgerPictBox_Click(object sender, EventArgs e)
        {
            totalPrice += Hamburger;
            cartListBox.Items.Add("Hamburger");
        }

        private void hotdogPictBox_Click(object sender, EventArgs e)
        {
            totalPrice += Hotdog;
            cartListBox.Items.Add("Hotdog");
        }

        private void pancakePictBox_Click(object sender, EventArgs e)
        {
            totalPrice += Pancake;
            cartListBox.Items.Add("Pancake");
        }

        private void pizzaPictBox_Click(object sender, EventArgs e)
        {
            totalPrice += Pizza;
            cartListBox.Items.Add("Pizza");
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (totalPrice <= 1000)
            {
                /* Mathematical Part */
                money = money - totalPrice;

                /* Writing Part */
                moneyLabel.Text = money.ToString() + "TL";

                /* Information */
                MessageBox.Show("Alisveris yaptiginiz icin tesekkur ederiz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Yetersiz Bakiye!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
