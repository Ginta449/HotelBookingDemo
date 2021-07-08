namespace HotelBMG2
{
    partial class RoomBuilder
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.checkBoxDinner = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakfast = new System.Windows.Forms.CheckBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonDeluxe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(1180, 390);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 44);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalPrice.Location = new System.Drawing.Point(1205, 434);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(99, 32);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "label2";
            this.lblTotalPrice.VisibleChanged += new System.EventHandler(this.radioButtonStandard_CheckedChanged);
            this.lblTotalPrice.Click += new System.EventHandler(this.radioButtonStandard_CheckedChanged);
            // 
            // checkBoxDinner
            // 
            this.checkBoxDinner.AutoSize = true;
            this.checkBoxDinner.Image = global::HotelBMG2.Properties.Resources.hbh_h2_dining_2;
            this.checkBoxDinner.Location = new System.Drawing.Point(445, 359);
            this.checkBoxDinner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDinner.Name = "checkBoxDinner";
            this.checkBoxDinner.Size = new System.Drawing.Size(371, 225);
            this.checkBoxDinner.TabIndex = 6;
            this.checkBoxDinner.UseVisualStyleBackColor = true;
            this.checkBoxDinner.CheckedChanged += new System.EventHandler(this.checkBoxDinner_CheckedChanged);
            // 
            // checkBoxBreakfast
            // 
            this.checkBoxBreakfast.AutoSize = true;
            this.checkBoxBreakfast.Image = global::HotelBMG2.Properties.Resources._7216;
            this.checkBoxBreakfast.Location = new System.Drawing.Point(27, 359);
            this.checkBoxBreakfast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBreakfast.Name = "checkBoxBreakfast";
            this.checkBoxBreakfast.Size = new System.Drawing.Size(371, 225);
            this.checkBoxBreakfast.TabIndex = 5;
            this.checkBoxBreakfast.UseVisualStyleBackColor = true;
            this.checkBoxBreakfast.CheckedChanged += new System.EventHandler(this.checkBoxBreakfast_CheckedChanged);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReserve.Location = new System.Drawing.Point(1111, 469);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(203, 94);
            this.btnReserve.TabIndex = 7;
            this.btnReserve.Text = "RESERVE";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.BackColor = System.Drawing.Color.MidnightBlue;
            this.radioButtonStandard.Image = global::HotelBMG2.Properties.Resources.chambre_standard_;
            this.radioButtonStandard.Location = new System.Drawing.Point(27, 32);
            this.radioButtonStandard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(352, 223);
            this.radioButtonStandard.TabIndex = 8;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.UseVisualStyleBackColor = false;
            this.radioButtonStandard.CheckedChanged += new System.EventHandler(this.radioButtonStandard_CheckedChanged);
            // 
            // radioButtonDeluxe
            // 
            this.radioButtonDeluxe.AutoSize = true;
            this.radioButtonDeluxe.Image = global::HotelBMG2.Properties.Resources._49c6c143edc49945879605ddbf63a9ce;
            this.radioButtonDeluxe.Location = new System.Drawing.Point(445, 32);
            this.radioButtonDeluxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDeluxe.Name = "radioButtonDeluxe";
            this.radioButtonDeluxe.Size = new System.Drawing.Size(352, 223);
            this.radioButtonDeluxe.TabIndex = 9;
            this.radioButtonDeluxe.TabStop = true;
            this.radioButtonDeluxe.UseVisualStyleBackColor = true;
            this.radioButtonDeluxe.CheckedChanged += new System.EventHandler(this.radioButtonDeluxe_CheckedChanged);
            // 
            // RoomBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1401, 665);
            this.Controls.Add(this.radioButtonDeluxe);
            this.Controls.Add(this.radioButtonStandard);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.checkBoxDinner);
            this.Controls.Add(this.checkBoxBreakfast);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoomBuilder";
            this.Text = "RoomBuilder";
            this.Load += new System.EventHandler(this.RoomBuilder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.CheckBox checkBoxBreakfast;
        private System.Windows.Forms.CheckBox checkBoxDinner;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.RadioButton radioButtonDeluxe;
    }
}