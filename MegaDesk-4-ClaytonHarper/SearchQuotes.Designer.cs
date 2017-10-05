namespace MegaDesk_3_ClaytonHarper
{
    partial class SearchQuotes
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
            this.materialSearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.searchError = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.searchQuotesTable = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // materialSearch
            // 
            this.materialSearch.FormattingEnabled = true;
            this.materialSearch.Location = new System.Drawing.Point(277, 70);
            this.materialSearch.Name = "materialSearch";
            this.materialSearch.Size = new System.Drawing.Size(121, 21);
            this.materialSearch.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "Search Quotes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Location = new System.Drawing.Point(404, 70);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(75, 21);
            this.searchQuotesButton.TabIndex = 14;
            this.searchQuotesButton.Text = "Search";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            this.searchQuotesButton.Click += new System.EventHandler(this.searchQuotesButton_Click);
            // 
            // searchError
            // 
            this.searchError.AutoSize = true;
            this.searchError.Location = new System.Drawing.Point(274, 94);
            this.searchError.Name = "searchError";
            this.searchError.Size = new System.Drawing.Size(42, 13);
            this.searchError.TabIndex = 15;
            this.searchError.Text = "Results";
            this.searchError.Visible = false;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(485, 70);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 21);
            this.mainMenuButton.TabIndex = 28;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // searchQuotesTable
            // 
            this.searchQuotesTable.AllowUserToAddRows = false;
            this.searchQuotesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.deskSize,
            this.drawers,
            this.deskMaterial,
            this.rushOrder,
            this.totalPrice,
            this.quoteDate});
            this.searchQuotesTable.Location = new System.Drawing.Point(12, 124);
            this.searchQuotesTable.Name = "searchQuotesTable";
            this.searchQuotesTable.ReadOnly = true;
            this.searchQuotesTable.Size = new System.Drawing.Size(810, 475);
            this.searchQuotesTable.TabIndex = 30;
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
            this.rushOrder.ReadOnly = true;
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
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.searchQuotesTable);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.searchError);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.materialSearch);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox materialSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Label searchError;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.DataGridView searchQuotesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDate;
    }
}