﻿
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textCM = new System.Windows.Forms.TextBox();
            this.textM = new System.Windows.Forms.TextBox();
            this.textKM = new System.Windows.Forms.TextBox();
            this.textIn = new System.Windows.Forms.TextBox();
            this.textFt = new System.Windows.Forms.TextBox();
            this.textYard = new System.Windows.Forms.TextBox();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCM
            // 
            this.textCM.Location = new System.Drawing.Point(148, 136);
            this.textCM.Margin = new System.Windows.Forms.Padding(4);
            this.textCM.Name = "textCM";
            this.textCM.Size = new System.Drawing.Size(132, 25);
            this.textCM.TabIndex = 0;
            this.textCM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCM_KeyUp);
            // 
            // textM
            // 
            this.textM.Location = new System.Drawing.Point(383, 136);
            this.textM.Margin = new System.Windows.Forms.Padding(4);
            this.textM.Name = "textM";
            this.textM.Size = new System.Drawing.Size(132, 25);
            this.textM.TabIndex = 1;
            this.textM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textM_KeyUp);
            // 
            // textKM
            // 
            this.textKM.Location = new System.Drawing.Point(611, 136);
            this.textKM.Margin = new System.Windows.Forms.Padding(4);
            this.textKM.Name = "textKM";
            this.textKM.Size = new System.Drawing.Size(132, 25);
            this.textKM.TabIndex = 2;
            this.textKM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textKM_KeyUp);
            // 
            // textIn
            // 
            this.textIn.Location = new System.Drawing.Point(148, 249);
            this.textIn.Margin = new System.Windows.Forms.Padding(4);
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(132, 25);
            this.textIn.TabIndex = 3;
            this.textIn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textIn_KeyUp);
            // 
            // textFt
            // 
            this.textFt.Location = new System.Drawing.Point(383, 249);
            this.textFt.Margin = new System.Windows.Forms.Padding(4);
            this.textFt.Name = "textFt";
            this.textFt.Size = new System.Drawing.Size(132, 25);
            this.textFt.TabIndex = 4;
            this.textFt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textFt_KeyUp);
            // 
            // textYard
            // 
            this.textYard.Location = new System.Drawing.Point(611, 249);
            this.textYard.Margin = new System.Windows.Forms.Padding(4);
            this.textYard.Name = "textYard";
            this.textYard.Size = new System.Drawing.Size(132, 25);
            this.textYard.TabIndex = 5;
            this.textYard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textYard_KeyUp);
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(383, 386);
            this.textInfo.Margin = new System.Windows.Forms.Padding(4);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(363, 25);
            this.textInfo.TabIndex = 6;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(848, 136);
            this.button.Margin = new System.Windows.Forms.Padding(4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(119, 74);
            this.button.TabIndex = 7;
            this.button.Text = "清除";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "公分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "公尺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "公里";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "英吋";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "英尺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "英碼";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "說明";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.textYard);
            this.Controls.Add(this.textFt);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.textKM);
            this.Controls.Add(this.textM);
            this.Controls.Add(this.textCM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCM;
        private System.Windows.Forms.TextBox textM;
        private System.Windows.Forms.TextBox textKM;
        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.TextBox textFt;
        private System.Windows.Forms.TextBox textYard;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

