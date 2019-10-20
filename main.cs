namespace Account_Teller {
    public partial class Form1 : Form {
        public Form1() {
        InitializeComponent();
        }

        Account acc = new Account();

        private void btnWithdraw_Click(object sender, EventArgs e) {
            try {
                acc.Amount = double.Parse(txtAmount.Text);
                acc.Balance = double.Parse(lblBalance.Text);
                lblBalance.Text = acc.doWithdrawl().ToString("C");
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex) {
                MessageBox.Show(ex.Message);
            } 
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e) {
            try {
                acc.Amount = double.Parse(txtAmount.Text);
                lblBalance.Text = acc.doDeposit().ToString("C");
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message);
            }    
            catch (ArgumentException ex) {
                MessageBox.Show(ex.Message);
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }      
    }
}