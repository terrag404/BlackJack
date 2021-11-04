using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class Game
    {
        public static int[] cardValues = new int[] {1,2,3,4,5,6,7,8,9,10,11};
        public static string[] cardNames = new string[] {"Jack","Queen","King","Ace"};
        public static string[] cardNames2 = new string[] {"Hearts","Diamonds","Spades","Clubs"};
        public static Random randy = new Random();

        public static Tuple<List<string>, List<string>> StartGame(Form1 mainForm, TextBox playerBox, TextBox DealerBox, Label playerLbl, Label dealerLbl)
        {
            mainForm.setBoxText("--Dealing Cards--" + Environment.NewLine);                        
            List<string> playerHand = new List<string>();
            List<string> dealerHand = new List<string>();
            int playerTotal = 0;
            int dealerTotal = 0;
            string card;
            for (int i = 0; i < 2; i++)
            {
                int cardIndex = randy.Next(0, cardValues.Length);
                int cardAmount = cardValues[cardIndex];                
                card = FindCardName(cardAmount);
                playerHand.Add(card);                
            }
            playerTotal = Game.GetCardTotals(playerHand);
            int dealCardI = randy.Next(0, cardValues.Length);
            int dealerValue = cardValues[dealCardI];
            card = FindCardName(dealerValue);            
            dealerHand.Add(card);
            dealerTotal = Game.GetCardTotals(dealerHand);
            string plhandString = string.Join(",", playerHand);
            playerBox.Text = plhandString;
            string dlhandString = string.Join(",", dealerHand);
            DealerBox.Text = dlhandString;
            playerLbl.Text = "Player Hand: " + playerTotal;
            dealerLbl.Text = "Dealer Hand: " + dealerTotal;
            mainForm.setBoxText("--Hit or Stand?--" + Environment.NewLine);
            return Tuple.Create(playerHand, dealerHand);
        }

        public static int Draw(Form1 mainForm, TextBox playerBox, TextBox DealerBox, Label playerLbl, Label dealerLbl, string who, List<string> playerHand, List<string> dealerHand)
        {
            int cardIndex = randy.Next(0, cardValues.Length);            
            string card = FindCardName(cardValues[cardIndex]);
            int playerTotal = 0;
            int dealerTotal = 0;
            if (who == "Player")
            {
                playerHand.Add(card);                                
                string plhandString = string.Join(",", playerHand);                
                playerBox.Text = plhandString;
                playerTotal = Game.GetCardTotals(playerHand);
                playerLbl.Text = "Player Hand: " + playerTotal;
                return playerTotal;
            }
            if (who == "Dealer")
            {
                dealerHand.Add(card);                                
                string dlhandString = string.Join(",", dealerHand);                
                DealerBox.Text = dlhandString;
                dealerTotal = Game.GetCardTotals(dealerHand);
                dealerLbl.Text = "Dealer Hand: " + dealerTotal;
                return dealerTotal;
            }
            return 0;
        }

        public static string FindCardName(int cardValue)
        {
            string card = String.Empty;
            int nameValue = 0;            
            if (cardValue == 1 ^ cardValue == 11)
            {
                nameValue = randy.Next(0, cardNames2.Length);
                card = cardNames[3] + " of " + cardNames2[nameValue];                
            }
            else if (cardValue == 10)
            {
                int value = randy.Next(0, cardNames.Length);
                nameValue = randy.Next(0, cardNames2.Length);
                if (value == 3)
                    value -= 1;
                card = cardNames[value] + " of " + cardNames2[nameValue];                
            }
            else
            {
                nameValue = randy.Next(0, cardNames2.Length);
                card = cardValue.ToString() + " of " + cardNames2[nameValue];                
            }
            return card;
        }
        public static int GetCardTotals(List<string> hand)
        {
            int handTotal = 0;
            int aceCount = 0;
            foreach (string card in hand)
            {
                string cardValue = String.Empty;
                if (card.Contains("Ace"))
                {                    
                    if (aceCount > 1)
                        cardValue = "1";
                    else
                        cardValue = "11";
                    aceCount++;
                }                    
                else if (card.Contains("King") ^ card.Contains("Queen") ^ card.Contains("Jack"))
                    cardValue = "10";
                else
                    cardValue = StripNonNumeric(card);
                handTotal += Convert.ToInt32(cardValue);
            }

            if(hand.Any(_h => _h.Contains("Ace")))
            {
                if (handTotal > 21)
                    handTotal -= 10;
            }

            return handTotal;
        }

        public static string CompareHands(Form1 mainForm, string who, int playerTotal, int dealerTotal)
        {
            string whoWon = String.Empty;
            if (who == "Player")
            {
                if (playerTotal > 21)
                {
                    mainForm.setBoxText("--Busted You Lose--" + Environment.NewLine);
                    whoWon = "Dealer";
                }
                else if (playerTotal == 21)
                    mainForm.setBoxText("--BlackJack!--" + Environment.NewLine);
                else
                    mainForm.setBoxText("--Player Draws--" + Environment.NewLine);
            }
            if (who == "Dealer")
            {
                mainForm.setBoxText("--Comparing Hands--" + Environment.NewLine);
                if (dealerTotal > 21)
                {
                    mainForm.setBoxText("--Dealer Busted You Win--" + Environment.NewLine);
                    whoWon = "Player";
                }
                else if (dealerTotal > playerTotal && dealerTotal < 22)
                {
                    mainForm.setBoxText("--Dealer Wins--" + Environment.NewLine);
                    whoWon = "Dealer";
                }
                else if (playerTotal > dealerTotal)
                {
                    mainForm.setBoxText("--Player Wins--" + Environment.NewLine);
                    whoWon = "Player";
                }
                else if (dealerTotal == playerTotal)
                {
                    mainForm.setBoxText("--Draw--" + Environment.NewLine);
                    whoWon = "Draw";
                }
            }            
            return whoWon;
        }

        private static string StripNonNumeric(string input)
        {
            string output = Regex.Replace(input, @"[^0-9.]+", "");
            return output.Trim();
        }
    }
}
