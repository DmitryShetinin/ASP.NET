namespace Swagger.Demo
{
    public class Person
    {



        public Person(int id, string Name, string Surname, int age)
        {
            _Id = id;
            _Name = Name;
            _Surname = Surname; 
            _age = age;
        }


 
        public int _Id { get; set; }
        public string _Name { get; set; }
        public string _Surname { get; set; }
        public int _age { get; set; }

     
    }
}
