using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Form
{
    public partial class Form_Cotation : Form
    {
        public Form_Cotation()
        {
            InitializeComponent();
        }

        private void btn_Coter_Click(object sender, EventArgs e)
        {
            float Total = float.Parse(txt_Math.Text) + float.Parse(txt_Français.Text) 
                        + float.Parse(txt_Prog.Text) + float.Parse(txt_Algo.Text) + float.Parse(txt_Bur.Text);

            string Mention;

            float pourc = (Total * 100) / 300;

            if (combo_Sex.Text=="Masculin")
            {
                if(pourc<50)
                {
                    Mention = "Ajourné";
                    lbl_Message.Text = "Mr " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }
                else if (pourc >= 50 || pourc < 70)

                {
                    Mention = "Satisfaction";
                    lbl_Message.Text = "Mr " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }
                else if (pourc >= 70 || pourc < 80)
                {
                    Mention = "Distinction";
                    lbl_Message.Text = "Mr " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }
                else if (pourc >= 80 | pourc < 90)
                {
                    Mention = "Grande Distinction";
                    lbl_Message.Text = "Mr " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }
                else if (pourc >= 90)
                {
                    Mention = "Trés-Grande Distinction";
                    lbl_Message.Text = "Mr " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }

            }
            else if (combo_Sex.Text == "Feminin")
            {
                if (pourc < 50)
                {
                    Mention = "Ajourné";
                    lbl_Message.Text = "Mme " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }
                else if (pourc >= 50 || pourc < 70)

                {
                    Mention = "Satisfaction";
                    lbl_Message.Text = "Mme " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }
                else if (pourc >= 70 || pourc < 80)
                {
                    Mention = "Distinction";
                    lbl_Message.Text = "Mme " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }
                else if (pourc >= 80 || pourc < 90)
                {
                    Mention = "Grande Distinction";
                    lbl_Message.Text = "Mme " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }
                else if (pourc >= 90)
                {
                    Mention = "Trés-Grande Distinction";
                    lbl_Message.Text = "Mme " + txt_Nom.Text + ", Vous avez eu " + pourc + "%, avec la mention :" + Mention.ToString();
                }

            }
        }
    }
}
