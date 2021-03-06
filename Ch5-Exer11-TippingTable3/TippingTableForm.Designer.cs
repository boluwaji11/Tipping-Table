
namespace Ch5_Exer11_TippingTable3
{
    partial class TippingTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TippingTableForm));
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.lblOuput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLowestPercentage = new System.Windows.Forms.TextBox();
            this.txtHighestPercentage = new System.Windows.Forms.TextBox();
            this.txtLowestBill = new System.Windows.Forms.TextBox();
            this.txtHighestBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOutput
            // 
            this.pnlOutput.AutoScroll = true;
            this.pnlOutput.BackColor = System.Drawing.Color.Transparent;
            this.pnlOutput.Controls.Add(this.lblOuput);
            this.pnlOutput.Location = new System.Drawing.Point(454, 138);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(607, 416);
            this.pnlOutput.TabIndex = 0;
            // 
            // lblOuput
            // 
            this.lblOuput.AutoSize = true;
            this.lblOuput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuput.Location = new System.Drawing.Point(9, 29);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(98, 21);
            this.lblOuput.TabIndex = 0;
            this.lblOuput.Text = "**output";
            this.lblOuput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lowest Tip Percentage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Highest Tip Percentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lowest Bill ($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Highest Bill ($)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(288, 419);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 42);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(135, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLowestPercentage
            // 
            this.txtLowestPercentage.Location = new System.Drawing.Point(355, 187);
            this.txtLowestPercentage.Name = "txtLowestPercentage";
            this.txtLowestPercentage.Size = new System.Drawing.Size(60, 26);
            this.txtLowestPercentage.TabIndex = 0;
            this.txtLowestPercentage.TextChanged += new System.EventHandler(this.AllTextboxes_TextChanged);
            // 
            // txtHighestPercentage
            // 
            this.txtHighestPercentage.Location = new System.Drawing.Point(355, 243);
            this.txtHighestPercentage.Name = "txtHighestPercentage";
            this.txtHighestPercentage.Size = new System.Drawing.Size(60, 26);
            this.txtHighestPercentage.TabIndex = 1;
            this.txtHighestPercentage.TextChanged += new System.EventHandler(this.AllTextboxes_TextChanged);
            // 
            // txtLowestBill
            // 
            this.txtLowestBill.Location = new System.Drawing.Point(355, 297);
            this.txtLowestBill.Name = "txtLowestBill";
            this.txtLowestBill.Size = new System.Drawing.Size(60, 26);
            this.txtLowestBill.TabIndex = 2;
            this.txtLowestBill.TextChanged += new System.EventHandler(this.AllTextboxes_TextChanged);
            // 
            // txtHighestBill
            // 
            this.txtHighestBill.Location = new System.Drawing.Point(355, 351);
            this.txtHighestBill.Name = "txtHighestBill";
            this.txtHighestBill.Size = new System.Drawing.Size(60, 26);
            this.txtHighestBill.TabIndex = 3;
            this.txtHighestBill.TextChanged += new System.EventHandler(this.AllTextboxes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Tipping Table";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Location = new System.Drawing.Point(2, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 10);
            this.panel1.TabIndex = 12;
            // 
            // TippingTableForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1159, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHighestBill);
            this.Controls.Add(this.txtLowestBill);
            this.Controls.Add(this.txtHighestPercentage);
            this.Controls.Add(this.txtLowestPercentage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlOutput);
            this.DoubleBuffered = true;
            this.Name = "TippingTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipping Table - Boluwaji Oyewumi";
            this.Load += new System.EventHandler(this.TippingTableForm_Load);
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOutput;
        private System.Windows.Forms.Label lblOuput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLowestPercentage;
        private System.Windows.Forms.TextBox txtHighestPercentage;
        private System.Windows.Forms.TextBox txtLowestBill;
        private System.Windows.Forms.TextBox txtHighestBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

