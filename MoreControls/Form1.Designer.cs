
namespace MoreControls
{
    partial class MoreControl
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
            this.HsbNumber = new System.Windows.Forms.HScrollBar();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HsbNumber
            // 
            this.HsbNumber.Location = new System.Drawing.Point(33, 31);
            this.HsbNumber.Name = "HsbNumber";
            this.HsbNumber.Size = new System.Drawing.Size(363, 22);
            this.HsbNumber.TabIndex = 0;
            this.HsbNumber.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbNumber_Scroll);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(442, 30);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(288, 23);
            this.TxtNumber.TabIndex = 1;
            // 
            // MoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.HsbNumber);
            this.Name = "MoreControl";
            this.Text = "MoreControls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar HsbNumber;
        private System.Windows.Forms.TextBox TxtNumber;
    }
}

