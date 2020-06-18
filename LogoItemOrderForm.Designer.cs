namespace MendozaP3
{
    partial class LogoItemOrderForm
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
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblNumOfItems = new System.Windows.Forms.Label();
            this.lblEngraving = new System.Windows.Forms.Label();
            this.lblNumOfColors = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.txtNumOfItems = new System.Windows.Forms.TextBox();
            this.txtTextEngraved = new System.Windows.Forms.TextBox();
            this.txtNumOfColors = new System.Windows.Forms.TextBox();
            this.grbxItemType = new System.Windows.Forms.GroupBox();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbMug = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.chbxLogo = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbxItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(28, 38);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(99, 17);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "Order Number";
            // 
            // lblNumOfItems
            // 
            this.lblNumOfItems.AutoSize = true;
            this.lblNumOfItems.Location = new System.Drawing.Point(28, 74);
            this.lblNumOfItems.Name = "lblNumOfItems";
            this.lblNumOfItems.Size = new System.Drawing.Size(114, 17);
            this.lblNumOfItems.TabIndex = 1;
            this.lblNumOfItems.Text = "Number Of Items";
            // 
            // lblEngraving
            // 
            this.lblEngraving.AutoSize = true;
            this.lblEngraving.Location = new System.Drawing.Point(366, 38);
            this.lblEngraving.Name = "lblEngraving";
            this.lblEngraving.Size = new System.Drawing.Size(185, 17);
            this.lblEngraving.TabIndex = 3;
            this.lblEngraving.Text = "Text to be Engraved/Printed";
            // 
            // lblNumOfColors
            // 
            this.lblNumOfColors.AutoSize = true;
            this.lblNumOfColors.Location = new System.Drawing.Point(28, 106);
            this.lblNumOfColors.Name = "lblNumOfColors";
            this.lblNumOfColors.Size = new System.Drawing.Size(118, 17);
            this.lblNumOfColors.TabIndex = 4;
            this.lblNumOfColors.Text = "Number of Colors";
            this.lblNumOfColors.Visible = false;
            // 
            // txtResults
            // 
            this.txtResults.Enabled = false;
            this.txtResults.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(631, 38);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(299, 338);
            this.txtResults.TabIndex = 5;
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(157, 33);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(127, 22);
            this.txtOrderNum.TabIndex = 6;
            // 
            // txtNumOfItems
            // 
            this.txtNumOfItems.Location = new System.Drawing.Point(157, 71);
            this.txtNumOfItems.Name = "txtNumOfItems";
            this.txtNumOfItems.Size = new System.Drawing.Size(127, 22);
            this.txtNumOfItems.TabIndex = 7;
            // 
            // txtTextEngraved
            // 
            this.txtTextEngraved.Enabled = false;
            this.txtTextEngraved.Location = new System.Drawing.Point(369, 69);
            this.txtTextEngraved.Multiline = true;
            this.txtTextEngraved.Name = "txtTextEngraved";
            this.txtTextEngraved.Size = new System.Drawing.Size(182, 59);
            this.txtTextEngraved.TabIndex = 9;
            // 
            // txtNumOfColors
            // 
            this.txtNumOfColors.Location = new System.Drawing.Point(157, 106);
            this.txtNumOfColors.Name = "txtNumOfColors";
            this.txtNumOfColors.Size = new System.Drawing.Size(123, 22);
            this.txtNumOfColors.TabIndex = 10;
            this.txtNumOfColors.Visible = false;
            // 
            // grbxItemType
            // 
            this.grbxItemType.Controls.Add(this.rbPen);
            this.grbxItemType.Controls.Add(this.rbMug);
            this.grbxItemType.Controls.Add(this.rbUSB);
            this.grbxItemType.Location = new System.Drawing.Point(31, 197);
            this.grbxItemType.Name = "grbxItemType";
            this.grbxItemType.Size = new System.Drawing.Size(182, 131);
            this.grbxItemType.TabIndex = 11;
            this.grbxItemType.TabStop = false;
            this.grbxItemType.Text = "Item Type :";
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(30, 88);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(54, 21);
            this.rbPen.TabIndex = 2;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // rbMug
            // 
            this.rbMug.AutoSize = true;
            this.rbMug.Location = new System.Drawing.Point(30, 60);
            this.rbMug.Name = "rbMug";
            this.rbMug.Size = new System.Drawing.Size(56, 21);
            this.rbMug.TabIndex = 1;
            this.rbMug.TabStop = true;
            this.rbMug.Text = "Mug";
            this.rbMug.UseVisualStyleBackColor = true;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Checked = true;
            this.rbUSB.Location = new System.Drawing.Point(30, 32);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(57, 21);
            this.rbUSB.TabIndex = 0;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // chbxLogo
            // 
            this.chbxLogo.AutoSize = true;
            this.chbxLogo.Location = new System.Drawing.Point(413, 134);
            this.chbxLogo.Name = "chbxLogo";
            this.chbxLogo.Size = new System.Drawing.Size(79, 21);
            this.chbxLogo.TabIndex = 12;
            this.chbxLogo.Text = "LOGO?";
            this.chbxLogo.UseVisualStyleBackColor = true;
            this.chbxLogo.CheckedChanged += new System.EventHandler(this.chbxLogo_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(369, 164);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 212);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 212);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClear);
            // 
            // LogoItemOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chbxLogo);
            this.Controls.Add(this.grbxItemType);
            this.Controls.Add(this.txtNumOfColors);
            this.Controls.Add(this.txtTextEngraved);
            this.Controls.Add(this.txtNumOfItems);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblNumOfColors);
            this.Controls.Add(this.lblEngraving);
            this.Controls.Add(this.lblNumOfItems);
            this.Controls.Add(this.lblOrderNum);
            this.Name = "LogoItemOrderForm";
            this.Text = "Logo Layout Designer";
            this.grbxItemType.ResumeLayout(false);
            this.grbxItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblNumOfItems;
        private System.Windows.Forms.Label lblEngraving;
        private System.Windows.Forms.Label lblNumOfColors;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.TextBox txtNumOfItems;
        private System.Windows.Forms.TextBox txtTextEngraved;
        private System.Windows.Forms.TextBox txtNumOfColors;
        private System.Windows.Forms.GroupBox grbxItemType;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbMug;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.CheckBox chbxLogo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button2;
    }
}

