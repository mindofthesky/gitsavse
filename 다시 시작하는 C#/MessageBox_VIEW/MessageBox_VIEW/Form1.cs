namespace MessageBox_VIEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MessageBoxButtons mbb;
        MessageBoxIcon mbi;

        private void BtShow_Click(object sender, EventArgs e)
        {
            if (this.raOk.Checked == true)
                mbb = MessageBoxButtons.OK;
            else if (this.raokcancel.Checked == true)
                mbb = MessageBoxButtons.OKCancel;
            else if (this.raYesNo.Checked == true)
                mbb = MessageBoxButtons.YesNo;

            if (this.raError.Checked == true)
                mbi = MessageBoxIcon.Error;
            else if (this.rainformation.Checked == true)
                mbi = MessageBoxIcon.Information;
            else if (this.raQuestion.Checked == true)
                mbi = MessageBoxIcon.Question;

            MessageBox.Show("메세지 알림확인", "알림", mbb, mbi);

            
        }
    }
}