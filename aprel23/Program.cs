using aprel23.Models;
using System;

namespace aprel23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Exam> exams = new List<Exam>
            {   new Exam { Subject = "geography" , ExamDuration = 1},
                new Exam { Subject = "Physics", ExamDuration = 2 },
                new Exam { Subject = "Math", ExamDuration = 3},
                new Exam { Subject = "Chemistry", ExamDuration = 4 }
            };

            DateTime lastWeek= DateTime.Now.AddDays(-7);
            var lastWeekExams= exams.Where(e => e.StartDate >= lastWeek);
            Console.WriteLine("Son 1 heftede olan imtahanlar:");
            //foreach (var exam in exams)
            //{
            //    Console.WriteLine($"{exam.Subject}: {exam.ExamDuration}");
            //}
            ShowExams(exams);


            var longExams = exams.Where(e => e.ExamDuration > 2);
            Console.WriteLine("2 saatdan cox ceken imtahanlar");
            ShowExams(longExams);


            var nowExams=exams.Where(e => e.StartDate <= DateTime.Now && DateTime.Now <=e.EndDate);
            Console.WriteLine("hal-hazirda davam eden imtahanlar:");
            ShowExams(nowExams);




            //    List<Person> people = new List<Person>
            //{
            //    new Person { Name = "Inara", Surname = "Ahmadova", Age = 20 },
            //    new Person { Name = "Fatima", Surname = "Abbasova", Age = 21 },
            //    new Person { Name = "Nargiz", Surname = "Nabiyeva", Age = 18 },
            //    new Person { Name = "Turkan", Surname = "Mammadova", Age = 22 },
            //    new Person { Name = "Mahir", Surname = "Musayev", Age = 22 },
            //    new Person { Name = "Mehman", Surname = "Hesenov", Age = 22 }

            //};
            //    List<Person> inarapeople = people.FindAll(p => p.Name == "Inara");
            //    Console.WriteLine("Adi Inara olanlar:");
            //    foreach (var p in inarapeople)
            //    {
            //        Console.WriteLine($"{p.Name} {p.Surname}");
            //    }
            //    List<Person> surnamePeople = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            //    Console.WriteLine("Soyadi 'ov' ve 'ova' ile bitenler:");
            //    foreach (var p in surnamePeople)
            //    {
            //        Console.WriteLine($"{p.Name} {p.Surname}");
            //    }
            //    List<Person> over20Age = people.FindAll(p => p.Age > 20);
            //    Console.WriteLine("Yashi 20-den boyuk olanlar:");
            //    foreach(var p in over20Age)
            //    {
            //        Console.WriteLine($"{p.Name} {p.Surname}, {p.Age} yash");
            //    }


            #region sinifdeki yazilar
            //thread t1 = new thread(increase);
            //thread t2 = new thread(decrease);
            //t1.start();
            //t2.start();
            //t1.join();
            //console.writeline(num);
            //static void increase()
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        num++;
            //    }
            //}
            //static void decrease()
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        num--;
            //    }
            //}
            //static void boilsausageasync()
            //{
            //    thread.sleep(5000);
            //    console.writeline("sausage boiled");
            //}
            //static void preparateaasync()
            //{
            //    console.writeline("caydani doldur");
            //    thread.sleep(3000);
            //    console.writeline("su qaynadi,cay demlemdi");
            //    console.writeline("cay hazirdir");
            //}
            //static void sufrehazirlaasync()
            //{

            //}
            //static void boilsausage()
            //{
            //    thread.sleep(5000);
            //    console.writeline("sausage boiled");
            //}
            //static void preparatea()
            //{
            //    console.writeline("caydani doldur");
            //    thread.sleep(3000);
            //    console.writeline("su qaynadi,cay demlendi");
            //    console.writeline("cay hazirdir");
            //}
            #endregion
        }
        static void ShowExams(IEnumerable<Exam> examList)
        {
            foreach (var exam in examList)
            {
                Console.WriteLine( $"Subject: {exam.Subject}, Duration: {exam.ExamDuration} hours");
            }
        }
    }
}
