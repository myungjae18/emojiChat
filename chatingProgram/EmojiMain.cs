using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class EmojiMain : Form
    {
        public string buttonText = null;//button의 text를 담을 변수, public으로 선언하여 다른 클래스에서 접근할 수 있도록 한다.
        public EmojiMain()
        {
            InitializeComponent();
        }

        void button_Click(object sender, EventArgs e)//모든 emoji 버튼의 이벤트를 처리하는 메서드
        {
            Button btn = sender as Button;//이벤트를 발생시킨 객체를 버튼으로 정의
            byte[] bt = Encoding.UTF8.GetBytes(btn.Text);//해당 버튼의 문자열을 UTF8 encoding(하지 않을 경우 깨짐)
            buttonText = Encoding.UTF8.GetString(bt);//encoding된 byte 배열을 다시 String type으로 변환
        }
    }
}
