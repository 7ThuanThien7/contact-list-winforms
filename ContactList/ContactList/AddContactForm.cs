using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;
            MessageBox.Show($"Đã lưu liên hệ:\nHọ tên: {fullName}\nSố điện thoại: {phoneNumber}\nEmail: {Email}", "Thông báo");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
