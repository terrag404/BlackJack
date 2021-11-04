using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        List<string> playerHand = new List<string>();
        List<string> dealerHand = new List<string>();
        int playerTotal = 0;
        int dealerTotal = 0;
        int winCount = 0;
        int lossCount = 0;
        int drawCount = 0;
        int dealCount = 0;
        public Form1()
        {
            InitializeComponent();
            Process[] processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (processes.Length > 1)
                closeWorker.RunWorkerAsync();
            else
                mainWorker.RunWorkerAsync();
        }

        delegate void SetTextDelegate(string value);

        public void setBoxText(string value)
        {
            if (InvokeRequired)
                Invoke(new SetTextDelegate(setBoxText), value);
            else
                mainBox.Text += value;
        }

        private void mainWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            setBoxText("--Welcome to BlackJack--" + Environment.NewLine);
        }

        private void mainWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void closeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            setBoxText("Another instance of this program is already running");
        }

        private void closeWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerTotal = 0;
            dealerTotal = 0;
            dealCount = 0;
            mainBox.Text = String.Empty;
            statsLbl.Visible = true;
            statsBox.Visible = true;            
            startBttn.Visible = false;
            statBttn.Visible = false;
            playerLbl.Visible = true;
            PlayerBox.Visible = true;
            dealerLbl.Visible = true;
            DealerBox.Visible = true;
            hitBttn.Visible = true;
            standBttn.Visible = true;
            var CurrentMatch = Game.StartGame(this, PlayerBox, DealerBox, playerLbl, dealerLbl);
            Utilities.ReadLogs(statsBox);
            playerHand = CurrentMatch.Item1;
            dealerHand = CurrentMatch.Item2;
        }

        private void statBttn_Click(object sender, EventArgs e)
        {            
            statsLbl.Visible = true;
            statsBox.Visible = true;
            Utilities.ReadLogs(statsBox);
        }

        private void hitBttn_Click(object sender, EventArgs e)
        {           
            playerTotal = Game.Draw(this, PlayerBox, DealerBox, playerLbl, dealerLbl, "Player", playerHand, dealerHand);
            if (dealCount == 0)
            {
                setBoxText("--Dealer Reveals His Card--" + Environment.NewLine);
                dealerTotal = Game.Draw(this, PlayerBox, DealerBox, playerLbl, dealerLbl, "Dealer", playerHand, dealerHand);
                dealCount++;
            }           
            dealerTotal = Game.GetCardTotals(dealerHand);
            string winner = Game.CompareHands(this, "Player", playerTotal, dealerTotal);
            if (!String.IsNullOrEmpty(winner))
            {                
                if (winner == "Dealer")
                {
                    lossCount++;
                    statsBox.Text = "Win: " + winCount + Environment.NewLine + "Loss: " + lossCount + Environment.NewLine + "Draw: " + drawCount;
                }                
                setBoxText("--Play Again?--" + Environment.NewLine);
                Utilities.CreateLogFile(statsBox.Text);
                ResetGame();
            }                
        }

        private void standBttn_Click(object sender, EventArgs e)
        {            
            while (dealerTotal < 17)
            {
                setBoxText("--Dealer Draws--" + Environment.NewLine);
                dealerTotal = Game.Draw(this, PlayerBox, DealerBox, playerLbl, dealerLbl, "Dealer", playerHand, dealerHand);
            }
            string winner = Game.CompareHands(this, "Dealer", playerTotal, dealerTotal);
            if (!String.IsNullOrEmpty(winner))
            {                
                if (winner == "Player")
                {
                    winCount++;
                    statsBox.Text = "Win: " + winCount + Environment.NewLine + "Loss: " + lossCount + Environment.NewLine + "Draw: " + drawCount;
                }
                else if (winner == "Dealer")
                {
                    lossCount++;
                    statsBox.Text = "Win: " + winCount + Environment.NewLine + "Loss: " + lossCount + Environment.NewLine + "Draw: " + drawCount;
                }
                else
                {
                    drawCount++;
                    statsBox.Text = "Win: " + winCount + Environment.NewLine + "Loss: " + lossCount + Environment.NewLine + "Draw: " + drawCount;
                }
                setBoxText("--Play Again?--" + Environment.NewLine);
                Utilities.CreateLogFile(statsBox.Text);
                ResetGame();
            }
        }

        public void ResetGame()
        {
            startBttn.Visible = true;
            statBttn.Visible = true;
            statsBox.Visible = false;
            statsLbl.Visible = false;
            PlayerBox.Visible = true;
            DealerBox.Visible = true;
            hitBttn.Visible = false;
            standBttn.Visible = false;                        
        }        
    }
}
