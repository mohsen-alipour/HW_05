public class Person
{
    public string Name { get; set; }
    public string Family { get; set; }
   
    public string CodeMeli { get; set; }

    public Person(string N, string F, string C)
    {
        Name = N;
        Family = F;
        CodeMeli = C;
    }
    public Person()
    {
      
    }

}


