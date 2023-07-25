namespace TechShop
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public Student(int id,string name,int age)
        {
            Id= id;
            Age = age;  
            Name = name;    
            
        }
    }
}
