namespace Swagger.Demo
{
    public class Phone
    {

        public Phone(int Id, string Model, string Contact, int age)
        {
            _Id = Id;
            _Model = Model;
            _Contact = Contact;
        }



        public int _Id { get; set; }
        public string _Model { get; set; }
        public string _Contact { get; set; }
      


    }
}
