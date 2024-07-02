namespace EasyBudgetGUI
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
            lblTitle = new Label();
            lblCurrentBalance = new Label();
            lblBalance = new Label();
            lblSetBudget = new Label();
            npdMonthlyBudget = new NumericUpDown();
            lblBudgetAmount = new Label();
            btnSaveBudget = new Button();
            btnSetBudget = new Button();
            lblAmount = new Label();
            npdAmount = new NumericUpDown();
            lblDate = new Label();
            btnAddIncome = new Button();
            btnAddExpence = new Button();
            lblTransactionHistory = new Label();
            lvwHistory = new ListView();
            dtpDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)npdMonthlyBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdAmount).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(286, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EasyBudget";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCurrentBalance.Location = new Point(264, 77);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(273, 30);
            lblCurrentBalance.TabIndex = 1;
            lblCurrentBalance.Text = "Current Balance / Tapeke";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBalance.Location = new Point(342, 116);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(97, 38);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "$1050";
            // 
            // lblSetBudget
            // 
            lblSetBudget.AutoSize = true;
            lblSetBudget.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSetBudget.Location = new Point(177, 174);
            lblSetBudget.Name = "lblSetBudget";
            lblSetBudget.Size = new Size(447, 38);
            lblSetBudget.TabIndex = 3;
            lblSetBudget.Text = "Set Budget / Rohe Mahere Pūtea";
            // 
            // npdMonthlyBudget
            // 
            npdMonthlyBudget.Location = new Point(41, 249);
            npdMonthlyBudget.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            npdMonthlyBudget.MaximumSize = new Size(1000, 0);
            npdMonthlyBudget.Name = "npdMonthlyBudget";
            npdMonthlyBudget.Size = new Size(707, 31);
            npdMonthlyBudget.TabIndex = 4;
            // 
            // lblBudgetAmount
            // 
            lblBudgetAmount.AutoSize = true;
            lblBudgetAmount.Font = new Font("Segoe UI", 8F);
            lblBudgetAmount.Location = new Point(41, 224);
            lblBudgetAmount.Name = "lblBudgetAmount";
            lblBudgetAmount.Size = new Size(178, 21);
            lblBudgetAmount.TabIndex = 5;
            lblBudgetAmount.Text = "Monthly Budget / Tahua:";
            // 
            // btnSaveBudget
            // 
            btnSaveBudget.Location = new Point(41, 292);
            btnSaveBudget.Name = "btnSaveBudget";
            btnSaveBudget.Size = new Size(351, 47);
            btnSaveBudget.TabIndex = 6;
            btnSaveBudget.Text = "Save / Pupuru";
            btnSaveBudget.UseVisualStyleBackColor = true;
            btnSaveBudget.Click += btnSaveBudget_Click;
            // 
            // btnSetBudget
            // 
            btnSetBudget.BackColor = Color.Gray;
            btnSetBudget.Location = new Point(420, 293);
            btnSetBudget.Name = "btnSetBudget";
            btnSetBudget.Size = new Size(328, 47);
            btnSetBudget.TabIndex = 7;
            btnSetBudget.Text = "Set Budget / Rohe Mahere Pūtea";
            btnSetBudget.UseVisualStyleBackColor = false;
            btnSetBudget.Click += btnSetBudget_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 8F);
            lblAmount.Location = new Point(41, 375);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(147, 21);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Amount / Tau Tapiri:";
            // 
            // npdAmount
            // 
            npdAmount.Location = new Point(41, 399);
            npdAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            npdAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdAmount.Name = "npdAmount";
            npdAmount.Size = new Size(707, 31);
            npdAmount.TabIndex = 9;
            npdAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 8F);
            lblDate.Location = new Point(41, 442);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(121, 21);
            lblDate.TabIndex = 10;
            lblDate.Text = "Date / Pourangi:";
            // 
            // btnAddIncome
            // 
            btnAddIncome.Font = new Font("Segoe UI", 7.5F);
            btnAddIncome.Location = new Point(41, 517);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(351, 46);
            btnAddIncome.TabIndex = 12;
            btnAddIncome.Text = "Add Income / Tāpiri Whiwhinga Moni";
            btnAddIncome.UseVisualStyleBackColor = true;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // btnAddExpence
            // 
            btnAddExpence.Font = new Font("Segoe UI", 7.5F);
            btnAddExpence.Location = new Point(419, 517);
            btnAddExpence.Name = "btnAddExpence";
            btnAddExpence.Size = new Size(329, 46);
            btnAddExpence.TabIndex = 13;
            btnAddExpence.Text = "Add Expence / Tāpiri Ruihi";
            btnAddExpence.UseVisualStyleBackColor = true;
            btnAddExpence.Click += btnAddExpence_Click;
            // 
            // lblTransactionHistory
            // 
            lblTransactionHistory.AutoSize = true;
            lblTransactionHistory.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTransactionHistory.Location = new Point(201, 603);
            lblTransactionHistory.Name = "lblTransactionHistory";
            lblTransactionHistory.Size = new Size(390, 38);
            lblTransactionHistory.TabIndex = 14;
            lblTransactionHistory.Text = "Transaction History / Hītōria";
            // 
            // lvwHistory
            // 
            lvwHistory.FullRowSelect = true;
            lvwHistory.GridLines = true;
            lvwHistory.Location = new Point(59, 668);
            lvwHistory.Name = "lvwHistory";
            lvwHistory.Size = new Size(658, 133);
            lvwHistory.TabIndex = 15;
            lvwHistory.UseCompatibleStateImageBehavior = false;
            lvwHistory.View = View.Details;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(41, 466);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(707, 31);
            dtpDate.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 828);
            Controls.Add(dtpDate);
            Controls.Add(lvwHistory);
            Controls.Add(lblTransactionHistory);
            Controls.Add(btnAddExpence);
            Controls.Add(btnAddIncome);
            Controls.Add(lblDate);
            Controls.Add(npdAmount);
            Controls.Add(lblAmount);
            Controls.Add(btnSetBudget);
            Controls.Add(btnSaveBudget);
            Controls.Add(lblBudgetAmount);
            Controls.Add(npdMonthlyBudget);
            Controls.Add(lblSetBudget);
            Controls.Add(lblBalance);
            Controls.Add(lblCurrentBalance);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)npdMonthlyBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCurrentBalance;
        private Label lblBalance;
        private Label lblSetBudget;
        private NumericUpDown npdMonthlyBudget;
        private Label lblBudgetAmount;
        private Button btnSaveBudget;
        private Button btnSetBudget;
        private Label lblAmount;
        private NumericUpDown npdAmount;
        private Label lblDate;
        private Button btnAddIncome;
        private Button btnAddExpence;
        private Label lblTransactionHistory;
        private ListView lvwHistory;
        private DateTimePicker dtpDate;
    }
}
