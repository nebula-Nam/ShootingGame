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
            LoadImage();

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
        }

        public void test()
        {
            // 테스트입니다
            // 123
        }
    }


}