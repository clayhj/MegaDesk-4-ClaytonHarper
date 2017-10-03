namespace MegaDesk_3_ClaytonHarper
{
    partial class AddQuote
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
            this.customerName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.numberOfDrawers = new System.Windows.Forms.NumericUpDown();
            this.rushNumberOfDays = new System.Windows.Forms.NumericUpDown();
            this.rushOrderCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deskMaterial = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushNumberOfDays)).BeginInit();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(155, 68);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(150, 20);
            this.customerName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Your Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desired Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rush Order:";
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(156, 125);
            this.deskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.deskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(120, 20);
            this.deskWidth.TabIndex = 7;
            this.deskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(156, 168);
            this.deskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.deskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(120, 20);
            this.deskDepth.TabIndex = 8;
            this.deskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.Location = new System.Drawing.Point(156, 206);
            this.numberOfDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(120, 20);
            this.numberOfDrawers.TabIndex = 9;
            // 
            // rushNumberOfDays
            // 
            this.rushNumberOfDays.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rushNumberOfDays.Location = new System.Drawing.Point(155, 280);
            this.rushNumberOfDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.rushNumberOfDays.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rushNumberOfDays.Name = "rushNumberOfDays";
            this.rushNumberOfDays.Size = new System.Drawing.Size(120, 20);
            this.rushNumberOfDays.TabIndex = 10;
            this.rushNumberOfDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rushNumberOfDays.Visible = false;
            // 
            // rushOrderCheck
            // 
            this.rushOrderCheck.AutoSize = true;
            this.rushOrderCheck.Location = new System.Drawing.Point(104, 283);
            this.rushOrderCheck.Name = "rushOrderCheck";
            this.rushOrderCheck.Size = new System.Drawing.Size(44, 17);
            this.rushOrderCheck.TabIndex = 11;
            this.rushOrderCheck.Text = "Yes";
            this.rushOrderCheck.UseVisualStyleBackColor = true;
            this.rushOrderCheck.CheckedChanged += new System.EventHandler(this.rushOrderCheck_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 50);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desk Quote";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deskMaterial
            // 
            this.deskMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deskMaterial.FormattingEnabled = true;
            this.deskMaterial.Location = new System.Drawing.Point(155, 243);
            this.deskMaterial.MaxDropDownItems = 5;
            this.deskMaterial.Name = "deskMaterial";
            this.deskMaterial.Size = new System.Drawing.Size(120, 21);
            this.deskMaterial.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Material";
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.Location = new System.Drawing.Point(155, 319);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(120, 30);
            this.getQuoteButton.TabIndex = 15;
            this.getQuoteButton.Text = "Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = true;
            this.getQuoteButton.Click += new System.EventHandler(this.getQuoteButton_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(281, 285);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(63, 13);
            this.dayLabel.TabIndex = 16;
            this.dayLabel.Text = "day delivery";
            this.dayLabel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "inches";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "inches";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deskMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rushOrderCheck);
            this.Controls.Add(this.rushNumberOfDays);
            this.Controls.Add(this.numberOfDrawers);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.customerName);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushNumberOfDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.NumericUpDown numberOfDrawers;
        private System.Windows.Forms.NumericUpDown rushNumberOfDays;
        private System.Windows.Forms.CheckBox rushOrderCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox deskMaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button getQuoteButton;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}