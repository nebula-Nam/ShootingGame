using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ShootingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        /*
        // 이미지를 화면에 출력할수있게하는 클래스
        void LoadImage()
        {
            try
            {
                // 이미지 경로 설정 (절대 경로 또는 상대 경로)
                string imagePath = "D:\\work\\ShootingGame\\images\\배경.png";

                // 이미지 로드
                pictureBox1.Image = Image.FromFile(imagePath);

                // 이미지 크기를 PictureBox에 맞게 조정
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                // 이미지 로드 실패 시 예외 처리
                MessageBox.Show("이미지를 로드하는 동안 오류가 발생했습니다: " + ex.Message);
            }
        }
        */
        void CollisionDetection()
        {
            // 충돌 확인 메서드 (김현민)
        }

        void MoveBackground()
        {
            // 배경을 움직이는 클래스 (이지원)
        }

        void PlayerAttack()
        {
            // 플레이어 일반공격을 담당하는 클래스 (남준혁)
        }

        void PlayerSpecialAttack()
        {
            // 플레이어의 움직임을 담당하는 클래스 (남준혁)
        }

        void Disapper()
        {
            // 체력이 0이될때 사라지게 하는 클래스 (이교현)
        }

        void EntityInformation()
        {
            // 플레이어, 잡몹, 보스의 정보를 담는 클래스 (이지원)
        }

        void Bosspattern()
        {
            // 보스 패턴을 담당하는 클래스 (김현민)
        }

    }


}