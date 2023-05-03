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
            lblWinCondition = new Label();
            lblInsurance = new Label();
            btnInsurance = new Button();
            lblDealerTotal = new Label();
            btnBet = new Button();
            lblPlayerTotal = new Label();
            increaseBet = new Button();
            reduceBet = new Button();
            playerCurrentBet = new Label();
            RulesButton = new Button();
            BetAmount = new Label();
            BetTitle = new TextBox();
            DoubleButton = new Button();
            StandButton = new Button();
            HitButton = new Button();
            BlackjackTitle = new Label();
            panelPlayerCards = new Panel();
            lblPlayerMoneyTitle = new Label();
            playerMoneyLabel = new Label();
            pctPlayerCard5 = new PictureBox();
            pctPlayerCard1 = new PictureBox();
            pctPlayerCard2 = new PictureBox();
            pctPlayerCard4 = new PictureBox();
            pctPlayerCard3 = new PictureBox();
            panelDealersCards = new Panel();
            pctDealerCard4 = new PictureBox();
            pctDealerCard5 = new PictureBox();
            pctDealerCard1 = new PictureBox();
            pctDealerCard2 = new PictureBox();
            pctDealerCard3 = new PictureBox();
            SplitButton = new Button();
            rulesTab = new TabPage();
            label1 = new Label();
            rulesLabel = new Label();
            blackjackTab.SuspendLayout();
            gameTab.SuspendLayout();
            panelPlayerCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard3).BeginInit();
            panelDealersCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard3).BeginInit();
            rulesTab.SuspendLayout();
            SuspendLayout();
            // 
            // blackjackTab
            // 
            blackjackTab.Appearance = TabAppearance.Buttons;
            blackjackTab.Controls.Add(gameTab);
            blackjackTab.Controls.Add(rulesTab);
            blackjackTab.Location = new Point(0, -1);
            blackjackTab.Margin = new Padding(2);
            blackjackTab.Name = "blackjackTab";
            blackjackTab.SelectedIndex = 0;
            blackjackTab.Size = new Size(799, 452);
            blackjackTab.TabIndex = 0;
            // 
            // gameTab
            // 
            gameTab.BackColor = Color.ForestGreen;
            gameTab.Controls.Add(lblWinCondition);
            gameTab.Controls.Add(lblInsurance);
            gameTab.Controls.Add(btnInsurance);
            gameTab.Controls.Add(lblDealerTotal);
            gameTab.Controls.Add(btnBet);
            gameTab.Controls.Add(lblPlayerTotal);
            gameTab.Controls.Add(increaseBet);
            gameTab.Controls.Add(reduceBet);
            gameTab.Controls.Add(playerCurrentBet);
            gameTab.Controls.Add(RulesButton);
            gameTab.Controls.Add(BetAmount);
            gameTab.Controls.Add(BetTitle);
            gameTab.Controls.Add(DoubleButton);
            gameTab.Controls.Add(StandButton);
            gameTab.Controls.Add(HitButton);
            gameTab.Controls.Add(BlackjackTitle);
            gameTab.Controls.Add(panelPlayerCards);
            gameTab.Controls.Add(panelDealersCards);
            gameTab.Controls.Add(SplitButton);
            gameTab.ForeColor = SystemColors.ActiveCaptionText;
            gameTab.Location = new Point(4, 27);
            gameTab.Margin = new Padding(2);
            gameTab.Name = "gameTab";
            gameTab.Padding = new Padding(2);
            gameTab.Size = new Size(791, 421);
            gameTab.TabIndex = 0;
            gameTab.Text = "Game";
            // 
            // lblWinCondition
            // 
            lblWinCondition.AutoSize = true;
            lblWinCondition.BackColor = Color.Transparent;
            lblWinCondition.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblWinCondition.Location = new Point(135, 155);
            lblWinCondition.Name = "lblWinCondition";
            lblWinCondition.Size = new Size(455, 128);
            lblWinCondition.TabIndex = 22;
            lblWinCondition.Text = "YOU WIN";
            lblWinCondition.TextAlign = ContentAlignment.MiddleCenter;
            lblWinCondition.Visible = false;
            // 
            // lblInsurance
            // 
            lblInsurance.AutoSize = true;
            lblInsurance.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsurance.Location = new Point(219, 201);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(280, 28);
            lblInsurance.TabIndex = 30;
            lblInsurance.Text = "Dealer does not have Blackjack";
            lblInsurance.Visible = false;
            // 
            // btnInsurance
            // 
            btnInsurance.BackColor = Color.LimeGreen;
            btnInsurance.Enabled = false;
            btnInsurance.ForeColor = SystemColors.ActiveCaptionText;
            btnInsurance.Location = new Point(608, 340);
            btnInsurance.Name = "btnInsurance";
            btnInsurance.Size = new Size(159, 45);
            btnInsurance.TabIndex = 29;
            btnInsurance.Text = "Insurance";
            btnInsurance.UseVisualStyleBackColor = false;
            btnInsurance.Click += btnInsurance_Click;
            // 
            // lblDealerTotal
            // 
            lblDealerTotal.AutoSize = true;
            lblDealerTotal.BackColor = Color.Ivory;
            lblDealerTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDealerTotal.Location = new Point(50, 105);
            lblDealerTotal.Name = "lblDealerTotal";
            lblDealerTotal.Size = new Size(27, 32);
            lblDealerTotal.TabIndex = 26;
            lblDealerTotal.Text = "0";
            // 
            // btnBet
            // 
            btnBet.BackColor = Color.LimeGreen;
            btnBet.Enabled = false;
            btnBet.Location = new Point(609, 92);
            btnBet.Name = "btnBet";
            btnBet.Size = new Size(159, 45);
            btnBet.TabIndex = 25;
            btnBet.Text = "Bet";
            btnBet.UseVisualStyleBackColor = false;
            btnBet.Click += btnBet_Click;
            // 
            // lblPlayerTotal
            // 
            lblPlayerTotal.AutoSize = true;
            lblPlayerTotal.BackColor = Color.Ivory;
            lblPlayerTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerTotal.Location = new Point(50, 324);
            lblPlayerTotal.Name = "lblPlayerTotal";
            lblPlayerTotal.Size = new Size(27, 32);
            lblPlayerTotal.TabIndex = 24;
            lblPlayerTotal.Text = "0";
            // 
            // increaseBet
            // 
            increaseBet.BackColor = Color.LimeGreen;
            increaseBet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            increaseBet.Location = new Point(738, 40);
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
            reduceBet.Location = new Point(608, 40);
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
            playerCurrentBet.Location = new Point(682, 43);
            playerCurrentBet.Name = "playerCurrentBet";
            playerCurrentBet.Size = new Size(13, 15);
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
            BetAmount.Location = new Point(608, 33);
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
            BetTitle.Location = new Point(608, 5);
            BetTitle.Name = "BetTitle";
            BetTitle.ReadOnly = true;
            BetTitle.Size = new Size(159, 24);
            BetTitle.TabIndex = 6;
            BetTitle.Text = "Current Bet";
            // 
            // DoubleButton
            // 
            DoubleButton.BackColor = Color.LimeGreen;
            DoubleButton.Enabled = false;
            DoubleButton.ForeColor = SystemColors.ActiveCaptionText;
            DoubleButton.Location = new Point(609, 281);
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
            StandButton.Enabled = false;
            StandButton.ForeColor = SystemColors.ActiveCaptionText;
            StandButton.Location = new Point(609, 217);
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
            HitButton.Enabled = false;
            HitButton.ForeColor = SystemColors.ActiveCaptionText;
            HitButton.Location = new Point(609, 152);
            HitButton.Name = "HitButton";
            HitButton.Size = new Size(159, 45);
            HitButton.TabIndex = 2;
            HitButton.Text = "Hit";
            HitButton.UseVisualStyleBackColor = false;
            HitButton.Visible = false;
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
            // panelPlayerCards
            // 
            panelPlayerCards.Controls.Add(lblPlayerMoneyTitle);
            panelPlayerCards.Controls.Add(playerMoneyLabel);
            panelPlayerCards.Controls.Add(pctPlayerCard5);
            panelPlayerCards.Controls.Add(pctPlayerCard1);
            panelPlayerCards.Controls.Add(pctPlayerCard2);
            panelPlayerCards.Controls.Add(pctPlayerCard4);
            panelPlayerCards.Controls.Add(pctPlayerCard3);
            panelPlayerCards.Location = new Point(110, 257);
            panelPlayerCards.Name = "panelPlayerCards";
            panelPlayerCards.Size = new Size(528, 159);
            panelPlayerCards.TabIndex = 28;
            // 
            // lblPlayerMoneyTitle
            // 
            lblPlayerMoneyTitle.AutoSize = true;
            lblPlayerMoneyTitle.ForeColor = SystemColors.ButtonHighlight;
            lblPlayerMoneyTitle.Location = new Point(106, 143);
            lblPlayerMoneyTitle.Name = "lblPlayerMoneyTitle";
            lblPlayerMoneyTitle.Size = new Size(82, 15);
            lblPlayerMoneyTitle.TabIndex = 22;
            lblPlayerMoneyTitle.Text = "Player Money:";
            // 
            // playerMoneyLabel
            // 
            playerMoneyLabel.AutoSize = true;
            playerMoneyLabel.ForeColor = SystemColors.ButtonHighlight;
            playerMoneyLabel.Location = new Point(194, 143);
            playerMoneyLabel.Name = "playerMoneyLabel";
            playerMoneyLabel.Size = new Size(154, 15);
            playerMoneyLabel.TabIndex = 30;
            playerMoneyLabel.Text = "Players total money go here";
            // 
            // pctPlayerCard5
            // 
            pctPlayerCard5.Location = new Point(384, 29);
            pctPlayerCard5.Name = "pctPlayerCard5";
            pctPlayerCard5.Size = new Size(71, 99);
            pctPlayerCard5.SizeMode = PictureBoxSizeMode.Zoom;
            pctPlayerCard5.TabIndex = 16;
            pctPlayerCard5.TabStop = false;
            // 
            // pctPlayerCard1
            // 
            pctPlayerCard1.Location = new Point(76, 29);
            pctPlayerCard1.Name = "pctPlayerCard1";
            pctPlayerCard1.Size = new Size(71, 99);
            pctPlayerCard1.SizeMode = PictureBoxSizeMode.Zoom;
            pctPlayerCard1.TabIndex = 12;
            pctPlayerCard1.TabStop = false;
            // 
            // pctPlayerCard2
            // 
            pctPlayerCard2.Location = new Point(153, 29);
            pctPlayerCard2.Name = "pctPlayerCard2";
            pctPlayerCard2.Size = new Size(71, 99);
            pctPlayerCard2.SizeMode = PictureBoxSizeMode.Zoom;
            pctPlayerCard2.TabIndex = 13;
            pctPlayerCard2.TabStop = false;
            // 
            // pctPlayerCard4
            // 
            pctPlayerCard4.Location = new Point(307, 29);
            pctPlayerCard4.Name = "pctPlayerCard4";
            pctPlayerCard4.Size = new Size(71, 99);
            pctPlayerCard4.SizeMode = PictureBoxSizeMode.Zoom;
            pctPlayerCard4.TabIndex = 15;
            pctPlayerCard4.TabStop = false;
            // 
            // pctPlayerCard3
            // 
            pctPlayerCard3.Location = new Point(230, 29);
            pctPlayerCard3.Name = "pctPlayerCard3";
            pctPlayerCard3.Size = new Size(71, 99);
            pctPlayerCard3.SizeMode = PictureBoxSizeMode.Zoom;
            pctPlayerCard3.TabIndex = 14;
            pctPlayerCard3.TabStop = false;
            // 
            // panelDealersCards
            // 
            panelDealersCards.Controls.Add(pctDealerCard4);
            panelDealersCards.Controls.Add(pctDealerCard5);
            panelDealersCards.Controls.Add(pctDealerCard1);
            panelDealersCards.Controls.Add(pctDealerCard2);
            panelDealersCards.Controls.Add(pctDealerCard3);
            panelDealersCards.Location = new Point(135, 49);
            panelDealersCards.Name = "panelDealersCards";
            panelDealersCards.Size = new Size(455, 129);
            panelDealersCards.TabIndex = 27;
            // 
            // pctDealerCard4
            // 
            pctDealerCard4.Location = new Point(282, 16);
            pctDealerCard4.Name = "pctDealerCard4";
            pctDealerCard4.Size = new Size(71, 99);
            pctDealerCard4.SizeMode = PictureBoxSizeMode.Zoom;
            pctDealerCard4.TabIndex = 20;
            pctDealerCard4.TabStop = false;
            // 
            // pctDealerCard5
            // 
            pctDealerCard5.Location = new Point(359, 16);
            pctDealerCard5.Name = "pctDealerCard5";
            pctDealerCard5.Size = new Size(71, 99);
            pctDealerCard5.SizeMode = PictureBoxSizeMode.Zoom;
            pctDealerCard5.TabIndex = 21;
            pctDealerCard5.TabStop = false;
            // 
            // pctDealerCard1
            // 
            pctDealerCard1.Location = new Point(51, 16);
            pctDealerCard1.Name = "pctDealerCard1";
            pctDealerCard1.Size = new Size(71, 99);
            pctDealerCard1.SizeMode = PictureBoxSizeMode.Zoom;
            pctDealerCard1.TabIndex = 17;
            pctDealerCard1.TabStop = false;
            // 
            // pctDealerCard2
            // 
            pctDealerCard2.Location = new Point(128, 16);
            pctDealerCard2.Name = "pctDealerCard2";
            pctDealerCard2.Size = new Size(71, 99);
            pctDealerCard2.SizeMode = PictureBoxSizeMode.Zoom;
            pctDealerCard2.TabIndex = 18;
            pctDealerCard2.TabStop = false;
            // 
            // pctDealerCard3
            // 
            pctDealerCard3.Location = new Point(205, 16);
            pctDealerCard3.Name = "pctDealerCard3";
            pctDealerCard3.Size = new Size(71, 99);
            pctDealerCard3.SizeMode = PictureBoxSizeMode.Zoom;
            pctDealerCard3.TabIndex = 19;
            pctDealerCard3.TabStop = false;
            // 
            // SplitButton
            // 
            SplitButton.BackColor = Color.LimeGreen;
            SplitButton.Enabled = false;
            SplitButton.ForeColor = SystemColors.ActiveCaptionText;
            SplitButton.Location = new Point(263, 197);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(159, 45);
            SplitButton.TabIndex = 5;
            SplitButton.Text = "Split";
            SplitButton.UseVisualStyleBackColor = false;
            SplitButton.Visible = false;
            SplitButton.Click += SplitButton_Click;
            // 
            // rulesTab
            // 
            rulesTab.BackColor = Color.ForestGreen;
            rulesTab.Controls.Add(label1);
            rulesTab.Controls.Add(rulesLabel);
            rulesTab.Location = new Point(4, 27);
            rulesTab.Margin = new Padding(2);
            rulesTab.Name = "rulesTab";
            rulesTab.Padding = new Padding(2);
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
            label1.Size = new Size(716, 150);
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
            panelPlayerCards.ResumeLayout(false);
            panelPlayerCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPlayerCard3).EndInit();
            panelDealersCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctDealerCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctDealerCard3).EndInit();
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
        private PictureBox pctDealerCard5;
        private PictureBox pctDealerCard4;
        private PictureBox pctDealerCard3;
        private PictureBox pctDealerCard2;
        private PictureBox pctDealerCard1;
        private PictureBox pctPlayerCard5;
        private PictureBox pctPlayerCard4;
        private PictureBox pctPlayerCard3;
        private PictureBox pctPlayerCard2;
        private PictureBox pctPlayerCard1;
        private Label lblPlayerTotal;
        private Button btnBet;
        private Label lblDealerTotal;
        private Label lblWinCondition;
        private Panel panelPlayerCards;
        private Panel panelDealersCards;
        private Button btnInsurance;
        private Label playerMoneyLabel;
        private Label lblPlayerMoneyTitle;
        private Label lblInsurance;
    }
}