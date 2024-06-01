using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ShootingGame
{
    public class Bullet
    {
        public PictureBox BulletBox { get; set; }
        private int speed;
        private double angle;

        public Bullet(Point position, double angle)
        {
            this.angle = angle;
            speed = 10;

            BulletBox = new PictureBox
            {
                Size = new Size(10, 20), // 총알의 크기 설정입니다 자연스럽게 바꿔주세요
                //Image = Properties.Resources.BulletImage, //이미지 추가하신 다음 실행해주세요
                Location = position
            };
        }

        public void Move()
        {
            BulletBox.Left += (int)(speed * Math.Cos(angle * Math.PI / 180));
            BulletBox.Top -= (int)(speed * Math.Sin(angle * Math.PI / 180));
        }
    }
    public partial class Form1 : Form
    {
        private Timer bulletTimer;
        private List<Bullet> bullets;
        private int attackStage;
        private int moveSpeed = 5;
        private bool isSpecialAttackActive = false;
        private int bulletSpeed = 10;
        public Form1()
        {
            InitializeComponent();
            bullets = new List<Bullet>();
            attackStage = 1; //총알 단계

            bulletTimer = new Timer();
            bulletTimer.Interval = 30;
            bulletTimer.Tick += BulletTimer_Tick;
            bulletTimer.Start(); //총알 타이머

            player = new PictureBox
            {
                Size = new Size(50, 50), //사이즈 조정
                //Image = Properties.Resources.PlayerImage, // 이미지로 캐릭터 설정
                Location = new Point(100, 100) // 스폰 위치 설정
            };
            this.Controls.Add(player);

            // 메인 클래스입니다 테스트용으로 아래에 코드를 써도 괜찮습니다
            // 혹시나  조심해주세요
            // test
            // 123


        }

        void GameStart()
        {// 게임 시작 화면을 나타내는 클래스(김현민)}
            void GameOver()
            {// 게임 오버화면 몇초뒤 게임시작 화면으로 넘어간다 (김현민)}
                void GameEnd()
                {// 게임의 엔딩(클리어)를 화면에 나타내는 클래스 (김현민)}

                    void ShowInfo()
                    {
                        // HP, SP_item, attack_stage를 단순 글씨가아닌 이미지를 통해서 보여준다. (김현민)
                    }
                    void CollisionDetection()
                    {
                        // 충돌 확인 메서드 (김현민)
                    }

                    void MainTimer()
                    {
                        // 모두 다다르게 타이머를 돌릴수도있지만 작업을 줄이기위해서 최대한 타이머 한개로 통일하여 진행. 메인타이머 (김현민)
                    }

                    void MoveBackground()
                    {
                        // 배경을 움직이는 클래스 (이지원)
                        // 아래 주석은 참고만해주세요 무조건적으로 따라하실필요는 없습니다
                        // 타이머 컨트롤을 통해서 예시 30ms마다 이동하도록 설정
                        // 30ms 마다 배경(picturebox)을 아래쪽으로 이동하게 합니다
                        // 화면에 이미지가 끊기지않기위해서 일정 시간마다 새로운 배경을 위에 추가하거나 아래 배경을 위로올립니다
                        // 만약 배경을 위로올리는방식말고 위로 새로 추가하는 방식을 선택한다면 계속해서 아래에 picturebox가 쌓이지않도록 삭제를 해야합니다
                    }

                    void FireBullet()
                    {
                        PictureBox bullet = new PictureBox
                        {
                            Size = new Size(10, 20), // 총알의 크기 설정
                            Image =  // 이미지로 총알 설정
                            Location = new Point(player.Location.X + player.Width / 2 - 5, player.Location.Y) // 총알이 캐릭터 위에서 시작되도록 설정
                        };
                        this.Controls.Add(bullet);
                        bullets.Add(bullet);
                    }

                    void Form1_KeyDown(object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Space)
                        {
                            PlayerAttack(1);
                        }
                        else if (e.KeyCode == Keys.ShiftKey)
                        {
                            PlayerSpecialAttack(1);
                        }
                    }


                    void PlayerAttack(int attack_stage)
                    {

                        // 플레이어 일반공격을 담당하는 클래스 (남준혁)
                        // 공격은 스페이스바를 통해서 공격을할수있습니다
                        Point startPosition = new Point(player.Location.X + player.Width / 2 - 5, player.Location.Y);
                        switch (attack_stage)
                        {
                            case 1:
                                CreateBullet(startPosition, 0);
                                break;
                            case 2:
                                CreateBullet(startPosition, 0);
                                CreateBullet(startPosition, -45);
                                CreateBullet(startPosition, 45);
                                break;
                            case 3:
                                CreateBullet(startPosition, 0);
                                CreateBullet(startPosition, -45);
                                CreateBullet(startPosition, 45);
                                CreateBullet(startPosition, -30);
                                CreateBullet(startPosition, 30);
                                break;
                            case 4:
                                CreateBullet(startPosition, 0);
                                CreateBullet(startPosition, -45);
                                CreateBullet(startPosition, 45);
                                CreateBullet(startPosition, -30);
                                CreateBullet(startPosition, 30);
                                CreateBullet(startPosition, -15);
                                CreateBullet(startPosition, 15);
                                break;
                        }
                    }
                    void CreateBullet(Point position, double angle) //총알
                    {
                        PictureBox bulletBox = new PictureBox
                        {
                            Size = new Size(10, 20),
                            Image = // 이미지 넣어주세요
                            Location = position
                        };
                        Bullet bullet = new Bullet(bulletBox, angle, bulletSpeed);
                        bullets.Add(bullet);
                        this.Controls.Add(bulletBox);
                    }

                    List<Bullet> GetBullets() { return bullets; }

                    void BulletTimer_Tick(object sender, EventArgs e, List<Bullet> bullets)
                    {
                        for (int i = bullets.Count - 1; i >= 0; i--)
                        {
                            bullets[i].Top -= 10; // 총알의 이동 속도
                            if (bullets[i].Top < 0)
                            {
                                this.Controls.Remove(bullets[i]);
                                bullets.RemoveAt(i);
                            }
                        }
                    }
                    void Form1_KeyDown(object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.ShiftKey && !isSpecialAttackActive)
                        {
                            PlayerSpecialAttack(10); // 10초 동안 특수 공격 활성화
                        }
                    }

                    void PlayerSpecialAttack(int Sp_Item)
                    {
                        if (Sp_Item > 0)
                        {
                            isSpecialAttackActive = true;
                            bulletSpeed = 20; // 속도 2배로 증가
                            Sp_Item--;

                            Timer specialAttackTimer = new Timer
                            {
                                Interval = 10000 // 10초
                            };
                            specialAttackTimer.Tick += (sender, e) =>
                            {
                                isSpecialAttackActive = false;
                                bulletSpeed = 10; // 원래 속도로 복원
                                specialAttackTimer.Stop();
                                specialAttackTimer.Dispose();
                            };
                            specialAttackTimer.Start();
                        }
                    }


                    void PlayerMove() // 이교현
                    {
                        private void Form1_KeyDown(object sender, KeyEventArgs e)
                        {
                            PlayerMove(e);
                        }

                        private void PlayerMove(KeyEventArgs e)
                        {
                            int newX = player.Location.X;
                            int newY = player.Location.Y;

                            // WASD와 화살표 키 감지
                            switch (e.KeyCode)
                            {
                                case Keys.W:
                                case Keys.Up:
                                    newY -= moveSpeed;
                                    break;
                                case Keys.S:
                                case Keys.Down:
                                    newY += moveSpeed;
                                    break;
                                case Keys.A:
                                case Keys.Left:
                                    newX -= moveSpeed;
                                    break;
                                case Keys.D:
                                case Keys.Right:
                                    newX += moveSpeed;
                                    break;
                            }

                            // 이동 범위 제한
                            if (newX < 0) newX = 0;
                            if (newY < 0) newY = 0;
                            if (newX > this.ClientSize.Width - player.Width) newX = this.ClientSize.Width - player.Width;
                            if (newY > this.ClientSize.Height - player.Height) newY = this.ClientSize.Height - player.Height;

                            player.Location = new Point(newX, newY);
                        }

                        private void Form1_Load(object sender, EventArgs e)
                        {
                            this.ActiveControl = player;
                        }
                    }

                    void Disapper()
                    {
                        // 체력이 0이될때 사라지게 하는 클래스 (이교현)
                        // 아래 주석은 참고만해주세요 무조건적으로 따라하실필요는 없습니다
                        // 해당 객체의 체력이 0이 된다면 아에 삭제해버리면됩니다.
                        if (playerHP <= 0)
                        {
                            // 플레이어의 체력이 0 이하이면 사라지도록 처리
                            Disapper();
                        }
                    }

                    void EntityInformation()
                    {
                        // 플레이어, 잡몹, 보스의 정보를 담는 클래스 (이지원)
                        // 해당 클래스를 상속을 통해서 짜야합니다

                        // Entity클래스 가장 높은 부모클래스
                        // 필요한 내용 : int HP(체력), int SNum(고유번호), boolean Invincible(무적여부), boolean Poison(독 여부)
                        // Entity를 상속하는 자식클래스
                        // Player 클래스 
                        // 필요한 내용 : int attack_stage(공격단계), int SP_Item(스페셜 아이템)
                        // Mob 클래스
                        // 필요한 내용 : int mob_type(몹 타입 종류가 3종류가있기때문에 기입), 
                        // Boss 클래스
                        // 필요한 내용 : int phase(보스의 페이즈 1,2,3까지 페이즈가 나눠져있기때문에 구성)
                        // 내용이 추가될수있습니다

                    }

                    void Mob_Ant()
                    {
                        // 몹(개미)을 담당하는 클래스 (김현민)
                    }

                    void Mob_Mogi()
                    {
                        // 몹(모기)을 담당하는 클래스 (김현민)
                    }

                    void Mob_DragonFly()
                    {
                        // 몹(잠자리)을 담당하는 클래스 (김현민)
                    }

                    void Drop_Item(int itemPer[])
                    {
                        // 아이템을 떨어트리는 클래스 (김현민)
                        // 몹마다 다른 확률로 아이템을 떨어트리기때문에 확률을 매개변수로 받아서 아이템을 떨어트리게한다
                    }

                    void Bosspattern()
                    {
                        // 보스 패턴을 담당하는 클래스 (김현민)
                    }

                }
            }
