namespace DiceRoll
{
    partial class CustomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomType));
            this.CustomTypeSizeNumberLabel = new System.Windows.Forms.Label();
            this.CustomTypeSideNumber = new System.Windows.Forms.TextBox();
            this.Side1ValueLabel = new System.Windows.Forms.Label();
            this.Side1Value = new System.Windows.Forms.TextBox();
            this.Side2Value = new System.Windows.Forms.TextBox();
            this.Side2ValueLabel = new System.Windows.Forms.Label();
            this.Side3Value = new System.Windows.Forms.TextBox();
            this.Side3ValueLabel = new System.Windows.Forms.Label();
            this.Side4Value = new System.Windows.Forms.TextBox();
            this.Side4ValueLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomTypeSizeNumberLabel
            // 
            this.CustomTypeSizeNumberLabel.AutoSize = true;
            this.CustomTypeSizeNumberLabel.Location = new System.Drawing.Point(177, 30);
            this.CustomTypeSizeNumberLabel.Name = "CustomTypeSizeNumberLabel";
            this.CustomTypeSizeNumberLabel.Size = new System.Drawing.Size(83, 13);
            this.CustomTypeSizeNumberLabel.TabIndex = 0;
            this.CustomTypeSizeNumberLabel.Text = "Number of sides";
            // 
            // CustomTypeSideNumber
            // 
            this.CustomTypeSideNumber.Location = new System.Drawing.Point(266, 26);
            this.CustomTypeSideNumber.MaxLength = 2;
            this.CustomTypeSideNumber.Name = "CustomTypeSideNumber";
            this.CustomTypeSideNumber.Size = new System.Drawing.Size(100, 20);
            this.CustomTypeSideNumber.TabIndex = 1;
            // 
            // Side1ValueLabel
            // 
            this.Side1ValueLabel.AutoSize = true;
            this.Side1ValueLabel.Location = new System.Drawing.Point(180, 92);
            this.Side1ValueLabel.Name = "Side1ValueLabel";
            this.Side1ValueLabel.Size = new System.Drawing.Size(37, 13);
            this.Side1ValueLabel.TabIndex = 2;
            this.Side1ValueLabel.Text = "Side 1";
            // 
            // Side1Value
            // 
            this.Side1Value.Location = new System.Drawing.Point(266, 89);
            this.Side1Value.Name = "Side1Value";
            this.Side1Value.Size = new System.Drawing.Size(100, 20);
            this.Side1Value.TabIndex = 3;
            // 
            // Side2Value
            // 
            this.Side2Value.Location = new System.Drawing.Point(266, 126);
            this.Side2Value.Name = "Side2Value";
            this.Side2Value.Size = new System.Drawing.Size(100, 20);
            this.Side2Value.TabIndex = 5;
            // 
            // Side2ValueLabel
            // 
            this.Side2ValueLabel.AutoSize = true;
            this.Side2ValueLabel.Location = new System.Drawing.Point(180, 129);
            this.Side2ValueLabel.Name = "Side2ValueLabel";
            this.Side2ValueLabel.Size = new System.Drawing.Size(37, 13);
            this.Side2ValueLabel.TabIndex = 4;
            this.Side2ValueLabel.Text = "Side 2";
            // 
            // Side3Value
            // 
            this.Side3Value.Location = new System.Drawing.Point(266, 163);
            this.Side3Value.Name = "Side3Value";
            this.Side3Value.Size = new System.Drawing.Size(100, 20);
            this.Side3Value.TabIndex = 7;
            // 
            // Side3ValueLabel
            // 
            this.Side3ValueLabel.AutoSize = true;
            this.Side3ValueLabel.Location = new System.Drawing.Point(180, 166);
            this.Side3ValueLabel.Name = "Side3ValueLabel";
            this.Side3ValueLabel.Size = new System.Drawing.Size(37, 13);
            this.Side3ValueLabel.TabIndex = 6;
            this.Side3ValueLabel.Text = "Side 3";
            // 
            // Side4Value
            // 
            this.Side4Value.Location = new System.Drawing.Point(266, 200);
            this.Side4Value.Name = "Side4Value";
            this.Side4Value.Size = new System.Drawing.Size(100, 20);
            this.Side4Value.TabIndex = 9;
            // 
            // Side4ValueLabel
            // 
            this.Side4ValueLabel.AutoSize = true;
            this.Side4ValueLabel.Location = new System.Drawing.Point(180, 203);
            this.Side4ValueLabel.Name = "Side4ValueLabel";
            this.Side4ValueLabel.Size = new System.Drawing.Size(37, 13);
            this.Side4ValueLabel.TabIndex = 8;
            this.Side4ValueLabel.Text = "Side 4";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(290, 306);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(412, 306);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CustomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 357);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Side4Value);
            this.Controls.Add(this.Side4ValueLabel);
            this.Controls.Add(this.Side3Value);
            this.Controls.Add(this.Side3ValueLabel);
            this.Controls.Add(this.Side2Value);
            this.Controls.Add(this.Side2ValueLabel);
            this.Controls.Add(this.Side1Value);
            this.Controls.Add(this.Side1ValueLabel);
            this.Controls.Add(this.CustomTypeSideNumber);
            this.Controls.Add(this.CustomTypeSizeNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomType";
            this.Text = "Modify custom type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomTypeSizeNumberLabel;
        private System.Windows.Forms.TextBox CustomTypeSideNumber;
        private System.Windows.Forms.Label Side1ValueLabel;
        private System.Windows.Forms.TextBox Side1Value;
        private System.Windows.Forms.TextBox Side2Value;
        private System.Windows.Forms.Label Side2ValueLabel;
        private System.Windows.Forms.TextBox Side3Value;
        private System.Windows.Forms.Label Side3ValueLabel;
        private System.Windows.Forms.TextBox Side4Value;
        private System.Windows.Forms.Label Side4ValueLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}