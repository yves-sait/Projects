
namespace LunchOrder
{
    partial class LunchOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LunchOrder));
            this.grpbMain = new System.Windows.Forms.GroupBox();
            this.rdbSalad = new System.Windows.Forms.RadioButton();
            this.rdbPizza = new System.Windows.Forms.RadioButton();
            this.rdbHam = new System.Windows.Forms.RadioButton();
            this.grpbOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.grpbAddOn = new System.Windows.Forms.GroupBox();
            this.chkbAdd3 = new System.Windows.Forms.CheckBox();
            this.chkbAdd2 = new System.Windows.Forms.CheckBox();
            this.chkbAdd1 = new System.Windows.Forms.CheckBox();
            this.grpbMain.SuspendLayout();
            this.grpbOrderTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.grpbAddOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbMain
            // 
            this.grpbMain.Controls.Add(this.rdbSalad);
            this.grpbMain.Controls.Add(this.rdbPizza);
            this.grpbMain.Controls.Add(this.rdbHam);
            this.grpbMain.Location = new System.Drawing.Point(39, 17);
            this.grpbMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpbMain.Name = "grpbMain";
            this.grpbMain.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpbMain.Size = new System.Drawing.Size(334, 164);
            this.grpbMain.TabIndex = 0;
            this.grpbMain.TabStop = false;
            this.grpbMain.Text = "Main Menu";
            // 
            // rdbSalad
            // 
            this.rdbSalad.AutoSize = true;
            this.rdbSalad.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbSalad.Location = new System.Drawing.Point(19, 118);
            this.rdbSalad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSalad.Name = "rdbSalad";
            this.rdbSalad.Size = new System.Drawing.Size(79, 26);
            this.rdbSalad.TabIndex = 2;
            this.rdbSalad.Text = "Salad";
            this.rdbSalad.UseVisualStyleBackColor = true;
            this.rdbSalad.CheckedChanged += new System.EventHandler(this.rdbMainMenu_CheckedChanged);
            // 
            // rdbPizza
            // 
            this.rdbPizza.AutoSize = true;
            this.rdbPizza.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPizza.Location = new System.Drawing.Point(19, 86);
            this.rdbPizza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbPizza.Name = "rdbPizza";
            this.rdbPizza.Size = new System.Drawing.Size(74, 26);
            this.rdbPizza.TabIndex = 1;
            this.rdbPizza.Text = "Pizza";
            this.rdbPizza.UseVisualStyleBackColor = true;
            this.rdbPizza.CheckedChanged += new System.EventHandler(this.rdbMainMenu_CheckedChanged);
            // 
            // rdbHam
            // 
            this.rdbHam.AutoSize = true;
            this.rdbHam.Checked = true;
            this.rdbHam.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbHam.Location = new System.Drawing.Point(19, 53);
            this.rdbHam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbHam.Name = "rdbHam";
            this.rdbHam.Size = new System.Drawing.Size(128, 26);
            this.rdbHam.TabIndex = 0;
            this.rdbHam.TabStop = true;
            this.rdbHam.Text = "Hamburger";
            this.rdbHam.UseVisualStyleBackColor = true;
            this.rdbHam.CheckedChanged += new System.EventHandler(this.rdbMainMenu_CheckedChanged);
            // 
            // grpbOrderTotal
            // 
            this.grpbOrderTotal.Controls.Add(this.txtOrderTotal);
            this.grpbOrderTotal.Controls.Add(this.txtTax);
            this.grpbOrderTotal.Controls.Add(this.txtSubTotal);
            this.grpbOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grpbOrderTotal.Controls.Add(this.lblTax);
            this.grpbOrderTotal.Controls.Add(this.lblSubTotal);
            this.grpbOrderTotal.Location = new System.Drawing.Point(39, 201);
            this.grpbOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbOrderTotal.Name = "grpbOrderTotal";
            this.grpbOrderTotal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbOrderTotal.Size = new System.Drawing.Size(334, 176);
            this.grpbOrderTotal.TabIndex = 1;
            this.grpbOrderTotal.TabStop = false;
            this.grpbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderTotal.Location = new System.Drawing.Point(164, 134);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(147, 28);
            this.txtOrderTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTax.Location = new System.Drawing.Point(164, 93);
            this.txtTax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(147, 28);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubTotal.Location = new System.Drawing.Point(164, 51);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(147, 28);
            this.txtSubTotal.TabIndex = 3;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTotal.Location = new System.Drawing.Point(31, 134);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(127, 28);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total:";
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(47, 93);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(112, 28);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (5%):";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(45, 50);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(113, 28);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "SubTotal:";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOrder
            // 
            this.BtnOrder.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOrder.Location = new System.Drawing.Point(39, 405);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(153, 49);
            this.BtnOrder.TabIndex = 5;
            this.BtnOrder.Text = "&Place Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(220, 405);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(153, 49);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "&Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(39, 512);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(153, 49);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // picMenu
            // 
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(398, 218);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(334, 236);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 8;
            this.picMenu.TabStop = false;
            // 
            // grpbAddOn
            // 
            this.grpbAddOn.Controls.Add(this.chkbAdd3);
            this.grpbAddOn.Controls.Add(this.chkbAdd2);
            this.grpbAddOn.Controls.Add(this.chkbAdd1);
            this.grpbAddOn.Location = new System.Drawing.Point(398, 17);
            this.grpbAddOn.Name = "grpbAddOn";
            this.grpbAddOn.Size = new System.Drawing.Size(334, 164);
            this.grpbAddOn.TabIndex = 9;
            this.grpbAddOn.TabStop = false;
            this.grpbAddOn.Text = "Add-on items ($/each)";
            // 
            // chkbAdd3
            // 
            this.chkbAdd3.AutoSize = true;
            this.chkbAdd3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAdd3.Location = new System.Drawing.Point(21, 119);
            this.chkbAdd3.Name = "chkbAdd3";
            this.chkbAdd3.Size = new System.Drawing.Size(176, 26);
            this.chkbAdd3.TabIndex = 2;
            this.chkbAdd3.Text = "Add On Option 3";
            this.chkbAdd3.UseVisualStyleBackColor = true;
            // 
            // chkbAdd2
            // 
            this.chkbAdd2.AutoSize = true;
            this.chkbAdd2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAdd2.Location = new System.Drawing.Point(21, 87);
            this.chkbAdd2.Name = "chkbAdd2";
            this.chkbAdd2.Size = new System.Drawing.Size(176, 26);
            this.chkbAdd2.TabIndex = 1;
            this.chkbAdd2.Text = "Add On Option 2";
            this.chkbAdd2.UseVisualStyleBackColor = true;
            // 
            // chkbAdd1
            // 
            this.chkbAdd1.AutoSize = true;
            this.chkbAdd1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAdd1.Location = new System.Drawing.Point(21, 53);
            this.chkbAdd1.Name = "chkbAdd1";
            this.chkbAdd1.Size = new System.Drawing.Size(176, 26);
            this.chkbAdd1.TabIndex = 0;
            this.chkbAdd1.Text = "Add On Option 1";
            this.chkbAdd1.UseVisualStyleBackColor = true;
            // 
            // LunchOrder
            // 
            this.AcceptButton = this.BtnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.BtnReset;
            this.ClientSize = new System.Drawing.Size(760, 573);
            this.Controls.Add(this.grpbAddOn);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.grpbOrderTotal);
            this.Controls.Add(this.grpbMain);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LunchOrder";
            this.Text = "Lunch Order";
            this.grpbMain.ResumeLayout(false);
            this.grpbMain.PerformLayout();
            this.grpbOrderTotal.ResumeLayout(false);
            this.grpbOrderTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.grpbAddOn.ResumeLayout(false);
            this.grpbAddOn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbMain;
        private System.Windows.Forms.RadioButton rdbSalad;
        private System.Windows.Forms.RadioButton rdbPizza;
        private System.Windows.Forms.RadioButton rdbHam;
        private System.Windows.Forms.GroupBox grpbOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.GroupBox grpbAddOn;
        private System.Windows.Forms.CheckBox chkbAdd3;
        private System.Windows.Forms.CheckBox chkbAdd2;
        private System.Windows.Forms.CheckBox chkbAdd1;
    }
}

