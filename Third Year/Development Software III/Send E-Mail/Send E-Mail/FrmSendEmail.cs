using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Send_E_Mail
{
    public partial class FrmSendEMail : Form
    {
        public FrmSendEMail()
        {
            InitializeComponent();

            HtmlRTB.BeginUpdate();
            HtmlRTB.AddHTML("<font>Dear <b>+Mrs Elizabeth Keen</b></font><br/><br/><p>Thank You For choosing <b>CRS Rentals</b><br/><br/><b>Rented Vehicle Details:</b><br/>Vehicle Reg No: <b>TFG 226 EC</b><br/>Vehicle Brand: <b>Ford</b><br/>Model: <b>Ranger</b><br/>Color: <b>Gold</b><br/>Transmission: <b>Manual</b><br/>Year: <b>2022</b><br/>Seats: <b>5</b><br/>Kilometers on Rental: <b>4447km</b><br/><br/></p><p style=\"color:#FF0000;\"><b>Please Note:</b><br/>The Maximum Kilometers You Must Travel: <b>400 km</b><br/>If You Travel More Than The Above Mentioned Kilometers, There Will Be An Excess Fee Charged For Every Kilometer Above The Maximum Kilometers You Were Supposed To Travel.<br/><br/></p><p>Rental Date: <b>2022/09/27</b><br/>Rental Time: <b>2022/</b><br/>Rental Days: <b>4 Days</b><br/>Return Date: <b>2022/09/30</b><br/>Return Time: <b>2022/km</b><br/><br/></p><p style=\"color:#FF0000;\"><b>Please Note The Return Date and Time. There Will Be A Grace Period of 1 Hour, After That There Will Be a Penalty Fee.</b><br/><br/></p><p><b>Costs on Rental:</b><br/>Rental Price: <b>R4400,80</b><br/>Vat: <b>R660,12</b><br/>Total Charged: <b>R5060,92</b><br/><br/></p><p>You Were Assisted By: <b>Raymond Reddington (Manager)</b><br/><br/></p><p>We Hope You Have A Great Journey!<br/><br/>Kind Regards<br/></p><p style=\"color:#3399FF;\"><b><i>CRS Rentals</i></b><br/><b><i>Tel: +27827797591</i></b><br/><br/></p><p style=\"font-size:8.5pt; color:#C0C0C0;\">This communication is intended for the addressee only. It is confidential.<br/>If you have received this communication in error, please notify<b>CRS Rentals</ b > immediately and destroy the original message.<br/>You may not copy or disseminate this communication without<b>CRS Rentals</ b > expressed or written permission.<br/></p></p>");
            HtmlRTB.EndUpdate();        
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Clear All?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TxtTo.Text = "";
                    TxtSubject.Text = "";
                    TxtBody.Text = "";
                    TxtBody.Focus();
                    break;

                case DialogResult.No:
                    return;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.Close();
                    break;

                case DialogResult.No:
                    return;
            }
        }

        private void FrmSendEMail_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=CHRISTOPH;Integrated Security=SSPI;Initial Catalog=db_Test"; //Connection Details  
                                                                                                                       //select fields to mail example student details  
            SqlCommand sqlCommand = new SqlCommand("select Name,DOB,Email,Mob from Student", sqlConnection); //select query command  
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand; //add selected rows to sql data adapter  
            DataSet dataSetStud = new DataSet(); //create new data set  
            try
            {
                sqlDataAdapter.Fill(dataSetStud, "student"); //fill sql data adapter rows to data set  
                dgStudent.ColumnCount = 4;
                dgStudent.Columns[0].HeaderText = "Student Name";
                dgStudent.Columns[0].DataPropertyName = "Name";
                dgStudent.Columns[1].HeaderText = "Date of birth";
                dgStudent.Columns[1].DataPropertyName = "DOB";
                dgStudent.Columns[2].HeaderText = "Mail Id";
                dgStudent.Columns[2].DataPropertyName = "Email";
                dgStudent.Columns[3].HeaderText = "Mobile No";
                dgStudent.Columns[3].DataPropertyName = "Mob";
                dgStudent.DataSource = dataSetStud;
                dgStudent.DataMember = "student";
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                sqlConnection.Close();
            }
        }

        public string getHtml(DataGridView grid)
        {
            try
            {
                string messageBody = "<font>The following are the records: </font><br><br>";
                if (grid.RowCount == 0) return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style=\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style=\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";
                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;
                messageBody += htmlTdStart + "Student Name" + htmlTdEnd;
                messageBody += htmlTdStart + "DOB" + htmlTdEnd;
                messageBody += htmlTdStart + "Email" + htmlTdEnd;
                messageBody += htmlTdStart + "Mobile" + htmlTdEnd;
                messageBody += htmlHeaderRowEnd;
                //Loop all the rows from grid vew and added to html td  
                for (int i = 0; i <= grid.RowCount - 1; i++)
                {
                    messageBody = messageBody + htmlTrStart;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[0].Value + htmlTdEnd; //adding student name  
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[1].Value + htmlTdEnd; //adding DOB  
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd; //adding Email  
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[3].Value + htmlTdEnd; //adding Mobile  
                    messageBody = messageBody + htmlTrEnd;
                }
                messageBody = messageBody + htmlTableEnd;
                return messageBody; // return HTML Table as string from this function  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Getting HTML Text");
                return null;
            }
        }

        public void Email(string htmlString)
        {
            try
            {
                //GMAIL
                /*MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("ghost1lucifer1@gmail.com", "CRS Rentals");
                message.To.Add(new MailAddress(TxtTo.Text));
                message.Subject = TxtSubject.Text;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("ghost1lucifer1@gmail.com", "jrym axrc jmgl knah");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);*/




                //HOTMAIL
                /*SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");
                MailMessage message = new MailMessage();
                message.From = new MailAddress("crs-rentals@hotmail.com", "CRS Rentals");
                message.To.Add(new MailAddress(TxtTo.Text));
                message.Subject = TxtSubject.Text;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new NetworkCredential("crs-rentals@hotmail.com", "Auth27@CRS");
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.Send(message);*/


                /*//GMAIL
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("hms.management6@gmail.com", "HMS Management");
                message.To.Add(new MailAddress(TxtTo.Text));
                message.Subject = TxtSubject.Text;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("hms.management6@gmail.com", "lano omjh yqzn ihau");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);*/

                //TITAN
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("no-reply@mmea.live", "MMEA");
                message.To.Add(new MailAddress(TxtTo.Text));
                message.Subject = TxtSubject.Text;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 465;
                smtp.Host = "smtp.titan.email"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("no-reply@mmea.live", "@651121.Titan");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sending Email");
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string htmlString = getHtml(dgStudent); //here you will be getting an html string  

            switch (MessageBox.Show("Are You Sure You Want To Send The Email?", "Sending Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Email(htmlString); //Pass html string to Email function.
                    MessageBox.Show("Email Sent Successfully", "Email Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case DialogResult.No:
                    return;
            }
        }
    }
}
