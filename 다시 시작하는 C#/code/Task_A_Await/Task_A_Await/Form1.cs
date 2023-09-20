namespace Task_A_Await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();
        }
        // ¿À´ÃÀº wait, asy ¿¬½À 
        public async void Run()
        {
            var taskforce = Task.Run(() => LongClator(10));
            int sum = await taskforce;
            label1.Text = sum.ToString();
        }

        public int LongClator(int a)
        {
            int b = 0;
            for (int i = 0; i <= a; i++)
            {
                b += i;
                Thread.Sleep(1000);
            }

            return b;
        }
    }
}