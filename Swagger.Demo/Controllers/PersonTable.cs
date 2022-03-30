using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.OleDb;



namespace Swagger.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonTable : Connected_to_BD
    {
    
     

        [HttpGet]
        public List<Person> Get()
        {
            _Mycommand.CommandText = "SELECT *FROM Person";
            OleDbDataReader reader = _Mycommand.ExecuteReader();
            List<Person> result = new List<Person>();

            while (reader.Read())
            {
                result.Add(new Person((int)reader[0], (string)reader[1],(string)reader[2],(int)reader[3])); 
            }
            return result; 
        }   

        [HttpPost]
        public string Post(string Name, string Surname, int age )
        {
            _Mycommand.CommandText = $"INSERT INTO PERSON VALUES('{Name}','{Surname}','{age}')";
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
        public string Delete(int ID)
        {
            _Mycommand.CommandText = $"DELETE FROM PERSON WHERE ID = {ID}";
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
        public string Put(int ID, string Name, string Surname, int age)
        {
            _Mycommand.CommandText = $"UPDATE PERSON SET[Name] = '{Name}' WHERE [id] = {ID} " +
                $"UPDATE PERSON SET[Surname] = '{Surname}' WHERE [id] = {ID} " +
                $"UPDATE PERSON SET[age] = '{age}' WHERE [id] = {ID}";
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
            