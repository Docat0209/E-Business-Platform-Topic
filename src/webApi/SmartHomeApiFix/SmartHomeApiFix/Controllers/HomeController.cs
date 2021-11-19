using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SmartHomeApiFix.Models;

namespace SmartHomeApiFix.Controllers
{
    public class HomeController : ApiController
    {
        readonly SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Smart_home_db"].ConnectionString);
        public DataTable Sql(string command)
        {

            SqlDataAdapter da = new SqlDataAdapter(command, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // GET: api/Home
        public HttpResponseMessage Get()
        {
            DataTable dt_home = Sql($"select * from Homes");
            IList<HomeInfoDTO> items = dt_home.AsEnumerable().Select(row =>
            new HomeInfoDTO
            {
                Id = Convert.ToInt32(row["id"]),
                Name = row["name"].ToString(),
                Status = Convert.ToBoolean(row["status"]),
                Areas = Sql($"select * from Areas where home_id = {row["id"]}").AsEnumerable().Select(row_area =>
                    new AreaSimpleDTO
                    {
                        Id = Convert.ToInt32(row_area["id"]),
                        Name = row_area["name"].ToString(),
                        Status = Convert.ToBoolean(row_area["status"]),
                        Devices = Sql("select Devices.id,Devices.name,Type.name as type,status from Devices " +
                        "inner join Type " +
                        "on type_id = Type.id " +
                        $"where area_id = {row_area["id"]}")
                    }).ToList()
            }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }

        // GET: api/Home/5
        public HttpResponseMessage Get(int id)
        {
            DataTable dt_home = Sql($"select * from Homes where id = {id}");
            IList<HomeInfoDTO> items = dt_home.AsEnumerable().Select(row =>
            new HomeInfoDTO
            {
                Id = Convert.ToInt32(row["id"]),
                Name = row["name"].ToString(),
                Status = Convert.ToBoolean(row["status"]),
                Areas = Sql($"select * from Areas where home_id = {row["id"]}").AsEnumerable().Select(row_area =>
                    new AreaSimpleDTO
                    {
                        Id = Convert.ToInt32(row_area["id"]),
                        Name = row_area["name"].ToString(),
                        Status = Convert.ToBoolean(row_area["status"]),
                        Devices = Sql("select Devices.id,Devices.name,Type.name as type,status from Devices " +
                        "inner join Type " +
                        "on type_id = Type.id " +
                        $"where area_id = {row_area["id"]}")
                    }).ToList()
            }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }

        // POST: api/Home
        public HttpResponseMessage Post(HomeDTO home)
        {
            Sql($"insert into Homes values('{home.Name}','{home.Status}')");
            DataTable dt_home = Sql($"select * from Homes where id = (select max(id) from Homes)");
            IList<HomeInfoDTO> items = dt_home.AsEnumerable().Select(row =>
            new HomeInfoDTO
            {
                Id = Convert.ToInt32(row["id"]),
                Name = row["name"].ToString(),
                Status = Convert.ToBoolean(row["status"]),
                Areas = Sql($"select * from Areas where home_id = {row["id"]}").AsEnumerable().Select(row_area =>
                    new AreaSimpleDTO
                    {
                        Id = Convert.ToInt32(row_area["id"]),
                        Name = row_area["name"].ToString(),
                        Status = Convert.ToBoolean(row_area["status"]),
                        Devices = Sql("select Devices.id,Devices.name,Type.name as type,status from Devices " +
                        "inner join Type " +
                        "on type_id = Type.id " +
                        $"where area_id = {row_area["id"]}")
                    }).ToList()
            }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }

        // PUT: api/Home/5
        public HttpResponseMessage Put(int id, HomeDTO home)
        {
            Sql($"update Homes set " +
                $"name = '{home.Name}'," +
                $"status = '{home.Status}'" +
                $"where id = {id}");
            DataTable dt_home = Sql($"select * from Homes where id = {id}");
            IList<HomeInfoDTO> items = dt_home.AsEnumerable().Select(row =>
            new HomeInfoDTO
            {
                Id = Convert.ToInt32(row["id"]),
                Name = row["name"].ToString(),
                Status = Convert.ToBoolean(row["status"]),
                Areas = Sql($"select * from Areas where home_id = {row["id"]}").AsEnumerable().Select(row_area =>
                    new AreaSimpleDTO
                    {
                        Id = Convert.ToInt32(row_area["id"]),
                        Name = row_area["name"].ToString(),
                        Status = Convert.ToBoolean(row_area["status"]),
                        Devices = Sql("select Devices.id,Devices.name,Type.name as type,status from Devices " +
                        "inner join Type " +
                        "on type_id = Type.id " +
                        $"where area_id = {row_area["id"]}")
                    }).ToList()
            }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
