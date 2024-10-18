using System.Drawing.Text;
using System.Windows.Forms;

namespace Hesap_Makinası
{
    public partial class Calculator : Form
    {

        char _islem;
        bool ekranTemizlenecekMi;
        int _ilkSayi;

        public Calculator()
        {
            InitializeComponent();
        }



        private void button0_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }

            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "0";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "1";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "6";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (labelSonuc.Text == "3") labelSonuc.Text = "";

            labelSonuc.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "4";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }

            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                labelSonuc.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (labelSonuc.Text == "0") labelSonuc.Text = "";

            labelSonuc.Text += "9";


        }

        private void buttonTopla_Click(object sender, EventArgs e)
        {
           
            _islem = '+';
            ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(labelSonuc.Text);

        }

        private void buttonCikart_Click(object sender, EventArgs e)
        {

            _islem = '-';
            ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(labelSonuc.Text);
            

        }

        private void buttonCarp_Click(object sender, EventArgs e)
        {
            
            _islem = '*';
            ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(labelSonuc.Text);
        
        }
        private void buttonBol_Click(object sender, EventArgs e)
        {
                
                _islem = '/';
                ekranTemizlenecekMi = true;
                _ilkSayi = Convert.ToInt32(labelSonuc.Text);
            }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {


            int ikinciSayi = Convert.ToInt32(labelSonuc.Text);
            int sonuc;

            switch (_islem)
            {
                default:

                    sonuc = 0;
                    break;

                case '+':
                    sonuc = _ilkSayi + ikinciSayi;

                    break;
            }
            switch (_islem)
            {
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;

                    break;
            }
            switch (_islem)
            {
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;

                    break;
            }
            switch (_islem)
            {
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;

                    break;


                
            }

            labelSonuc.Text = Convert.ToString(sonuc);

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            labelSonuc.Text = "0";

        }


    }

}