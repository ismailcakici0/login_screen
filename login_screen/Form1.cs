namespace login_screen
{
    public partial class Form1 : Form
    {
        String? kullaniciAdi, sifre,hataMesaji;
        Form2? form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2();
            kullaniciAdi = "admin";
            sifre = "admin123";
            hataMesaji = "Kullanıcı adı veya Şifre hatalı !";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            } else
            {
                textBox2.PasswordChar = '*';
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kullaniciAdi && textBox2.Text == sifre)
            {
                form2!.Show();
            }
            else {
                MessageBox.Show(hataMesaji);
            }
        }
    }
}