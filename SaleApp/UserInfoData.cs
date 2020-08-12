using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SaleApp
{
    public class UserInfoData
    {
        string strConnection =
            "server=SE130705\\SQLEXPRESS;database=ManagerSale;uid=sa;pwd=123456";
        public UserInfoData() { }
        public void InsertUserInfo(UserInfo newUser)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQLInsert = "Insert UserInfo values" +
                "(@UserName,@Password,@BirthDate,@Address,@Email)";
            SqlCommand cmd = new SqlCommand(SQLInsert, cnn);
            cmd.Parameters.AddWithValue("@UserName", newUser.UserName);
            cmd.Parameters.AddWithValue("@Password", newUser.Password);
            cmd.Parameters.AddWithValue("@BirthDate", newUser.BirthDate);
            cmd.Parameters.AddWithValue("@Address", newUser.Address);
            cmd.Parameters.AddWithValue("@Email", newUser.Email);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error:"+ex.Message);
            }
            finally
            {
                cnn.Close();
            }

        }
        public void UpdateUserInfo(UserInfo user)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQLUpdate = "Update UserInfo set [Password]= @Password," +
                " BirthDate = @BirthDate, [Address]=@Address,Email = @Email" +
                " where UserName = @UserName";
            SqlCommand cmd = new SqlCommand(SQLUpdate, cnn);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@BirthDate", user.BirthDate);
            cmd.Parameters.AddWithValue("@Address", user.Address);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error:"+ex.Message);
            }
            finally
            {
                cnn.Close();
            }

        }
        public void DeleteUserInfo(UserInfo u)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQLInsert =
                "Delete UserInfo where UserName=@UserName";
            SqlCommand cmd = new SqlCommand(SQLInsert, cnn);
            cmd.Parameters.AddWithValue("@UserName", u.UserName);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error:" + ex.Message);
            }
            finally
            {
                cnn.Close();
            }

        }
        public List<UserInfo> GetUserList()
        {
            List<UserInfo> data = new List<UserInfo>();
            string SQL = "select * from UserInfo";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cnn.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    dynamic u = new UserInfo()
                    {
                        UserName = rd["UserName"].ToString(),
                        Password = rd["Password"].ToString(),
                        BirthDate = DateTime.Parse(rd["BirthDate"].ToString()),
                        Address = rd["Address"].ToString(),
                        Email = rd["Email"].ToString()
                    };
                    data.Add(u);
                }
            }
            return data;
        }
    }
}