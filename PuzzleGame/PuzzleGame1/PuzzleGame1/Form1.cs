using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hamleSayisi = 0, labelIndex = 0;

        private void shuffleButtons()
        {
            List<int> labelList = new List<int>();
            Random rand = new Random();
            foreach(Button btn in this.pnl.Controls)
            {
                while (labelList.Contains(labelIndex))
                    labelIndex = rand.Next(9);

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList.Add(labelIndex);
            }

            hamleSayisi = 0;
            lblHamle.Text = "Hamle Sayısı : " + hamleSayisi;
        }

        private void swapLabel(Object sender,EventArgs e) // butonlara tıklayınca yer değiştirme olayı 
        {
            Button btn = (Button)sender;
            if(btn.Text == "")
            {
                return;
            }
            Button beyazBtn = null;
            foreach(Button bt in this.pnl.Controls)
            {
                if(bt.Text == "")
                {
                    beyazBtn = bt;
                    break;
                }
            }

            
            if (btn.TabIndex == (beyazBtn.TabIndex - 1) ||
                btn.TabIndex == (beyazBtn.TabIndex - 3) ||
                btn.TabIndex == (beyazBtn.TabIndex + 1) ||
                btn.TabIndex == (beyazBtn.TabIndex + 3))
            {
                beyazBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                beyazBtn.Text = btn.Text;
                btn.Text = "";
                hamleSayisi++;
                lblHamle.Text = "Hamle Sayısı : " + hamleSayisi;
            }

            checkOrder();
        }

        private void checkOrder()
        {
            int index = 0;
            foreach(Button btn in this.pnl.Controls)
            {
                if(btn.Text!= "" && Convert.ToInt16(btn.Text) != index)
                {
                    return;

                }

                index++;
            }

            MessageBox.Show("Tebrikler !  "+ hamleSayisi+ "yaparak başardınız");
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            shuffleButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shuffleButtons();
        }
    }
}
