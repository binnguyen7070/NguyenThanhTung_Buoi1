namespace NguyenThanhTung_Buoi1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btngiai = new Button();
            btnxoatrang = new Button();
            btnthoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblketqua = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label5 = new Label();
            lblKQ = new Label();
            SuspendLayout();
            // 
            // btngiai
            // 
            btngiai.Location = new Point(196, 329);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(75, 23);
            btngiai.TabIndex = 0;
            btngiai.Text = "Giải ";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // btnxoatrang
            // 
            btnxoatrang.Location = new Point(358, 329);
            btnxoatrang.Name = "btnxoatrang";
            btnxoatrang.Size = new Size(75, 23);
            btnxoatrang.TabIndex = 0;
            btnxoatrang.Text = "Xóa trắng ";
            btnxoatrang.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(522, 329);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 0;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 65);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 1;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 106);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 139);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 1;
            label3.Text = "C";
            label3.Click += label3_Click;
            // 
            // lblketqua
            // 
            lblketqua.AutoSize = true;
            lblketqua.Location = new Point(169, 198);
            lblketqua.Name = "lblketqua";
            lblketqua.Size = new Size(47, 15);
            lblketqua.TabIndex = 1;
            lblketqua.Text = "Kết quả";
            // 
            // txtA
            // 
            txtA.Location = new Point(272, 65);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(272, 98);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.Location = new Point(272, 139);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 21);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 1;
            label5.Text = "Giải phương trình bậc 2";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.BackColor = SystemColors.AppWorkspace;
            lblKQ.Location = new Point(225, 245);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(319, 15);
            lblKQ.TabIndex = 3;
            lblKQ.Text = "                                                                                                        ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKQ);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblketqua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnthoat);
            Controls.Add(btnxoatrang);
            Controls.Add(btngiai);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btngiai;
        private Button btnxoatrang;
        private Button btnthoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblketqua;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label5;
        private Label lblKQ;
    }
}
