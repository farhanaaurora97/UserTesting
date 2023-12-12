using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzimAndSonApp
{
    public partial class _Default : Page
    {
        SqlConnection connection = new SqlConnection("Data Source=AFTAHISLAM007\\SQLEXPRESS;Initial Catalog=AzimAndSonDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetUserList();
            }
        }

        protected void Insert_Button_Click(object sender, EventArgs e)
        {
            Page.Validate("insert");
            if (Page.IsValid)
            {
                int user_id = int.Parse(User_ID_Txt.Text);
                //int user_id;
                //if (int.TryParse(User_ID_Txt.Text, out user_id))
                //{
                //    return;
                //}

                string first_name = First_Name_Txt.Text;
                string last_name = Last_Name_Txt.Text;
                string email = Email_Txt.Text;
                string password = Password_Txt.Text;
                string confirm_password = Confirm_Password_Txt.Text;

                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO user_registration (User_ID, First_name, Last_name, Email, Password, Confirm_Password) VALUES ('" + user_id + "','" + first_name + "','" + last_name + "','" + email + "','" + password + "','" + confirm_password + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();

                string message = "Data saved successfully";
                string script = "window.onload = function () { alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);
                GetUserList();
            }
            else
            {
                string message = "Validation Error! Data not Saved";
                string script = "window.onload = function () { alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "FailedMessage", script, true);
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Validation Error! Data not Saved');", true);
            }


            //if (User_ID_Txt.Text == "")
            //{
            //    User_Id_CustomValidator.ServerValidate();
            //}


        }

        void GetUserList()
        {
            //string str = "SELECT * FROM user_registration";
            SqlCommand command = new SqlCommand("SELECT * FROM user_registration", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Update_Button_Click(object sender, EventArgs e)
        {
            int user_id = int.Parse(User_ID_Txt.Text);
            string first_name = First_Name_Txt.Text;
            string last_name = Last_Name_Txt.Text;
            string email = Email_Txt.Text;
            string password = Password_Txt.Text;
            string confirm_password = Confirm_Password_Txt.Text;
            
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE user_registration SET First_name = '" + first_name + "', Last_name = '" + last_name + "', Email = '" + email + "', Password = '" + password + "', Confirm_Password = '" + confirm_password + "' WHERE User_ID = '" + user_id + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();

            string message = "Data updated successfully";
            string script = "window.onload = function () { alert('";
            script += message;
            script += "')};";
            ClientScript.RegisterStartupScript(this.GetType(), "UpdateMessage", script, true);
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            GetUserList();
        }

        protected void Delete_Button_Click(object sender, EventArgs e)
        {
            int user_id = int.Parse(User_ID_Txt.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE user_registration WHERE User_ID = '" + user_id + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();

            string message = "Data deleted successfully";
            string script = "window.onload = function () { alert('";
            script += message;
            script += "')};";
            ClientScript.RegisterStartupScript(this.GetType(), "DeleteMessage", script, true);
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            GetUserList();
        }

        protected void Search_Button_Click(object sender, EventArgs e)
        {
            int user_id = int.Parse(User_ID_Txt.Text); 
            
            SqlCommand command = new SqlCommand("SELECT * FROM user_registration WHERE User_ID = '" + user_id + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Get_Button_Click(object sender, EventArgs e)
        {
            int user_id = int.Parse(User_ID_Txt.Text);

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM user_registration WHERE User_ID = '" + user_id + "'", connection);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                First_Name_Txt.Text = sdr[1].ToString();
                Last_Name_Txt.Text = sdr[2].ToString();
                Email_Txt.Text = sdr[3].ToString();
                Password_Txt.Text = sdr[4].ToString();
                Confirm_Password_Txt.Text = sdr[5].ToString();
            }
        }

        protected void User_ID_CustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (User_ID_Txt.Text == "" || First_Name_Txt.Text == "" || Last_Name_Txt.Text == "" || Email_Txt.Text == "" || Password_Txt.Text == "" || Confirm_Password_Txt.Text == "")
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            
        }

        protected void First_Name_CustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (User_ID_Txt.Text == "" || First_Name_Txt.Text == "" || Last_Name_Txt.Text == "" || Email_Txt.Text == "" || Password_Txt.Text == "" || Confirm_Password_Txt.Text == "")
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void Last_Name_CustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (User_ID_Txt.Text == "" || First_Name_Txt.Text == "" || Last_Name_Txt.Text == "" || Email_Txt.Text == "" || Password_Txt.Text == "" || Confirm_Password_Txt.Text == "")
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void Email_CustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (User_ID_Txt.Text == "" || First_Name_Txt.Text == "" || Last_Name_Txt.Text == "" || Email_Txt.Text == "" || Password_Txt.Text == "" || Confirm_Password_Txt.Text == "")
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void Password_CustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (User_ID_Txt.Text == "" || First_Name_Txt.Text == "" || Last_Name_Txt.Text == "" || Email_Txt.Text == "" || Password_Txt.Text == "" || Confirm_Password_Txt.Text == "")
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void Confirm_Password_CustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (User_ID_Txt.Text == "" || First_Name_Txt.Text == "" || Last_Name_Txt.Text == "" || Email_Txt.Text == "" || Password_Txt.Text == "" || Confirm_Password_Txt.Text == "")
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }
    }
}