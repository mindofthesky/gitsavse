namespace MenuChoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] SList = new string[] { "�̰� �ҰԸ³�", "��Ѿ� ��ũ", "�Ϸ����", "������ G" };
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
                MessageBox.Show("������ �߰� �Ϸ�", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Information);
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