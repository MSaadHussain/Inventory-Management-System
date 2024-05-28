using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    internal class retrieval
    {

        public void showuser(DataGridView gv , DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passwordGV , DataGridViewColumn email_GV ,DataGridViewColumn phone_gv,DataGridViewColumn status_gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUsersdata",MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt   = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passwordGV.DataPropertyName = dt.Columns["Password"].ToString();
                phone_gv.DataPropertyName = dt.Columns["Phone"].ToString();
                email_GV.DataPropertyName = dt.Columns["Email"].ToString();
                status_gv.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch(Exception)
            {

            }
            
                }
    }
}
