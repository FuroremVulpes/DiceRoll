namespace DiceRoll
{
    partial class AddDices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDices));
            this.DiceNumberLabel = new System.Windows.Forms.Label();
            this.DiceNumber = new System.Windows.Forms.TextBox();
            this.DiceTypeLabel = new System.Windows.Forms.Label();
            this.DiceType = new System.Windows.Forms.ComboBox();
            this.DiceModifierLabel = new System.Windows.Forms.Label();
            this.DiceModifier = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiceNumberLabel
            // 
            this.DiceNumberLabel.AutoSize = true;
            this.DiceNumberLabel.Location = new System.Drawing.Point(84, 79);
            this.DiceNumberLabel.Name = "DiceNumberLabel";
            this.DiceNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.DiceNumberLabel.TabIndex = 0;
            this.DiceNumberLabel.Text = "Number of dices";
            // 
            // DiceNumber
            // 
            this.DiceNumber.Location = new System.Drawing.Point(174, 76);
            this.DiceNumber.Name = "DiceNumber";
            this.DiceNumber.Size = new System.Drawing.Size(50, 20);
            this.DiceNumber.TabIndex = 1;
            this.DiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiceTypeLabel
            // 
            this.DiceTypeLabel.AutoSize = true;
            this.DiceTypeLabel.Location = new System.Drawing.Point(83, 111);
            this.DiceTypeLabel.Name = "DiceTypeLabel";
            this.DiceTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.DiceTypeLabel.TabIndex = 2;
            this.DiceTypeLabel.Text = "Type of dices";
            // 
            // DiceType
            // 
            this.DiceType.FormattingEnabled = true;
            this.DiceType.Items.AddRange(new object[] {
            "d3",
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d16",
            "d20",
            "d36",
            "custom"});
            this.DiceType.Location = new System.Drawing.Point(174, 108);
            this.DiceType.Name = "DiceType";
            this.DiceType.Size = new System.Drawing.Size(51, 21);
            this.DiceType.TabIndex = 3;
            // 
            // DiceModifierLabel
            // 
            this.DiceModifierLabel.AutoSize = true;
            this.DiceModifierLabel.Location = new System.Drawing.Point(83, 141);
            this.DiceModifierLabel.Name = "DiceModifierLabel";
            this.DiceModifierLabel.Size = new System.Drawing.Size(85, 13);
            this.DiceModifierLabel.TabIndex = 4;
            this.DiceModifierLabel.Text = "Modifier per dice";
            // 
            // DiceModifier
            // 
            this.DiceModifier.FormattingEnabled = true;
            this.DiceModifier.Items.AddRange(new object[] {
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.DiceModifier.Location = new System.Drawing.Point(174, 138);
            this.DiceModifier.Name = "DiceModifier";
            this.DiceModifier.Size = new System.Drawing.Size(51, 21);
            this.DiceModifier.TabIndex = 5;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(150, 237);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(231, 237);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddDices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 275);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DiceModifier);
            this.Controls.Add(this.DiceModifierLabel);
            this.Controls.Add(this.DiceType);
            this.Controls.Add(this.DiceTypeLabel);
            this.Controls.Add(this.DiceNumber);
            this.Controls.Add(this.DiceNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDices";
            this.Text = "Add dices";
            this.Load += new System.EventHandler(this.AddDices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiceNumberLabel;
        private System.Windows.Forms.TextBox DiceNumber;
        private System.Windows.Forms.Label DiceTypeLabel;
        private System.Windows.Forms.ComboBox DiceType;
        private System.Windows.Forms.Label DiceModifierLabel;
        private System.Windows.Forms.ComboBox DiceModifier;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}