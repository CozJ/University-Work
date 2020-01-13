using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// check for comments---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace Monopoly
{
    public partial class Form1 : Form
    {
        Location[] boardLocation = new Location[40];
        player[] players = new player[4];
        int liveplayers = 0;
        int currentPlayer = 0;
        int move = 0;


        public Form1()
        {
            InitializeComponent();
        }

        class Location
        {
            public string street;
            public int price;
            public string attribute;
            public int rent;
            public int ownedBy;
            public int ammountOwned;
            public int locationX;
            public int locationY;

            public Location(string streetName, int streetPrice, string streetAttribute, int streetRent, int streetOwnedBy, int streetAmountOwned, int streetLocationX, int streetLocationY)
            {
                street = streetName;
                price = streetPrice;
                attribute = streetAttribute;
                rent = streetRent;
                ownedBy = streetOwnedBy;
                ammountOwned = streetAmountOwned;
                locationX = streetLocationX;
                locationY = streetLocationY;

            }
        }
        class player
        {
            public string name;
            public double bank;
            public bool live;
            public int location;
            public bool isJail;
            public int jailCounter;
            public bool bankruptcy;

            public player(string playerName, double playerBank, bool playerLive, int playerLocation, bool jail, int jailC, bool bankrupt)
            {
                name = playerName;
                bank = playerBank;
                live = playerLive;
                location = playerLocation;
                jail = isJail;
                jailC = jailCounter;
                bankrupt = bankruptcy;

            }
        }

        public void generateBoard()
        {
            boardLocation[0] = new Location("Go", 0, "Go", 0, 5, 0, 892, 930);
            boardLocation[1] = new Location("Old Kent Road", 60, "Brown", 2, 6, 0, 793, 930);
            boardLocation[2] = new Location("Community Chest", 0, "Chest", 0, 5, 0, 713, 930);
            boardLocation[3] = new Location("Whitechapel Road", 60, "Brown", 4, 6, 0, 633, 930);
            boardLocation[4] = new Location("Income Tax", 200, "Tax", 0, 5, 0, 553, 930);
            boardLocation[5] = new Location("Kings Cross Station", 200, "Station", 0, 6, 0, 469, 930);
            boardLocation[6] = new Location("The Angel Islington", 100, "Blue", 6, 6, 0, 393, 930);
            boardLocation[7] = new Location("Chance", 0, "Chance", 0, 5, 0, 306, 930);
            boardLocation[8] = new Location("Euston Road", 100, "Blue", 6, 6, 0, 226, 930);
            boardLocation[9] = new Location("Pentonville Road", 120, "Blue", 8, 6, 0, 143, 930);
            boardLocation[10] = new Location("Jail Visit", 0, "JailVisit", 0, 5, 0, 9, 930);
            boardLocation[11] = new Location("Pall Mall", 140, "Pink", 10, 6, 0, 9, 795);
            boardLocation[12] = new Location("Electric Company", 150, "Utilities", 0, 6, 0, 9, 710);
            boardLocation[13] = new Location("Whitehall", 140, "Pink", 10, 6, 0, 9, 630);
            boardLocation[14] = new Location("Northumberland Avenue", 160, "Pink", 12, 6, 0, 9, 550);
            boardLocation[15] = new Location("Marylbone Station", 200, "Station", 0, 6, 0, 9, 470);
            boardLocation[16] = new Location("Bow Street", 180, "Orange", 14, 6, 0, 9, 385);
            boardLocation[17] = new Location("Community Chest", 0, "Chest", 0, 5, 0, 9, 305);
            boardLocation[18] = new Location("Marlborough Street", 180, "Orange", 14, 6, 0, 9, 225);
            boardLocation[19] = new Location("Vine Street", 200, "Orange", 16, 6, 0, 9, 140);
            boardLocation[20] = new Location("Free Parking", 0, "Parking", 0, 5, 0, 9, 9);
            boardLocation[21] = new Location("Strand", 220, "Red", 18, 6, 0, 145, 9);
            boardLocation[22] = new Location("Chance", 0, "Chance", 0, 5, 0, 225, 9);
            boardLocation[23] = new Location("Fleet Street", 220, "Red", 18, 6, 0, 305, 9);
            boardLocation[24] = new Location("Trafalger Square", 240, "Red", 20, 6, 0, 385, 9);
            boardLocation[25] = new Location("Fenchurch Station", 200, "Station", 0, 6, 0, 465, 9);
            boardLocation[26] = new Location("Leicester Square", 260, "Yellow", 22, 6, 0, 550, 9);
            boardLocation[27] = new Location("Coventry Street", 260, "Yellow", 22, 6, 0, 630, 9);
            boardLocation[28] = new Location("Water Works", 0, "Utilities", 0, 6, 0, 710, 9);
            boardLocation[29] = new Location("Piccadily", 280, "Yellow", 22, 6, 0, 795, 9);
            boardLocation[30] = new Location("Go To Jail", 0, "Jail", 0, 5, 0, 68, 871);
            boardLocation[31] = new Location("Regent Street", 300, "Green", 26, 6, 0, 930, 140);
            boardLocation[32] = new Location("Oxford Street", 300, "Green", 26, 6, 0, 930, 222);
            boardLocation[33] = new Location("Community Chest", 0, "Chest", 0, 5, 0, 930, 305);
            boardLocation[34] = new Location("Bond Street", 320, "Green", 28, 6, 0, 930, 385);
            boardLocation[35] = new Location("Liverpool Street Station", 200, "Station", 0, 6, 0, 930, 465);
            boardLocation[36] = new Location("Chance", 0, "Chance", 0, 5, 0, 930, 550);
            boardLocation[37] = new Location("Park Lane", 350, "Blue", 35, 6, 0, 930, 630);
            boardLocation[38] = new Location("Super Tax", 100, "Tax", 0, 5, 0, 930, 710);
            boardLocation[39] = new Location("Mayfair", 400, "Blue", 50, 6, 0, 930, 793);
        }

        public void generatePlayers()
        {
            players[0] = new player("Player One", 1500, false, 0, false, 0, false);
            players[1] = new player("Player Two", 500, false, 0, false, 0, false);
            players[2] = new player("Player Three", 1500, false, 0, false, 0, false);
            players[3] = new player("Player Four", 1500, false, 0, false, 0, false);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void prepPlayerOne()
        {
            pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
            Player1Label.Visible = true;
            Player1Money.Visible = true;
            pictureBox2.Visible = true;
            players[0].live = true;
        }
        private void prepPlayerTwo()
        {
            pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);
            Player2Label.Visible = true;
            Player2Money.Visible = true;
            pictureBox3.Visible = true;
            players[1].live = true;
        }
        private void prepPlayerThree()
        {
            pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
            Player3Label.Visible = true;
            Player3Money.Visible = true;
            pictureBox4.Visible = true;
            players[2].live = true;
        }
        private void prepPlayerFour()
        {
            pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
            Player4Label.Visible = true;
            Player4Money.Visible = true;
            pictureBox5.Visible = true;
            players[3].live = true;
        }

        private void prepBoard()
        {
            label1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            Dice1.Visible = true;
            Dice2.Visible = true;
            RollDice.Visible = true;
            Buy.Visible = true;
            label2.Visible = true;
            currentPlayer = 0;
            for (int i = 0; i < 4; i++)
            {
                if (players[i].live == true)
                {
                    liveplayers = liveplayers + 1;
                }
            }
        }

        public double calculateRent(int currentPlayer)
        {
            double rent = 0;
            textBoxCommunity.Text = "";
            textBoxChance.Text = "";
            if (boardLocation[players[currentPlayer].location].ownedBy == 6)
            {
                return 0;
            }
            else if (boardLocation[players[currentPlayer].location].ownedBy == 5)
            {
                switch (players[currentPlayer].location)
                {
                    case 2:
                        communityChest(currentPlayer);
                        return 0;
                    case 4:
                        return 200;
                    case 7:
                        Chance(currentPlayer);
                        return 0;
                    case 10:
                        return 0;
                    case 30:
                        return 0;
                    case 17:
                        communityChest(currentPlayer);
                        return 0;
                    case 20:
                        return 0;
                    case 22:
                        Chance(currentPlayer);
                        return 0;
                    case 33:
                        communityChest(currentPlayer);
                        return 0;
                    case 36:
                        Chance(currentPlayer);
                        return 0;
                    case 38:
                        return 100;


                }
                return 0;
            }
            else if ((boardLocation[players[currentPlayer].location].ownedBy == 0) || (boardLocation[players[currentPlayer].location].ownedBy == 1) || (boardLocation[players[currentPlayer].location].ownedBy == 2) || (boardLocation[players[currentPlayer].location].ownedBy == 3))
            {
                switch (boardLocation[players[currentPlayer].location].ammountOwned)
                {
                    case 0:
                        rent = 0;
                        break;
                    case 1:
                        switch (players[currentPlayer].location)
                        {
                            case 3:
                                rent = 4; break;
                            case 15:
                            case 25:
                            case 35:
                            case 5:
                                int multiplierP0 = 0;
                                int multiplierP1 = 0;
                                int multiplierP2 = 0;
                                int multiplierP3 = 0;
                                for (int p = 0; p < 31; p++)
                                {
                                    if (boardLocation[p].ownedBy == 0)
                                    {
                                        multiplierP0++;
                                    }
                                    if (boardLocation[p].ownedBy == 1)
                                    {
                                        multiplierP1++;
                                    }
                                    if (boardLocation[p].ownedBy == 2)
                                    {
                                        multiplierP2++;
                                    }
                                    if (boardLocation[p].ownedBy == 3)
                                    {
                                        multiplierP3++;
                                    }
                                }
                                if (boardLocation[players[currentPlayer].location].ownedBy == 0)
                                {
                                    rent = 200 * multiplierP0;
                                }
                                if (boardLocation[players[currentPlayer].location].ownedBy == 1)
                                {
                                    rent = 200 * multiplierP1;
                                }
                                if (boardLocation[players[currentPlayer].location].ownedBy == 2)
                                {
                                    rent = 200 * multiplierP2;
                                }
                                if (boardLocation[players[currentPlayer].location].ownedBy == 3)
                                {
                                    rent = 200 * multiplierP3;
                                }
                                break;
                            case 12:
                                rent = move * 4;
                                break;
                            case 28:
                                rent = move * 4;
                                break;
                            case 29:
                                rent = 22; break;
                            case 37:
                                rent = 35; break;
                            case 39:
                                rent = 50; break;
                            default:
                                rent = ((boardLocation[players[currentPlayer].location].price / 10) - 4); break;
                        }
                        break;
                    case 2:
                        switch (players[currentPlayer].location)
                        {
                            case 3:
                                rent = 20; break;
                            case 34:
                                rent = 150; break;
                            case 37:
                                rent = 175; break;
                            case 39:
                                rent = 200; break;
                            default:
                                rent = ((boardLocation[players[currentPlayer].location].price / 2) - 20); break;
                        }
                        break;
                    case 3:
                        switch (players[currentPlayer].location)
                        {
                            case 9:
                                rent = 100; break;
                            case 16:
                                rent = 200; break;
                            case 18:
                                rent = 200; break;
                            case 19:
                                rent = 220; break;
                            case 21:
                                rent = 250; break;
                            case 23:
                                rent = 250; break;
                            case 37:
                                rent = 500; break;
                            default:
                                rent = (((boardLocation[players[currentPlayer].location].price / 2) - 20) * 3); break;
                        }
                        break;
                    case 4:
                        switch (players[currentPlayer].location)
                        {
                            case 1:
                                rent = 90; break;
                            case 3:
                                rent = 180; break;
                            case 6:
                                rent = 270; break;
                            case 8:
                                rent = 270; break;
                            case 9:
                                rent = 300; break;
                            case 34:
                                rent = 1000; break;
                            case 37:
                                rent = 1100; break;
                            case 39:
                                rent = 1400; break;
                            default:
                                double n = ((((boardLocation[players[currentPlayer].location].price / 2) - 20) * 6) + 140);
                                rent = (Math.Floor(n / 50) * 50);
                                break;
                        }
                        break;
                    case 5:
                        switch (players[currentPlayer].location)
                        {
                            case 1:
                                rent = 160; break;
                            case 3:
                                rent = 320; break;
                            default:
                                rent = ((((boardLocation[players[currentPlayer].location].price / 2) - 20) * 7) + 210);
                                break;
                        }
                        break;
                    case 6:
                        switch (players[currentPlayer].location)
                        {
                            case 1:
                                rent = 250; break;
                            case 3:
                                rent = 450; break;
                            case 6:
                                rent = 550; break;
                            case 8:
                                rent = 550; break;
                            case 9:
                                rent = 600; break;
                            case 11:
                                rent = 750; break;
                            case 13:
                                rent = 750; break;
                            case 31:
                                rent = 1275; break;
                            case 32:
                                rent = 1275; break;
                            case 34:
                                rent = 1400; break;
                            case 37:
                                rent = 1500; break;
                            case 39:
                                rent = 2000; break;
                            default:
                                rent = ((((boardLocation[players[currentPlayer].location].price / 2) - 20) * 5) + 600);
                                break;
                        }
                        break;

                }

                players[currentPlayer].bank = players[currentPlayer].bank - rent;
                players[boardLocation[players[currentPlayer].location].ownedBy].bank = players[boardLocation[players[currentPlayer].location].ownedBy].bank + rent;
                return rent;
            }
            else
            {
                return 0;
            }
        }

        void communityChest(int currentPlayer)
        {
            Random rnd = new Random();
            int communityCard = rnd.Next(1, 8);
            switch (communityCard)
            {
                case 1:
                    textBoxCommunity.Text = "Advance to Go. (Collect $200)";
                    players[currentPlayer].bank = players[currentPlayer].bank + 200;
                    players[currentPlayer].location = 0;
                    switch (currentPlayer)
                    {
                        case 0:
                            pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                            Player1Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 1:
                            pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);
                            Player2Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 2:
                            pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                            Player3Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 3:
                            pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                            Player4Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                    }
                    break;
                case 2:
                    textBoxCommunity.Text = "Bank error in your favor. Collect £200";
                    players[currentPlayer].bank = players[currentPlayer].bank + 200;
                    break;
                case 3:
                    textBoxCommunity.Text = "Doctor's fees. Pay £50";
                    players[currentPlayer].bank = players[currentPlayer].bank - 50;
                    break;
                case 4:
                    textBoxCommunity.Text = "Receive $25 consultancy fee";
                    players[currentPlayer].bank = players[currentPlayer].bank + 25;
                    break;
                case 5:
                    textBoxCommunity.Text = "Go to Jail";
                    players[currentPlayer].location = 30;
                    players[currentPlayer].isJail = true;
                    switch (currentPlayer)
                    {
                        case 0:
                            pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                            break;
                        case 1:
                            pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);

                            break;
                        case 2:
                            pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                            break;
                        case 3:
                            pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                            break;
                    }
                    break;
                case 6:
                    textBoxCommunity.Text = "You have won second prize in a beauty contest. Collect £10";
                    players[currentPlayer].bank = players[currentPlayer].bank + 10;
                    break;
                case 7:
                    textBoxCommunity.Text = "It is your birthday. Collect £10 from every player";
                    players[currentPlayer].bank = players[currentPlayer].bank + 20;
                    players[0].bank = players[0].bank - 10;
                    players[1].bank = players[1].bank - 10;
                    players[2].bank = players[2].bank - 10;
                    players[3].bank = players[3].bank - 10;
                    break;
                case 8:
                    textBoxCommunity.Text = "You inherit $100";
                    players[currentPlayer].bank = players[currentPlayer].bank + 100;
                    break;

            }
            Player1Money.Text = (players[currentPlayer].bank).ToString();
            Player2Money.Text = (players[currentPlayer].bank).ToString();
            Player3Money.Text = (players[currentPlayer].bank).ToString();
            Player4Money.Text = (players[currentPlayer].bank).ToString();

        }

        void Chance(int currentPlayer)
        {
            Random rnd = new Random();
            int chanceCard = rnd.Next(1, 8);
            switch (chanceCard)
            {
                case 1:
                    textBoxChance.Text = "Advance to Go. (Collect $200)";
                    players[currentPlayer].bank = players[currentPlayer].bank + 200;
                    players[currentPlayer].location = 0;
                    switch (currentPlayer)
                    {
                        case 0:
                            pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                            Player1Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 1:
                            pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);
                            Player2Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 2:
                            pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                            Player3Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 3:
                            pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                            Player4Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                    }
                    break;
                case 2:
                    textBoxChance.Text = "Pay school fees of £150";
                    players[currentPlayer].bank = players[currentPlayer].bank - 150;
                    break;
                case 3:
                    textBoxChance.Text = "Go back 4 spaces Dont Pay Rent";
                    players[currentPlayer].location = players[currentPlayer].location - 4;
                    switch (currentPlayer)
                    {
                        case 0:
                            pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                            break;
                        case 1:
                            pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);

                            break;
                        case 2:
                            pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                            break;
                        case 3:
                            pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                            break;
                    }
                    break;
                case 4:
                    textBoxChance.Text = "Speeding fine £15";
                    players[currentPlayer].bank = players[currentPlayer].bank - 15;
                    break;
                case 5:
                    textBoxChance.Text = "Go to Jail";
                    players[currentPlayer].location = 30;
                    players[currentPlayer].isJail = true;
                    switch (currentPlayer)
                    {
                        case 0:
                            pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                            break;
                        case 1:
                            pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);

                            break;
                        case 2:
                            pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                            break;
                        case 3:
                            pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                            break;
                    }
                    break;
                case 6:
                    textBoxChance.Text = "You have won a crossword competition. Collect £100";
                    players[currentPlayer].bank = players[currentPlayer].bank + 100;
                    break;
                case 7:
                    textBoxChance.Text = "Take a walk on Parklane";
                    players[currentPlayer].location = 37;
                    switch (currentPlayer)
                    {
                        case 0:
                            pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                            break;
                        case 1:
                            pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);

                            break;
                        case 2:
                            pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                            break;
                        case 3:
                            pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                            break;
                    }
                    break;
                case 8:
                    textBoxChance.Text = "Bank pays you dividend of £50";
                    players[currentPlayer].bank = players[currentPlayer].bank + 50;
                    break;

            }
            Player1Money.Text = (players[currentPlayer].bank).ToString();
            Player2Money.Text = (players[currentPlayer].bank).ToString();
            Player3Money.Text = (players[currentPlayer].bank).ToString();
            Player4Money.Text = (players[currentPlayer].bank).ToString();

        }

        private void bankruptcheck(int currentPlayer)
        {
            for (int i = 0; i < 4; i++)
            {
                if (players[i].bank < 0)
                {
                    players[i].bankruptcy = true;
                    for (int p = 0; p < 31; p++)
                    {
                        if (boardLocation[p].ownedBy == i)
                        {
                            boardLocation[p].ammountOwned = 0;
                            boardLocation[p].ownedBy = 6;
                            Label CurrentPurchase = this.Controls[("labelLocation" + p.ToString())] as Label;
                            CurrentPurchase.BackColor = System.Drawing.Color.White;
                            CurrentPurchase.Visible = false;
                        }
                    }
                    if (players[0].bankruptcy == true)
                    {
                        Player1Label.Visible = false;
                        Player1Money.Visible = false;
                        pictureBox2.Visible = false;
                    }
                    if (players[1].bankruptcy == true)
                    {
                        Player2Label.Visible = false;
                        Player2Money.Visible = false;
                        pictureBox3.Visible = false;
                    }
                    if (players[2].bankruptcy == true)
                    {
                        Player3Label.Visible = false;
                        Player3Money.Visible = false;
                        pictureBox4.Visible = false;
                    }
                    if (players[3].bankruptcy == true)
                    {
                        Player4Label.Visible = false;
                        Player4Money.Visible = false;
                        pictureBox5.Visible = false;
                    }
                }
            }
        }


        private void Turnover(int move, bool doubleDice, int currentPlayer)
        {
            if (players[currentPlayer].location == 30)
            {
                players[currentPlayer].isJail = true;
                players[currentPlayer].location = 10;
                if (doubleDice == true)
                {
                    if (players[currentPlayer].location + move > 39)
                    {
                        players[currentPlayer].location = players[currentPlayer].location - 40;
                        players[currentPlayer].bank = players[currentPlayer].bank + 200;

                    }
                    players[currentPlayer].location = players[currentPlayer].location + move;
                    switch (currentPlayer)
                    {
                        case 0:
                            pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                            Player1Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 1:
                            pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);
                            Player2Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 2:
                            pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                            Player3Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                        case 3:
                            pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                            Player4Money.Text = (players[currentPlayer].bank).ToString();
                            break;
                    }
                }
                else
                {
                    players[currentPlayer].jailCounter = players[currentPlayer].jailCounter++;
                    if (players[currentPlayer].jailCounter == 2)
                    {
                        players[currentPlayer].jailCounter = 0;
                        if (players[currentPlayer].location + move > 39)
                        {
                            players[currentPlayer].location = players[currentPlayer].location - 40;
                            players[currentPlayer].bank = players[currentPlayer].bank + 200;

                        }
                        players[currentPlayer].location = players[currentPlayer].location + move;
                        switch (currentPlayer)
                        {
                            case 0:
                                pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                                Player1Money.Text = (players[currentPlayer].bank).ToString();
                                break;
                            case 1:
                                pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);
                                Player2Money.Text = (players[currentPlayer].bank).ToString();
                                break;
                            case 2:
                                pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                                Player3Money.Text = (players[currentPlayer].bank).ToString();
                                break;
                            case 3:
                                pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                                Player4Money.Text = (players[currentPlayer].bank).ToString();
                                break;
                        }
                    }

                }
            }
            else
            {
                if (players[currentPlayer].location + move > 39)
                {
                    players[currentPlayer].location = players[currentPlayer].location - 40;
                    players[currentPlayer].bank = players[currentPlayer].bank + 200;

                }
                players[currentPlayer].location = players[currentPlayer].location + move;
                switch (currentPlayer)
                {
                    case 0:
                        pictureBox2.Location = new Point(boardLocation[players[0].location].locationX, boardLocation[players[0].location].locationY);
                        Player1Money.Text = (players[currentPlayer].bank).ToString();
                        break;
                    case 1:
                        pictureBox3.Location = new Point(boardLocation[players[1].location].locationX + 30, boardLocation[players[1].location].locationY);
                        Player2Money.Text = (players[currentPlayer].bank).ToString();
                        break;
                    case 2:
                        pictureBox4.Location = new Point(boardLocation[players[2].location].locationX, boardLocation[players[2].location].locationY + 30);
                        Player3Money.Text = (players[currentPlayer].bank).ToString();
                        break;
                    case 3:
                        pictureBox5.Location = new Point(boardLocation[players[3].location].locationX + 30, boardLocation[players[3].location].locationY + 30);
                        Player4Money.Text = (players[currentPlayer].bank).ToString();
                        break;
                }
            }
            calculateRent(currentPlayer);
            bankruptcheck(currentPlayer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            Dice1.Image = Image.FromFile("../" + dice1.ToString() + ".png");
            int dice2 = rnd.Next(1, 7);
            Dice2.Image = Image.FromFile("../" + dice2.ToString() + ".png");
            move = (dice1 + dice2);
            bool doubleDice;
            if (dice1 == dice2)
            {
                doubleDice = true;
            }
            else
            {
                doubleDice = false;
            }
            if (currentPlayer < liveplayers)
            {
                Turnover(move, doubleDice, currentPlayer);
                if (boardLocation[players[currentPlayer].location].ownedBy == 6)
                {
                    label2.Text = "Player " + (currentPlayer + 1).ToString();
                    Buy.Text = "Buy :" + boardLocation[players[currentPlayer].location].street;
                    button1.Text = "Avaliable";
                }
                currentPlayer++;
                label2.Text = "Player " + (currentPlayer).ToString();
                button1.Visible = false;
                button1.Text = "unavaliable";
                PurchaseButton();
            }
            else
            {
                currentPlayer = 0;
                Turnover(move, doubleDice, currentPlayer);
                Buy.Text = (currentPlayer).ToString();
                if (boardLocation[players[currentPlayer].location].ownedBy == 6)
                {
                    label2.Text = "Player " + (currentPlayer + 1).ToString();
                    Buy.Text = "Buy :" + boardLocation[players[currentPlayer].location].street;
                    button1.Text = "Avaliable";
                }
                currentPlayer++;
                label2.Text = "Player " + (currentPlayer).ToString();
                button1.Visible = false;
                button1.Text = "unavaliable";
                PurchaseButton();
            }
            Player1Money.Text = (players[0].bank).ToString();
            Player2Money.Text = (players[1].bank).ToString();
            Player3Money.Text = (players[2].bank).ToString();
            Player4Money.Text = (players[3].bank).ToString();
        }

        private void PurchaseButton()
        {
            if (boardLocation[players[currentPlayer - 1].location].ownedBy == 5)
            {
                label2.Text = "Player " + (currentPlayer).ToString();
                Buy.Text = "unavaliable";
                button1.Visible = false;
            }
            else if (boardLocation[players[currentPlayer - 1].location].ownedBy == 6)
            {
                label2.Text = "Player " + (currentPlayer).ToString();
                button1.Visible = true;
                button1.Text = "Avaliable";
            }
            else if (boardLocation[players[currentPlayer - 1].location].ownedBy == (currentPlayer -1))
            {
                label2.Text = "Player " + (currentPlayer).ToString();
                button1.Visible = true;
                button1.Text = "Buy House?";
            }
            else if (boardLocation[players[currentPlayer - 1].location].ownedBy == (0|1|2|3))
            {
                label2.Text = "Player " + (currentPlayer).ToString();
                button1.Visible = false;
                button1.Text = "unavaliable";
            }
            else if ((boardLocation[players[currentPlayer - 1].location].attribute == "Station") & (boardLocation[players[currentPlayer - 1].location].ownedBy == (0|1|2|3)))
            {
                label2.Text = "Player " + (currentPlayer).ToString();
                button1.Visible = false;
                button1.Text = "unavaliable";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prepPlayerOne();
            prepPlayerTwo();
            prepBoard();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prepPlayerOne();
            prepPlayerTwo();
            prepPlayerThree();
            prepBoard();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prepPlayerOne();
            prepPlayerTwo();
            prepPlayerThree();
            prepPlayerFour();
            prepBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateBoard();
            generatePlayers();
        }

        private void BuyProperty(object sender, EventArgs e)
        {
            boardLocation[players[currentPlayer - 1].location].ownedBy = (currentPlayer - 1);
            Label CurrentPurchase = this.Controls[("labelLocation" + players[currentPlayer - 1].location.ToString())] as Label;

            boardLocation[players[currentPlayer - 1].location].ammountOwned = boardLocation[players[currentPlayer - 1].location].ammountOwned + 1;
            switch (currentPlayer)
            {
                case 1:
                    CurrentPurchase.BackColor = System.Drawing.Color.DodgerBlue;
                    break;
                case 2:
                    CurrentPurchase.BackColor = System.Drawing.Color.Green;
                    break;
                case 3:
                    CurrentPurchase.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    CurrentPurchase.BackColor = System.Drawing.Color.Yellow;
                    break;
            }
            CurrentPurchase.ForeColor = Color.Black;
            CurrentPurchase.Visible = true;
            CurrentPurchase.Text = boardLocation[players[currentPlayer - 1].location].ammountOwned.ToString();
            players[currentPlayer-1].bank = players[currentPlayer-1].bank - boardLocation[players[currentPlayer - 1].location].price;
            button1.Visible = false;
        }
    }
}
