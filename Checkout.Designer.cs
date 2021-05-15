
namespace TheComfortZone
{
    partial class Checkout
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
            this.lblProdID = new System.Windows.Forms.Label();
            this.txtBxProdID = new System.Windows.Forms.TextBox();
            this.lBoxIDs = new System.Windows.Forms.ListBox();
            this.lBoxAmounts = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblProdNm = new System.Windows.Forms.Label();
            this.lblProdNameAct = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbAftDisc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuUpDownAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Location = new System.Drawing.Point(40, 42);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(101, 25);
            this.lblProdID.TabIndex = 0;
            this.lblProdID.Text = "Product ID:";
            // 
            // txtBxProdID
            // 
            this.txtBxProdID.Location = new System.Drawing.Point(143, 42);
            this.txtBxProdID.Name = "txtBxProdID";
            this.txtBxProdID.Size = new System.Drawing.Size(208, 31);
            this.txtBxProdID.TabIndex = 1;
            // 
            // lBoxIDs
            // 
            this.lBoxIDs.FormattingEnabled = true;
            this.lBoxIDs.ItemHeight = 25;
            this.lBoxIDs.Location = new System.Drawing.Point(390, 42);
            this.lBoxIDs.Name = "lBoxIDs";
            this.lBoxIDs.Size = new System.Drawing.Size(180, 254);
            this.lBoxIDs.TabIndex = 2;
            // 
            // lBoxAmounts
            // 
            this.lBoxAmounts.FormattingEnabled = true;
            this.lBoxAmounts.ItemHeight = 25;
            this.lBoxAmounts.Location = new System.Drawing.Point(597, 42);
            this.lBoxAmounts.Name = "lBoxAmounts";
            this.lBoxAmounts.Size = new System.Drawing.Size(180, 254);
            this.lBoxAmounts.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(40, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(311, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add to Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(40, 211);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(81, 25);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // lblProdNm
            // 
            this.lblProdNm.AutoSize = true;
            this.lblProdNm.Location = new System.Drawing.Point(40, 154);
            this.lblProdNm.Name = "lblProdNm";
            this.lblProdNm.Size = new System.Drawing.Size(130, 25);
            this.lblProdNm.TabIndex = 8;
            this.lblProdNm.Text = "Product Name:";
            // 
            // lblProdNameAct
            // 
            this.lblProdNameAct.AutoSize = true;
            this.lblProdNameAct.Location = new System.Drawing.Point(176, 154);
            this.lblProdNameAct.Name = "lblProdNameAct";
            this.lblProdNameAct.Size = new System.Drawing.Size(52, 25);
            this.lblProdNameAct.TabIndex = 9;
            this.lblProdNameAct.Text = "none";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(40, 313);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(86, 25);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Discount:";
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Location = new System.Drawing.Point(213, 310);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(146, 33);
            this.comboBoxDiscount.TabIndex = 11;
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(597, 313);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(180, 34);
            this.btnTax.TabIndex = 12;
            this.btnTax.Text = "Tax Invoice";
            this.btnTax.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(390, 361);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(387, 34);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(390, 313);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(107, 25);
            this.lblTotal1.TabIndex = 14;
            this.lblTotal1.Text = "Total to Pay:";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(518, 313);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(52, 25);
            this.lblTotal2.TabIndex = 15;
            this.lblTotal2.Text = "none";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Location = new System.Drawing.Point(40, 262);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(120, 25);
            this.lblPrice1.TabIndex = 17;
            this.lblPrice1.Text = "Product Price:";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(213, 262);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(146, 31);
            this.txtBoxPrice.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(390, 408);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(387, 34);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset the Form";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // tbAftDisc
            // 
            this.tbAftDisc.Location = new System.Drawing.Point(214, 358);
            this.tbAftDisc.Name = "tbAftDisc";
            this.tbAftDisc.Size = new System.Drawing.Size(145, 31);
            this.tbAftDisc.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Price after discount:";
            // 
            // nuUpDownAmount
            // 
            this.nuUpDownAmount.Location = new System.Drawing.Point(213, 211);
            this.nuUpDownAmount.Name = "nuUpDownAmount";
            this.nuUpDownAmount.Size = new System.Drawing.Size(146, 31);
            this.nuUpDownAmount.TabIndex = 23;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nuUpDownAmount);
            this.Controls.Add(this.tbAftDisc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.comboBoxDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblProdNameAct);
            this.Controls.Add(this.lblProdNm);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lBoxAmounts);
            this.Controls.Add(this.lBoxIDs);
            this.Controls.Add(this.txtBxProdID);
            this.Controls.Add(this.lblProdID);
            this.Name = "Checkout";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.TextBox txtBxProdID;
        private System.Windows.Forms.ListBox lBoxIDs;
        private System.Windows.Forms.ListBox lBoxAmounts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblProdNm;
        private System.Windows.Forms.Label lblProdNameAct;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbAftDisc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuUpDownAmount;
    }
}