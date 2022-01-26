
namespace Final
{
    partial class winnerScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wsLabel = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.overButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wsLabel
            // 
            this.wsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wsLabel.Location = new System.Drawing.Point(323, 135);
            this.wsLabel.Name = "wsLabel";
            this.wsLabel.Size = new System.Drawing.Size(146, 55);
            this.wsLabel.TabIndex = 0;
            this.wsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // replayButton
            // 
            this.replayButton.Location = new System.Drawing.Point(328, 207);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(160, 44);
            this.replayButton.TabIndex = 1;
            this.replayButton.Text = "Play Again";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // overButton
            // 
            this.overButton.Location = new System.Drawing.Point(328, 257);
            this.overButton.Name = "overButton";
            this.overButton.Size = new System.Drawing.Size(160, 44);
            this.overButton.TabIndex = 2;
            this.overButton.Text = "Exit";
            this.overButton.UseVisualStyleBackColor = true;
            this.overButton.Click += new System.EventHandler(this.overButton_Click);
            // 
            // winnerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.overButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.wsLabel);
            this.Name = "winnerScreen";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.winnerScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wsLabel;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button overButton;
    }
}
