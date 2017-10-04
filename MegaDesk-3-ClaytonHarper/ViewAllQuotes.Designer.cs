namespace MegaDesk_3_ClaytonHarper
{
    partial class ViewAllQuotes
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
            this.label6 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.displayError = new System.Windows.Forms.Label();
            this.displayQuotesTable = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.displayQuotesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "All Quotes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(363, 63);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(120, 30);
            this.mainMenuButton.TabIndex = 28;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // displayError
            // 
            this.displayError.AutoSize = true;
            this.displayError.Location = new System.Drawing.Point(12, 108);
            this.displayError.Name = "displayError";
            this.displayError.Size = new System.Drawing.Size(35, 13);
            this.displayError.TabIndex = 0;
            this.displayError.Text = "label1";
            this.displayError.Visible = false;
            // 
            // displayQuotesTable
            // 
            this.displayQuotesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayQuotesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.deskSize,
            this.drawers,
            this.deskMaterial,
            this.rushOrder,
            this.totalPrice,
            this.quoteDate});
            this.displayQuotesTable.Location = new System.Drawing.Point(12, 124);
            this.displayQuotesTable.Name = "displayQuotesTable";
            this.displayQuotesTable.Size = new System.Drawing.Size(810, 475);
            this.displayQuotesTable.TabIndex = 29;
            // 
            // customerName
            // 
            this.customerName.Frozen = true;
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 125;
            // 
            // deskSize
            // 
            this.deskSize.HeaderText = "Desk Size";
            this.deskSize.Name = "deskSize";
            this.deskSize.ReadOnly = true;
            // 
            // drawers
            // 
            this.drawers.HeaderText = "Drawers";
            this.drawers.Name = "drawers";
            this.drawers.ReadOnly = true;
            // 
            // deskMaterial
            // 
            this.deskMaterial.HeaderText = "Material";
            this.deskMaterial.Name = "deskMaterial";
            this.deskMaterial.ReadOnly = true;
            // 
            // rushOrder
            // 
            this.rushOrder.HeaderText = "Delivery";
            this.rushOrder.Name = "rushOrder";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // quoteDate
            // 
            this.quoteDate.HeaderText = "Date";
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.ReadOnly = true;
            this.quoteDate.Width = 150;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.displayQuotesTable);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.displayError);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.displayQuotesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label displayError;
        private System.Windows.Forms.DataGridView displayQuotesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDate;
    }
}