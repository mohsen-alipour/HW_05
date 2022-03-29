public interface IPersonRepository
{
    void CreatePerson(Person person);
    Person? ReadPerson(string codemeli);
    void DeletePerson(string codemeli);
    //string UbdatePerson(string codemeli);

}