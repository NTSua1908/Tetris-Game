using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Tetris
{ 
    public partial class Tetris_Mulltiplayer : Form
    { 
        #region Properties
        GamePlayer game1;
        GameOtherPlayer game2;

        SocketManager socket;
        string IP;

        bool GameStart;
        bool PreventKeyRotation;

        Display Area1;
        Display Area2;

        int TimeGame;
        int Port;

        #endregion

        #region Method
        public Tetris_Mulltiplayer()
        { 
            InitializeComponent();
            InitDislay();

            game1 = new GamePlayer(0, 0, 200, 25, Area1);
            game2 = new GameOtherPlayer(400, 0, 200, 25, Area2);

            GameStart = false;
            TimeGame = 500;

            socket = new SocketManager(lstMess, txtMess);
            CheckForIllegalCrossThreadCalls = false;
            IP = getIPV4();

            socket.messageFromPlayer += Socket_messageFromPlayer;
            socket.Disconnect += Socket_Disconnect;
            socket.Connected += Socket_Connected;

            game1.NewBrickEvent += Game1_NewBrickEvent;
            game1.NewBoard += Game1_NewBoard;
            game1.GetScore += Game1_GetScore;
            game2.StartGame += Game2_StartGame;

        }

        private void Game1_GetScore(object sender, EventArgs e)
        {
            if (game1.Score % 10 == 0)
                TimeGame = (int)(0.9 * TimeGame);
            lbScore1.Text = game1.Score.ToString();
        }

        private void Game1_NewBoard(object sender, EventArgs e)
        {
            SendBoard(false);
        }

        private void Game1_NewBrickEvent(object sender, BrickInfo e)
        {
            SocketData data = new SocketData(SocketCommand.SEND_NEW_BRICK, e.NextBrick.ToString(), null, null);
            socket.Send(data);
        }

        #region FromOtherPlayer
        private void Game2_StartGame(object sender, EventArgs e)
        {
            lbScore1.Text = "0";
            lbScore2.Text = "0";
            if (!socket.isSever)
                game1.Reset();
            else
            {
                Thread.Sleep(50);
                SocketData data = new SocketData(SocketCommand.START_GAME, "", null, null);
                socket.Send(data);

                StartGame();
            }
        }

        void NewBrickFromOtherPlayer(SocketDataEvent e)
        {
            game2.SetNewBrick(Convert.ToInt32(e.Mess));
        }

        private void Socket_messageFromPlayer(object sender, SocketDataEvent e)
        {
            switch (e.Command)
            {
                case SocketCommand.BOARD:
                    
                    if (e.Mess == "LOSE")
                        game2.Lose = true;
                    else
                    {
                        int score = Convert.ToInt32(e.Mess);
                        if (score != game2.Score)
                        {
                            game2.Score = score;
                            lbScore2.Text = e.Mess;
                        }
                        //this.Invoke((MethodInvoker)(() =>
                        //{
                        //    lbScore2.Text = e.Mess;
                        //}));
                        
                    };
                    game2.setBoard(e.Board);
                    game2.setA(e.A);
                    //Area2.Invalidate();
                    break;
                case SocketCommand.SEND_NEW_BRICK:
                    NewBrickFromOtherPlayer(e);
                    break;
                case SocketCommand.READY:
                    game1.isOtherPlayerReady = true;
                    socket.AddMess("Client is ready");
                    break;
                case SocketCommand.NOT_READY:
                    game1.isOtherPlayerReady = false;
                    socket.AddMess("Client is not ready");
                    break;
                case SocketCommand.NEW_GAME:
                    game2.Reset();
                    break;
                case SocketCommand.START_GAME:
                    StartGame();
                    break;
                case SocketCommand.DISCONNECTED:
                    MessageBox.Show("The other player has disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Disconnect();
                    break;
                default:
                    break;
            }
        }
        #endregion
        void InitDislay()
        {
            Area1 = new Display();
            Area1.Location = new Point(0, 20);
            Area1.Size = new Size(380, 480);
            Area1.Paint += Area1_Paint;
            this.Controls.Add(Area1);
            Area1.BackColor = Color.Transparent;
            Area1.BringToFront();
            lbScore1.BringToFront();
            ptbEmiya.BringToFront();

            Area2 = new Display();
            Area2.Location = new Point(400, 20);
            Area2.Size = new Size(380, 480);
            Area2.Paint += Area2_Paint;
            this.Controls.Add(Area2);
            Area2.BackColor = Color.Transparent;
            Area2.BringToFront();

            LoadFont();

            ptbFrame.BringToFront();
            label1.BringToFront();
            txtPort.BringToFront();
            label2.BringToFront();
            txtIP.BringToFront();
            lbPlayReady.BringToFront();
            lbConnect.BringToFront();
            lbDisconnect.BringToFront();
            GetIP.BringToFront();
            lbStatus.BringToFront();
            lbScore2.BringToFront();
            ptbGil.BringToFront();
            ptbRandom.BringToFront();
        }

        private void Area2_Paint(object sender, PaintEventArgs e)
        {
            if (GameStart)
                game2.Paint(e.Graphics);
            if (game1.Lose && game2.Lose)
                GameStart = false;
        }

        private void Area1_Paint(object sender, PaintEventArgs e)
        {
            if (GameStart)
                game1.Paint(e.Graphics);
            if (game1.Lose && game2.Lose)
                GameStart = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!GameStart || game1.Lose)
                return false;
            if (keyData != Keys.Left && keyData != Keys.Right && keyData != Keys.Up && keyData != Keys.Down)
                return false;

            game1.UpdateBoard(0);
            game1.isKeyPress = true;
            
            switch (keyData)
            {
                case Keys.Left:
                    game1.MoveLeft();
                    //SendBoard();
                    break;
                case Keys.Right:
                    game1.MoveRight();
                    //SendBoard();
                    break;
                case Keys.Up:
                    if (!PreventKeyRotation)
                    {
                        game1.Rotation();
                        //SendBoard();
                        PreventKeyRotation = true;
                    }
                    break;
                case Keys.Down:
                    if (!game1.PreventKey)
                    {
                        timer1.Interval = 10;
                        //SendBoard();
                    }
                    break;
            }
            //if (!(keyData == Keys.Up && PreventKeyRotation) && !(keyData == Keys.Down && game1.PreventKey))
            //{
            //    SendBoard();
            //    Area2.Invalidate();
            //}
            return false;
        }

        void ResetReady()
        {
            if (socket.isSever)
            {
                
            }
            //btnPlayReady.Enabled = true;
            lbPlayReady.Enabled = true;
        }

        void SendBoard(bool isLose)
        {
            SocketData data;
            if (isLose)
                data = new SocketData(SocketCommand.BOARD, "LOSE", game1.getBoard(), game1.getBrick());
            else
                data = new SocketData(SocketCommand.BOARD, game1.Score.ToString(), game1.getBoard(), game1.getBrick());
            socket.Send(data);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = TimeGame;
            game1.UpdateGame();
            //SendBoard();

            Area1.Invalidate();
            if (game1.Lose)
            {
                timer1.Stop();
                ResetReady();
            }

            if (!socket.isConnect)
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer2.Interval = 500;

            ////Area2.Invalidate();
            //if (game2.Lose)
            //{
            //    timer2.Stop();
            //    ResetReady();
            //}
            //if (!socket.isConnect)
            //{
            //    timer1.Stop();
            //    timer2.Stop();
            //}
        }

        void Send(SocketData data)
        {            
            if (socket.Send(data))
            {
                if(data.Command == SocketCommand.MESSAGE)
                    txtMess.Clear();
            }    
            else
            {

                lbConnect.Enabled = true;
                lbSend.Enabled = false;
                lbDisconnect.Enabled = false;
            }
        }

        void StartGame()
        {
            //SendBoard();
            this.Invoke((MethodInvoker)(()=>
            {
                Area1.Invalidate();
                Area2.Invalidate();
                SendBoard(false);
                GameStart = true;
                timer1.Start();

                timer2.Start();
            }));
            //MessageBox.Show("aaa");
        }

        private void Tetris_Mulltiplayer_Shown(object sender, EventArgs e)
        {
            txtIP.Text = IP;
            socket.PORT = Convert.ToInt32(txtPort.Text); //Sau nay lam ki lai
        }

        private string getIPV4()
        {
            string IP;
            IP = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            //IP = socket.GetLocalIPv4();

            if (string.IsNullOrEmpty(IP))
            {
                IP = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
            //IP = socket.GetIPV4();


            return IP;
        }

        #region Event Connect or Disconnect

        private void Socket_Connected(object sender, EventArgs e)
        {
            if (socket.isSever)
            {
                lbSend.Enabled = true;
                lbPlayReady.Enabled = true;
                game1.isOtherPlayerReady = false;
                lbPlayReady.Text = "Play";
                //ptbGil.Visible = true;
                this.Invoke((MethodInvoker)(() =>
                {
                    ptbGil.Visible = true;
                }));
                SourceGame.MultiPlayerMusic.PlayLooping();
            }
        }

        private void Socket_Disconnect(object sender, EventArgs e)
        {
            Disconnect();
        }

        void Disconnect()
        {
            socket.Close();
            lbDisconnect.Enabled = false;
            lbSend.Enabled = false;
            lbConnect.Enabled = true;
            lbStatus.Text = "";
            lbPlayReady.Text = "";
            lbPlayReady.Enabled = false;
            txtIP.Enabled = true;
            txtPort.Enabled = true;
        }


        #endregion

        #endregion

        private void lbPlayReady_Click(object sender, EventArgs e)
        {
            if (socket.isSever)
            {
                if (game1.isOtherPlayerReady)
                {
                    game1.isOtherPlayerReady = false;
                    timer1.Stop();
                    timer2.Stop();

                    SocketData data = new SocketData(SocketCommand.NEW_GAME, "", null, null);
                    socket.Send(data);
                    game2.Reset();
                    game1.Reset();
                    lbPlayReady.Enabled = false;
                    
                    //MessageBox.Show("GameStart");
                }
                else
                {
                    SocketData data = new SocketData(SocketCommand.MESSAGE, "Sever want to start game but Client not ready", null, null);
                    socket.Send(data);
                }

            }
            else
            {
                timer1.Stop();
                timer2.Stop();

                lbPlayReady.Enabled = false;
                SocketData data = new SocketData(SocketCommand.READY, "", null, null);
                socket.Send(data);
            }
        }
        private void lbConnect_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (!string.IsNullOrEmpty(txtPort.Text))
                port = Convert.ToInt32(txtPort.Text);
            if (port < 6000 || port > 9999)
                txtPort.Text = Port.ToString();

            IPAddress ip;
            if (IPAddress.TryParse(txtIP.Text, out ip))
            {
                socket.IP = txtIP.Text;
            }
            else
            {
                MessageBox.Show("Invalid IP Adress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            socket.PORT = Convert.ToInt32(txtPort.Text);
            ptbEmiya.Visible = true;

            if (socket.ConnectSever())
            {
                lbStatus.Font = new Font(SourceGame.FontGame.Families[0], 9, FontStyle.Italic);
                lbStatus.Text = "CONNETED";
                lbSend.Enabled = true;
                lbConnect.Enabled = false;
                lbDisconnect.Enabled = true;
                lbPlayReady.Enabled = true;
                lbPlayReady.Text = "Ready";
                ptbGil.Visible = true;
                txtIP.Enabled = false;
                txtPort.Enabled = false;

            }
            else
            {
                if (socket.IP == IP)
                {
                    socket.CreateSever();
                    lbPlayReady.Text = "Play";
                    lbConnect.Enabled = false;
                    lbDisconnect.Enabled = true;
                    lbStatus.Text = "CREATED";
                    txtIP.Enabled = false;
                    txtPort.Enabled = false;

                }
                else
                {
                    MessageBox.Show("CAN'T CONNECT " + txtIP.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbStatus.Text = "";
                    lbDisconnect.Enabled = false;
                }
            }
        }

        private void lbDisconnect_Click(object sender, EventArgs e)
        {
            SocketData data = new SocketData(SocketCommand.DISCONNECTED, "", null, null);
            Send(data);
            Disconnect();
        }

        void SendMessage()
        {
            if (!string.IsNullOrEmpty(txtMess.Text))
            {
                SocketData data = new SocketData(SocketCommand.MESSAGE, txtMess.Text, null, null);
                Send(data);
            }
        }

        private void lbSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void txtMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && lbSend.Enabled)
            {
                SendMessage();
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.Handled = true;
        }

        private void txtMess_KeyUp(object sender, KeyEventArgs e)
        {
            game1.isKeyPress = false;
            game1.PreventKey = false;
            PreventKeyRotation = false;
        }

        private void lstMess_Click(object sender, EventArgs e)
        {
            //txtMess.is
        }

        private void GetIP_Click(object sender, EventArgs e)
        {
            if (txtIP.Enabled)
                txtIP.Text = IP;
        }

        void RandomPort()
        {
            Random random = new Random();
            Port = random.Next(6000, 10000);
            txtPort.Text = Port.ToString();
        }

        private void Tetris_Mulltiplayer_Load(object sender, EventArgs e)
        {
            SourceGame.MainMenuMusic.Stop();
            RandomPort();
        }

        private void ptbRandom_Click(object sender, EventArgs e)
        {
            if (txtPort.Enabled)
                RandomPort();
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Tetris_Mulltiplayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SourceGame.isMusicMainMenuOn)
                SourceGame.MainMenuMusic.PlayLooping();
        }
        void LoadFont()
        {
            lbSend.Font = new Font(SourceGame.FontGame.Families[0], 10, FontStyle.Italic);
            lbStatus.Font = new Font(SourceGame.FontGame.Families[0], 9, FontStyle.Italic);
            lbScore1.Font = new Font(SourceGame.FontGame.Families[0], 15, FontStyle.Italic);
            lbScore2.Font = new Font(SourceGame.FontGame.Families[0], 15, FontStyle.Italic);
            label1.Font = new Font(SourceGame.FontGame.Families[0], 11, FontStyle.Italic);
            label2.Font  = new Font(SourceGame.FontGame.Families[0], 12, FontStyle.Italic);
            txtIP.Font = new Font(SourceGame.FontGame.Families[0], 11, FontStyle.Italic);
            txtPort.Font = new Font(SourceGame.FontGame.Families[0], 12, FontStyle.Italic);
            lbConnect.Font = new Font(SourceGame.FontGame.Families[0], 14, FontStyle.Italic);
            lbDisconnect.Font = new Font(SourceGame.FontGame.Families[0], 14, FontStyle.Italic);
            lbPlayReady.Font = new Font(SourceGame.FontGame.Families[0], 15, FontStyle.Italic);
        }
    }
}
