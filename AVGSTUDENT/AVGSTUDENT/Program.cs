// See https://aka.ms/new-console-template for more information
using AVGSTUDENT;

namespace WorkAVGSTUDENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "นุ";
            student1.weight = 66.2f;

            Student student2 = new Student();
            student2.name = "ติณ";
            student2.weight = 54.1f;

            Student student3 = new Student();
            student3.name = "แบม";
            student3.weight = 50.1f;

            Student student4 = new Student();
            student4.name = "เปียโน";
            student4.weight = 43.5f;

            Student student5 = new Student();
            student5.name = "โอ๊ต";
            student5.weight = 53.1f;

            float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
            Console.WriteLine("น้ำหนักเฉลี่ยของนักเรียน 5 คน : " + avgWeight);
            Console.WriteLine("น้ำหนักของเพื่อนที่มากที่สุด : " + student1.name + student1.weight);
            Console.WriteLine("น้ำหนักของเพื่อนที่น้อยที่สุด : " + student4.name + student4.weight);
            Console.WriteLine("นาย ถิรวัฒน์ โชติธนกิจไพศาล 653450090-6");
        }
    }

}