namespace MongoCrudApi.DataTypes
{
    public class ExamplePerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Salary { get; set; }
        public ExamplePerson[] Colleagues { get; set; } = Array.Empty<ExamplePerson>();

    }
}
