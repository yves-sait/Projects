
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
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbPizza = new System.Windows.Forms.RadioButton();
            this.rdbHam = new System.Windows.Forms.RadioButton();
            this.grpbOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.grpbAddHam = new System.Windows.Forms.GroupBox();
            this.chkbAddHam3 = new System.Windows.Forms.CheckBox();
            this.chkbAddHam2 = new System.Windows.Forms.CheckBox();
            this.chkbAddHam1 = new System.Windows.Forms.CheckBox();
            this.grpbAddPizza = new System.Windows.Forms.GroupBox();
            this.chkbAddPizza3 = new System.Windows.Forms.CheckBox();
            this.chkbAddPizza2 = new System.Windows.Forms.CheckBox();
            this.chkbAddPizza1 = new System.Windows.Forms.CheckBox();
            this.grpbAddSalad = new System.Windows.Forms.GroupBox();
            this.chkbAddSalad3 = new System.Windows.Forms.CheckBox();
            this.chkbAddSalad2 = new System.Windows.Forms.CheckBox();
            this.chkbAddSalad1 = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.grbMain.SuspendLayout();
            this.grpbOrderTotal.SuspendLayout();
            this.grpbAddHam.SuspendLayout();
            this.grpbAddPizza.SuspendLayout();
            this.grpbAddSalad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.radioButton2);
            this.grbMain.Controls.Add(this.rdbPizza);
            this.grbMain.Controls.Add(this.rdbHam);
            this.grbMain.Location = new System.Drawing.Point(39, 17);
            this.grbMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbMain.Name = "grbMain";
            this.grbMain.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbMain.Size = new System.Drawing.Size(263, 164);
            this.grbMain.TabIndex = 0;
            this.grbMain.TabStop = false;
            this.grbMain.Text = "Main Menu";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(19, 118);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 26);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Salad - $4.95";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdbPizza
            // 
            this.rdbPizza.AutoSize = true;
            this.rdbPizza.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPizza.Location = new System.Drawing.Point(19, 86);
            this.rdbPizza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbPizza.Name = "rdbPizza";
            this.rdbPizza.Size = new System.Drawing.Size(144, 26);
            this.rdbPizza.TabIndex = 1;
            this.rdbPizza.TabStop = true;
            this.rdbPizza.Text = "Pizza - $5.95";
            this.rdbPizza.UseVisualStyleBackColor = true;
            // 
            // rdbHam
            // 
            this.rdbHam.AutoSize = true;
            this.rdbHam.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbHam.Location = new System.Drawing.Point(19, 53);
            this.rdbHam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbHam.Name = "rdbHam";
            this.rdbHam.Size = new System.Drawing.Size(198, 26);
            this.rdbHam.TabIndex = 0;
            this.rdbHam.TabStop = true;
            this.rdbHam.Text = "Hamburger - $6.95";
            this.rdbHam.UseVisualStyleBackColor = true;
            // 
            // grpbOrderTotal
            // 
            this.grpbOrderTotal.Controls.Add(this.txtOrderTotal);
            this.grpbOrderTotal.Controls.Add(this.txtTax);
            this.grpbOrderTotal.Controls.Add(this.txtSubTotal);
            this.grpbOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grpbOrderTotal.Controls.Add(this.lblTax);
            this.grpbOrderTotal.Controls.Add(this.lblSubTotal);
            this.grpbOrderTotal.Location = new System.Drawing.Point(39, 391);
            this.grpbOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbOrderTotal.Name = "grpbOrderTotal";
            this.grpbOrderTotal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbOrderTotal.Size = new System.Drawing.Size(374, 203);
            this.grpbOrderTotal.TabIndex = 1;
            this.grpbOrderTotal.TabStop = false;
            this.grpbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderTotal.Location = new System.Drawing.Point(169, 138);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(147, 28);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.Text = "Test";
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTax.Location = new System.Drawing.Point(169, 97);
            this.txtTax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(147, 28);
            this.txtTax.TabIndex = 4;
            this.txtTax.Text = "Test";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubTotal.Location = new System.Drawing.Point(169, 55);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(147, 28);
            this.txtSubTotal.TabIndex = 3;
            this.txtSubTotal.Text = "Test";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTotal.Location = new System.Drawing.Point(36, 138);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(127, 28);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total:";
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(52, 97);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(112, 28);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (5%):";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(50, 55);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(113, 28);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "SubTotal:";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbAddHam
            // 
            this.grpbAddHam.Controls.Add(this.chkbAddHam3);
            this.grpbAddHam.Controls.Add(this.chkbAddHam2);
            this.grpbAddHam.Controls.Add(this.chkbAddHam1);
            this.grpbAddHam.Location = new System.Drawing.Point(327, 17);
            this.grpbAddHam.Name = "grpbAddHam";
            this.grpbAddHam.Size = new System.Drawing.Size(334, 164);
            this.grpbAddHam.TabIndex = 2;
            this.grpbAddHam.TabStop = false;
            this.grpbAddHam.Text = "Add-on items ($0.75/each)";
            // 
            // chkbAddHam3
            // 
            this.chkbAddHam3.AutoSize = true;
            this.chkbAddHam3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddHam3.Location = new System.Drawing.Point(21, 119);
            this.chkbAddHam3.Name = "chkbAddHam3";
            this.chkbAddHam3.Size = new System.Drawing.Size(137, 26);
            this.chkbAddHam3.TabIndex = 2;
            this.chkbAddHam3.Text = "French Fries";
            this.chkbAddHam3.UseVisualStyleBackColor = true;
            // 
            // chkbAddHam2
            // 
            this.chkbAddHam2.AutoSize = true;
            this.chkbAddHam2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddHam2.Location = new System.Drawing.Point(21, 87);
            this.chkbAddHam2.Name = "chkbAddHam2";
            this.chkbAddHam2.Size = new System.Drawing.Size(278, 26);
            this.chkbAddHam2.TabIndex = 1;
            this.chkbAddHam2.Text = "Ketchup. mustard and mayo";
            this.chkbAddHam2.UseVisualStyleBackColor = true;
            // 
            // chkbAddHam1
            // 
            this.chkbAddHam1.AutoSize = true;
            this.chkbAddHam1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddHam1.Location = new System.Drawing.Point(21, 53);
            this.chkbAddHam1.Name = "chkbAddHam1";
            this.chkbAddHam1.Size = new System.Drawing.Size(268, 26);
            this.chkbAddHam1.TabIndex = 0;
            this.chkbAddHam1.Text = "Lettuce, tomato and onions";
            this.chkbAddHam1.UseVisualStyleBackColor = true;
            // 
            // grpbAddPizza
            // 
            this.grpbAddPizza.Controls.Add(this.chkbAddPizza3);
            this.grpbAddPizza.Controls.Add(this.chkbAddPizza2);
            this.grpbAddPizza.Controls.Add(this.chkbAddPizza1);
            this.grpbAddPizza.Location = new System.Drawing.Point(39, 651);
            this.grpbAddPizza.Name = "grpbAddPizza";
            this.grpbAddPizza.Size = new System.Drawing.Size(339, 164);
            this.grpbAddPizza.TabIndex = 3;
            this.grpbAddPizza.TabStop = false;
            this.grpbAddPizza.Text = "Add-on items ($0.50/each)";
            // 
            // chkbAddPizza3
            // 
            this.chkbAddPizza3.AutoSize = true;
            this.chkbAddPizza3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddPizza3.Location = new System.Drawing.Point(21, 119);
            this.chkbAddPizza3.Name = "chkbAddPizza3";
            this.chkbAddPizza3.Size = new System.Drawing.Size(84, 26);
            this.chkbAddPizza3.TabIndex = 2;
            this.chkbAddPizza3.Text = "Olives";
            this.chkbAddPizza3.UseVisualStyleBackColor = true;
            // 
            // chkbAddPizza2
            // 
            this.chkbAddPizza2.AutoSize = true;
            this.chkbAddPizza2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddPizza2.Location = new System.Drawing.Point(21, 87);
            this.chkbAddPizza2.Name = "chkbAddPizza2";
            this.chkbAddPizza2.Size = new System.Drawing.Size(105, 26);
            this.chkbAddPizza2.TabIndex = 1;
            this.chkbAddPizza2.Text = "Sausage";
            this.chkbAddPizza2.UseVisualStyleBackColor = true;
            // 
            // chkbAddPizza1
            // 
            this.chkbAddPizza1.AutoSize = true;
            this.chkbAddPizza1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddPizza1.Location = new System.Drawing.Point(21, 53);
            this.chkbAddPizza1.Name = "chkbAddPizza1";
            this.chkbAddPizza1.Size = new System.Drawing.Size(117, 26);
            this.chkbAddPizza1.TabIndex = 0;
            this.chkbAddPizza1.Text = "Pepperoni";
            this.chkbAddPizza1.UseVisualStyleBackColor = true;
            // 
            // grpbAddSalad
            // 
            this.grpbAddSalad.Controls.Add(this.chkbAddSalad3);
            this.grpbAddSalad.Controls.Add(this.chkbAddSalad2);
            this.grpbAddSalad.Controls.Add(this.chkbAddSalad1);
            this.grpbAddSalad.Location = new System.Drawing.Point(421, 651);
            this.grpbAddSalad.Name = "grpbAddSalad";
            this.grpbAddSalad.Size = new System.Drawing.Size(364, 164);
            this.grpbAddSalad.TabIndex = 4;
            this.grpbAddSalad.TabStop = false;
            this.grpbAddSalad.Text = "Add-on items ($0.25/each)";
            this.grpbAddSalad.Visible = false;
            // 
            // chkbAddSalad3
            // 
            this.chkbAddSalad3.AutoSize = true;
            this.chkbAddSalad3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddSalad3.Location = new System.Drawing.Point(21, 119);
            this.chkbAddSalad3.Name = "chkbAddSalad3";
            this.chkbAddSalad3.Size = new System.Drawing.Size(140, 26);
            this.chkbAddSalad3.TabIndex = 2;
            this.chkbAddSalad3.Text = "Bread Sticks";
            this.chkbAddSalad3.UseVisualStyleBackColor = true;
            // 
            // chkbAddSalad2
            // 
            this.chkbAddSalad2.AutoSize = true;
            this.chkbAddSalad2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddSalad2.Location = new System.Drawing.Point(21, 87);
            this.chkbAddSalad2.Name = "chkbAddSalad2";
            this.chkbAddSalad2.Size = new System.Drawing.Size(122, 26);
            this.chkbAddSalad2.TabIndex = 1;
            this.chkbAddSalad2.Text = "Bacon bits";
            this.chkbAddSalad2.UseVisualStyleBackColor = true;
            // 
            // chkbAddSalad1
            // 
            this.chkbAddSalad1.AutoSize = true;
            this.chkbAddSalad1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbAddSalad1.Location = new System.Drawing.Point(21, 53);
            this.chkbAddSalad1.Name = "chkbAddSalad1";
            this.chkbAddSalad1.Size = new System.Drawing.Size(109, 26);
            this.chkbAddSalad1.TabIndex = 0;
            this.chkbAddSalad1.Text = "Croutons";
            this.chkbAddSalad1.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(435, 404);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(153, 49);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "&Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(435, 469);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(153, 49);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(435, 545);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 49);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // picMenu
            // 
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(178, 198);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(253, 176);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 8;
            this.picMenu.TabStop = false;
            // 
            // LunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(812, 830);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpbAddSalad);
            this.Controls.Add(this.grpbAddPizza);
            this.Controls.Add(this.grpbAddHam);
            this.Controls.Add(this.grpbOrderTotal);
            this.Controls.Add(this.grbMain);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LunchOrder";
            this.Text = "Lunch Order";
            this.grbMain.ResumeLayout(false);
            this.grbMain.PerformLayout();
            this.grpbOrderTotal.ResumeLayout(false);
            this.grpbOrderTotal.PerformLayout();
            this.grpbAddHam.ResumeLayout(false);
            this.grpbAddHam.PerformLayout();
            this.grpbAddPizza.ResumeLayout(false);
            this.grpbAddPizza.PerformLayout();
            this.grpbAddSalad.ResumeLayout(false);
            this.grpbAddSalad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdbPizza;
        private System.Windows.Forms.RadioButton rdbHam;
        private System.Windows.Forms.GroupBox grpbOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.GroupBox grpbAddHam;
        private System.Windows.Forms.CheckBox chkbAddHam3;
        private System.Windows.Forms.CheckBox chkbAddHam2;
        private System.Windows.Forms.CheckBox chkbAddHam1;
        private System.Windows.Forms.GroupBox grpbAddPizza;
        private System.Windows.Forms.CheckBox chkbAddPizza3;
        private System.Windows.Forms.CheckBox chkbAddPizza2;
        private System.Windows.Forms.CheckBox chkbAddPizza1;
        private System.Windows.Forms.GroupBox grpbAddSalad;
        private System.Windows.Forms.CheckBox chkbAddSalad3;
        private System.Windows.Forms.CheckBox chkbAddSalad2;
        private System.Windows.Forms.CheckBox chkbAddSalad1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picMenu;
    }
}

