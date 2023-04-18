using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Helper
{
    public class SendMail
    {
        private string senderEmail;
        private string senderPassword;

        public SendMail(string senderEmail, string senderPassword)
        {
            this.senderEmail = senderEmail;
            this.senderPassword = senderPassword;
        }

        public string SendMailProcess(string recipientEmail, string recipientPassword, bool isUpdate = false)
        {
            try
            {
                MailMessage mailMsg = new MailMessage();
                mailMsg.From = new MailAddress(senderEmail);
                mailMsg.To.Add(recipientEmail);
                if (isUpdate)
                {
                    mailMsg.Body = "Chào bạn, mật khẩu mới truy cập vào phần mềm của bạn là: " + recipientPassword;
                    mailMsg.Subject = "Bạn đã yêu cầu cấp lại mật khẩu!";
                }
                else
                {
                    mailMsg.Body = string.Format("Chào mừng bạn đã được thêm vào danh sách nhân viên của phần mềm với " +
                                                 "thông tin đăng nhập là: \n- Email: {0} \n- Mật khẩu: {1} ", recipientEmail, recipientPassword);
                    mailMsg.Subject = "Thông tin đăng nhập phần mềm!";
                }
                using (SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(mailMsg);
                }
                return "Vui lòng kiểm tra Email để nhận mật khẩu mới!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
