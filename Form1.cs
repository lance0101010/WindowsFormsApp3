using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInput;
        double douOutput;
        private void button_Click(object sender, EventArgs e)
        {
            // 給予每一個輸入文字框一個「空字串」
            textCM.Text = "";
            textM.Text = "";
            textKM.Text = "";
            textIn.Text = "";
            textFt.Text = "";
            textYard.Text = "";
            textInfo.Text = "";
        }

        private void textCM_KeyUp(object sender, KeyEventArgs e)
        {
          
                strInput = textCM.Text; // 將txtCM文字框的值放入strInput變數

                // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
                if (double.TryParse(strInput, out douOutput) == true)
                {
                    textM.Text = string.Format("{0:0.##########}", douOutput / 100);
                    textKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                    textIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                    textFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                    textYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                    textInfo.Text = "請輸入數字";
                    textCM.Text = "";
                }


                /*double douCM; //宣告一個double變數，變數名稱叫douCM

                douCM = Convert.ToDouble(textCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

                textM.Text = string.Format("{0:0.##########}", douCM / 100);
            textKM.Text = string.Format("{0:0.#########}", douCM / 100000);
            textIn.Text = string.Format("{0:0.########}", douCM /2.54);
            textFt.Text = string.Format("{0:0.########}", douCM /30.4878);
            textYard.Text = string.Format("{0:0.########}", douCM /91.44);
            //將douCM的數值除以100，也就是從公分轉換成公尺
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果*/

            }

        private void textM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                textCM.Text = string.Format("{0:0.##########}", douOutput * 100);
                textKM.Text = string.Format("{0:0.#########}", douOutput / 1000);
                textIn.Text = string.Format("{0:0.########}", douOutput * 39.37);
                textFt.Text = string.Format("{0:0.########}", douOutput * 3.281);
            textYard.Text = string.Format("{0:0.########}", douOutput * 1.094);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textM.Text = "";
            }
        }

        private void textKM_KeyUp(object sender, KeyEventArgs e)
        {

            strInput = textKM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                textCM.Text = string.Format("{0:0.##########}", douOutput * 100000);
                textM.Text = string.Format("{0:0.#########}", douOutput * 1000);
                textIn.Text = string.Format("{0:0.########}", douOutput * 39370.1);
                textFt.Text = string.Format("{0:0.########}", douOutput * 3280.84);
                textYard.Text = string.Format("{0:0.########}", douOutput * 1093.61);
            }

            else
            {
                textInfo.Text = "請輸入數字";
                textKM.Text = "";
            }
        }

        private void textIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textIn.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                textCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);
                textM.Text = string.Format("{0:0.#########}", douOutput / 39.3701);
                textKM.Text = string.Format("{0:0.########}", douOutput / 39370.0787);
                textFt.Text = string.Format("{0:0.########}", douOutput / 12);
                textYard.Text = string.Format("{0:0.########}", douOutput / 35.971);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textIn.Text = "";
            }
        }

        private void textFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textFt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                textCM.Text = string.Format("{0:0.##########}", douOutput * 30.48);
                textM.Text = string.Format("{0:0.##########}", douOutput * 0.3048);
                textKM.Text = string.Format("{0:0.##########}", douOutput * 0.0003048);
                textIn.Text = string.Format("{0:0.##########}", douOutput * 12);
                textYard.Text = string.Format("{0:0.##########}", douOutput * 0.3333);

            }
            else
            {
                textInfo.Text = "請輸入數字";
                textFt.Text = "";
            }

           
        }

        private void textYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textYard.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                textCM.Text = string.Format("{0:0.##########}", douOutput * 91.44);
                textM.Text = string.Format("{0:0.##########}", douOutput * 0.9144);
                textKM.Text = string.Format("{0:0.##########}", douOutput * 0.0009144);
                textIn.Text = string.Format("{0:0.##########}", douOutput * 36);
                textFt.Text = string.Format("{0:0.##########}", douOutput * 3);
            }
            else
            {
                textInfo.Text = "請輸入數字";
                textYard.Text = "";
            }

            
        }

        private void textInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
