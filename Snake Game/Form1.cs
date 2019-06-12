using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        private List<Snake> snake = new List<Snake>();
        private Snake food = new Snake();
        public Form1()
        {
            InitializeComponent();

            new Settings();

            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += updateScreen;
            gameTimer.Start();

            startGame();
        }

        private void updateScreen(object sender, EventArgs e)
        {
            if(Settings.GameOver == true)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                if (Input.KeyPress(Keys.Right) && Settings.direction != Directions.Left)
                {
                    Settings.direction = Directions.Right;
                }
                if (Input.KeyPress(Keys.Left) && Settings.direction != Directions.Right)
                {
                    Settings.direction = Directions.Left;
                }
                if (Input.KeyPress(Keys.Up) && Settings.direction != Directions.Down)
                {
                    Settings.direction = Directions.Up;
                }
                if (Input.KeyPress(Keys.Down) && Settings.direction != Directions.Up)
                {
                    Settings.direction = Directions.Down;
                }

                movePlayer();
            }

            snakeCanvas.Invalidate();
        }

        private void movePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Directions.Down:
                            snake[i].Y++;
                            break;

                        case Directions.Up:
                            snake[i].Y--;
                            break;

                        case Directions.Right:
                            snake[i].X++;
                            break;

                        case Directions.Left:
                            snake[i].X--;
                            break;
                    }

                    int maxXpos = snakeCanvas.Size.Width / Settings.Width;
                    int maxYpos = snakeCanvas.Size.Height / Settings.Height;

                    if (snake[i].X < 0 || snake[i].Y < 0 || snake[i].X > maxXpos || snake[i].Y > maxYpos)
                    {
                        die();
                    }

                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                        {
                            die();
                        }
                    }

                    if (snake[0].X == food.X && snake[0].Y == food.Y)
                    {
                        eat();
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Settings.GameOver == false)
            {
                Brush snakeColor;

                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColor = Brushes.Black;
                    }
                    else
                    {
                        snakeColor = Brushes.Green;
                    }

                    canvas.FillEllipse(snakeColor,
                                        new Rectangle(
                                            snake[i].X * Settings.Width,
                                            snake[i].Y * Settings.Height,
                                            Settings.Width, Settings.Height));

                    canvas.FillEllipse(Brushes.Red,
                                        new Rectangle(
                                            food.X * Settings.Width,
                                            food.Y * Settings.Height,
                                            Settings.Width, Settings.Height));

                }
            }
            else
            {
                string gameOver = "Game Over \n" + "Final Score is: " + "\nPress Enter to Restart \n";
                endLabel.Text = gameOver;
                endLabel.Visible = true;
            }
        }

        private void startGame()
        {
            endLabel.Visible = false;
            new Settings();
            snake.Clear();
            Snake head = new Snake { X = 10, Y = 5 };
            snake.Add(head);

            pointsLabel.Text = Settings.Score.ToString();

            generateFood();
        }

        private void generateFood()
        {
            int maxXpos = snakeCanvas.Size.Width / Settings.Width;
            int maxYpos = snakeCanvas.Size.Height / Settings.Height;

            Random rnd = new Random();
            food = new Snake { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
        }

        private void eat()
        {
            Snake body = new Snake
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            };

            snake.Add(body);
            Settings.Score += Settings.Points;
            pointsLabel.Text = Settings.Score.ToString();
            generateFood();
        }

        private void die()
        {
            Settings.GameOver = true;
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
