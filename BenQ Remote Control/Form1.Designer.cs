namespace BenQ_Remote_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Computer = new System.Windows.Forms.Button();
            this.gp_source = new System.Windows.Forms.GroupBox();
            this.btn_HDMI2 = new System.Windows.Forms.Button();
            this.btn_hdmi1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_SendwithEnter = new System.Windows.Forms.Button();
            this.gp_source.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Computer
            // 
            this.btn_Computer.Location = new System.Drawing.Point(21, 34);
            this.btn_Computer.Name = "btn_Computer";
            this.btn_Computer.Size = new System.Drawing.Size(76, 37);
            this.btn_Computer.TabIndex = 1;
            this.btn_Computer.Text = "Computer";
            this.btn_Computer.UseVisualStyleBackColor = true;
            this.btn_Computer.Click += new System.EventHandler(this.btn_Computer_Click);
            // 
            // gp_source
            // 
            this.gp_source.Controls.Add(this.btn_HDMI2);
            this.gp_source.Controls.Add(this.btn_hdmi1);
            this.gp_source.Controls.Add(this.btn_Computer);
            this.gp_source.Location = new System.Drawing.Point(23, 50);
            this.gp_source.Name = "gp_source";
            this.gp_source.Size = new System.Drawing.Size(335, 109);
            this.gp_source.TabIndex = 2;
            this.gp_source.TabStop = false;
            this.gp_source.Text = "Source";
            // 
            // btn_HDMI2
            // 
            this.btn_HDMI2.Location = new System.Drawing.Point(228, 34);
            this.btn_HDMI2.Name = "btn_HDMI2";
            this.btn_HDMI2.Size = new System.Drawing.Size(76, 37);
            this.btn_HDMI2.TabIndex = 3;
            this.btn_HDMI2.Text = "HDMI 2";
            this.btn_HDMI2.UseVisualStyleBackColor = true;
            this.btn_HDMI2.Click += new System.EventHandler(this.btn_HDMI2_Click);
            // 
            // btn_hdmi1
            // 
            this.btn_hdmi1.Location = new System.Drawing.Point(129, 34);
            this.btn_hdmi1.Name = "btn_hdmi1";
            this.btn_hdmi1.Size = new System.Drawing.Size(76, 37);
            this.btn_hdmi1.TabIndex = 2;
            this.btn_hdmi1.Text = "HDMI 1";
            this.btn_hdmi1.UseVisualStyleBackColor = true;
            this.btn_hdmi1.Click += new System.EventHandler(this.btn_hdmi1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 24);
            this.textBox1.TabIndex = 3;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(222, 252);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(76, 37);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_SendwithEnter
            // 
            this.btn_SendwithEnter.Location = new System.Drawing.Point(222, 307);
            this.btn_SendwithEnter.Name = "btn_SendwithEnter";
            this.btn_SendwithEnter.Size = new System.Drawing.Size(105, 37);
            this.btn_SendwithEnter.TabIndex = 5;
            this.btn_SendwithEnter.Text = "Send With Enter";
            this.btn_SendwithEnter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 718);
            this.Controls.Add(this.btn_SendwithEnter);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gp_source);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ephrathah - Benq Remote Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gp_source.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Computer;
        private System.Windows.Forms.GroupBox gp_source;
        private System.Windows.Forms.Button btn_hdmi1;
        private System.Windows.Forms.Button btn_HDMI2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_SendwithEnter;
    }
}

