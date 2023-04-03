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
            this.blackjackTab = new System.Windows.Forms.TabControl();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.rulesTab = new System.Windows.Forms.TabPage();
            this.blackjackTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blackjackTab
            // 
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
            this.gameTab.Location = new System.Drawing.Point(4, 34);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(1133, 715);
            this.gameTab.TabIndex = 0;
            this.gameTab.Text = "Game";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // rulesTab
            // 
            this.rulesTab.Location = new System.Drawing.Point(4, 34);
            this.rulesTab.Name = "rulesTab";
            this.rulesTab.Padding = new System.Windows.Forms.Padding(3);
            this.rulesTab.Size = new System.Drawing.Size(1133, 715);
            this.rulesTab.TabIndex = 1;
            this.rulesTab.Text = "Rules";
            this.rulesTab.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl blackjackTab;
        private TabPage gameTab;
        private TabPage rulesTab;
    }
}