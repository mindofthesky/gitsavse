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

        // memflag는 m+ , m- 값을 저장시키는 역할을 한다 주로 쓰지 않는 기능이지만 
        // 계산기를 최대한 비슷하게 만드는김에 한번 작업해보았다 
        public Form1()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
            txtExp.Enabled = false;
            txtResult.Focus();
            
        }
        //코드 자체는 정말 좋다 근데 지금 문제는 엔터키로도 하고 싶으니까 엔터키도 하나 구현해보는게 낳다 오래간?만에 
        private void btnNumber_Click(object sender, EventArgs e)
        {
            //  Button btn = sender as Button;
        }

        //숫자 클릭시 이벤트 btn 0 ~ 9 
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

        //소수점 
        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
            {
                return;
            }
            else txtResult.Text += ".";
        }
        //음과 양의 합체
        private void btn_pluma_Click(object sender, EventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            txtResult.Text = (-v).ToString();
        }
        // 곱
        private void btn_mul_Click(object sender, EventArgs e)
        {
            saveValue = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " x ";
            op = '*';
            opFlag = true;
        }
        //더하기
        private void btn_sum_Click(object sender, EventArgs e)
        {
            saveValue = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " + ";
            op = '+';
            opFlag = true;
        }
        //빼기
        private void btn_min_Click(object sender, EventArgs e)
        {
            saveValue = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " - ";
            op = '-';
            opFlag = true;
        }
        //나누긔
        private void btn_div_Click(object sender, EventArgs e)
        {
            saveValue = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " ÷ ";
            op = '/';
            opFlag = true;
        }
        // 결과값에 넣을 값 
        private void btn_result_Click(object sender, EventArgs e)
        {
            // txtResult는 현재 값을 입력이 가능 , txtExp 는 readonly

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
        //제곱근 
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtExp.Text = "√(" + txtResult.Text + ")";
            txtResult.Text = Math.Sqrt(double.Parse(txtResult.Text)).ToString();
        }
        //제곱
        private void btnsqr_Click(object sender, EventArgs e)
        {
            txtExp.Text = "sqr(" + txtResult.Text + ")";
            txtResult.Text = (Double.Parse(txtResult.Text) * Double.Parse(txtResult.Text)).ToString();
        }
        // 분수화 
        private void btnRecip_Click(object sender, EventArgs e)
        {
            txtResult.Text = "1 / (" + txtResult.Text + ")";
            txtResult.Text = (1 / Double.Parse(txtResult.Text)).ToString();
        }
        // 저장된값 완전 초기화
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }
        // 이전값 취소
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            saveValue = 0;
            op = '\0';
            opFlag = false;
        }
        // 계산기 값 초기화
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }

        //MC 메모리값 취소하기 위한 초기화 작업 0, 메모리값에 0을 반환 다시 MR, MC를 false 로 초기화
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
        //MR 클릭시 이벤트 
        private void btnMR_Click(object sender, EventArgs e)
        {
            // 이걸통해서 memory에 String 값으로 값을 전달 전달받은값은 초기값은 false 였지만 현재로는 값을 받았기때문에 true 반환
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

        //현재 Enter 이벤트 재작업 
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
