using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data.OleDb;
using System;

namespace Swagger.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneTable : Connected_to_BD
    {
        

        [HttpGet]
        public List<Phone> Get()
        {
            _Mycommand.CommandText = "SELECT *FROM Phone";
            OleDbDataReader reader = _Mycommand.ExecuteReader();
            List<Phone> result = new List<Phone>();

            while (reader.Read())
            {
                result.Add(new Phone((int)reader[0], (string)reader[1], (string)reader[2], (int)reader[3]));
            }
            return result;
        }

        [HttpPost]
        public string Post(string Model, string Contact)
        {
            _Mycommand.CommandText = $"INSERT INTO Phone VALUES('{Model}','{Contact}')";
            try
            {
                _Mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return e.Message; 
            }
          
            return "Вы сделали Post()";
        }

        [HttpDelete]
        public string Delete(int Person_ID)
        {
            _Mycommand.CommandText = $"DELETE FROM Phone WHERE [person-id] = {Person_ID}";
            try
            {
                _Mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "Вы сделали Delete()";
        }

        [HttpPut]
        public string Put(int Person_ID, string Model, string Contact)
        {
            _Mycommand.CommandText = $"UPDATE Phone SET[Model] = '{Model}' WHERE [person-id] = {Person_ID} " +
               $"UPDATE Phone SET[Contact] = '{Contact}' WHERE [person-id] = {Person_ID}";
            try
            {
                _Mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "Вы сделали Put()";
        }

    }


  
}
