using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.Controller;

namespace HotelManager.Admin
{
    public partial class CreateService : Form
    {
        public CreateService()
        {
            InitializeComponent();

            cbbExistingService.DataSource = ServiceController.GetRoomServiceCategory();
            cbbExistingService.DisplayMember = "nameCategory";
            cbbExistingService.ValueMember = "idCategory";

            radioBtnAlready.Checked = true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioBtnAlready_CheckedChanged(object sender, EventArgs e)
        {
            txtCategoryID.Enabled = false;
            txtNameCategory.Enabled = false;    
            cbbExistingService.Enabled = true;
        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cbbExistingService.Enabled = false;
            txtCategoryID.Enabled = true;
            txtNameCategory.Enabled = true; 
        }

        private void btnConfirmCreateService_Click(object sender, EventArgs e)
        {
            if (numUDServicePrice.Value >= 20000)
            {
                if (radioBtnAlready.Checked == true)
                {
                    bool result = ServiceController.InsertAlreadyService(cbbExistingService.SelectedValue.ToString(), txtNewServiceID.Text, txtServiceName.Text, (int)numUDServicePrice.Value);
                    if (result)
                    {
                        MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult= DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string idCategory = txtCategoryID.Text;
                    string nameCategory = txtNameCategory.Text;
                    bool result = ServiceController.InsertNewService(idCategory, nameCategory, txtNewServiceID.Text, txtServiceName.Text, (int)numUDServicePrice.Value);
                    if (result)
                    {
                        MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else
            {
                MessageBox.Show("Giá dịch vụ chưa hợp lý, phải lớn hơn 20000VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
