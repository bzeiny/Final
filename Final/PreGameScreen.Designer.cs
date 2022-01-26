
namespace Final
{
    partial class PreGameScreen
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
            this.playernameBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.PictureBox();
            this.playerNumberPicBox = new System.Windows.Forms.PictureBox();
            this.yellowSelect = new System.Windows.Forms.Button();
            this.blueSelect = new System.Windows.Forms.Button();
            this.redSelect = new System.Windows.Forms.Button();
            this.greenSelect = new System.Windows.Forms.Button();
            this.purpleSelect = new System.Windows.Forms.Button();
            this.orangeSelect = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerNumberPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playernameBox
            // 
            this.playernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernameBox.Location = new System.Drawing.Point(545, 242);
            this.playernameBox.Name = "playernameBox";
            this.playernameBox.Size = new System.Drawing.Size(100, 26);
            this.playernameBox.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.BackgroundImage = global::Final.Properties.Resources.enter3;
            this.enterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Location = new System.Drawing.Point(105, 520);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(618, 68);
            this.enterButton.TabIndex = 4;
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Transparent;
            this.nameBox.BackgroundImage = global::Final.Properties.Resources.playerName;
            this.nameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nameBox.Location = new System.Drawing.Point(30, 217);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(460, 69);
            this.nameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nameBox.TabIndex = 2;
            this.nameBox.TabStop = false;
            // 
            // playerNumberPicBox
            // 
            this.playerNumberPicBox.BackColor = System.Drawing.Color.Transparent;
            this.playerNumberPicBox.BackgroundImage = global::Final.Properties.Resources.shirtclr;
            this.playerNumberPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerNumberPicBox.Location = new System.Drawing.Point(30, 331);
            this.playerNumberPicBox.Name = "playerNumberPicBox";
            this.playerNumberPicBox.Size = new System.Drawing.Size(491, 123);
            this.playerNumberPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerNumberPicBox.TabIndex = 1;
            this.playerNumberPicBox.TabStop = false;
            // 
            // yellowSelect
            // 
            this.yellowSelect.BackColor = System.Drawing.Color.Yellow;
            this.yellowSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowSelect.FlatAppearance.BorderSize = 0;
            this.yellowSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yellowSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowSelect.ForeColor = System.Drawing.Color.Transparent;
            this.yellowSelect.Location = new System.Drawing.Point(536, 380);
            this.yellowSelect.Name = "yellowSelect";
            this.yellowSelect.Size = new System.Drawing.Size(30, 30);
            this.yellowSelect.TabIndex = 5;
            this.yellowSelect.UseVisualStyleBackColor = false;
            this.yellowSelect.Click += new System.EventHandler(this.yellowSelect_Click);
            // 
            // blueSelect
            // 
            this.blueSelect.BackColor = System.Drawing.Color.Blue;
            this.blueSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueSelect.FlatAppearance.BorderSize = 0;
            this.blueSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.blueSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueSelect.ForeColor = System.Drawing.Color.Transparent;
            this.blueSelect.Location = new System.Drawing.Point(581, 380);
            this.blueSelect.Name = "blueSelect";
            this.blueSelect.Size = new System.Drawing.Size(30, 30);
            this.blueSelect.TabIndex = 6;
            this.blueSelect.UseVisualStyleBackColor = false;
            this.blueSelect.Click += new System.EventHandler(this.blueSelect_Click);
            // 
            // redSelect
            // 
            this.redSelect.BackColor = System.Drawing.Color.Red;
            this.redSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redSelect.FlatAppearance.BorderSize = 0;
            this.redSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.redSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redSelect.ForeColor = System.Drawing.Color.Transparent;
            this.redSelect.Location = new System.Drawing.Point(626, 380);
            this.redSelect.Name = "redSelect";
            this.redSelect.Size = new System.Drawing.Size(30, 30);
            this.redSelect.TabIndex = 7;
            this.redSelect.UseVisualStyleBackColor = false;
            this.redSelect.Click += new System.EventHandler(this.redSelect_Click);
            // 
            // greenSelect
            // 
            this.greenSelect.BackColor = System.Drawing.Color.Lime;
            this.greenSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenSelect.FlatAppearance.BorderSize = 0;
            this.greenSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.greenSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenSelect.ForeColor = System.Drawing.Color.Transparent;
            this.greenSelect.Location = new System.Drawing.Point(669, 380);
            this.greenSelect.Name = "greenSelect";
            this.greenSelect.Size = new System.Drawing.Size(30, 30);
            this.greenSelect.TabIndex = 8;
            this.greenSelect.UseVisualStyleBackColor = false;
            this.greenSelect.Click += new System.EventHandler(this.greenSelect_Click);
            // 
            // purpleSelect
            // 
            this.purpleSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.purpleSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purpleSelect.FlatAppearance.BorderSize = 0;
            this.purpleSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.purpleSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleSelect.ForeColor = System.Drawing.Color.Transparent;
            this.purpleSelect.Location = new System.Drawing.Point(712, 380);
            this.purpleSelect.Name = "purpleSelect";
            this.purpleSelect.Size = new System.Drawing.Size(30, 30);
            this.purpleSelect.TabIndex = 9;
            this.purpleSelect.UseVisualStyleBackColor = false;
            this.purpleSelect.Click += new System.EventHandler(this.purpleSelect_Click);
            // 
            // orangeSelect
            // 
            this.orangeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangeSelect.FlatAppearance.BorderSize = 0;
            this.orangeSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.orangeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orangeSelect.ForeColor = System.Drawing.Color.Transparent;
            this.orangeSelect.Location = new System.Drawing.Point(755, 380);
            this.orangeSelect.Name = "orangeSelect";
            this.orangeSelect.Size = new System.Drawing.Size(30, 30);
            this.orangeSelect.TabIndex = 10;
            this.orangeSelect.UseVisualStyleBackColor = false;
            this.orangeSelect.Click += new System.EventHandler(this.orangeSelect_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(119, 472);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(552, 45);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.orangeSelect);
            this.Controls.Add(this.purpleSelect);
            this.Controls.Add(this.greenSelect);
            this.Controls.Add(this.redSelect);
            this.Controls.Add(this.blueSelect);
            this.Controls.Add(this.yellowSelect);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.playerNumberPicBox);
            this.Controls.Add(this.playernameBox);
            this.Name = "PreGameScreen";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.PreGameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerNumberPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playernameBox;
        private System.Windows.Forms.PictureBox playerNumberPicBox;
        private System.Windows.Forms.PictureBox nameBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button yellowSelect;
        private System.Windows.Forms.Button blueSelect;
        private System.Windows.Forms.Button redSelect;
        private System.Windows.Forms.Button greenSelect;
        private System.Windows.Forms.Button purpleSelect;
        private System.Windows.Forms.Button orangeSelect;
        private System.Windows.Forms.Label errorLabel;
    }
}
