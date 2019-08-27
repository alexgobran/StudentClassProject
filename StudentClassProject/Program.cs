using System;

namespace StudentClassProject {
    class Program {
        static void Main(string[] args) {
            //Setting properties have to put (name of variable.property = Script)

            var Lidya = new Student();
            Lidya.FirstName = "lidya";
            Lidya.LastName = "Tsegay";
            Lidya.SetFinalGrade(98);
            var FullName = Lidya.GetFullName();
            Console.WriteLine("Lidya's Full Name Is " + FullName);

            var Justin = new Student();
            Justin.FirstName = "Justin";
            Justin.LastName = "Dudley";
            Justin.SetFinalGrade(99);
            FullName = Justin.GetFullName();
            Console.WriteLine($"{FullName}");

            var Nick = new Student();
            Nick.FirstName = "Nick";
            Nick.LastName = "Baker";
            Nick.SetFinalGrade(99);
                      Console.WriteLine($"{Nick.FirstName} {Nick.LastName}");

        }

        
    }
}
