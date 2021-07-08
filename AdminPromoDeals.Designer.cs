namespace HotelBMG2
{
    partial class AdminPromoDeals
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
            this.richTextBoxPromoDeals = new System.Windows.Forms.RichTextBox();
            this.buttonPromoDeals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxPromoDeals
            // 
            this.richTextBoxPromoDeals.Location = new System.Drawing.Point(69, 66);
            this.richTextBoxPromoDeals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxPromoDeals.Name = "richTextBoxPromoDeals";
            this.richTextBoxPromoDeals.Size = new System.Drawing.Size(896, 123);
            this.richTextBoxPromoDeals.TabIndex = 0;
            this.richTextBoxPromoDeals.Text = "";
            // 
            // buttonPromoDeals
            // 
            this.buttonPromoDeals.Location = new System.Drawing.Point(248, 230);
            this.buttonPromoDeals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPromoDeals.Name = "buttonPromoDeals";
            this.buttonPromoDeals.Size = new System.Drawing.Size(545, 68);
            this.buttonPromoDeals.TabIndex = 1;
            this.buttonPromoDeals.Text = "Post Promotion Deals";
            this.buttonPromoDeals.UseVisualStyleBackColor = true;
            this.buttonPromoDeals.Click += new System.EventHandler(this.buttonPromoDeals_Click);
            // 
            // AdminPromoDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonPromoDeals);
            this.Controls.Add(this.richTextBoxPromoDeals);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminPromoDeals";
            this.Text = "AdminPromoDeals";
            this.Load += new System.EventHandler(this.AdminPromoDeals_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxPromoDeals;
        private System.Windows.Forms.Button buttonPromoDeals;
    }
}