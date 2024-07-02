namespace EasyBudgetGUI
{
    public partial class Form1 : Form
    {
        // Global variables
        List<string> historyDate = new List<string>();
        List<string> historyAmount = new List<string>();
        List<bool> isExpense = new List<bool>();
        float balance;
        float amount;
        DateTime date;

        public Form1()
        {
            InitializeComponent();

            lvwHistory.Columns.Add("Date:", 504);
            lvwHistory.Columns.Add("Amount", 150);

            btnSetBudget.Enabled = false;
            balance = 0.0f;
            date = dtpDate.Value;
            lblBalance.Text = "$" + balance;
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            balance += (float)npdAmount.Value;
            lblBalance.Text = "$" + balance;

            amount = (float)npdAmount.Value;
            historyDate.Add(date.ToString());
            historyAmount.Add("$" + amount);
            isExpense.Add(false);

            UpdateHistory();
        }

        private void btnAddExpence_Click(object sender, EventArgs e)
        {
            balance -= (float)npdAmount.Value;
            lblBalance.Text = "$" + balance;

            amount = (float)npdAmount.Value;
            historyDate.Add(date.ToString());
            historyAmount.Add("$" + amount);
            isExpense.Add(true);

            UpdateHistory();
        }

        private void UpdateHistory()
        {
            // Clear table
            lvwHistory.Items.Clear();
            
            int count = historyAmount.Count;
            int startIndex = count >= 3 ? count - 3 : 0;

            // Repopulate table from list using a reverse for loop
            for (int i = count - 1; i >= startIndex; i--)
            {
                string amount = isExpense[i] ? "-" + historyAmount[i] : historyAmount[i];
                string[] row = { historyDate[i], amount };
                var listViewItem = new ListViewItem(row);
                lvwHistory.Items.Add(listViewItem);
            }
        }

        private void btnSaveBudget_Click(object sender, EventArgs e)
        {
            npdMonthlyBudget.ReadOnly = true;
            npdMonthlyBudget.BackColor = Color.Gray;
            btnSaveBudget.Enabled = false;
            btnSaveBudget.BackColor = Color.Gray;
            btnSetBudget.Enabled = true;
            btnSetBudget.BackColor = Color.White;
        }

        private void btnSetBudget_Click(object sender, EventArgs e)
        {
            npdMonthlyBudget.ReadOnly = false;
            npdMonthlyBudget.BackColor = Color.White;
            btnSaveBudget.Enabled = true;
            btnSaveBudget.BackColor = Color.White;
            btnSetBudget.Enabled = false;
            btnSetBudget.BackColor = Color.Gray;
        }
    }
}
