using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NotWebMatrix.Data;


namespace sandness_mvc4.Models.Diplo
{
    public class ByggeplassRepository
    {
        public static int GetUserId(string Email)
        {
            var db = Database.Open("SolaBetong");            
            var query = db.QueryValue("Select Id FROM [SolaBetong].[dbo].[User] WHERE Email=@0", Email);
            return query;
        }
        public static IEnumerable<dynamic> GetByggeplass()
        {
            var db = Database.Open("SolaBetong");           
            var query = db.Query("SELECT p.*,cust.name kundeName FROM [SolaBetong].[dbo].[Project] p, [SolaBetong].[dbo].[Customer] cust WHERE  p.CustomerId = cust.Id");
            return query;
        }
        public static IEnumerable<dynamic> GetByggeplass(string uid)
        {
            var db = Database.Open("SolaBetong");            
            var query = db.Query("SELECT p.*,cust.name kundeName FROM [SolaBetong].[dbo].[Project] p, [SolaBetong].[dbo].[Customer] cust WHERE  p.CustomerId = cust.Id and cust.Id=" + uid);
            return query;
        }
        
        public static IEnumerable<dynamic> GetProjectsWithKunde(string customerId)
        {
            var db = Database.Open("SolaBetong");
            var query = db.Query("SELECT p.*,cust.name kundeName FROM [SolaBetong].[dbo].[Project] p, [SolaBetong].[dbo].[Customer] cust WHERE  p.CustomerId = cust.Id and p.CustomerId=" + customerId);
            return query;
        }

        public static IEnumerable<dynamic> GetKunde()
        {
            var db = Database.Open("SolaBetong");
            var q1 = db.Query("SELECT  Id,Name FROM [SolaBetong].[dbo].[Customer]  Order by Id ASC");
            return q1;
        }
      
        public static IEnumerable<dynamic> GetProjectsWithUserIdCustId( int UserId, int CustomerId)
        {
            var db = Database.Open("SolaBetong");
            var q1 = db.Query("SELECT  pro.Id,pro.Name,pro.UserId FROM [SolaBetong].[dbo].[Project] pro, [SolaBetong].[dbo].[User] usr, [SolaBetong].[dbo].[Customer] cust where usr.Id = pro.UserId and  cust.Id= pro.CustomerId  and pro.UserId=@0 and pro.CustomerId=@1 Order by pro.Name", UserId,CustomerId);            
            return q1;
        }
        public static IEnumerable<dynamic> Projects_emails(int  proID)
        {
            var db = Database.Open("SolaBetong");
            var q2 = db.Query("SELECT Email,Id FROM [SolaBetong].[dbo].[ProjectsEmail] WHERE ProjectId=" + proID);
            return q2;
        }
        public static void Projects_emails_del(int emailID)
        {
            var db = Database.Open("SolaBetong");
            db.Execute("Delete FROM [SolaBetong].[dbo].[ProjectsEmail] WHERE Id = " + emailID);
        }

        public static void Projects_emails_update(string email, int id)
        {
            var db = Database.Open("SolaBetong");
            db.Execute("UPDATE [SolaBetong].[dbo].[ProjectsEmail] set Email=@0 WHERE Id =@1", email, id);
        }

        public static IEnumerable<dynamic> userList()
        {
            var db = Database.Open("SolaBetong");
            var q3 = db.Query("SELECT u.Id,u.LastName,u.FirstName, g.GroupName, r.Name FROM [SolaBetong].[dbo].[User] u , [SolaBetong].[dbo].[Roll] r,[SolaBetong].[dbo].[UserGroup] g  WHERE u.RollId = r.id  and u.UserGroupId = g.Id and u.UsergroupId !=1 Order by u.FirstName ASC");
            return q3;
        }

        public static IEnumerable<dynamic> adminUserList()
        {
            var db = Database.Open("SolaBetong");
            //var q4 = db.Query("SELECT u.u_adminid, u.u_id, u.u_fname, u.u_lname, u.u_company, u.u_mail, u.u_phone, u.u_company_name, g.ug_name FROM [SolaBetong].[dbo].[user] u , [SolaBetong].[dbo].[usergroup] g where u.u_group = g.ug_id and  g.ug_id = 1 ORDER BY u_company DESC");
            var q4 = db.Query("SELECT u.id,u.FirstName,u.LastName,u.Email,u.Mobile, g.GroupName FROM [SolaBetong].[dbo].[User] u, [SolaBetong].[dbo].[UserGroup] g WHERE u.UserGroupId = g.Id and g.Id=1 ORDER By u.FirstName Desc ");
            return q4;
        }

