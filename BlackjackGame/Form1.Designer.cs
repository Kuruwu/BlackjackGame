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
            increaseBet = new Button();
            reduceBet = new Button();
            playerCurrentBet = new Label();
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
            currentMoneyLabel = new Label();
            playerMoneyLabel = new Label();
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
            blackjackTab.Margin = new Padding(2, 2, 2, 2);
            blackjackTab.Name = "blackjackTab";
            blackjackTab.SelectedIndex = 0;
            blackjackTab.Size = new Size(799, 452);
            blackjackTab.TabIndex = 0;
            // 
            // gameTab
            // 
            gameTab.BackColor = Color.ForestGreen;
            gameTab.Controls.Add(playerMoneyLabel);
            gameTab.Controls.Add(currentMoneyLabel);
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
            gameTab.Location = new Point(4, 27);
            gameTab.Margin = new Padding(2, 2, 2, 2);
            gameTab.Name = "gameTab";
            gameTab.Padding = new Padding(2, 2, 2, 2);
            gameTab.Size = new Size(791, 421);
            gameTab.TabIndex = 0;
            gameTab.Text = "Game";
            // 
            // increaseBet
            // 
            increaseBet.BackColor = Color.LimeGreen;
            increaseBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            increaseBet.Location = new Point(737, 68);
            increaseBet.Margin = new Padding(3, 2, 3, 2);
            increaseBet.Name = "increaseBet";
            increaseBet.Size = new Size(30, 22);
            increaseBet.TabIndex = 11;
            increaseBet.Text = "+";
            increaseBet.UseVisualStyleBackColor = false;
            increaseBet.Click += increaseBet_Click;
            // 
            // reduceBet
            // 
            reduceBet.BackColor = Color.LimeGreen;
            reduceBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reduceBet.Location = new Point(608, 67);
            reduceBet.Margin = new Padding(3, 2, 3, 2);
            reduceBet.Name = "reduceBet";
            reduceBet.Size = new Size(30, 22);
            reduceBet.TabIndex = 10;
            reduceBet.Text = "-";
            reduceBet.UseVisualStyleBackColor = false;
            reduceBet.Click += reduceBet_Click;
            // 
            // playerCurrentBet
            // 
            playerCurrentBet.AutoSize = true;
            playerCurrentBet.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            playerCurrentBet.Location = new Point(677, 65);
            playerCurrentBet.Name = "playerCurrentBet";
            playerCurrentBet.Size = new Size(24, 25);
            playerCurrentBet.TabIndex = 9;
            playerCurrentBet.Text = "0";
            // 
            // RulesButton
            // 
            RulesButton.BackColor = Color.LimeGreen;
            RulesButton.ForeColor = SystemColors.ActiveCaptionText;
            RulesButton.Location = new Point(5, 5);
            RulesButton.Name = "RulesButton";
            RulesButton.Size = new Size(82, 25);
            RulesButton.TabIndex = 8;
            RulesButton.Text = "Rules";
            RulesButton.UseVisualStyleBackColor = false;
            // 
            // BetAmount
            // 
            BetAmount.AutoSize = true;
            BetAmount.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BetAmount.ForeColor = SystemColors.Window;
            BetAmount.Location = new Point(608, 53);
            BetAmount.Name = "BetAmount";
            BetAmount.Size = new Size(0, 24);
            BetAmount.TabIndex = 7;
            // 
            // BetTitle
            // 
            BetTitle.BackColor = Color.ForestGreen;
            BetTitle.BorderStyle = BorderStyle.None;
            BetTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BetTitle.ForeColor = SystemColors.Window;
            BetTitle.Location = new Point(630, 38);
            BetTitle.Name = "BetTitle";
            BetTitle.Size = new Size(119, 24);
            BetTitle.TabIndex = 6;
            BetTitle.Text = "Current Bet";
            // 
            // SplitButton
            // 
            SplitButton.BackColor = Color.LimeGreen;
            SplitButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SplitButton.ForeColor = SystemColors.ActiveCaptionText;
            SplitButton.Location = new Point(608, 296);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(159, 45);
            SplitButton.TabIndex = 5;
            SplitButton.Text = "Split";
            SplitButton.UseVisualStyleBackColor = false;
            SplitButton.Click += SplitButton_Click;
            // 
            // DoubleButton
            // 
            DoubleButton.BackColor = Color.LimeGreen;
            DoubleButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DoubleButton.ForeColor = SystemColors.ActiveCaptionText;
            DoubleButton.Location = new Point(608, 233);
            DoubleButton.Name = "DoubleButton";
            DoubleButton.Size = new Size(159, 45);
            DoubleButton.TabIndex = 4;
            DoubleButton.Text = "Double";
            DoubleButton.UseVisualStyleBackColor = false;
            DoubleButton.Click += DoubleButton_Click;
            // 
            // StandButton
            // 
            StandButton.BackColor = Color.LimeGreen;
            StandButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            StandButton.ForeColor = SystemColors.ActiveCaptionText;
            StandButton.Location = new Point(608, 169);
            StandButton.Name = "StandButton";
            StandButton.Size = new Size(159, 45);
            StandButton.TabIndex = 3;
            StandButton.Text = "Stand";
            StandButton.UseVisualStyleBackColor = false;
            StandButton.Click += StandButton_Click;
            // 
            // HitButton
            // 
            HitButton.BackColor = Color.LimeGreen;
            HitButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            HitButton.ForeColor = SystemColors.ActiveCaptionText;
            HitButton.Location = new Point(608, 104);
            HitButton.Name = "HitButton";
            HitButton.Size = new Size(159, 45);
            HitButton.TabIndex = 2;
            HitButton.Text = "Hit";
            HitButton.UseVisualStyleBackColor = false;
            HitButton.Click += HitButton_Click;
            // 
            // BlackjackTitle
            // 
            BlackjackTitle.AutoSize = true;
            BlackjackTitle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BlackjackTitle.ForeColor = SystemColors.ButtonHighlight;
            BlackjackTitle.Location = new Point(262, 2);
            BlackjackTitle.Margin = new Padding(2, 0, 2, 0);
            BlackjackTitle.Name = "BlackjackTitle";
            BlackjackTitle.Size = new Size(237, 42);
            BlackjackTitle.TabIndex = 1;
            BlackjackTitle.Text = "BLACKJACK";
            BlackjackTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // rulesTab
            // 
            rulesTab.BackColor = Color.ForestGreen;
            rulesTab.Controls.Add(label1);
            rulesTab.Controls.Add(rulesLabel);
            rulesTab.Location = new Point(4, 27);
            rulesTab.Margin = new Padding(2, 2, 2, 2);
            rulesTab.Name = "rulesTab";
            rulesTab.Padding = new Padding(2, 2, 2, 2);
            rulesTab.Size = new Size(791, 421);
            rulesTab.TabIndex = 1;
            rulesTab.Text = "Rules";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(10, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(716, 135);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // rulesLabel
            // 
            rulesLabel.AutoSize = true;
            rulesLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rulesLabel.ForeColor = SystemColors.ButtonHighlight;
            rulesLabel.Location = new Point(342, 12);
            rulesLabel.Margin = new Padding(2, 0, 2, 0);
            rulesLabel.Name = "rulesLabel";
            rulesLabel.Size = new Size(105, 31);
            rulesLabel.TabIndex = 0;
            rulesLabel.Text = "RULES";
            // 
            // currentMoneyLabel
            // 
            currentMoneyLabel.AutoSize = true;
            currentMoneyLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            currentMoneyLabel.ForeColor = SystemColors.Control;
            currentMoneyLabel.Location = new Point(8, 37);
            currentMoneyLabel.Name = "currentMoneyLabel";
            currentMoneyLabel.Size = new Size(154, 25);
            currentMoneyLabel.TabIndex = 12;
            currentMoneyLabel.Text = "Current Money";
            // 
            // playerMoneyLabel
            // 
            playerMoneyLabel.AutoSize = true;
            playerMoneyLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            playerMoneyLabel.Location = new Point(77, 64);
            playerMoneyLabel.Name = "playerMoneyLabel";
            playerMoneyLabel.Size = new Size(0, 25);
            playerMoneyLabel.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(blackjackTab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label playerMoneyLabel;
        private Label currentMoneyLabel;
    }
}