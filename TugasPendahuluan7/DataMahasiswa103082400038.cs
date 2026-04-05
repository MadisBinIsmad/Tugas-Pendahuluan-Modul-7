using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace TugasPendahuluan7
{
    class DataMahasiswa103082400038
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("tp7_1_103082400038.json");

            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(json);

            Console.WriteLine(
                "Nama " + data.nama.depan + " " + data.nama.belakang +
                " dengan nim " + data.nim +
                " dari fakultas " + data.fakultas
            );
        }
    }
}
