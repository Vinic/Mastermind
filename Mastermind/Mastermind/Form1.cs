using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Drawing.Drawing2D;

namespace Mastermind
{
    public partial class Form1 : Form
    {
        int a, b, c, d;
        string user_name;
        List<Color> UserColors = new List<Color>();
        List<Color> GuessColors = new List<Color>();

        public Form1()
        {
            InitializeComponent();
            openInput();
            UserColors.Add(Color.Red);
            UserColors.Add(Color.Blue);
            UserColors.Add(Color.Green);
            UserColors.Add(Color.Purple);
            UserColors.Add(Color.Orange);
            UserColors.Add(Color.Cyan);
            UserColors.Add(Color.Brown);
            UserColors.Add(Color.Gold);

            GuessColors.Add(Color.Blue);
            GuessColors.Add(Color.Red);
            GuessColors.Add(Color.Blue);
            GuessColors.Add(Color.Purple);
        }

        class RoundButton : Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(grPath);
                base.OnPaint(e);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 7)
            {
                a = 0;
            }
            button1.BackColor = UserColors[a++];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b == 7)
            {
                b = 0;
            }
            button2.BackColor = UserColors[b++];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == 7)
            {
                c = 0;
            }
            button3.BackColor = UserColors[c++];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (d == 7)
            {
                d = 0;
            }
            button4.BackColor = UserColors[d++];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = 0;
            int goodAnswer = 0;
            List<RoundButton> ColorInput = new List<RoundButton> { button1, button2, button3, button4 };
            List<RoundButton> ColorCheck = new List<RoundButton> { roundButton1, roundButton2, roundButton3, roundButton4 };
            List<Color> GuessColorsCopy = new List<Color>();
            GuessColorsCopy.AddRange(GuessColors);

            for(x = 0; x < ColorInput.Count; x++)
            {
                if (ColorInput[x].BackColor == GuessColorsCopy[x])
                {
                    ColorCheck[x].BackColor = Color.Green;
                    GuessColorsCopy[x] = Color.Bisque;
                    goodAnswer++;
                }

            }

            for(x = 0; x < ColorInput.Count; x++)
            {
                if (GuessColorsCopy.Contains(ColorInput[x].BackColor))
                {
                    ColorCheck[x].BackColor = Color.Red;
                    GuessColorsCopy[GuessColorsCopy.IndexOf(ColorInput[x].BackColor)] = Color.Bisque;
                }
                else if(!GuessColorsCopy.Contains(ColorInput[x].BackColor))
                {
                    ColorCheck[x].BackColor = Color.White;
                }
                
            }

            if (goodAnswer >= 4)
            {
                MastermindDataSet.user_scoreRow newUser_scoreRow = mastermindDataSet.user_score.Newuser_scoreRow();
                user_scoreTableAdapter.Fill(mastermindDataSet.user_score);
                newUser_scoreRow.user_name = user_name;
                newUser_scoreRow.user_score = goodAnswer;
                mastermindDataSet.user_score.Rows.Add(newUser_scoreRow);


                DataTable saveData = new DataTable();
                saveData.Columns.Add("user_name", typeof(string));
                saveData.Columns.Add("user_score", typeof(int));
                saveData.Rows.Add(user_name, goodAnswer);

                var connection = ConfigurationManager.ConnectionStrings["Mastermind.Properties.Settings.MastermindConnectionString"].ToString();

                using (var connectACDB = new OleDbConnection(connection))
                {
                    connectACDB.Open();

                    var OleDBapdater = new OleDbDataAdapter();
                    OleDBapdater.InsertCommand = new OleDbCommand("INSERT INTO user_score(user_name, user_score) VALUES(@user_name, @user_score)", connectACDB);
                    OleDBapdater.InsertCommand.Parameters.Add("user_name", OleDbType.VarChar, 255, "user_name");
                    OleDBapdater.InsertCommand.Parameters.Add("user_score", OleDbType.Numeric, 255, "user_score");

                    OleDBapdater.Update(saveData);

                }
            }
        }
        private void openInput()
        {
            // Initialiseert het andere input scherm
            Form2 PlayerInput = new Form2();
            // Zorgt ervoor dat je niet iets kan doen met het hoofdscherm
            PlayerInput.ShowDialog();
            // Haalt de text vanuit de input box
            user_name = PlayerInput.textBox1.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastermindDataSet.user_score' table. You can move, or remove it, as needed.
            this.user_scoreTableAdapter.Fill(this.mastermindDataSet.user_score);
        }
    }
}
