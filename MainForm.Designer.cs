namespace CurrencyConverter
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;

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
            this.txtFromCurrency = new System.Windows.Forms.TextBox();
            this.txtToCurrency = new System.Windows.Forms.TextBox();
            this.cmbFromCurrency = new System.Windows.Forms.ComboBox();
            this.cmbToCurrency = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFromCuurency = new System.Windows.Forms.Label();
            this.lblToCurrency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFromCurrency
            // 
            this.txtFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromCurrency.Location = new System.Drawing.Point(199, 84);
            this.txtFromCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.Size = new System.Drawing.Size(610, 44);
            this.txtFromCurrency.TabIndex = 0;
            // 
            // txtToCurrency
            // 
            this.txtToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToCurrency.Location = new System.Drawing.Point(199, 372);
            this.txtToCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.Size = new System.Drawing.Size(610, 44);
            this.txtToCurrency.TabIndex = 1;
            // 
            // cmbFromCurrency
            // 
            this.cmbFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromCurrency.FormattingEnabled = true;
            this.cmbFromCurrency.Location = new System.Drawing.Point(199, 153);
            this.cmbFromCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFromCurrency.Name = "cmbFromCurrency";
            this.cmbFromCurrency.Size = new System.Drawing.Size(610, 40);
            this.cmbFromCurrency.TabIndex = 2;
            // 
            // cmbToCurrency
            // 
            this.cmbToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToCurrency.FormattingEnabled = true;
            this.cmbToCurrency.Location = new System.Drawing.Point(199, 221);
            this.cmbToCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbToCurrency.Name = "cmbToCurrency";
            this.cmbToCurrency.Size = new System.Drawing.Size(610, 40);
            this.cmbToCurrency.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(357, 284);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(215, 61);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFromCuurency
            // 
            this.lblFromCuurency.AutoSize = true;
            this.lblFromCuurency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromCuurency.Location = new System.Drawing.Point(75, 159);
            this.lblFromCuurency.Name = "lblFromCuurency";
            this.lblFromCuurency.Size = new System.Drawing.Size(70, 29);
            this.lblFromCuurency.TabIndex = 5;
            this.lblFromCuurency.Text = "From";
            // 
            // lblToCurrency
            // 
            this.lblToCurrency.AutoSize = true;
            this.lblToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCurrency.Location = new System.Drawing.Point(75, 227);
            this.lblToCurrency.Name = "lblToCurrency";
            this.lblToCurrency.Size = new System.Drawing.Size(43, 29);
            this.lblToCurrency.TabIndex = 6;
            this.lblToCurrency.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Currency Converter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(963, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToCurrency);
            this.Controls.Add(this.lblFromCuurency);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbToCurrency);
            this.Controls.Add(this.cmbFromCurrency);
            this.Controls.Add(this.txtToCurrency);
            this.Controls.Add(this.txtFromCurrency);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromCurrency;
        private System.Windows.Forms.TextBox txtToCurrency;
        private System.Windows.Forms.ComboBox cmbFromCurrency;
        private System.Windows.Forms.ComboBox cmbToCurrency;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFromCuurency;
        private System.Windows.Forms.Label lblToCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

