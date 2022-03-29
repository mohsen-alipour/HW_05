public class Person03
{
    public int id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Birthday { get; set; }

    public int CodeMeli { get; set; }

    public string Aderess { get; set; }


    public Person03(int personid, string personame,int age,int Birth,int code,string add)
    {
        id = personid;
        Name = personame;
        Age = age;
        Birthday = Birth;
        CodeMeli = code;
        Aderess = add;
    }
    //public Person03()
    //{

    //}

}