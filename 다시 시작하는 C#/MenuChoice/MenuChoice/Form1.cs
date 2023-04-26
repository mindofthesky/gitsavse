namespace MenuChoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] SList = new string[] { "이게 할게맞나", "드롤앤 비크", "하루우라라", "증식의 G" };
        string str = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            str = this.cbList.Text;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (this.txtList.Text != "")
            {
                this.cbList.Items.Add(this.txtList.Text);
                MessageBox.Show("아이템 추가 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                this.txtList.Focus();
            this.txtList.Text = "";

        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbList.Text != "")
                this.lblresult.Text = str+ this.cbList.Text;
        }
    }
}