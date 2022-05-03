using System.Windows.Forms;

namespace Tic_Tac_Toe_Visual
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
            this.title = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.title.Location = new System.Drawing.Point(160, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(293, 51);
            this.title.TabIndex = 0;
            this.title.Text = "TIC-TAC-TOE";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.resultLabel.Location = new System.Drawing.Point(240, 85);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 13);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // restart label
            //
            this.restartLabel.AutoSize = true;
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.restartLabel.Location = new System.Drawing.Point(190, 125);
            this.restartLabel.Name = "resultLabel";
            this.restartLabel.Size = new System.Drawing.Size(35, 13);
            this.restartLabel.TabIndex = 1;
            this.restartLabel.Text = "";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 763);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.restartLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label restartLabel;
    }
}

