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

        Random r = new Random();
        uint[] GenerateKey()
        {
            uint[] key = new uint[4];
            for (int i = 0; i < 4; i++)
            {
                key[i] = (uint)r.Next();
            }
            return key;
        }
        void Encrypt()
        {
            uint[] IV = GenerateKey();
            uint[] K = GenerateKey();
            State S = KCipher2.InitChiper(K, IV);
            using FileStream input = new FileStream(enFileNameLabel.Text, FileMode.Open, FileAccess.Read);
            using FileStream output = new FileStream(enOutNameLabel.Text, FileMode.Create, FileAccess.Write);
            using FileStream key = new FileStream(enKeyNameLabel.Text, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    output.WriteByte((byte)(IV[i] >> (24 - 8 * j)));
                    key.WriteByte((byte)(K[i] >> (24 - 8 * j)));
                }
            }
            byte[] bf = new byte[8];
            int count = input.Read(bf, 0, 8);
            ulong z;
            while (count > 0)
            {
                z = KCipher2.Stream(S);
                for (int i = 0; i < count; i++)
                {
                    output.WriteByte((byte)(bf[i] ^ (byte)(z >> (56 - 8 * i))));
                }
                S = KCipher2.Next(S);
                count = input.Read(bf, 0, 8);
            }
        }

        void Decrypt()
        {
            uint[] IV = new uint[4];
            uint[] K = new uint[4];
            using FileStream input = new FileStream(decFileNameLabel.Text, FileMode.Open, FileAccess.Read);
            using FileStream output = new FileStream(decOutNameLabel.Text, FileMode.Create, FileAccess.Write);
            using FileStream key = new FileStream(decKeyNameLabel.Text, FileMode.Open, FileAccess.Read);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    IV[i] = (IV[i] << 8) | (uint)input.ReadByte();
                    K[i] = (K[i] << 8) | (uint)key.ReadByte();
                }
            }
            State S = KCipher2.InitChiper(K, IV);
            byte[] bf = new byte[8];
            int count = input.Read(bf, 0, 8);
            ulong z;
            while (count > 0)
            {
                z = KCipher2.Stream(S);
                for (int i = 0; i < count; i++)
                {
                    output.WriteByte((byte)(bf[i] ^ (byte)(z >> (56 - 8 * i))));
                }
                S = KCipher2.Next(S);
                count = input.Read(bf, 0, 8);
            }
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
                Encrypt();
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
                decFileNameLabel.Text = openFileDialog1.FileName;
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
                Decrypt();
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

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