        public static IEnumerable<dynamic> getUserGroup()
        {
            var db = Database.Open("SolaBetong");
            var usergroup = db.Query("Select * from [SolaBetong].[dbo].[UserGroup]");
            return usergroup;
        }
        public static IEnumerable<dynamic> getrolle()
        {
            var db = Database.Open("SolaBetong");
            var roller = db.Query("SELECT *  FROM [SolaBetong].[dbo].[Roll]");
            return roller;
        }
        public static int getAdminId(string login)
        {
            var db = Database.Open("SolaBetong");
            var q6 = db.QueryValue("Select id FROM [SolaBetong].[dbo].[User] u, [SolaBetong].[dbo].[UserGroup] g  WHERE u.UserGroupId=g.Id and g.Id=1 and  u.Email=@0", login);
            return q6;
        }
        public static int emailcheck(string email)
        {
            var db = Database.Open("SolaBetong");
            var sql = db.QueryValue("SELECT count(u.ID) FROM [SolaBetong].[dbo].[User] WHERE Email=@0", email);
            return sql;
        }
        public static IEnumerable<dynamic> get_username_passwd(string email)
        {
            var db = Database.Open("SolaBetong");
            var sql = db.Query("SELECT Email,password FROM [SolaBetong].[dbo].[User] WHERE Email=@0", email);
            return sql;
        }
        public static string getCompanyName(int u_id)
        {
            var db = Database.Open("SolaBetong");
            //var q7 = db.QueryValue("Select u_company_name FROM [SolaBetong].[dbo].[User] where u_id=@0", u_id);
            var q7 = db.QueryValue("Select Name FROM [SolaBetong].[dbo].[Customer] where id=@0", u_id);
            return q7;
        }
        public static int getLastAdminId()
        {
            var db = Database.Open("SolaBetong");
            var q8 = db.QueryValue("SELECT TOP 1 Id FROM [SolaBetong].[dbo].[User] Order By Id DESC");
            return q8;
        }
        public static IEnumerable<dynamic> rollerList()
        {
            var db = Database.Open("SolaBetong");
            var q9 = db.Query("SELECT * FROM [SolaBetong].[dbo].[Roll]");
            return q9;
        }
        // for paging ,total row count
        public static IEnumerable<dynamic> ordersForCount(string kunde_id, string project_id, int status, string order_date )
        {
            var db = Database.Open("SolaBetong");            
            //var sql = "SELECT ord.id, ord.UserId,ord.CustomerId, ord.DeliveryDate , ord.khour, ord.kval, ord.sort, ord.cement, ord.var, ord.temp, ord.pump, ord.bil, ord.note, usr.u_company kunde_user, u.u_company kunde_name, pro.id proid, pro.name, pro.adres FROM [SolaBetong].[dbo].[orders] ord, [SolaBetong].[dbo].[user] usr, [SolaBetong].[dbo].[user] u, [SolaBetong].[dbo].[Project] pro WHERE ord.userid = usr.u_id AND ord.project = pro.id And ord.kunde = u.u_id and ord.deleted!=1";
            var sql = "SELECT ord.Id, ord.UserId,ord.CustomerId, ord.DeliveryDate, ord.Note, cust.Name CustomerName, pro.Id proid, pro.Name, pro.Address FROM [SolaBetong].[dbo].[Order] ord, [SolaBetong].[dbo].[Customer] cust, [SolaBetong].[dbo].[User] usr, [SolaBetong].[dbo].[Project] pro WHERE ord.UserId = usr.Id AND ord.ProjectId = pro.Id And ord.CustomerId = cust.Id and ord.Deleted!=1";
            sql += " And Status=" + status;
            if (!String.IsNullOrEmpty(kunde_id))
            {
                sql += " And ord.CustomerId =" + kunde_id;
            }
            if (!String.IsNullOrEmpty(project_id))
            {
                sql += " And ord.ProjectId = " + project_id;
            }
            if (!String.IsNullOrEmpty (order_date))   
            { 
                sql += " And ord.DeliveryDate =  '" + order_date + "'";
            }            
            var q10 = db.Query(sql);
            return q10;
        }
        public static IEnumerable<dynamic> orders(string kunde_id, string project_id, int status, string order_date, int offset, int pagesize, string sortcol, string sortorder)
        {
            var db = Database.Open("SolaBetong");
            var sql = "SELECT ord.Id, ord.UserId,ord.CustomerId, ord.DeliveryDate, ord.DeliveryTime,  ord.Note, ord.status, cust.Name CustomerName, pro.Id ProjectId, pro.Name ProjectName, pro.Address FROM [SolaBetong].[dbo].[Order] ord,[SolaBetong].[dbo].[Customer] cust, [SolaBetong].[dbo].[User] usr, [SolaBetong].[dbo].[Project] pro WHERE ord.CustomerId =cust.Id and ord.UserId = usr.Id AND ord.ProjectId = pro.Id  and ord.deleted!=1";
            sql += " And status=" + status;
            if (!String.IsNullOrEmpty(kunde_id))
            {
                sql += " And ord.CustomerId =" + kunde_id;
            }
            if (!String.IsNullOrEmpty(project_id))
            {
                sql += " And ord.ProjectId = " + project_id;
            }
            if (!String.IsNullOrEmpty(order_date))
            {
                sql += " And ord.DeliveryDate =  '" + order_date + "'";
            }
            sql += " Order by " + @sortcol + "  " + @sortorder + " OFFSET " + @offset + " ROWS FETCH NEXT " + @pagesize + " ROWS ONLY ";
            var q10 = db.Query(sql);
            return q10;
        }
        public static IEnumerable<dynamic> orders_project()
        {
            var db = Database.Open("SolaBetong");
            var sql = "SELECT Id,Name FROM [SolaBetong].[dbo].[Project] Order by Id ASC";
            var q11 = db.Query(sql);
            return q11;
        }
        public static IEnumerable<dynamic> orders_project_with_company(int u_id)
        {
            var db = Database.Open("SolaBetong");
            var sql = db.Query("SELECT Id,Name FROM [SolaBetong].[dbo].[Project] WHERE UserId=@0 Order by Id ASC", u_id);
            return sql;
        }
        public static IEnumerable<dynamic> getFormUserfield()
        {
            var db = Database.Open("SolaBetong");
            var sql12 = db.Query("SELECT * FROM [SolaBetong].[dbo].[Felters] WHERE foruser=1 Order by ord DESC");
            return sql12;
        }
        public static IEnumerable<dynamic> getFormfield()
        {
            var db = Database.Open("SolaBetong");
            var sql = db.Query("SELECT * FROM [SolaBetong].[dbo].[Felters] Order by ord DESC");
            return sql;
        }
        public static IEnumerable<dynamic> getfieldfortable()
        {
            var db = Database.Open("SolaBetong");
            var sql = db.Query("SELECT * FROM [SolaBetong].[dbo].[Felters] WHERE ForTable=1 Order by ord DESC");
            return sql;
        }
        public static double ToUnix(DateTime value)
        {
            long epoch = (value.Ticks - 621355968000000000) / 10000000;
            return epoch;
        }
        public static double ConvertToUnixTimestamp(DateTime date)
        {
            long epoch = (date.Ticks - 621355968000000000) / 10000000;
            return epoch;
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {            
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
        //for infopages
        /*
        public static IEnumerable<dynamic> infopages_data(int i_id)
        { //infopages id
            var db = Database.Open("SolaBetong");
            var sql = db.Query("SELECT info.id,info.Text,txtcode.t_val FROM [SolaBetong].[dbo].[Infopages] info, [SolaBetong].[dbo].[Textcodes] txtcode WHERE info.Textcode_t_code = txtcode.t_code and info.id=@0", @i_id);
            return sql;
        }
        public static IEnumerable<dynamic> get_t_code(int i_id)
        { //infopages id
            var db = Database.Open("SolaBetong");
            var sql = db.Query("SELECT txtcode.t_code FROM [SolaBetong].[dbo].[Infopages] info, [SolaBetong].[dbo].[Textcodes] txtcode WHERE info.textcode_t_code = txtcode.t_code and info.id=@0", @i_id);
            return sql;
        }
        */
        public static IEnumerable<dynamic> get_infopages_data()
        { //infopages id
            var db = Database.Open("SolaBetong");
            var sql = db.Query("SELECT txtCode.Id,txtcode.t_val, info.Text  FROM  [SolaBetong].[dbo].[Textcodes] txtcode ,[SolaBetong].[dbo].[Infopages] info  WHERE txtcode.InfopagesId = info.Id   ORDER BY Id DESC");
            return sql;
        }
    }
}