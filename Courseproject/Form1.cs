using System.Reflection.Emit;

namespace Courseproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool[] nesDat = new bool[6];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                nesDat[i] = false;
            }
            enFileNameLabel.ForeColor = Color.Blue;
            enOutNameLabel.ForeColor = Color.Blue;
            enKeyNameLabel.ForeColor = Color.Blue;
            decFileNameLabel.ForeColor = Color.Blue;
            decOutNameLabel.ForeColor = Color.Blue;
            decKeyNameLabel.ForeColor = Color.Blue;
            enFileNameLabel.Text = "Вказати";
            enOutNameLabel.Text = "Вказати";
            enKeyNameLabel.Text = "Вказати";
            enResLable.Text = "";
            decFileNameLabel.Text = "Вказати";
            decOutNameLabel.Text = "Вказати";
            decKeyNameLabel.Text = "Вказати";
            decResLable.Text = "";
        }

        private void enFileNameLabel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                enFileNameLabel.Text = openFileDialog1.FileName;
                enFileNameLabel.ForeColor = Color.Black;
                nesDat[0] = true;
            }
        }

        private void enOutNameLabel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                enOutNameLabel.Text = saveFileDialog1.FileName;
                enOutNameLabel.ForeColor = Color.Black;
                nesDat[1] = true;
            }
        }

        private void enKeyNameLabel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                enKeyNameLabel.Text = saveFileDialog1.FileName;
                enKeyNameLabel.ForeColor = Color.Black;
                nesDat[2] = true;
            }
        }

        private void EncryptB_Click(object sender, EventArgs e)
        {
            if (nesDat[0] && nesDat[1] && nesDat[2])
            {
                enResLable.Text = "Файл зашифровано";
            }
            else
            {
                enResLable.Text = "Уведіть шляхи для читання/записування файлів";
            }
        }

        private void enResLable_Click(object sender, EventArgs e)
        {

        }

        private void decFileNameLabel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                decFileNameLabel.Text =  openFileDialog1.FileName;
                decFileNameLabel.ForeColor = Color.Black;
                nesDat[3] = true;
            }
        }

        private void decKeyNameLabel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                decKeyNameLabel.Text = openFileDialog1.FileName;
                decKeyNameLabel.ForeColor = Color.Black;
                nesDat[4] = true;
            }
        }

        private void decOutNameLabel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                decOutNameLabel.Text = saveFileDialog1.FileName;
                decOutNameLabel.ForeColor = Color.Black;
                nesDat[5] = true;
            }
        }

        private void DecryptB_Click(object sender, EventArgs e)
        {
            if (nesDat[3] && nesDat[4] && nesDat[5])
            {
                decResLable.Text = "Файл дешифровано";
            }
            else
            {
                decResLable.Text = "Уведіть шляхи для читання/записування файлів";
            }
        }

        private void decResLable_Click(object sender, EventArgs e)
        {

        }
    }
}
