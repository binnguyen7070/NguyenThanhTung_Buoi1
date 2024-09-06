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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btngiai = new Button();
            btnxoatrang = new Button();
            btnthoat = new Button();
            label5 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 49);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Giải phương trình bậc 2";
            //
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 91);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 1;
            label2.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 142);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 1;
            label3.Text = "b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 237);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 1;
            label4.Text = "Kết quả ";
            label4.Click += label4_Click;
            // 
            // btngiai
            // 
            btngiai.Location = new Point(148, 336);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(75, 23);
            btngiai.TabIndex = 2;
            btngiai.Text = "Giải ";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // btnxoatrang
            // 
            btnxoatrang.Location = new Point(274, 336);
            btnxoatrang.Name = "btnxoatrang";
            btnxoatrang.Size = new Size(75, 23);
            btnxoatrang.TabIndex = 2;
            btnxoatrang.Text = "xóa trắng ";
            btnxoatrang.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(421, 336);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 196);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(13, 15);
            label5.TabIndex = 1;
            label5.Text = "c";
            label5.Click += label4_Click;
            // 
            // txta
            // 
            txta.Location = new Point(124, 91);
            txta.Name = "txta";
            txta.Size = new Size(100, 23);
            txta.TabIndex = 3;
            // 
            // txtb
            // 
            txtb.Location = new Point(125, 139);
            txtb.Name = "txtb";
            txtb.Size = new Size(100, 23);
            txtb.TabIndex = 3;
            // 
            // txtc
            // 
            txtc.Location = new Point(125, 188);
            txtc.Name = "txtc";
            txtc.Size = new Size(100, 23);
            txtc.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(btnthoat);
            Controls.Add(btnxoatrang);
            Controls.Add(btngiai);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btngiai;
        private Button btnxoatrang;
        private Button btnthoat;
        private Label label5;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
    }
}
