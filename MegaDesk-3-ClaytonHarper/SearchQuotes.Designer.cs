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
            this.quoteResults = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialSearch
            // 
            this.materialSearch.FormattingEnabled = true;
            this.materialSearch.Location = new System.Drawing.Point(28, 71);
            this.materialSearch.Name = "materialSearch";
            this.materialSearch.Size = new System.Drawing.Size(121, 21);
            this.materialSearch.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "Search Quotes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Location = new System.Drawing.Point(155, 71);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(75, 21);
            this.searchQuotesButton.TabIndex = 14;
            this.searchQuotesButton.Text = "Search";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            this.searchQuotesButton.Click += new System.EventHandler(this.searchQuotesButton_Click);
            // 
            // quoteResults
            // 
            this.quoteResults.AutoSize = true;
            this.quoteResults.Location = new System.Drawing.Point(25, 120);
            this.quoteResults.Name = "quoteResults";
            this.quoteResults.Size = new System.Drawing.Size(42, 13);
            this.quoteResults.TabIndex = 15;
            this.quoteResults.Text = "Results";
            this.quoteResults.Visible = false;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(236, 71);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 21);
            this.mainMenuButton.TabIndex = 28;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Visible = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.quoteResults);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.materialSearch);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox materialSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Label quoteResults;
        private System.Windows.Forms.Button mainMenuButton;
    }
}