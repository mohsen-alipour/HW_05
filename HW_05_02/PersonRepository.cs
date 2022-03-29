public class PersonRepository : IPersonRepository
{
    string s1 = "D:\\Course .Net\\TamrinMustResolve\\HW_05\\ConsoleApp\\HW_05_02\\File.txt";

    //-------
    public void CreatePerson(Person person)
    {

        
        File.AppendAllText(s1, $"\n{person.Name}-{person.Family}-{person.CodeMeli}");
        Console.WriteLine("Create Person is ok");
    }

    //--------------
    public void DeletePerson(string codemeli)
    {
        var line = System.IO.File.ReadAllLines(s1);

        var person1 = line.Select(p => new Person()
        {
        Name=p.Split('-')[0].Trim(),
        Family = p.Split('-')[1].Trim(),
        CodeMeli = p.Split('-')[2].Trim()
        }).ToList();

        if (person1.Any(P => P.CodeMeli == codemeli))
        {
        var per2 = person1.FirstOrDefault(P => P.CodeMeli == codemeli);
        person1.Remove(per2);

        File.WriteAllText(s1, string.Empty);
            foreach (var item in person1)
            {
             File.AppendAllText(s1, $"{item.Name}-{item.Family}-{item.CodeMeli}\n");       
            }
        }
        else Console.WriteLine("there is not peroson whith this CodeMeli");

        Console.WriteLine("Delete is complate");

    }

    //-------------

    public Person ReadPerson(string code)
    {
        var line = System.IO.File.ReadAllLines(s1);

        var person1 = line.Select(p => new Person()
        {
            Name = p.Split('-')[0].Trim(),
            Family = p.Split('-')[1].Trim(),
            CodeMeli = p.Split('-')[2].Trim()
        }).ToList();
        Person? per3 = person1.FirstOrDefault(P => P.CodeMeli == code);
        return per3;
    }

}
