using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using System.Data;

namespace apiProject.Controllers
{
    public class ValuesController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        SqlCommand Mycomnd;

        // GET api/values
        public IHttpActionResult Get()
        {
             Mycomnd = new SqlCommand("select*from KhabnahStyles ", con);
            Mycomnd.CommandType = CommandType.Text ;
            SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter(Mycomnd);
            System.Data.DataTable dt = new System.Data.DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return NotFound();
            }

            return Ok(dt);
            //for (int i = 0; i <= dt.Rows.Count; i++)
            //    {
            //        return new string[] { dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString() };
            //    }
            //    return new string[] { "this" };
            
        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}
        // GET api/values/5

        public IEnumerable<string> Get(int id)
        {
            Mycomnd = new SqlCommand("select*from KhabnahStyles ", con);
            Mycomnd.CommandType = CommandType.Text;
            SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter(Mycomnd);
            System.Data.DataTable dt = new System.Data.DataTable();
            adp.Fill(dt);
            for (int i = id; i <= dt.Rows.Count; i++)
            {
                return new string[] { dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString() };
            }
            return new string[] { "this" };

        }
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
