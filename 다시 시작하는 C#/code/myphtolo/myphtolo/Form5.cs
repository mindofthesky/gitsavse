using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myphtolo
{

    public partial class Form5 : Form
    {
        public Form5()
        {
            Methods.RESET();
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        
        

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;

            int wind_x = this.ClientSize.Width;
            DATA.wind_x = wind_x;
            int wind_y = this.ClientSize.Height;
            DATA.wind_y = wind_y;

            int gridsize = DATA.gridSize;
            int edge = DATA.edge;
            int tileSize = ((wind_x < wind_y ? wind_x : wind_y) - 2 * edge) / gridsize;
                DATA.titleSize = tileSize; // 얘때문에 안됬음 계속 값이없으니까 
            if (tileSize < 0) return;
            // 이제 버그 잡아야됨 시팔 같은곳누르는거 막아야되고 아니 시발 이게 맞
            bool colorSwitch = false, colorSwitch2 = gridsize % 2 == 0;
            int sizeIn = -4, sizeOut = -3;
            int x, y;

            for (int ix = 0; ix < gridsize; ix++)
            {
                if (colorSwitch2) colorSwitch = !colorSwitch;
                for (int iy = 0; iy < gridsize; iy++)
                {
                    x = ix * tileSize + edge;
                    y = iy * tileSize + edge;
                    G.FillRectangle(colorSwitch ? Brushes.Green : Brushes.ForestGreen, x, y, tileSize, tileSize);
                    colorSwitch = !colorSwitch2;
                    DATA.titleCoords[ix, iy].X = x;
                    DATA.titleCoords[ix, iy].Y = y;

                    x -= 1; y -= 1;

                    switch (DATA.titleTeamValue[ix, iy])
                    {
                        case (int)DATA.TeamValue.Empty:
                            break;
                        case (int)DATA.TeamValue.black:
                            G.FillEllipse(Brushes.DimGray, x - sizeOut, y - sizeOut, tileSize + 1 + sizeOut * 2, tileSize + 1 + sizeOut * 2);
                            G.FillEllipse(Brushes.Black, x - sizeIn, y - sizeIn, tileSize + 1 + sizeIn * 2, tileSize + 1 + sizeIn * 2);
                            break;
                        case (int)DATA.TeamValue.white:
                            G.FillEllipse(Brushes.DimGray, x - sizeOut, y - sizeOut, tileSize + 1 + sizeOut * 2, tileSize + 1 + sizeOut * 2);
                            G.FillEllipse(Brushes.LightGray, x - sizeIn, y - sizeIn, tileSize + 1 + sizeIn * 2, tileSize + 1 + sizeIn * 2);
                            break;


                    }

                }
            }

            string displayText = "Team" + (DATA.currentTeam == 1 ? "Black" : "White") + "'s turn";
            SizeF stringWidth = G.MeasureString(displayText, Font);
            G.DrawString(displayText, Font, Brushes.White, (wind_x - stringWidth.Width) / 2, 2);

            if (DATA.doHighlight)
            {
                int borderWidth = 1 + tileSize / 30;
                for (int iA = 0; iA < gridsize; iA++)
                {
                    for (int iB = 0; iB < gridsize; iB++)
                    {
                        if ((iB - 1 >= 0 && DATA.titleMarked[iB - 1, iA]) || (iB < gridsize && DATA.titleMarked[iB, iA]))
                        {
                            x = tileSize * iB + edge;
                            y = tileSize * iA + edge;
                            G.FillRectangle(Brushes.White, x - borderWidth, y, borderWidth * 2 - 1, tileSize - 1);
                        }
                        if ((iB - 1 >= 0 && DATA.titleMarked[iA, iB - 1]) || (iB < gridsize && DATA.titleMarked[iA, iB]))
                        {
                            x = tileSize * iB + edge;
                            y = tileSize * iA + edge;
                            G.FillRectangle(Brushes.White, x, y - borderWidth, tileSize - 1, borderWidth * 2 - 1);
                        }
                    }
                }
            }


        }

        private void Form5_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (!Methods.ISClickInside(e.Location)) return ;
            
            Point pos = Methods.GetTileatPos(e.Location);
            try
            {
                //MessageBox.Show("여기서는 걸리니까 try문 자체는 아니지");
                if(DATA.titleMarked[pos.X, pos.Y])
                {
                    
                    
                    
                    DATA.titleTeamValue[pos.X, pos.Y] = DATA.currentTeam;
                    Methods.FilpOctaRay(pos);

                    if (DATA.currentTeam == (int)DATA.TeamValue.white) DATA.currentTeam = (int)DATA.TeamValue.black;
                    else if (DATA.currentTeam == (int)DATA.TeamValue.black) DATA.currentTeam = (int)DATA.TeamValue.white;
                    
                    Methods.GridClearHighlight();
                    Methods.HighlightAllPossibleOctaMoves();
                    
                    Refresh();

                    Methods.CheckGameEnded();
                    Refresh();

                }
            } catch { return; }
        }


        private void button_restart_click(object sender, EventArgs e)
        {
            Methods.RESET();
            Refresh();
        }

        private void button_highlight_click(object sender, EventArgs e)
        {
            DATA.doHighlight = !DATA.doHighlight;
            Refresh();
        }

        private void Form5_ClientSizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        static class DATA
        {

            public enum TeamValue
            {
                Empty,
                black,
                white,
                both

            }
            public static int gridSize = 8;
            public static int edge = 40;

            public static int wind_x = 0;
            public static int wind_y = 0;
            public static int titleSize = 0;
            public static int amountOFMovesForCurrenteam = 0;
            public static int[,] titleTeamValue = new int[gridSize, gridSize];
            public static Point[,] titleCoords = new Point[gridSize, gridSize];
            public static bool[,] titleMarked = new bool[gridSize, gridSize];
            public static int currentTeam = (int)TeamValue.black;
            public static bool doHighlight = false;
        }
        #region 함수
        static class Methods
        {
            public static bool ISClickInside(Point pos)
            {
                return pos.X >= DATA.titleCoords[0, 0].X
                    &&
                    pos.Y >= DATA.titleCoords[0, 0].Y
                    &&
                    pos.X < DATA.titleCoords[DATA.gridSize - 1, DATA.gridSize - 1].X + DATA.titleSize
                    &&
                    pos.Y < DATA.titleCoords[DATA.gridSize - 1, DATA.gridSize - 1].Y + DATA.titleSize;

            }

            public static Point GetTileatPos(Point pos)
            {
                try
                {
                    int titleSize = DATA.titleSize, tCx = DATA.titleCoords[0, 0].X, tCy = DATA.titleCoords[0, 0].Y;


                    Point pt = new Point(
                        pos.X - tCx >= 0 ? (pos.X - tCx) / titleSize : (pos.X - tCy) / titleSize,
                        pos.Y - tCy >= 0 ? (pos.Y - tCy) / titleSize : (pos.Y - tCy) / titleSize);
                    return pt;
                }
                catch (DivideByZeroException ex)
                {
                    //MessageBox.Show("나는 여기가 오류라고 생각해"); < 여기까지는 옵니다 근데 리턴에 문제
                    int titleSize = DATA.titleSize = 1, tCx = DATA.titleCoords[0, 0].X, tCy = DATA.titleCoords[0, 0].Y;
                    MessageBox.Show(Convert.ToString(titleSize));
                    // pos.X =276 , pos.Y = 233
                    // DATA.titlecoords = System.Drawing.Point값임 
                    //tCx = DATA.titleCoords[0, 0].X 40 , tCx = DATA.titleCoords[0, 0].Y = 40
                    // (246 ,193)

                    //catch 까지 왔지만 new Point 값이 없어서 값이 호출 못되는게 오류라고 생각하는데 안그럼 오류가 발생할일이 없거든 
                    return new Point(0, 0);
                }


            }
            public static void HighlightAllPossibleOctaMoves()
            {
                DATA.amountOFMovesForCurrenteam = 0;
                for (int x = 0; x < DATA.gridSize; x++)
                    for (int y = 0; y < DATA.gridSize; y++)
                        if (DATA.titleTeamValue[x, y] == DATA.currentTeam)
                            HighlightAllPossibleOctaMoves(new Point(x, y));
            }
            private static void HighlightAllPossibleOctaMoves(Point pos)
            {
                List<Point> path;
                int selectedTeam = DATA.titleTeamValue[pos.X, pos.Y];
                for (int i = 0; i < 16; i += 2)
                {
                    path = HighlightAllPossibleOctaMoves(pos, VAR_directions[i], VAR_directions[i + 1]);
                    if (path.Count != 0)
                        for (int i2 = path.Count - 1; i2 >= 0; i2--)
                        {
                            DATA.amountOFMovesForCurrenteam++;
                            DATA.titleMarked[path[i2].X, path[i2].Y] = true;
                            break;
                        }

                }

            }
            private static List<Point> HighlightAllPossibleOctaMoves(Point pos, int stepX, int stepY)
            {
                int gridsize = DATA.gridSize; bool badcase = false; bool finish = false;
                List<Point> path = new List<Point>();
                for (int i = 0; i < gridsize - 1; i++)
                {
                    if (pos.X + i * stepX >= 0 && pos.Y + i * stepY < gridsize
                        && pos.Y + i * stepY >= 0 && pos.Y + stepY < gridsize)
                    {
                        if (DATA.titleTeamValue[pos.X + i * stepX, pos.Y + i * stepY] == (int)DATA.TeamValue.Empty)
                        {
                            path.Add(new Point(pos.X + i * stepX, pos.Y + i + stepY));
                            finish = true;
                            break;
                        }
                        else if (DATA.titleTeamValue[pos.X + i * stepX, pos.Y + i + stepY] != DATA.currentTeam)
                        {
                            path.Add(new Point(pos.X + i * stepX, pos.Y + i + stepY));
                        }
                        else
                        {
                            badcase = true;
                            break;
                        }
                    }

                }
                if (badcase || !finish || path.Count == 1) path.Clear();
                return path;

            }
            public static void FilpOctaRay(Point pos)
            {
                List<Point> path;
                int selectedTeam = DATA.titleTeamValue[pos.X, pos.Y];

                for (int i = 0; i < 16; i += 2)
                {
                    path = FilpRay(pos, VAR_directions[i], VAR_directions[i + 1]);
                    for (int i2 = 0; i2 < path.Count; i2++)
                    {
                        DATA.titleTeamValue[path[i2].X, path[i2].Y] = selectedTeam;

                    }
                }
            }
            private static List<Point> FilpRay(Point pos, int stepX, int stepY)
            {
                int gridsize = DATA.gridSize;
                int selectedTeam = DATA.titleTeamValue[pos.X, pos.Y];
                bool badcase = true;
                List<Point> path = new List<Point>();

                for (int i = 1; i < gridsize - 1; i++)
                {
                    if (pos.X + i * stepX >= 0 && pos.X + i * stepX < gridsize
                        && pos.Y + i * stepY >= 0 && pos.Y + i * stepY < gridsize)
                        if (DATA.titleTeamValue[pos.X + i * stepX, pos.Y + i * stepY] == (int)DATA.TeamValue.Empty)
                            break;
                        else if (DATA.titleTeamValue[pos.X + i * stepX, pos.Y + i * stepY] == selectedTeam)
                        { badcase = false; break; }
                        else if (DATA.titleTeamValue[pos.X + i * stepX, pos.Y + i * stepY] != selectedTeam)
                            path.Add(new Point(pos.X + i * stepX, pos.Y + i * stepY));
                }

                if (badcase) path.Clear();
                return path;
            }
            public static void GridClearHighlight()
            {
                for (int x = 0; x < DATA.gridSize; x++)
                    for (int y = 0; y < DATA.gridSize; y++)
                        DATA.titleMarked[x, y] = false;
            }
            public static void CheckGameEnded()
            {
                int black = 0, white = 0;
                for (int x = 0; x < DATA.gridSize; x++)
                    for (int y = 0; y < DATA.gridSize; y++)
                        if (DATA.titleTeamValue[x, y] == (int)DATA.TeamValue.black) black++;
                        else if (DATA.titleTeamValue[x, y] == (int)(DATA.TeamValue.white)) white++;
                int winerTeam = (int)DATA.TeamValue.Empty;
                if (black == 0) winerTeam = (int)DATA.TeamValue.white;
                else if (white == 0) winerTeam = (int)DATA.TeamValue.black;
                else if (black + white == DATA.gridSize * DATA.gridSize)
                {
                    if (black == white) winerTeam = (int)DATA.TeamValue.both;
                    else if (black > white) winerTeam = (int)DATA.TeamValue.black;
                    else if (white > black) winerTeam = (int)DATA.TeamValue.white;

                }
                else if (DATA.amountOFMovesForCurrenteam == 0)
                    if (DATA.currentTeam == (int)DATA.TeamValue.black) winerTeam = (int)DATA.TeamValue.white;
                    else if (DATA.currentTeam == (int)DATA.TeamValue.white) winerTeam = (int)DATA.TeamValue.black;
                if (winerTeam != (int)DATA.TeamValue.Empty)
                {
                    switch (MessageBox.Show("게임종료" + (winerTeam == (int)DATA.TeamValue.black ? "Black Win" : winerTeam == (int)DATA.TeamValue.white ? "White win" : "Draw"),
                        "Select someting. play again?", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            RESET();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
            public static void RESET()
            {
                if (DATA.gridSize >= 5)
                {
                    for (int x = 0; x < DATA.gridSize; x++)
                        for (int y = 0; y < DATA.gridSize; y++)
                            DATA.titleTeamValue[x, y] = (int)DATA.TeamValue.Empty;
                    DATA.titleTeamValue[3, 3] = 1;
                    DATA.titleTeamValue[3, 4] = 2;
                    DATA.titleTeamValue[4, 3] = 2;
                    DATA.titleTeamValue[4, 4] = 1;
                    DATA.currentTeam = (int)DATA.TeamValue.black;
                    GridClearHighlight();
                    HighlightAllPossibleOctaMoves();
                }
            }

        }
        #endregion 
        private static readonly int[] VAR_directions = new int[]
               {    1, 0, 0, 1,
                   -1, 0, 0, -1,
                    1, 1, 1, -1,
                   -1, 1, -1, -1
               };
    }
}
