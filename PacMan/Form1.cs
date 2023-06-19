using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PacMan
{
    public partial class title : Form
    {
        //player 1
        Rectangle player1 = new Rectangle();
        Rectangle player1HitBox = new Rectangle();
        int player1HitBoxSpeed = 6;
        int player1Speed = 6;

        //player 2
        Rectangle player2 = new Rectangle();
        int player2Speed = 4;

        //enemy
        Rectangle enemy = new Rectangle();
        Rectangle enemyHitBox = new Rectangle();
        int enemySpeed = 6;
        int enemyHitBoxSpeed = 6;

        Rectangle enemy2 = new Rectangle();
        Rectangle enemy2HitBox = new Rectangle();
        int enemy2Speed = 6;
        int enemy2HitBoxSpeed = 6;

        //highscore
        List<string> name = new List<string>();
        //List<>

        //invisible characters (controls)
        List<Rectangle> left = new List<Rectangle>();
        Rectangle leftColumn3Row3 = new Rectangle();
        Rectangle leftColumn3Row2 = new Rectangle();
        Rectangle leftColumn3Row1 = new Rectangle();
        Rectangle leftColumn2Row3 = new Rectangle();
        Rectangle leftColumn2Row2 = new Rectangle();
        Rectangle leftColumn2Row1 = new Rectangle();

        List<Rectangle> right = new List<Rectangle>();
        Rectangle rightColumn1Row3 = new Rectangle();
        Rectangle rightColumn1Row2 = new Rectangle();
        Rectangle rightColumn1Row1 = new Rectangle();
        Rectangle rightColumn2Row3 = new Rectangle();
        Rectangle rightColumn2Row2 = new Rectangle();
        Rectangle rightColumn2Row1 = new Rectangle();

        List<Rectangle> up = new List<Rectangle>();
        Rectangle upColumn1Row3 = new Rectangle();
        Rectangle upColumn2Row3 = new Rectangle();
        Rectangle upColumn3Row3 = new Rectangle();
        Rectangle upColumn1Row2 = new Rectangle();
        Rectangle upColumn2Row2 = new Rectangle();
        Rectangle upColumn3Row2 = new Rectangle();

        List<Rectangle> down = new List<Rectangle>();
        Rectangle downColumn1Row1 = new Rectangle();
        Rectangle downColumn2Row1 = new Rectangle();
        Rectangle downColumn3Row1 = new Rectangle();
        Rectangle downColumn1Row2 = new Rectangle();
        Rectangle downColumn2Row2 = new Rectangle();
        Rectangle downColumn3Row2 = new Rectangle();

        List<Rectangle> points = new List<Rectangle>();
        Rectangle point1 = new Rectangle();
        Rectangle point2 = new Rectangle();
        Rectangle point3 = new Rectangle();
        Rectangle point4 = new Rectangle();
        Rectangle point5 = new Rectangle();
        Rectangle point6 = new Rectangle();
        Rectangle point7 = new Rectangle();
        Rectangle point8 = new Rectangle();
        Rectangle point9 = new Rectangle();
        Rectangle point10 = new Rectangle();
        Rectangle point11 = new Rectangle();
        Rectangle point12 = new Rectangle();
        Rectangle point13 = new Rectangle();
        Rectangle point14 = new Rectangle();
        Rectangle point15 = new Rectangle();
        Rectangle point16 = new Rectangle();
        Rectangle point17 = new Rectangle();
        Rectangle point18 = new Rectangle();
        Rectangle point19 = new Rectangle();
        Rectangle point20 = new Rectangle();
        Rectangle point21 = new Rectangle();

        //map
        Rectangle outerBorder = new Rectangle();
        Rectangle box1 = new Rectangle();
        Rectangle box2 = new Rectangle();
        Rectangle box3 = new Rectangle();
        Rectangle box4 = new Rectangle();

        //paint
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow); // point
        SolidBrush player1Brush = new SolidBrush(Color.Pink); // player 1
        Pen borderPen = new Pen(Color.DarkBlue); //borders
        SolidBrush lollipopBrush = new SolidBrush(Color.Magenta); //speedboost
        SolidBrush blueBrush = new SolidBrush(Color.Blue);

        SolidBrush invisibleBrush = new SolidBrush(Color.Transparent);

        string direction = "stop";
        string enemyDirection = "stop";
        string enemy2Direction = "stop";

        //items
        int item = 0;


        int timer = 0;
        int score = 0;
        int scoreValue = 500;
        int point = 0;
        int lifeValue = 3;

        //player 1 controls
        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;

        //player 2 controls
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool rightArrowDown = false;
        bool leftArrowDown = false;

        //state
        string state = "waiting";
        string difficulty = "none";

        //rand number generator
        Random randGen = new Random();
        int randDirection = 0;


        public title()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //player 1

                case Keys.W:
                    wDown = true;
                    direction = "up";
                    break;
                case Keys.S:
                    direction = "down";
                    sDown = true;
                    break;
                case Keys.A:
                    direction = "left";
                    aDown = true;
                    break;
                case Keys.D:
                    direction = "right";
                    dDown = true;
                    break;


                    //player 2
                    //case Keys.Up:
                    //    upArrowDown = true;
                    //    break;
                    //case Keys.Down:
                    //    downArrowDown = true;
                    //    break;
                    //case Keys.Left:
                    //    leftArrowDown = true;
                    //    break;
                    //case Keys.Right:
                    //    rightArrowDown = true;
                    //    break;
            }

            //initialize game
            switch (e.KeyCode)
            {
                case Keys.Space:
                    if (state == "waiting")
                    {
                        state = "start up";
                    }

                    if (state == "game over" || state == "winner")
                    {
                        InitializeGame();
                    }
                    break;
                case Keys.Escape:
                    if (state == "waiting" || state == "game over" || state == "winner")
                    {
                        Application.Exit();
                    }
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {            //player 1
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;

                    //player 2
                    //case Keys.Up:
                    //    upArrowDown = false;
                    //    break;
                    //case Keys.Down:
                    //    downArrowDown = false;
                    //    break;
                    //case Keys.Left:
                    //    leftArrowDown = false;
                    //    break;
                    //case Keys.Right:
                    //    rightArrowDown = false;
                    //    break;
            }
        }

        public void InitializeGame()
        {
            state = "playing";
            gameTimer.Enabled = true;

            //player1 = Properties.Resources.kirby1;

            player1 = new Rectangle(278, 515, 26, 26);
            player1HitBox = new Rectangle(284, 523, 8, 8);

            enemy = new Rectangle(632, 517, 28, 28);
            enemyHitBox = new Rectangle(640, 525, 8, 8);

            enemy2 = new Rectangle(397, 62, 28, 28);
            enemy2HitBox = new Rectangle(405, 70, 8, 8);


            outerBorder = new Rectangle(150, 50, 520, 500);
            box1 = new Rectangle(202, 90, 175, 185);
            box2 = new Rectangle(445, 90, 175, 185);
            box3 = new Rectangle(202, 320, 175, 185);
            box4 = new Rectangle(445, 320, 175, 185);

            leftColumn3Row3 = new Rectangle(640, 525, 8, 8);
            leftColumn3Row2 = new Rectangle(640, 290, 8, 8);
            leftColumn3Row1 = new Rectangle(640, 70, 8, 8);
            leftColumn2Row3 = new Rectangle(405, 525, 8, 8);
            leftColumn2Row2 = new Rectangle(405, 290, 8, 8);
            leftColumn2Row1 = new Rectangle(405, 70, 8, 8);

            left.Add(leftColumn3Row3);
            left.Add(leftColumn3Row2);
            left.Add(leftColumn3Row1);
            left.Add(leftColumn2Row3);
            left.Add(leftColumn2Row2);
            left.Add(leftColumn2Row1);

            rightColumn1Row3 = new Rectangle(640, 70, 8, 8);
            rightColumn1Row2 = new Rectangle(405, 70, 8, 8);
            rightColumn1Row1 = new Rectangle(176, 70, 8, 8);
            rightColumn2Row3 = new Rectangle(405, 525, 8, 8);
            rightColumn2Row2 = new Rectangle(405, 290, 8, 8);
            rightColumn2Row1 = new Rectangle(405, 70, 8, 8);

            right.Add(rightColumn1Row3);
            right.Add(rightColumn1Row2);
            right.Add(rightColumn1Row1);
            right.Add(rightColumn2Row3);
            right.Add(rightColumn2Row2);
            right.Add(rightColumn2Row1);

            upColumn1Row3 = new Rectangle(176, 525, 8, 8);
            upColumn2Row3 = new Rectangle(405, 525, 8, 8);
            upColumn3Row3 = new Rectangle(640, 525, 8, 8);
            upColumn1Row2 = new Rectangle(176, 290, 8, 8);
            upColumn2Row2 = new Rectangle(405, 290, 8, 8);
            upColumn3Row2 = new Rectangle(640, 290, 8, 8);

            up.Add(upColumn1Row3);
            up.Add(upColumn2Row3);
            up.Add(upColumn3Row3);
            up.Add(upColumn1Row2);
            up.Add(upColumn2Row2);
            up.Add(upColumn3Row2);

            downColumn1Row1 = new Rectangle(176, 70, 8, 8);
            downColumn2Row1 = new Rectangle(405, 70, 8, 8);
            downColumn3Row1 = new Rectangle(640, 70, 8, 8);
            downColumn1Row2 = new Rectangle(176, 290, 8, 8);
            downColumn2Row2 = new Rectangle(405, 290, 8, 8);
            downColumn3Row2 = new Rectangle(640, 290, 8, 8);

            down.Add(downColumn1Row1);
            down.Add(downColumn2Row1);
            down.Add(downColumn3Row1);
            down.Add(downColumn1Row2);
            down.Add(downColumn2Row2);
            down.Add(downColumn3Row2);

            point1 = new Rectangle(176, 70, 9, 9);
            point2 = new Rectangle(283, 70, 9, 9);
            point3 = new Rectangle(405, 70, 9, 9);
            point4 = new Rectangle(520, 70, 9, 9);
            point5 = new Rectangle(640, 70, 9, 9);
            point6 = new Rectangle(176, 180, 9, 9);
            point7 = new Rectangle(405, 180, 9, 9);
            point8 = new Rectangle(640, 180, 9, 9);
            point9 = new Rectangle(176, 290, 9, 9);
            point10 = new Rectangle(283, 290, 9, 9);
            point11 = new Rectangle(405, 290, 9, 9);
            point12 = new Rectangle(520, 290, 9, 9);
            point13 = new Rectangle(640, 290, 9, 9);
            point14 = new Rectangle(176, 410, 9, 9);
            point15 = new Rectangle(405, 410, 9, 9);
            point16 = new Rectangle(640, 410, 9, 9);
            point17 = new Rectangle(176, 525, 9, 9);
            point18 = new Rectangle(283, 525, 9, 9);
            point19 = new Rectangle(405, 525, 9, 9);
            point20 = new Rectangle(520, 525, 9, 9);
            point21 = new Rectangle(640, 525, 9, 9);

            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            points.Add(point4);
            points.Add(point5);
            points.Add(point6);
            points.Add(point7);
            points.Add(point8);
            points.Add(point9);
            points.Add(point10);
            points.Add(point11);
            points.Add(point12);
            points.Add(point13);
            points.Add(point14);
            points.Add(point15);
            points.Add(point16);
            points.Add(point17);
            points.Add(point18);
            points.Add(point19);
            points.Add(point20);
            points.Add(point21);


            //reset everything

            titleName.ForeColor = Color.Yellow;
            titleName.Text = "";
            subtitleLabel.Text = "";
            scoreLabel.Text = "";

            life1Picture.Image = Properties.Resources.heart;
            life2Picture.Image = Properties.Resources.heart;
            life3Picture.Image = Properties.Resources.heart;

             timer = 0;
             score = 0;
             scoreValue = 500;
             point = 0;
             lifeValue = 3;


            if (difficulty == "easy")
            {
                enemySpeed = 6;
                enemyHitBoxSpeed = 6;
            }
            if (difficulty == "medium")
            {
                enemySpeed = 9;
                enemyHitBoxSpeed = 9;
            }
            if (difficulty == "hard")
            {
                enemySpeed = 9;
                enemyHitBoxSpeed = 9;
            }

        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            //player movement
            if (direction == "left" && player1.X > 160)
            {
                player1.X -= player1Speed;
                player1HitBox.X -= player1HitBoxSpeed;
            }
            else if (direction == "up" && player1.Y > 63)
            {
                player1.Y -= player1Speed;
                player1HitBox.Y -= player1HitBoxSpeed;
            }
            else if (direction == "right" & player1.X < 650 - player1.Width)
            {
                player1.X += player1Speed;
                player1HitBox.X += player1HitBoxSpeed;
            }
            else if (direction == "down" && player1.Y < 540 - player1.Height)
            {
                player1.Y += player1Speed;
                player1HitBox.Y += player1HitBoxSpeed;
            }

            //make sure not to go through box
            if (player1.IntersectsWith(box3))
            {
                direction = "stop";
            }
            if (player1.IntersectsWith(box2))
            {
                direction = "stop";
            }
            if (player1.IntersectsWith(box1))
            {
                direction = "stop";
            }
            if (player1.IntersectsWith(box4))
            {
                direction = "stop";
            }

            //enemy 1
            //x = right / left y = up / down
            if (enemyDirection == "go left") //bottom right -> go left
            {
                enemy.X -= enemySpeed;
                enemyHitBox.X -= enemyHitBoxSpeed;
            }
            else if (enemyDirection == "go up") //bottom left -> go up
            {
                enemy.Y -= enemySpeed;
                enemyHitBox.Y -= enemyHitBoxSpeed;
            }

            else if (enemyDirection == "go right")// top left -> go right
            {
                enemy.X += enemySpeed;
                enemyHitBox.X += enemyHitBoxSpeed;
            }
            else if (enemyDirection == "go down") // top right -> go down
            {
                enemy.Y += enemySpeed;
                enemyHitBox.Y += enemyHitBoxSpeed;
            }

            if (enemyHitBox.IntersectsWith(leftColumn3Row3))
            {
                enemyDirection = "go left";
            }
            if (enemyHitBox.IntersectsWith(rightColumn1Row1))
            {
                enemyDirection = "go right";
            }
            if (enemyHitBox.IntersectsWith(upColumn1Row3))
            {
                enemyDirection = "go up";
            }
            if (enemyHitBox.IntersectsWith(downColumn3Row1))
            {
                enemyDirection = "go down";
            }


            //enemy2 direction
            if (difficulty == "hard")
            {
                if (enemy2HitBox.IntersectsWith(leftColumn3Row2))
                {
                    enemy2Direction = "go left";
                }
                if (enemy2HitBox.IntersectsWith(upColumn1Row2))
                {
                    enemy2Direction = "go right";
                }
                if (enemy2HitBox.IntersectsWith(upColumn2Row3))
                {
                    enemy2Direction = "go up";
                }
                if (enemy2HitBox.IntersectsWith(downColumn2Row1))
                {
                    enemy2Direction = "go down";
                }
                if (enemy2HitBox.IntersectsWith(downColumn2Row2))
                {
                    randDirection = randGen.Next(1, 101);
                    {
                        if (randDirection < 25)
                        {
                            enemy2Direction = "go left";
                        }
                        else if (randDirection < 50)
                        {
                            enemy2Direction = "go right";
                        }
                        else if (randDirection < 75)
                        {
                            enemy2Direction = "go up";
                        }
                        else
                        {
                            enemy2Direction = "go down";
                        }
                    }
                }
                if (difficulty == "hard")
                {
                    if (enemy2Direction == "go left") //bottom right -> go left
                    {
                        enemy2.X -= enemy2Speed;
                        enemy2HitBox.X -= enemy2HitBoxSpeed;
                    }
                    else if (enemy2Direction == "go up") //bottom left -> go up
                    {
                        enemy2.Y -= enemy2Speed;
                        enemy2HitBox.Y -= enemy2HitBoxSpeed;
                    }

                    else if (enemy2Direction == "go right")// top left -> go right
                    {
                        enemy2.X += enemy2Speed;
                        enemy2HitBox.X += enemy2HitBoxSpeed;
                    }
                    else if (enemy2Direction == "go down") // top right -> go down
                    {
                        enemy2.Y += enemy2Speed;
                        enemy2HitBox.Y += enemy2HitBoxSpeed;
                    }
                }


                for (int i = 0; i < points.Count; i++)
                {
                    if (points[i].IntersectsWith(player1))
                    {
                        points.RemoveAt(i);
                        point++;
                        score = scoreValue + score;
                        scoreLabel.Text = $"{score}";
                    }
                }
                if (player1.IntersectsWith(enemy) || player1.IntersectsWith(enemy2))
                {
                    enemyHit();
                    livesControl();
                }

                if (point == 21)
                {
                    state = "winner";
                }

                Refresh();
            }

        }
        public void livesControl()
        {
            if (lifeValue == 3)
            {
                life1Picture.Image = Properties.Resources.heart;
                life2Picture.Image = Properties.Resources.heart;
                life3Picture.Image = Properties.Resources.heart;
            }
            if (lifeValue == 2)
            {
                life1Picture.Image = Properties.Resources.heart;
                life2Picture.Image = Properties.Resources.heart;
                life3Picture.Image = null;
            }
            if (lifeValue == 1)
            {
                life1Picture.Image = Properties.Resources.heart;
                life2Picture.Image = null;
                life3Picture.Image = null;
            }
            if (lifeValue == 0)
            {
                life1Picture.Image = null;
                life2Picture.Image = null;
                life3Picture.Image = null;
                state = "game over";
            }
        }

        public void enemyHit()
        {
            lifeValue = lifeValue - 1;
            player1.X = 278;
            player1HitBox.X = 284;
            player1.Y = 515;
            player1HitBox.Y = 523;
            direction = "stop";
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (state == "waiting")
            {
                titleName.Text = "KIRBY-MAN";
                subtitleLabel.Text = "Press Space to Play";
                subtitleLabel.Text += "\n Or Press Esc. To Exit";

            }

            if(state == "start up")
            {
                titleName.Visible = false;
                subtitleLabel.Visible = false;
                chooseLabel.Visible = true;
                chooseLabel.Text = "Choose Your Difficulty:";

                easyButton.Enabled = true;
                easyButton.Visible = true;

                mediumButton.Enabled = true;
                mediumButton.Visible = true;

                hardButton.Enabled = true;
                hardButton.Visible = true;

            }


            if (state == "playing") 
            {
                chooseLabel.Visible = false;
                easyButton.Visible = false;
                mediumButton.Visible = false;
                hardButton.Visible = false;

                scoreLabel.Text = $"Score : {score}";

                e.Graphics.FillRectangle(invisibleBrush, player1HitBox);

                e.Graphics.FillRectangle(invisibleBrush, enemyHitBox);
                e.Graphics.FillRectangle(player1Brush, enemy2HitBox);

                e.Graphics.DrawRectangle(borderPen, outerBorder);
                e.Graphics.DrawRectangle(borderPen, box1);
                e.Graphics.DrawRectangle(borderPen, box2);
                e.Graphics.DrawRectangle(borderPen, box3);
                e.Graphics.DrawRectangle(borderPen, box4);

                for (int i =0; i < left.Count; i++)
                {
                    e.Graphics.FillRectangle(invisibleBrush, left[i]);
                    e.Graphics.FillRectangle(invisibleBrush, right[i]);
                    e.Graphics.FillRectangle(invisibleBrush, up[i]);
                    e.Graphics.FillRectangle(invisibleBrush, down[i]);

                }
                for (int i = 0; i < points.Count; i++)
                {
                    e.Graphics.FillRectangle(yellowBrush, points[i]);
                }

                //player 1
                if (direction == "left")
                {
                    e.Graphics.DrawImage(Properties.Resources.kirby1left, player1.X, player1.Y, player1.Width, player1.Height);

                }
                else if (direction == "up"/* && player1.Y > 63*/)
                {
                    e.Graphics.DrawImage(Properties.Resources.kirby1up, player1.X, player1.Y, player1.Width, player1.Height);

                }
                else if (direction == "right" /*& player1.X < 650 - player1.Width*/)
                {
                    e.Graphics.DrawImage(Properties.Resources.kirby1, player1.X, player1.Y, player1.Width, player1.Height);

                }
                else if (direction == "down" /*&& player1.Y < 540 - player1.Height*/)
                {
                    e.Graphics.DrawImage(Properties.Resources.kirby1down, player1.X, player1.Y, player1.Width, player1.Height);
                }
                else
                { 
                    e.Graphics.DrawImage(Properties.Resources.kirby1, player1.X, player1.Y, player1.Width, player1.Height);
                }

                if (player1.IntersectsWith(box3))
                {
                    direction = "stop";
                    e.Graphics.DrawImage(Properties.Resources.kirby1, player1.X, player1.Y, player1.Width, player1.Height);
                }
                

                //enemy direction image
                if (enemyDirection == "go left")
                {
                    e.Graphics.DrawImage(Properties.Resources.cappyleft, enemy.X, enemy.Y, enemy.Width, enemy.Height);
                }
                else if (enemyDirection == "go up")
                {
                    e.Graphics.DrawImage(Properties.Resources.cappyup, enemy.X, enemy.Y, enemy.Width, enemy.Height);
                }
                else if (enemyDirection == "go right")
                {
                    e.Graphics.DrawImage(Properties.Resources.cappyright, enemy.X, enemy.Y, enemy.Width, enemy.Height);
                }
                else if (enemyDirection == "go down")
                {
                    e.Graphics.DrawImage(Properties.Resources.cappydown, enemy.X, enemy.Y, enemy.Width, enemy.Height);
                }

                //enemy 2
                if (difficulty == "hard")
                {
                    if (enemy2Direction == "go left")
                    {
                        //e.Graphics.FillRectangle(blueBrush, enemy2);
                        e.Graphics.DrawImage(Properties.Resources.burtleft, enemy2.X, enemy2.Y, enemy2.Width, enemy2.Height);
                    }
                    else if (enemy2Direction == "go up")
                    {
                        //e.Graphics.FillRectangle(blueBrush, enemy2);

                        e.Graphics.DrawImage(Properties.Resources.burtup, enemy2.X, enemy2.Y, enemy2.Width, enemy2.Height);
                    }
                    else if (enemy2Direction == "go right")
                    {
                        //e.Graphics.FillRectangle(blueBrush, enemy2);

                        e.Graphics.DrawImage(Properties.Resources.burtright, enemy2.X, enemy2.Y, enemy2.Width, enemy2.Height);
                    }
                    else if (enemy2Direction == "go down")
                    {
                        //e.Graphics.FillRectangle(blueBrush, enemy2);

                        e.Graphics.DrawImage(Properties.Resources.burtdown, enemy2.X, enemy2.Y, enemy2.Width, enemy2.Height);
                    }
                }
            }

            if (state == "winner")
            {
                scoreLabel.Enabled = false;

                life1Picture.Image = null;
                life2Picture.Image = null;
                life3Picture.Image = null;

                titleName.Visible = true;
                titleName.ForeColor = Color.LimeGreen;
                titleName.Text = "YOU WIN";
                subtitleLabel.Visible = true;
                subtitleLabel.Text = "Press Space to Play or Esc. to Exit";
            }

            if (state == "game over")
            {
                scoreLabel.Enabled = false;

                life1Picture.Image = null;
                life2Picture.Image = null;
                life3Picture.Image = null;

                titleName.Visible = true;
                titleName.ForeColor = Color.Red;
                titleName.Text = "YOU LOSE";
                subtitleLabel.Visible = true;
                subtitleLabel.Text = "Press Space to Play or Esc. to Exit";
            }

        }

        private void easyButton_Click(object sender, EventArgs e)
        {

            this.Focus();

            difficulty = "easy";
            InitializeGame();
            easyButton.Enabled = false;
            mediumButton.Enabled = false;
            hardButton.Enabled = false;
        }
        private void mediumButton_Click(object sender, EventArgs e)
        {
            this.Focus();

            difficulty = "medium";
            InitializeGame();
            easyButton.Enabled = false;
            mediumButton.Enabled = false;
            hardButton.Enabled = false;
        }
        private void hardButton_Click(object sender, EventArgs e)
        {
            this.Focus();

            difficulty = "hard";
            InitializeGame();
            easyButton.Enabled = false;
            mediumButton.Enabled = false;
            hardButton.Enabled = false;
        }
    }
}
