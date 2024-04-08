﻿using System;
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
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                textCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                textM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                textKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                textIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                textFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                textYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }

        private void textCM_KeyUp(object sender, KeyEventArgs e)
        {
          
                strInput = textCM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                 
                textInfo.Text = "請輸入數字";
                textCM.Text = "";
            }


        }

        private void textM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = textM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput*100);
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
                caculateAnswer(2, douOutput*100000);
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
                caculateAnswer(3, douOutput*2.54);
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
                caculateAnswer(4, douOutput*30.98);

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
                caculateAnswer(5, douOutput * 91.44);
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
    
