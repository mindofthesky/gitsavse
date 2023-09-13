using System.Diagnostics;

namespace restartcal
{
    public partial class Form1 : Form
    {
        private double saveValue;
        private double memory;
        private char op = '\0';
        private bool opFlag = false;
        private bool memflag = false;

        // memflag�� m+ , m- ���� �����Ű�� ������ �Ѵ� �ַ� ���� �ʴ� ��������� 
        // ���⸦ �ִ��� ����ϰ� ����±迡 �ѹ� �۾��غ��Ҵ� 
        public Form1()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
            txtExp.Enabled = false;
            txtResult.Focus();
            
        }
        //�ڵ� ��ü�� ���� ���� �ٵ� ���� ������ ����Ű�ε� �ϰ� �����ϱ� ����Ű�� �ϳ� �����غ��°� ���� ������?���� 
        private void btnNumber_Click(object sender, EventArgs e)
        {
            //  Button btn = sender as Button;
        }

        //���� Ŭ���� �̺�Ʈ btn 0 ~ 9 
        private void btn_Allnumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (txtResult.Text == "0" || opFlag == true || memflag == true)
            {
                txtResult.Text = btn.Text;
                opFlag = false;
                memflag = false;
            }
            else txtResult.Text = txtResult.Text + btn.Text;

            double v = double.Parse(txtResult.Text);
            txtResult.Text = commaProcedure(v, txtResult.Text);
        }

        //�Ҽ��� 
        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
            {
                return;
            }
            else txtResult.Text += ".";
        }
        //���� ���� ��ü
        private void btn_pluma_Click(object sender, EventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            txtResult.Text = (-v).ToString();
        }
        // ��
        private void btn_mul_Click(object sender, EventArgs e)
        {
            saveValue = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " x ";
            op = '*';
            opFlag = true;
        }
        //���ϱ�
        private void btn_sum_Click(object sender, EventArgs e)
        {
            saveValue = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " + ";
            op = '+';
            opFlag = true;
        }
        //����
        private void btn_min_Click(object sender, EventArgs e)
        {
            saveValue = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " - ";
            op = '-';
            opFlag = true;
        }
        //������
        private void btn_div_Click(object sender, EventArgs e)
        {
            saveValue = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " �� ";
            op = '/';
            opFlag = true;
        }
        // ������� ���� �� 
        private void btn_result_Click(object sender, EventArgs e)
        {
            // txtResult�� ���� ���� �Է��� ���� , txtExp �� readonly

            try
            {
                double v = double.Parse(txtResult.Text);
                if (txtExp.Text == "" && txtExp.Text == null) txtResult.Text = "0";
                if (txtResult.Text == null && txtResult.Text == "") txtResult.Text = "0";

                switch (op)
                {
                    default:
                        txtResult.Text = "0";
                        txtExp.Text = "0";
                        break;
                    case '+':
                        txtResult.Text = (saveValue + v).ToString();
                        break;
                    case '-':
                        txtResult.Text = (saveValue - v).ToString();
                        break;
                    case '*':
                        txtResult.Text = (saveValue * v).ToString();
                        break;
                    case '/':
                        txtResult.Text = (saveValue / v).ToString();
                        break;
                    

                }
            }catch (Exception ex) 
            {
                
            }
            if(txtResult.Text == "0" && txtResult.Text ==null) txtResult.Text = "0";
            else txtExp.Text = "";
        }
        //������ 
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtExp.Text = "��(" + txtResult.Text + ")";
            txtResult.Text = Math.Sqrt(double.Parse(txtResult.Text)).ToString();
        }
        //����
        private void btnsqr_Click(object sender, EventArgs e)
        {
            txtExp.Text = "sqr(" + txtResult.Text + ")";
            txtResult.Text = (Double.Parse(txtResult.Text) * Double.Parse(txtResult.Text)).ToString();
        }
        // �м�ȭ 
        private void btnRecip_Click(object sender, EventArgs e)
        {
            txtResult.Text = "1 / (" + txtResult.Text + ")";
            txtResult.Text = (1 / Double.Parse(txtResult.Text)).ToString();
        }
        // ����Ȱ� ���� �ʱ�ȭ
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }
        // ������ ���
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            saveValue = 0;
            op = '\0';
            opFlag = false;
        }
        // ���� �� �ʱ�ȭ
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }

        //MC �޸𸮰� ����ϱ� ���� �ʱ�ȭ �۾� 0, �޸𸮰��� 0�� ��ȯ �ٽ� MR, MC�� false �� �ʱ�ȭ
        private void btnMC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            memory += double.Parse(txtResult.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            memory -= double.Parse(txtResult.Text);
        }
        //MR Ŭ���� �̺�Ʈ 
        private void btnMR_Click(object sender, EventArgs e)
        {
            // �̰����ؼ� memory�� String ������ ���� ���� ���޹������� �ʱⰪ�� false ������ ����δ� ���� �޾ұ⶧���� true ��ȯ
            txtResult.Text = memory.ToString();
            memflag = true;
        }

        private static string commaProcedure(double v, string s)
        {
            int pos = 0;
            if (s.Contains(","))
            {
                if (pos == 1) return s;
                string formatstr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatstr, v);
                return s;
            }
            else s = string.Format("{0:N0}", v); return s;
        }

        //���� Enter �̺�Ʈ ���۾� 
        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtResult.Text = "";
                txtResult.Text = memory.ToString();
            }
        }
    }
}
