using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;


namespace TugasPendahuluan7
{
    class KuliahMahasiswa103082400038
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Root
        {
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("tp7_2_103082400038.json");

            Root data = JsonSerializer.Deserialize<Root>(json);

            Console.WriteLine("Daftar mata kuliah yang diambil:");

            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine("MK " + i + " " + course.code + " - " + course.name);
                i++;
            }
        }
    }
}
