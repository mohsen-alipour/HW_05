string f1 = "File1.txt";
string f2 = $"D:\\Course .Net\\TamrinMustResolve\\HW_05\\ConsoleApp\\HW_05\\Archive\\{f1}";
string Dir= "D:\\Course .Net\\TamrinMustResolve\\HW_05\\ConsoleApp\\HW_05\\Archive";
DirectoryInfo D = new DirectoryInfo(Dir);
try
{

    if (Directory.Exists(Dir) && (D.Attributes == FileAttributes.ReadOnly))
    {
        if (File.Exists(f2) )
        {
            Console.WriteLine("the File is Exist And can not File Copy");
            throw new Exception();
        }
        else
        {
            File.Copy(f1, f2);
            Console.WriteLine("Copy File is complate");
        }
    }
    else
    {
        Console.WriteLine("there is not or readonly Directory and Plese Create Directory");
        throw new Exception();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    
}




