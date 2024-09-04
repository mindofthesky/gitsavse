using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace kiwoom_testing
{
    public partial class Form1 : Form
    {
        #region 일봉 및 변수
        string 체결일;
        int 시가, 저가, 고가, 현재가;
        long 거래량;
        List<dayChart> priceInfoList;
        #endregion
        #region 자동 메세지박스 닫기 구현 
        public class AutoClosingMessageBox
        {
            private const int WM_CLOSE = 0x0010;

            [DllImport("user32.dll", SetLastError = true)]
            private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [DllImport("user32.dll", SetLastError = true)]
            private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

            public static void Show(string text, string caption, int timeout)
            {
                Task.Run(() =>
                {
                    IntPtr hWnd = IntPtr.Zero;
                    while ((hWnd = FindWindow(null, caption)) == IntPtr.Zero) ;
                    Task.Delay(timeout).Wait();
                    PostMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                });

                MessageBox.Show(text, caption);
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            #region 실행 가능 코드
            axKHOpenAPI1.OnReceiveTrData += OnReceiveTrData;
            // 정상 실행중 
            axKHOpenAPI1.OnReceiveTrData += OnReceiveTrDataDaychart;
            // 현재 해결완료 
            axKHOpenAPI1.OnReceiveRealData += axKHOpenAPI_OnReceiveRealData;
            // 해결완료 
            #endregion

            #region 차트 관련 초기값
            Series chartSeries;
            chartSeries = daychart.Series["Series1"];
            daychart.Series["Series1"]["priceupColor"] = "Red";
            daychart.Series["Series1"]["priceDownColor"] = "Blue";
            daychart.AxisViewChanged += daychart_AxisViewChanged;
            
            #endregion
        }
        #region 일봉 차트 관련 변수 선언 
        private class dayChart
        {
            public string 일자 { get; set; }
            public int 싯가 { get; set; }
            public int 곳가 { get; set; }
            public int 젓가 { get; set; }
            public int 종가 { get; set; }
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void axKHOpenAPI1_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

        }

        #region 검색텍스트 박스 무조건 숫자로 해야됨
        private void button2_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.SetInputValue("종목코드", textBox1.Text); // 1. SetInputValue
            int ret = axKHOpenAPI1.CommRqData("주식기본정보", "OPT10001", 0, "1002"); // 2. CommRqData 를 통해 데이터 요청
            if (ret < 0)
            {
                MessageBox.Show("요청 실패\nError Code : " + ret, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            axKHOpenAPI1.SetInputValue("종목코드", textBox1.Text);
            int result = axKHOpenAPI1.CommRqData("주식거래원", "OPT10002", 0, "1002");
            
        }
        #endregion
        #region 데이터 리시브 
        private void OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            int receiveCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
            if ("주식기본정보".Equals(e.sRQName))
            {
                for (int i = 0; i <= receiveCnt; i++)
                {
                    // for문 없애도 되고 i 를 0으로 처리하면 똑같이 나오나 귀찮으니까 그냥 이렇게 둠 
                    string jName = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim(); // 4. GetCommData 메소드를 통해 데이터 접근
                    string jPrice = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim(); // 4. GetCommData 메소드를 통해 데이터 접근
                    string jmonth = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "결산월").Trim();
                    string jprices = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "자본금").Trim();
                    string juptip = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "상한가").Trim();
                    string jdowntip = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "하한가").Trim();
                    MessageBox.Show("[" + jName + "]\n현재가 : " + jPrice + "\n결산월" + jmonth + "\n자본금" + jprices
                        + "\n상한가" +juptip + "\n하한가" + jdowntip + "]\n");

                    richTextBox1.Text += "[" + jName + "]\n현재가 : " + jPrice + "\n결산월" + jmonth + "\n자본금" + jprices
                        + "\n상한가" + juptip + "\n하한가"+ jdowntip + "]\n";
                    Debug.WriteLine("test");
                }
            }
        }
        #endregion
        #region 로그인 버튼 클릭 이벤트 처리
        private void button1_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI1.CommConnect() == 0) AutoClosingMessageBox.Show("로그인창 열기 성공.", "로그인 확인", 3000);
            else MessageBox.Show("로그인창 열기 실패");
        }
        #endregion
        #region 버튼3 이벤트 처리 
        private void button3_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI1.GetConnectState() == 0) // 0이면 미연결, 1이면 정상연결 
                MessageBox.Show("Open API 연결되어 있지 않습니다.");
            else
                MessageBox.Show("Open API 연결 중입니다.");
        }

        #endregion
        #region 차트 코드 
        // daychart_AxisViewChanged 크기가 변경되면 이벤트가 작동하는 함수 > 그런데 값이 변화하는지 확인불가 
        private void daychart_AxisViewChanged(object sender, System.Windows.Forms.DataVisualization.Charting.ViewEventArgs e)
        {
            // 크기가 변경되지않아서 작동안됨 

            if (sender.Equals(daychart))
            {
                int startPosition = (int)e.Axis.ScaleView.ViewMinimum;
                int endPosition = (int)e.Axis.ScaleView.ViewMaximum;
                Debug.WriteLine("값 확인 start, end :" + startPosition, endPosition);
                int max = (int)e.ChartArea.AxisY.ScaleView.ViewMinimum;
                int min = (int)e.ChartArea.AxisY.ScaleView.ViewMaximum;

                for (int i = startPosition - 1; i < endPosition; i++)
                {
                    if (i >= priceInfoList.Count)
                        break;
                    if (i < 0)
                        i = 0;

                    if (priceInfoList[i].곳가 > max)
                        max = priceInfoList[i].곳가;
                    if (priceInfoList[i].젓가 < min)
                        min = priceInfoList[i].젓가;
                }

                this.daychart.ChartAreas[0].AxisY.Maximum = max;
                this.daychart.ChartAreas[0].AxisY.Minimum = min;
            }
        }
        private void UpdateChart()
        {
            try
            {
                daychart.Series.Clear();  // 시리즈 초기화 확인
                Debug.WriteLine("Series cleared");

                

                // 차트 새로고침
                daychart.Invalidate();
                Debug.WriteLine("Chart updated", daychart.ChartAreas[0].AxisX.LabelStyle.Format);
            }
            catch (Exception ex)
            {
                MessageBox.Show("차트 업데이트 중 오류 발생: " + ex.Message);
                Debug.WriteLine("Error: " + ex.Message);
            }
        }
        #endregion
        #region 일봉 조회 클릭 버튼 
        private void DayButton_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.SetInputValue("종목코드", textBox1.Text.Trim());
            axKHOpenAPI1.SetInputValue("기준일자", daytxt.Text.Trim());
            //axKHOpenAPI1.SetInputValue("기준일자",DateTime.Now.ToString("yyyymmdd"));
            // 자동화 할려다 현재 잠시 에러 
            // 기준일자는 20240902 처럼 가야한다 
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");
            axKHOpenAPI1.CommRqData("주식일봉차트조회", "OPT10081", 0, "1002");
            Debug.WriteLine("버튼 적용까지는 코드가 오고있는거 같음");
            // <!--
            // 실패한코드 
            //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string newFileName = System.IO.Path.Combine(desktopPath, "[" + textBox1.Text.Trim() + "] " + label3.Text + "-" + daytxt.Text.Trim() + "-일봉.csv");
            // 아마 원드라이브 때문에 에러가 나는거일수도? 
            // -->

            // <summary> 현재 C로 잡아놔서 관리자 권한으로 실행해야 에러가 안남 > 수정해서 관리자 안해도됨 
            // 파일 만드는건 해놨는데 굳이 필요없는거 같아서 주석처리 
            //string newFileName = @"C:\Users\ms_cr\OneDrive\Desktop\[" + textBox1.Text.Trim() + "] " + label3.Text + "-" + daytxt.Text.Trim() + "-일봉.csv";
            //string directory = System.IO.Path.GetDirectoryName(newFileName);
            //if (!System.IO.Directory.Exists(directory))
            //{
            //    System.IO.Directory.CreateDirectory(directory);            
            //}
            //string title = "Date" + "," + "Open" + "," + "High" + "," + "Low" + "," + "Close" + "," + "Volume" + Environment.NewLine;
            //System.IO.File.WriteAllText(newFileName, title);
            // --- 여기까지가 파일만들어주는것 </summary>
            axKHOpenAPI1.OnReceiveTrData += OnReceiveTrDataDaychart;
            //UpdateChart();
            priceInfoList = new List<dayChart>();
        }
        #endregion
        #region 예수금 관련 코드 > 구현 아직 
        private void txtTest_Click(object sender, EventArgs e)
        {
            WriteLog(textBox1.Text.Trim());
            axKHOpenAPI1.SetInputValue("계좌번호", textBox2.Text.Trim());
            axKHOpenAPI1.SetInputValue("비밀번호", "");
            axKHOpenAPI1.SetInputValue("비밀번호입력매개체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "3");

            int nRet = axKHOpenAPI1.CommRqData("예수금상세현황요청", "OPW00001", 0,"0");
            
        }

        #region 에러 발생 버튼쪽 로그 그냥 디버그 로그로 찍어서 이제는필요없음 
        private void WriteLog(string message)
        {
            // 에러 발생이유 버튼에 있는 모든 설정을 해놨음 이건 버튼이아닌 BOX에 이벤트를 정의하지않았음 
            richTextBox1.AppendText($@"{message}");
            richTextBox1.SelectionStart = txtTest.Text.Length;
            richTextBox1.ScrollToCaret();
        }


        #endregion

        #endregion
        
        #region 일봉 구현완료 > 차트형식으로 구현중  
        private void OnReceiveTrDataDaychart(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            // 이거 코드 해결한게 (e.sRQName == "주식일봉차트조회") 이게 원래 코드였는데 
            if ("주식일봉차트조회".Equals(e.sRQName))
                // 아래로 코드 변경후 작동이 됩니다 
            {
                Debug.WriteLine("주식일봉차트조회 처리 시작");
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sRQName, e.sRQName);
                Debug.WriteLine($"수신된 데이터 개수: {nCnt}");
                // 현재 코드 수정으로 여기까지 오고 있음 이제 어떻게 해야 받을수있는지 해결해야함 아니지 0이 맞잖아? 
                priceInfoList.Clear();

                for (int i=0; i<= nCnt; i++)
                {
                    try { 
                    체결일 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim();
                    Debug.WriteLine(체결일);
                    시가 = Math.Abs(int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i,"시가").Trim()));
                    고가 = Math.Abs(int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "고가").Trim()));
                    저가 = Math.Abs(int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "저가").Trim()));
                    현재가 = Math.Abs(int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim()));
                    거래량  = Math.Abs(int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "거래량").Trim()));
                    //string newFileName = @"C:\Users\ms_cr\OneDrive\Desktop\[" + textBox1.Text.Trim() + "] " + label3.Text + "-" + daytxt.Text.Trim() + "-일봉.csv";
                        //System.IO.File.AppendAllText(newFileName, 체결일 + "," + 시가 + "," + 고가 + "," + 저가 + "," + 현재가 + "," + 거래량 + Environment.NewLine);
                        // 테스트용 코드 아래 작성 위 
                        //using (System.IO.StreamWriter sw = new System.IO.StreamWriter(newFileName, true)) // append 모드로 파일 열기
                        //{
                        //    sw.WriteLine(체결일 + "," + 시가 + "," + 고가 + "," + 저가 + "," + 현재가 + "," + 거래량);
                        //    Debug.WriteLine("테스트 :" + 시가);
                            // 해결함! 
                        //}

                        richTextBox1.Text += ("체결일 : "+체결일 + "\n 시가 :" + 시가 + "\n 고가 :" + 고가 + " \n 저가 :" + 저가 + "\n 현재가:" + 현재가 + "\n 거래량:" + 거래량 + Environment.NewLine);
                        priceInfoList.Add(new dayChart() {
                            일자 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim(),
                            싯가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "시가").Trim()),
                            곳가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "고가").Trim()),
                            젓가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "저가").Trim()),
                            종가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim())

                        });
                        daychart.Series["Series1"].Points.AddXY(priceInfoList[i].일자, priceInfoList[i].곳가);
                        daychart.Series["Series1"].Points[i].YValues[1] = priceInfoList[i].젓가;
                        daychart.Series["Series1"].Points[i].YValues[2] = priceInfoList[i].싯가;
                        daychart.Series["Series1"].Points[i].YValues[3] = priceInfoList[i].종가;
                        Debug.WriteLine("값 3 2 1 :"+daychart.Series["Series1"].Points[i].YValues[3]+","+daychart.Series["Series1"].Points[i].YValues[2]+","+daychart.Series["Series1"].Points[i].YValues[1]);
                        // 값은 들어오고있으나 차트가 보이지않음 

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("에러발생"+ex.Message);
                    }
                    UpdateChart();
                }
            }
            e.sTrCode = "";
            e.sRQName = "";
        }
        #region 차트 관련 코드 
        
        
        #endregion
        #endregion
        #region 실시간 데이터 오후4시이후 조회 안됨 
        private void axKHOpenAPI_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            // 잘오고있고 디버그 로그 찍기 힘드니 주석처리 
            // Debug.WriteLine("OnRealTime");
            listBox1.Items.Add(textBox1.Text.Trim());
            // 텍스트박스의 값을 주고 나니 정상적으로 출력중  실시간 속도가 너무 빠른거같음 
            // 실시간으로 데이터가 오니까 실시간안될때는 작동안되는게 맞음 
            listBox1.Items.Add(e.sRealType);
            listBox1.Items.Add(e.sRealData);
            if ("주식체결".Equals(e.sRealType))
            {
                //richTextBox1.Text += axKHOpenAPI1.GetCommRealData(e.sRealType, 10).Trim();
                // 실시간 데이터 받아오게하는 데이터를 목록 
                listBox1.Items.Add("------------------------------------------------------------------");
                this.listBox1.Items.Add("현재가" + axKHOpenAPI1.GetCommRealData(e.sRealType, 10).Trim());
                this.listBox1.Items.Add("전일대비" + axKHOpenAPI1.GetCommRealData(e.sRealType, 11).Trim());
                this.listBox1.Items.Add("등락율" + axKHOpenAPI1.GetCommRealData(e.sRealType, 12).Trim());
                this.listBox1.Items.Add("누적거래량" + axKHOpenAPI1.GetCommRealData(e.sRealType, 13).Trim());
                this.listBox1.Items.Add("누적거래대금" + axKHOpenAPI1.GetCommRealData(e.sRealType, 14).Trim());
                this.listBox1.Items.Add("시가" + axKHOpenAPI1.GetCommRealData(e.sRealType, 16).Trim());
                this.listBox1.Items.Add("고가" + axKHOpenAPI1.GetCommRealData(e.sRealType, 17).Trim());
                this.listBox1.Items.Add("저가" + axKHOpenAPI1.GetCommRealData(e.sRealType, 18).Trim());
                this.listBox1.Items.Add("전일대비기호" + axKHOpenAPI1.GetCommRealData(e.sRealType, 25).Trim());
                this.listBox1.Items.Add("전일거래량대비(계약,주)" + axKHOpenAPI1.GetCommRealData(e.sRealType, 26).Trim());
                this.listBox1.Items.Add("거래대금증감" + axKHOpenAPI1.GetCommRealData(e.sRealType, 29).Trim());
                this.listBox1.Items.Add("전일거래량대비(비율)" + axKHOpenAPI1.GetCommRealData(e.sRealType, 30).Trim());
                listBox1.Items.Add("------------------------------------------------------------------");
                int maxItems = 100; // 최대 리스트박스 크기 설정 
                if (listBox1.Items.Count > maxItems)
                {
                    listBox1.Items.RemoveAt(0); // 가장 오래된 항목 삭제 
                }
                // 마지막 스크롤로 fouse 
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.TopIndex = listBox1.SelectedIndex;
            }
        }
        #endregion
    }
}
