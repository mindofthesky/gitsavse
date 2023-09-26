using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Reader_USE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //listView1.View = View.Details;
        }

        

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
        //  사실 이런 코드는 
        //  Adobe Reader를 이용한 파일 열기가 끝이라 코딩이라고 보기 어렵다
        //  개인적으로 만들고싶은건 View로 PDF를 읽어 오고 싶다는점인데 
        // 이제 그 프로젝트를 실행해보자
        // 이걸 문서화부터 할까 이번건? 쉽지 않을께 뻔한데 
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Files | *.Pdf", ValidateNames = true, Multiselect = false }) {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    // 사실 이건 코드라기보단 동작 시퀀스를 다 불러온셈인데 
                    axAcroPDF1.src = dlg.FileName;
                 
                    AxAcroPDF aa  = new AxAcroPDF();  
                    
                    
                }
            
            }
        }
    }
}
