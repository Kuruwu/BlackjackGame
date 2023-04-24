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
            this.BetTitle = new System.Windows.Forms.TextBox();
            this.SplitButton = new System.Windows.Forms.Button();
            this.DoubleButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.BlackjackTitle = new System.Windows.Forms.Label();
            this.rulesTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.BetAmount = new System.Windows.Forms.Label();
            this.RulesButton = new System.Windows.Forms.Button();
            this.blackjackTab.SuspendLayout();
            this.gameTab.SuspendLayout();
            this.rulesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blackjackTab
            // 
            this.blackjackTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.blackjackTab.Controls.Add(this.gameTab);
            this.blackjackTab.Controls.Add(this.rulesTab);
            this.blackjackTab.Location = new System.Drawing.Point(0, -1);
            this.blackjackTab.Margin = new System.Windows.Forms.Padding(2);
            this.blackjackTab.Name = "blackjackTab";
            this.blackjackTab.SelectedIndex = 0;
            this.blackjackTab.Size = new System.Drawing.Size(799, 452);
            this.blackjackTab.TabIndex = 0;
            // 
            // gameTab
            // 
            this.gameTab.BackColor = System.Drawing.Color.ForestGreen;
            this.gameTab.Controls.Add(this.RulesButton);
            this.gameTab.Controls.Add(this.BetAmount);
            this.gameTab.Controls.Add(this.BetTitle);
            this.gameTab.Controls.Add(this.SplitButton);
            this.gameTab.Controls.Add(this.DoubleButton);
            this.gameTab.Controls.Add(this.StandButton);
            this.gameTab.Controls.Add(this.HitButton);
            this.gameTab.Controls.Add(this.BlackjackTitle);
            this.gameTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameTab.Location = new System.Drawing.Point(4, 27);
            this.gameTab.Margin = new System.Windows.Forms.Padding(2);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(2);
            this.gameTab.Size = new System.Drawing.Size(791, 421);
            this.gameTab.TabIndex = 0;
            this.gameTab.Text = "Game";
            // 
            // BetTitle
            // 
            this.BetTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.BetTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BetTitle.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BetTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.BetTitle.Location = new System.Drawing.Point(608, 5);
            this.BetTitle.Name = "BetTitle";
            this.BetTitle.Size = new System.Drawing.Size(159, 25);
            this.BetTitle.TabIndex = 6;
            this.BetTitle.Text = "Current Bet:";
            // 
            // SplitButton
            // 
            this.SplitButton.BackColor = System.Drawing.Color.LimeGreen;
            this.SplitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SplitButton.Location = new System.Drawing.Point(608, 296);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(159, 45);
            this.SplitButton.TabIndex = 5;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = false;
            // 
            // DoubleButton
            // 
            this.DoubleButton.BackColor = System.Drawing.Color.LimeGreen;
            this.DoubleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DoubleButton.Location = new System.Drawing.Point(608, 233);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(159, 45);
            this.DoubleButton.TabIndex = 4;
            this.DoubleButton.Text = "Double";
            this.DoubleButton.UseVisualStyleBackColor = false;
            // 
            // StandButton
            // 
            this.StandButton.BackColor = System.Drawing.Color.LimeGreen;
            this.StandButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StandButton.Location = new System.Drawing.Point(608, 169);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(159, 45);
            this.StandButton.TabIndex = 3;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = false;
            // 
            // HitButton
            // 
            this.HitButton.BackColor = System.Drawing.Color.LimeGreen;
            this.HitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HitButton.Location = new System.Drawing.Point(608, 104);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(159, 45);
            this.HitButton.TabIndex = 2;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = false;
            // 
            // BlackjackTitle
            // 
            this.BlackjackTitle.AutoSize = true;
            this.BlackjackTitle.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BlackjackTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BlackjackTitle.Location = new System.Drawing.Point(262, 2);
            this.BlackjackTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BlackjackTitle.Name = "BlackjackTitle";
            this.BlackjackTitle.Size = new System.Drawing.Size(228, 44);
            this.BlackjackTitle.TabIndex = 1;
            this.BlackjackTitle.Text = "BLACKJACK";
            this.BlackjackTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rulesTab
            // 
            this.rulesTab.BackColor = System.Drawing.Color.ForestGreen;
            this.rulesTab.Controls.Add(this.label1);
            this.rulesTab.Controls.Add(this.rulesLabel);
            this.rulesTab.Location = new System.Drawing.Point(4, 27);
            this.rulesTab.Margin = new System.Windows.Forms.Padding(2);
            this.rulesTab.Name = "rulesTab";
            this.rulesTab.Padding = new System.Windows.Forms.Padding(2);
            this.rulesTab.Size = new System.Drawing.Size(791, 421);
            this.rulesTab.TabIndex = 1;
            this.rulesTab.Text = "Rules";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 135);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rulesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rulesLabel.Location = new System.Drawing.Point(342, 12);
            this.rulesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(96, 32);
            this.rulesLabel.TabIndex = 0;
            this.rulesLabel.Text = "RULES";
            // 
            // BetAmount
            // 
            this.BetAmount.AutoSize = true;
            this.BetAmount.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BetAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.BetAmount.Location = new System.Drawing.Point(608, 33);
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(0, 22);
            this.BetAmount.TabIndex = 7;
            // 
            // RulesButton
            // 
            this.RulesButton.BackColor = System.Drawing.Color.LimeGreen;
            this.RulesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RulesButton.Location = new System.Drawing.Point(5, 5);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(82, 25);
            this.RulesButton.TabIndex = 8;
            this.RulesButton.Text = "Rules";
            this.RulesButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blackjackTab);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.blackjackTab.ResumeLayout(false);
            this.gameTab.ResumeLayout(false);
            this.gameTab.PerformLayout();
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
        private Label BlackjackTitle;
        private Button SplitButton;
        private Button DoubleButton;
        private Button StandButton;
        private Button HitButton;
        private TextBox BetTitle;
        private Button RulesButton;
        private Label BetAmount;
    }
}