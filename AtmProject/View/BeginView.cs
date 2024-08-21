namespace AtmProject
{
    public partial class BeginView : Form
    {
        public int contagem = 0;
        public BeginView()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contagem += 1;
            pb_begin.Value = contagem;
            lbl_percent.Text = contagem.ToString() + "%";
            if (pb_begin.Value == 100)
            {
                pb_begin.Value = 0;
                timer1.Stop();
                LoginView login = new LoginView();
                login.Show();
                this.Hide();
            }
        }

        private void begin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
