namespace jogo_da_velha__
{
    public partial class Form1 : Form
    {
        public string usuario;
        public int contador;
        public Form1()
        {
            InitializeComponent();
        }

        public void troca_usuario()
        {
            if (usuario == "O")
                usuario = "X";
            else
                usuario = "O";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.Enabled = false;
            btn_1.Text = usuario;
            troca_usuario();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            btn_10.Enabled = false;
            btn_11.Enabled = false;
            usuario = "X";
            btn_12.Visible = false;
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            btn_10.Enabled = false;
            btn_11.Enabled = false;
            usuario = "O";
            btn_12.Visible = false;
        }

        private void btn_12_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_2.Enabled = false;
            btn_2.Text = usuario;
            troca_usuario();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            btn_3.Enabled = false;
            btn_3.Text = usuario;
            troca_usuario();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            btn_4.Enabled = false;
            btn_4.Text = usuario;
            troca_usuario();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            btn_5.Enabled = false;
            btn_5.Text = usuario;
            troca_usuario();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            btn_6.Enabled = false;
            btn_6.Text = usuario;
            troca_usuario();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            btn_7.Enabled = false;
            btn_7.Text = usuario;
            troca_usuario();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            btn_8.Enabled = false;
            btn_8.Text = usuario;
            troca_usuario();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            btn_9.Enabled = false;
            btn_9.Text = usuario;
            troca_usuario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void COMPARADOR()
        {
            if 
                ( );
            else
                ;
        }
    }
}
