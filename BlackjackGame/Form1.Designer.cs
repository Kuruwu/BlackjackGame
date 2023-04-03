namespace BlackjackGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.blackjackTab = new System.Windows.Forms.TabControl();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.rulesTab = new System.Windows.Forms.TabPage();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blackjackTab.SuspendLayout();
            this.rulesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blackjackTab
            // 
            this.blackjackTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.blackjackTab.Controls.Add(this.gameTab);
            this.blackjackTab.Controls.Add(this.rulesTab);
            this.blackjackTab.Location = new System.Drawing.Point(0, -2);
            this.blackjackTab.Name = "blackjackTab";
            this.blackjackTab.SelectedIndex = 0;
            this.blackjackTab.Size = new System.Drawing.Size(1141, 753);
            this.blackjackTab.TabIndex = 0;
            // 
            // gameTab
            // 
            this.gameTab.BackColor = System.Drawing.Color.ForestGreen;
            this.gameTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameTab.Location = new System.Drawing.Point(4, 37);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(1133, 712);
            this.gameTab.TabIndex = 0;
            this.gameTab.Text = "Game";
            // 
            // rulesTab
            // 
            this.rulesTab.BackColor = System.Drawing.Color.ForestGreen;
            this.rulesTab.Controls.Add(this.label1);
            this.rulesTab.Controls.Add(this.rulesLabel);
            this.rulesTab.Location = new System.Drawing.Point(4, 37);
            this.rulesTab.Name = "rulesTab";
            this.rulesTab.Padding = new System.Windows.Forms.Padding(3);
            this.rulesTab.Size = new System.Drawing.Size(1133, 712);
            this.rulesTab.TabIndex = 1;
            this.rulesTab.Text = "Rules";
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rulesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rulesLabel.Location = new System.Drawing.Point(488, 20);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(141, 47);
            this.rulesLabel.TabIndex = 0;
            this.rulesLabel.Text = "RULES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1115, 225);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.blackjackTab);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.blackjackTab.ResumeLayout(false);
            this.rulesTab.ResumeLayout(false);
            this.rulesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl blackjackTab;
        private TabPage gameTab;
        private TabPage rulesTab;
        private Label rulesLabel;
        private Label label1;
    }
}