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
            blackjackTab = new TabControl();
            gameTab = new TabPage();
            RulesButton = new Button();
            BetAmount = new Label();
            BetTitle = new TextBox();
            SplitButton = new Button();
            DoubleButton = new Button();
            StandButton = new Button();
            HitButton = new Button();
            BlackjackTitle = new Label();
            rulesTab = new TabPage();
            label1 = new Label();
            rulesLabel = new Label();
            playerCurrentBet = new Label();
            reduceBet = new Button();
            increaseBet = new Button();
            blackjackTab.SuspendLayout();
            gameTab.SuspendLayout();
            rulesTab.SuspendLayout();
            SuspendLayout();
            // 
            // blackjackTab
            // 
            blackjackTab.Appearance = TabAppearance.Buttons;
            blackjackTab.Controls.Add(gameTab);
            blackjackTab.Controls.Add(rulesTab);
            blackjackTab.Location = new Point(0, -1);
            blackjackTab.Margin = new Padding(2, 3, 2, 3);
            blackjackTab.Name = "blackjackTab";
            blackjackTab.SelectedIndex = 0;
            blackjackTab.Size = new Size(913, 603);
            blackjackTab.TabIndex = 0;
            // 
            // gameTab
            // 
            gameTab.BackColor = Color.ForestGreen;
            gameTab.Controls.Add(increaseBet);
            gameTab.Controls.Add(reduceBet);
            gameTab.Controls.Add(playerCurrentBet);
            gameTab.Controls.Add(RulesButton);
            gameTab.Controls.Add(BetAmount);
            gameTab.Controls.Add(BetTitle);
            gameTab.Controls.Add(SplitButton);
            gameTab.Controls.Add(DoubleButton);
            gameTab.Controls.Add(StandButton);
            gameTab.Controls.Add(HitButton);
            gameTab.Controls.Add(BlackjackTitle);
            gameTab.ForeColor = SystemColors.ActiveCaptionText;
            gameTab.Location = new Point(4, 32);
            gameTab.Margin = new Padding(2, 3, 2, 3);
            gameTab.Name = "gameTab";
            gameTab.Padding = new Padding(2, 3, 2, 3);
            gameTab.Size = new Size(905, 567);
            gameTab.TabIndex = 0;
            gameTab.Text = "Game";
            // 
            // RulesButton
            // 
            RulesButton.BackColor = Color.LimeGreen;
            RulesButton.ForeColor = SystemColors.ActiveCaptionText;
            RulesButton.Location = new Point(6, 7);
            RulesButton.Margin = new Padding(3, 4, 3, 4);
            RulesButton.Name = "RulesButton";
            RulesButton.Size = new Size(94, 33);
            RulesButton.TabIndex = 8;
            RulesButton.Text = "Rules";
            RulesButton.UseVisualStyleBackColor = false;
            // 
            // BetAmount
            // 
            BetAmount.AutoSize = true;
            BetAmount.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BetAmount.ForeColor = SystemColors.Window;
            BetAmount.Location = new Point(695, 44);
            BetAmount.Name = "BetAmount";
            BetAmount.Size = new Size(0, 29);
            BetAmount.TabIndex = 7;
            // 
            // BetTitle
            // 
            BetTitle.BackColor = Color.ForestGreen;
            BetTitle.BorderStyle = BorderStyle.None;
            BetTitle.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BetTitle.ForeColor = SystemColors.Window;
            BetTitle.Location = new Point(695, 7);
            BetTitle.Margin = new Padding(3, 4, 3, 4);
            BetTitle.Name = "BetTitle";
            BetTitle.Size = new Size(182, 32);
            BetTitle.TabIndex = 6;
            BetTitle.Text = "Current Bet:";
            // 
            // SplitButton
            // 
            SplitButton.BackColor = Color.LimeGreen;
            SplitButton.ForeColor = SystemColors.ActiveCaptionText;
            SplitButton.Location = new Point(695, 395);
            SplitButton.Margin = new Padding(3, 4, 3, 4);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(182, 60);
            SplitButton.TabIndex = 5;
            SplitButton.Text = "Split";
            SplitButton.UseVisualStyleBackColor = false;
            SplitButton.Click += SplitButton_Click;
            // 
            // DoubleButton
            // 
            DoubleButton.BackColor = Color.LimeGreen;
            DoubleButton.ForeColor = SystemColors.ActiveCaptionText;
            DoubleButton.Location = new Point(695, 311);
            DoubleButton.Margin = new Padding(3, 4, 3, 4);
            DoubleButton.Name = "DoubleButton";
            DoubleButton.Size = new Size(182, 60);
            DoubleButton.TabIndex = 4;
            DoubleButton.Text = "Double";
            DoubleButton.UseVisualStyleBackColor = false;
            DoubleButton.Click += DoubleButton_Click;
            // 
            // StandButton
            // 
            StandButton.BackColor = Color.LimeGreen;
            StandButton.ForeColor = SystemColors.ActiveCaptionText;
            StandButton.Location = new Point(695, 225);
            StandButton.Margin = new Padding(3, 4, 3, 4);
            StandButton.Name = "StandButton";
            StandButton.Size = new Size(182, 60);
            StandButton.TabIndex = 3;
            StandButton.Text = "Stand";
            StandButton.UseVisualStyleBackColor = false;
            StandButton.Click += StandButton_Click;
            // 
            // HitButton
            // 
            HitButton.BackColor = Color.LimeGreen;
            HitButton.ForeColor = SystemColors.ActiveCaptionText;
            HitButton.Location = new Point(695, 139);
            HitButton.Margin = new Padding(3, 4, 3, 4);
            HitButton.Name = "HitButton";
            HitButton.Size = new Size(182, 60);
            HitButton.TabIndex = 2;
            HitButton.Text = "Hit";
            HitButton.UseVisualStyleBackColor = false;
            HitButton.Click += HitButton_Click;
            // 
            // BlackjackTitle
            // 
            BlackjackTitle.AutoSize = true;
            BlackjackTitle.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BlackjackTitle.ForeColor = SystemColors.ButtonHighlight;
            BlackjackTitle.Location = new Point(299, 3);
            BlackjackTitle.Margin = new Padding(2, 0, 2, 0);
            BlackjackTitle.Name = "BlackjackTitle";
            BlackjackTitle.Size = new Size(285, 56);
            BlackjackTitle.TabIndex = 1;
            BlackjackTitle.Text = "BLACKJACK";
            BlackjackTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // rulesTab
            // 
            rulesTab.BackColor = Color.ForestGreen;
            rulesTab.Controls.Add(label1);
            rulesTab.Controls.Add(rulesLabel);
            rulesTab.Location = new Point(4, 32);
            rulesTab.Margin = new Padding(2, 3, 2, 3);
            rulesTab.Name = "rulesTab";
            rulesTab.Padding = new Padding(2, 3, 2, 3);
            rulesTab.Size = new Size(905, 567);
            rulesTab.TabIndex = 1;
            rulesTab.Text = "Rules";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(11, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(912, 180);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // rulesLabel
            // 
            rulesLabel.AutoSize = true;
            rulesLabel.Font = new Font("Stencil", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rulesLabel.ForeColor = SystemColors.ButtonHighlight;
            rulesLabel.Location = new Point(391, 16);
            rulesLabel.Margin = new Padding(2, 0, 2, 0);
            rulesLabel.Name = "rulesLabel";
            rulesLabel.Size = new Size(121, 40);
            rulesLabel.TabIndex = 0;
            rulesLabel.Text = "RULES";
            // 
            // playerCurrentBet
            // 
            playerCurrentBet.AutoSize = true;
            playerCurrentBet.Location = new Point(780, 57);
            playerCurrentBet.Name = "playerCurrentBet";
            playerCurrentBet.Size = new Size(17, 20);
            playerCurrentBet.TabIndex = 9;
            playerCurrentBet.Text = "0";
            // 
            // reduceBet
            // 
            reduceBet.BackColor = Color.LimeGreen;
            reduceBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reduceBet.Location = new Point(695, 53);
            reduceBet.Name = "reduceBet";
            reduceBet.Size = new Size(34, 29);
            reduceBet.TabIndex = 10;
            reduceBet.Text = "-";
            reduceBet.UseVisualStyleBackColor = false;
            reduceBet.Click += reduceBet_Click;
            // 
            // increaseBet
            // 
            increaseBet.BackColor = Color.LimeGreen;
            increaseBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            increaseBet.Location = new Point(843, 53);
            increaseBet.Name = "increaseBet";
            increaseBet.Size = new Size(34, 29);
            increaseBet.TabIndex = 11;
            increaseBet.Text = "+";
            increaseBet.UseVisualStyleBackColor = false;
            increaseBet.Click += increaseBet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 600);
            Controls.Add(blackjackTab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Blackjack";
            Load += Form1_Load;
            blackjackTab.ResumeLayout(false);
            gameTab.ResumeLayout(false);
            gameTab.PerformLayout();
            rulesTab.ResumeLayout(false);
            rulesTab.PerformLayout();
            ResumeLayout(false);
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
        private Button increaseBet;
        private Button reduceBet;
        private Label playerCurrentBet;
    }
}