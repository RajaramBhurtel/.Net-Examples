class Student
{
    public int sid { get; set; }
    public string name { get; set; }
    public string address { get; set; }

    public Student(int sid, string name, string address)
    {
        this.sid = sid;
        this.name = name;
        this.address = address;
    }
}

class LinqTest
{
    static void Main(string[] args)
    {
        List<Student> mylist = new List<Student>(){
            new Student(1,"Ram","Btm"),
            new Student(2, "Hari", "Ktm"),
            new Student(3,"Shyam","Btm"),
            new Student(4, "Gita", "Ktm")
        };

        var result = mylist.Where(s => s.address.Equals("Btm") && s.sid.Equals(1));

        Console.WriteLine("Sid\tName\tAddress");
        foreach (var res in result)
        {
            Console.WriteLine(res.sid + "\t" + res.name + "\t" + res.address);
        }
        Console.ReadLine();
    }
}