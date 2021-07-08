namespace HotelBMG2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeuxe = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblPromoDeal = new System.Windows.Forms.Label();
            this.btnDisplayDeals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Image = global::HotelBMG2.Properties.Resources.chambre_standard_;
            this.button1.Location = new System.Drawing.Point(13, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 272);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeuxe
            // 
            this.btnDeuxe.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeuxe.Image = global::HotelBMG2.Properties.Resources._49c6c143edc49945879605ddbf63a9ce;
            this.btnDeuxe.Location = new System.Drawing.Point(865, 457);
            this.btnDeuxe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeuxe.Name = "btnDeuxe";
            this.btnDeuxe.Size = new System.Drawing.Size(489, 272);
            this.btnDeuxe.TabIndex = 3;
            this.btnDeuxe.UseVisualStyleBackColor = false;
            this.btnDeuxe.Click += new System.EventHandler(this.btnDeuxe_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.Honeydew;
            this.btnBook.Location = new System.Drawing.Point(485, 524);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(356, 139);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "BOOK NOW";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblPromoDeal
            // 
            this.lblPromoDeal.AutoSize = true;
            this.lblPromoDeal.BackColor = System.Drawing.Color.LimeGreen;
            this.lblPromoDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromoDeal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromoDeal.Location = new System.Drawing.Point(719, 15);
            this.lblPromoDeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromoDeal.Name = "lblPromoDeal";
            this.lblPromoDeal.Size = new System.Drawing.Size(85, 29);
            this.lblPromoDeal.TabIndex = 5;
            this.lblPromoDeal.Text = "label1";
            // 
            // btnDisplayDeals
            // 
            this.btnDisplayDeals.Location = new System.Drawing.Point(404, 15);
            this.btnDisplayDeals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayDeals.Name = "btnDisplayDeals";
            this.btnDisplayDeals.Size = new System.Drawing.Size(293, 30);
            this.btnDisplayDeals.TabIndex = 6;
            this.btnDisplayDeals.Text = "Display Promo Deals";
            this.btnDisplayDeals.UseVisualStyleBackColor = true;
            this.btnDisplayDeals.Click += new System.EventHandler(this.btnDisplayDeals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::HotelBMG2.Properties.Resources.HardRockHotelSG_Exterior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1369, 742);
            this.Controls.Add(this.btnDisplayDeals);
            this.Controls.Add(this.lblPromoDeal);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnDeuxe);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeuxe;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblPromoDeal;
        private System.Windows.Forms.Button btnDisplayDeals;
    }
}

