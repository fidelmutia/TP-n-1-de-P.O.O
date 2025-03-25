namespace TP_Form
{
    public partial class Form_Calculatrice : Form
    {
        public Form_Calculatrice()
        {
            InitializeComponent();
        }
        

        private void btn_Calcul_Click(object sender, EventArgs e)
        {
            float x, y, operation;

            x = float.Parse(txt_Nbre1.Text);

            y = float.Parse(txt_Nbre2.Text);


            if (radio_Sum.Checked)
            {
                operation = x + y;
                txt_Rep.Text = operation.ToString();
            }
            if (radio_Sub.Checked)
            {
                operation = x - y;
                txt_Rep.Text = operation.ToString();
            }
            if (radio_Mult.Checked)
            {
                operation = x * y;
                txt_Rep.Text = operation.ToString();
            }
            if (radio_Div.Checked)
            {

                if (txt_Nbre2.Text == "0")
                {
                    MessageBox.Show("Division par Zero impossible");
                    txt_Rep.Text = "Error";
                }

                operation = x / y;

                txt_Rep.Text = operation.ToString();


            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
