using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class CFormMain : Form
    {
        public TcpClient mTcpClient = null;
        public NetworkStream mStream = null;
        public static EmojiMain emojiForm = new EmojiMain();//이모티콘을 선택하여 입력할 수 있는 form


        public CFormMain()
        {
            InitializeComponent();
        }


        private void btConnect_Click(object sender, EventArgs e)
        {
            if (mTcpClient == null)
            {
                
                mTcpClient = new TcpClient(AddressFamily.InterNetwork);
                IPAddress iPAddress = IPAddress.Parse(txtIpAddress.Text);
                int port = Convert.ToInt32(txtPort.Text);

                MessageBox.Show("환영합니다.");//접속 성공 후 알림 창 팝업

                IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
                mTcpClient.Connect(iPEndPoint);

                btConnect.Text = "Disconnect";

                timerReceive.Enabled = true;
                mStream = mTcpClient.GetStream();
            } else
            {
                mStream.Close();
                mStream.Dispose();
                mStream = null;

                mTcpClient.Close();
                mTcpClient.Dispose();
                mTcpClient = null;

                MessageBox.Show("접속 해제되었습니다.");//접속 해제 후 알림 창 팝업

                btConnect.Text = "Connect";
                timerReceive.Enabled = false;

            }
        }

        private void checkEmoji()
        {
            if (emojiForm.buttonText != null)//emojiForm 내의 buttonText 값이 바뀌었을 때
            {
                txtSend.Text += emojiForm.buttonText;//txtSend에 내용 추가
                emojiForm.buttonText = null;//buttonText 초기화하여 다시 버튼을 누르면 그 값을 받아올 준비를 한다.
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if(mTcpClient == null || mTcpClient.Connected==false)
            {
                return;
            }

            byte[] data = Encoding.UTF8.GetBytes(txtSend.Text);//입력한 문자열을 UTF8로 인코딩하여 byte 배열에 저장
            mTcpClient.Client.Send(data);
        }

        private void timerReceive_Tick(object sender, EventArgs e)
        {            
            if (mTcpClient == null || mTcpClient.Connected == false || mStream==null)
            {
                return;
            }
            txtSend.ReadOnly = false;//접속 성공 후에 txtSend내에 내용을 입력할 수 있게 설정
            if (emojiForm.buttonText != null)//emojiForm 내의 buttonText 값이 바뀌었을 때
            {
                txtSend.Text += emojiForm.buttonText;//txtSend에 내용 추가
                emojiForm.buttonText = null;//buttonText 초기화하여 다시 버튼을 누르면 그 값을 받아올 준비를 한다.
            }

            if (mStream.DataAvailable==true)
            {
                byte[] bzReceive = new byte[1024];

                mStream.ReadAsync(bzReceive, 0, 1024);

                string strReceive = Encoding.UTF8.GetString(bzReceive);//해당 byte 배열을 UTF8 문자열로 변환

                StringBuilder sb = new StringBuilder(strReceive);
                

                txtReceive.Text += sb; 
                txtReceive.AppendText("\r\n");
                
            }
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            emojiForm.ShowDialog();//emojiForm 보여주기
        }
    }
}
