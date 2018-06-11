using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    //partial: dùng để chia class thành các phần khác nhau
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();//dùng để khởi tạo các đối tượng có trên form
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        //object sender: đối tượng kích hoạt ra event
        //EventArgs e: các tham số liên quan đến event, tùy theo event mà đối tượng này sẽ có kiểu khác nhau (chẳng hạn như PaintEventArgs, CancelEventArgs,…), các kiểu này đều được thừa kế từ lớp EventArgs.
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
