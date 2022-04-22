using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Test1.Models;

namespace Test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FireFighterController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostFireFighter(FireFighter newFireFighter)
        {

            using (var con = new SqlConnection("Data Source = db-mssql; Initial Catalog = s22297; Integrated Security = True"))
            
            {
                SqlCommand com = new SqlCommand("Select *  from  FireTruck", con);
              
                con.Open();
                var dr = com.ExecuteReader();
                FireFighter fireFighter = null;
                while (dr.Read())
                {
                    fireFighter = new FireFighter
                    {
                        idFireFighter = (int)dr["idFirefighter"],
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["SecondName"]

                    };
                    Console.WriteLine(fireFighter.LastName + " " + fireFighter.FirstName);
                }
                return Ok();
            }
        }
    }
}
