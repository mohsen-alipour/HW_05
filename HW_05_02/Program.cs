IPersonRepository _IPR = new PersonRepository();
Console.WriteLine("Press C for Create Person");
Console.WriteLine("Press R for Create Person");
Console.WriteLine("Press D for Create Person");
Console.WriteLine("Press e for Exit");
var k= Console.ReadLine();
switch (k.ToLower())

{
    case "c":
        {
            Console.WriteLine("enter person Name");
            var N = Console.ReadLine();
            Console.WriteLine("enter person Family");
            var F = Console.ReadLine();
            Console.WriteLine("enter person CodeMeli");
            var C = Console.ReadLine();
            Person p = new Person(N, F, C);
            _IPR.CreatePerson(p);
        }
        break;
    case "r":
        {
            Console.WriteLine("Please Enter CodeMeli For Read");
            var R = Console.ReadLine();
            var pe = _IPR.ReadPerson(R);
            Console.WriteLine($"{pe.Name}-{pe.Family}-{pe.CodeMeli}");
        }
        break;
    case "d":
        {
            Console.WriteLine("Please Enter CodeMeli For Delete");
            var P = Console.ReadLine();
            _IPR.DeletePerson(P);
            
        }
        break;
    case "e":
        
        break;

}

   









