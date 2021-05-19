
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
            this.btnToCart = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblProdNm = new System.Windows.Forms.Label();
            this.lblProdNameAct = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbAftDisc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.tBDiscount = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Location = new System.Drawing.Point(28, 25);
            this.lblProdID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(66, 15);
            this.lblProdID.TabIndex = 0;
            this.lblProdID.Text = "Product ID:";
            // 
            // txtBxProdID
            // 
            this.txtBxProdID.Location = new System.Drawing.Point(100, 25);
            this.txtBxProdID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxProdID.Name = "txtBxProdID";
            this.txtBxProdID.Size = new System.Drawing.Size(147, 23);
            this.txtBxProdID.TabIndex = 1;
            // 
            // lBoxIDs
            // 
            this.lBoxIDs.FormattingEnabled = true;
            this.lBoxIDs.ItemHeight = 15;
            this.lBoxIDs.Location = new System.Drawing.Point(273, 33);
            this.lBoxIDs.Margin = new System.Windows.Forms.Padding(2);
            this.lBoxIDs.Name = "lBoxIDs";
            this.lBoxIDs.Size = new System.Drawing.Size(127, 139);
            this.lBoxIDs.TabIndex = 2;
            // 
            // lBoxAmounts
            // 
            this.lBoxAmounts.FormattingEnabled = true;
            this.lBoxAmounts.ItemHeight = 15;
            this.lBoxAmounts.Location = new System.Drawing.Point(418, 33);
            this.lBoxAmounts.Margin = new System.Windows.Forms.Padding(2);
            this.lBoxAmounts.Name = "lBoxAmounts";
            this.lBoxAmounts.Size = new System.Drawing.Size(127, 139);
            this.lBoxAmounts.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(28, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(218, 20);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(28, 245);
            this.btnToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(223, 20);
            this.btnToCart.TabIndex = 5;
            this.btnToCart.Text = "Add to Cart";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(28, 127);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(54, 15);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // lblProdNm
            // 
            this.lblProdNm.AutoSize = true;
            this.lblProdNm.Location = new System.Drawing.Point(28, 92);
            this.lblProdNm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdNm.Name = "lblProdNm";
            this.lblProdNm.Size = new System.Drawing.Size(87, 15);
            this.lblProdNm.TabIndex = 8;
            this.lblProdNm.Text = "Product Name:";
            // 
            // lblProdNameAct
            // 
            this.lblProdNameAct.AutoSize = true;
            this.lblProdNameAct.Location = new System.Drawing.Point(123, 92);
            this.lblProdNameAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdNameAct.Name = "lblProdNameAct";
            this.lblProdNameAct.Size = new System.Drawing.Size(34, 15);
            this.lblProdNameAct.TabIndex = 9;
            this.lblProdNameAct.Text = "none";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(28, 188);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(57, 15);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Discount:";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(273, 217);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(271, 20);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "Payment Confirmed";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(273, 188);
            this.lblTotal1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(71, 15);
            this.lblTotal1.TabIndex = 14;
            this.lblTotal1.Text = "Total to Pay:";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(363, 188);
            this.lblTotal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(34, 15);
            this.lblTotal2.TabIndex = 15;
            this.lblTotal2.Text = "none";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Location = new System.Drawing.Point(28, 157);
            this.lblPrice1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(81, 15);
            this.lblPrice1.TabIndex = 17;
            this.lblPrice1.Text = "Product Price:";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(149, 157);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(103, 23);
            this.txtBoxPrice.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(273, 245);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(271, 20);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset the Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbAftDisc
            // 
            this.tbAftDisc.Location = new System.Drawing.Point(150, 218);
            this.tbAftDisc.Margin = new System.Windows.Forms.Padding(2);
            this.tbAftDisc.Name = "tbAftDisc";
            this.tbAftDisc.Size = new System.Drawing.Size(103, 23);
            this.tbAftDisc.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Price after discount:";
            // 
            // nuUpDownAmount
            // 
            this.nuUpDownAmount.Location = new System.Drawing.Point(149, 127);
            this.nuUpDownAmount.Margin = new System.Windows.Forms.Padding(2);
            this.nuUpDownAmount.Name = "nuUpDownAmount";
            this.nuUpDownAmount.Size = new System.Drawing.Size(102, 23);
            this.nuUpDownAmount.TabIndex = 23;
            // 
            // tBDiscount
            // 
            this.tBDiscount.Location = new System.Drawing.Point(149, 188);
            this.tBDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.tBDiscount.Name = "tBDiscount";
            this.tBDiscount.Size = new System.Drawing.Size(103, 23);
            this.tBDiscount.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-1862, 193);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 23);
            this.textBox3.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(-1621, 371);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(980, 23);
            this.textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(-1482, 354);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(224, 23);
            this.textBox6.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "IDs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Qty";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tBDiscount);
            this.Controls.Add(this.nuUpDownAmount);
            this.Controls.Add(this.tbAftDisc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblProdNameAct);
            this.Controls.Add(this.lblProdNm);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lBoxAmounts);
            this.Controls.Add(this.lBoxIDs);
            this.Controls.Add(this.txtBxProdID);
            this.Controls.Add(this.lblProdID);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblProdNm;
        private System.Windows.Forms.Label lblProdNameAct;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbAftDisc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuUpDownAmount;
        private System.Windows.Forms.TextBox tBDiscount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}