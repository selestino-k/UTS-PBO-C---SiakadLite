using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO_C___SiakadLite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("NAMA : SELESTINO B. KROON");
            Console.WriteLine("NIM  : 2006080017");
            Console.WriteLine("UTS PBO C - Siakad Sederhana");
            Console.WriteLine();

        MenuUtama:
            Console.WriteLine("===========================");
            Console.WriteLine("|      MENU UTAMA         |");
            Console.WriteLine("===========================");
            Console.WriteLine("| 1. Mahasiswa            |");
            Console.WriteLine("| 2. Matakuliah           |");
            Console.WriteLine("| 3. Semester             |");
            Console.WriteLine("| 4. Nilai                |");
            Console.WriteLine("===========================");


        Menu:
            Console.Write("Pilih : ");
            string pilihanmenu = Console.ReadLine();
            Console.WriteLine("");
            switch (pilihanmenu)
            {
//Mahasiswa
                case "1":
                Pilihanmhs:
                    Console.WriteLine("Menu Mahasiswa : ");
                    Console.WriteLine("1. Daftar");
                    Console.WriteLine("2. Tambah");
                    Console.WriteLine("3. Edit");
                    Console.WriteLine("4. Hapus");
                    Console.WriteLine("5. Kembali ke Menu Utama");
                    Console.Write("Pilih : ");
                    string plhnmhs = Console.ReadLine();
                    Console.WriteLine("");
                    switch (plhnmhs)
                    {
                        case "1":
                            Mahasiswa.Cetak();
                            Console.WriteLine("");
                            goto Pilihanmhs;

                        case "2":

                        tambahlagi:
                            Console.WriteLine("Tambah Mahasiswa");
                        nim:
                            Console.Write("NIM                  : ");
                            string nim = Console.ReadLine();

                            if (nim.Length != 10)
                            {
                                Console.WriteLine("Panjang NIM harus 10 karakter.");

                                goto nim;
                            }

                            long longNim = 0;

                            if (long.TryParse(nim, out longNim) == false)
                            {
                                Console.WriteLine("NIM harus angka.");

                                goto nim;
                            }
                        nama:
                            Console.Write("Nama                 : ");
                            string nama = Console.ReadLine();

                            if (nama.Length < 5)
                            {
                                Console.WriteLine("Panjang Nama minimal 5 karakter.");

                                goto nama;
                            }

                        jk:

                            Console.WriteLine("Jenis Kelamin : ");
                            Console.WriteLine("1. Laki-laki");
                            Console.WriteLine("2. Perempuan");
                            Console.Write("Masukkan di sini     : ");

                            string jniskel = Console.ReadLine();

                            bool jenisKelamin = new bool();


                            if (jniskel == "1")
                            {
                                jenisKelamin = true;

                            }
                            else if (jniskel == "2")
                            {
                                jenisKelamin = false;
                            }
                            else
                            {
                                Console.WriteLine("Hanya bisa memilih 1 atau 2");
                                goto jk;
                            }

                        angkatan:
                            Console.Write("Angkatan             : ");
                            string angkatan = Console.ReadLine();
                            if (long.TryParse(angkatan, out longNim) == false)
                            {
                                Console.WriteLine("Angkatan harus angka.");

                                goto angkatan;
                            }
                            if (angkatan.Length != 4)
                            {
                                Console.WriteLine("Panjang Angkatan harus 4 karakter.");

                                goto angkatan;
                            }

                            Mahasiswa databaru = new Mahasiswa(nim, nama, jenisKelamin, angkatan);

                        konfirmasi:
                            Console.Write("Apakah anda ingin menambahkan data lagi ? (Y/T) :");
                            string tambah = Console.ReadLine();
                            Console.WriteLine("");
                            if (tambah == "Y")
                            {
                                goto tambahlagi;
                            }
                            else if (tambah == "T")
                            {
                                goto Pilihanmhs;
                            }
                            else
                            {
                                Console.WriteLine("Pilih Y/T");
                                goto konfirmasi;
                            }


                        case "3":
                            Editmhs:
                            Console.WriteLine("Edit");

                            Console.Write("Inputkan NIM mahasiswa yang ingin diubah : ");
                            nim = Console.ReadLine();
                            if (long.TryParse(nim, out longNim) == false)
                            {
                                Console.WriteLine("NIM harus angka.");

                                goto Editmhs;
                            }
                            if (nim.Length != 10)
                            {
                                Console.WriteLine("Panjang NIM harus 10 karakter.");
                                goto Editmhs;
                            }
                            NamaBaru:
                            Console.Write("Masukkan Nama Baru : ");
                            string namabaru = Console.ReadLine();
                            if (namabaru.Length < 5)
                            {
                                Console.WriteLine("Panjang Nama minimal 5 karakter.");
                                goto NamaBaru;
                            }
                            
                           JKBaru: 
                            Console.WriteLine("1. Laki-Laki");
                            Console.WriteLine("2. Perempuan");
                            Console.Write("Masukkan Jenis Kelamin Baru : ");
                            string jnskelbaru = Console.ReadLine();

                            if (jnskelbaru == "1")
                            {
                                jenisKelamin = true;

                            }
                            else if (jnskelbaru == "2")
                            {
                                jenisKelamin = false;
                            }
                            else
                            {
                                Console.WriteLine("Hanya bisa memilih 1 atau 2");
                                goto JKBaru;
                            }
                           AngkatanBaru: 

                            Console.Write("Masukkkan tahun angkatan baru : ");
                            string angkatanBaru = Console.ReadLine();
                            longNim = 0;
                            if (long.TryParse(angkatanBaru, out longNim) == false)
                            {
                                Console.WriteLine("Angkatan harus angka.");
                                goto AngkatanBaru;
                            }
                            if (angkatanBaru.Length != 4)
                            {
                                Console.WriteLine("Panjang Angkatan harus 4 karakter.");
                                goto AngkatanBaru;
                            }

                            Mahasiswa.Edit(nim, namabaru, jenisKelamin, angkatanBaru);
                            goto Pilihanmhs;

                        case "4":
                            Console.WriteLine("Hapus Data");
                        Hapusmahasiswa:
                            Console.Write("Masukan NIM yang akan dihapus : ");
                            nim = Console.ReadLine();
                            if (long.TryParse(nim, out longNim) == false)
                            {
                                Console.WriteLine("NIM harus angka.");

                                goto Hapusmahasiswa;
                            }
                            if (nim.Length != 10)
                            {
                                Console.WriteLine("Panjang NIM harus 10 karakter.");
                                goto Hapusmahasiswa;
                            }
                            Mahasiswa.Hapus(nim);
                        konfirm:
                            Console.Write("Apakah anda ingin menghapus data lagi ? (Y/T) :");
                            string hapus = Console.ReadLine();
                            if (hapus == "Y")
                            {
                                goto Hapusmahasiswa;
                            }
                            else if (hapus == "T")
                            {
                                goto Pilihanmhs;
                            }
                            else
                            {
                                Console.WriteLine("Pilih Y/T");
                                goto konfirm;
                            }
                            goto Pilihanmhs;

                        case "5":
                            goto MenuUtama;

                        default:
                            break;

                    }
                    goto MenuUtama;
//MataKuliah
                case "2":
                PilihanMK:
                    Console.WriteLine("Menu Mata Kuliah : ");
                    Console.WriteLine("1. Daftar");
                    Console.WriteLine("2. Tambah");
                    Console.WriteLine("3. Edit");
                    Console.WriteLine("4. Hapus");
                    Console.WriteLine("5. Kembali Ke Menu Utama");
                    Console.Write("Pilih : ");
                    string plhnmk = Console.ReadLine();
                    Console.WriteLine("");
                    switch (plhnmk)
                    {
                        case "1":
                            MataKuliah.Cetak();
                            Console.WriteLine("");
                            goto PilihanMK;
                        case "2":
                        tambahmk:
                            Console.WriteLine("Tambah Mata Kuliah");
                        kodemk:
                            Console.Write("Kode Mata Kuliah     : ");
                            string kodemk = Console.ReadLine();
                            if (kodemk == null)
                            {
                                goto kodemk;
                            }
                        namamk:
                            Console.Write("Nama Mata Kuliah     : ");
                            string namamk = Console.ReadLine();
                            if (namamk.Length < 3)
                            {
                                Console.WriteLine("Panjang Nama minimal 3 karakter.");
                                goto namamk;
                            }
                        
                            Console.Write("Masukkan Deskripsi   : ");
                            string deskripsi = Console.ReadLine();
                            if (deskripsi == null)
                            {
                                deskripsi = null;
                            }
                        jmlhsks:
                            Console.Write("Masukkan Jumlah SKS  : ");
                            double jumlahsks = double.Parse(Console.ReadLine());
                            
                            if (jumlahsks == 0)
                            {
                                Console.WriteLine("Harap diisi bagian ini");
                                goto jmlhsks;
                            }
                            MataKuliah databaru = new MataKuliah(kodemk, namamk, deskripsi, jumlahsks);

                        konfirmasimk:
                            Console.Write("Apakah anda ingin menambahkan data lagi ? (Y/T) :");
                            
                            string tambah = Console.ReadLine();
                            Console.WriteLine("");
                            if (tambah == "Y")
                            {
                                goto tambahmk;
                               
                            }
                            else if (tambah == "T")
                            {
                                goto PilihanMK;
                            }
                            else
                            {
                                Console.WriteLine("Pilih Y/T");
                                goto konfirmasimk;
                            }
                            
                            goto PilihanMK;

                        case "3":
                            Console.WriteLine("Ubah Data MataKuliah");

                            Console.Write("Inputkan Kode Mata Kuliah yang ingin diubah : ");
                            kodemk = Console.ReadLine();

                        namamkedit:
                            Console.Write("Inputkan Nama MK Baru : ");
                            string namamkbaru = Console.ReadLine();
                            if (namamkbaru.Length < 3)
                            {
                                Console.WriteLine("Panjang Nama MK minimal 3 karakter.");
                                goto namamkedit;
                            }

                            Console.Write("Inputkan Deskripsi Baru : ");
                            string deskbaru = Console.ReadLine();
                            if (deskbaru == "")
                            {
                                deskbaru = null;
                            }

                        sksedit:
                            Console.Write("Inputkan Jumlah SKS Baru : ");
                            double sksbaru = Console.Read();
                            
                           
                            if (sksbaru == 0)
                            {
                                Console.WriteLine("Jumlah SKS harus lebih dari 0");
                                goto sksedit;
                            }
                            Console.WriteLine("Edit Berhasil!");
                            MataKuliah.Edit(kodemk, namamkbaru, deskbaru, sksbaru);
                            goto PilihanMK;

                            goto PilihanMK;
                        case "4":
                            Console.WriteLine("Hapus Mata Kuliah");
                        Hapusmk:
                            Console.Write("Masukan Kode Mata Kuliah yang akan dihapus: ");
                            kodemk = Console.ReadLine();
                            MataKuliah.Hapus(kodemk);

                        konfirmmk:
                            Console.Write("Apakah anda ingin menghapus data lagi ? (Y/T) :");
                            string hapus = Console.ReadLine();
                            if (hapus == "Y" )
                            {
                                goto Hapusmk;
                            }
                            else if (hapus == "T" )
                            {
                                goto PilihanMK;
                            }
                            else
                            {
                                Console.WriteLine("Pilih ya/tidak");
                                goto konfirmmk;
                            }
                            goto PilihanMK;

                        case "5":
                            goto MenuUtama;

                        default:
                            break;
                    }
                    goto MenuUtama;
//Semester
                case "3":
                PilihanSem:
                    Console.WriteLine("Menu Semester : ");
                    Console.WriteLine("1. Daftar");
                    Console.WriteLine("2. Tambah");
                    Console.WriteLine("3. Edit");
                    Console.WriteLine("4. Hapus");
                    Console.WriteLine("5. Kembali Ke Menu Utama");
                    Console.Write("Pilih : ");
                    string plhnsem = Console.ReadLine();
                    Console.WriteLine("");
                    switch (plhnsem)
                    {
                        case "1":
                            Semester.Cetak();
                            Console.WriteLine("");
                            goto PilihanSem;
                        case "2":
                        tambahsmstr:
                            Console.WriteLine("Tambah Semester");
                        
                            Console.Write("ID Semester      : ");
                            int idsmstr = int.Parse(Console.ReadLine());
                        
                            Console.Write("Nama Semester    : ");
                            string namasmstr = Console.ReadLine();

                            Semester databaru = new Semester(idsmstr, namasmstr);
                        konfirmasismstr:
                            Console.Write("Apakah anda ingin menambahkan data lagi ? (Y/T) :");
                            Console.WriteLine("");
                            string tambah = Console.ReadLine();
                            if (tambah == "Y")
                            {
                                goto tambahsmstr;
                            }
                            else if (tambah == "T")
                            {
                                goto PilihanSem;
                            }
                            else
                            {
                                Console.WriteLine("Pilih Y/T");
                                goto konfirmasismstr;
                            }
                            goto PilihanSem;

                        case "3":
                            Console.WriteLine("Ubah Data Semester");
                            Console.Write("Inputkan ID Semester yang ingin diubah : ");
                            idsmstr = int.Parse(Console.ReadLine());

                            Console.Write("Inputkan Nama Semester Baru : ");
                            string nsbaru = Console.ReadLine();

                            Semester.Edit(idsmstr, nsbaru);

                            goto PilihanSem;

                        case "4":
                            Console.WriteLine("Hapus Semester");
                        Hapussmstr:
                            Console.Write("Masukan ID Semester yang akan dihapus: ");
                            idsmstr = int.Parse(Console.ReadLine());
                            Semester.Hapus(idsmstr);

                        konfirmstr:
                            Console.Write("Apakah anda ingin menghapus data lagi ? (Y/T) :");
                            string hapus = Console.ReadLine();
                            Console.WriteLine("");
                            if (hapus == "Y" )
                            {
                                goto Hapussmstr;
                            }
                            else if (hapus == "T")
                            {
                                goto PilihanSem;
                            }
                            else
                            {
                                Console.WriteLine("Pilih Y (Ya) atau T (Tidak)!");
                                goto konfirmstr;
                            }

                            goto PilihanSem;
                            goto PilihanSem;
                        case "5":
                            goto MenuUtama;
                        default:
                            break;

                    }
                    goto MenuUtama;

//Nilai
                case "4":
                PilihanNilai:
                    Console.WriteLine("Menu Nilai : ");
                    Console.WriteLine("1. Daftar");
                    Console.WriteLine("2. Tambah");
                    Console.WriteLine("3. Edit");
                    Console.WriteLine("4. Hapus");
                    Console.WriteLine("5. Kembali Ke Menu Utama");
                    Console.Write("Pilih : ");
                    string plhnnli = Console.ReadLine();
                    Console.WriteLine("");
                    switch (plhnnli)
                    {
                        case "1":
                            Nilai.Cetak();
                            Console.WriteLine("");
                            goto PilihanNilai;

                        case "2":
                        tambahnilai:
                            Console.WriteLine("Tambah Data Nilai");

                            Console.Write("ID Semester      : ");
                            int idsmstrnilai = int.Parse(Console.ReadLine());

                            Console.Write("Kode Mata Kuliah : ");
                            string kodemknilai = Console.ReadLine();

                        nimnilai:
                            Console.Write("NIM          : ");
                            string nim = Console.ReadLine();
                            if (nim.Length != 10)
                            {
                                Console.WriteLine("Panjang NIM harus 10 karakter.");
                                goto nimnilai;
                            }
                            long longNim = 0;
                            if (long.TryParse(nim, out longNim) == false)
                            {
                                Console.WriteLine("NIM harus angka.");
                                goto nimnilai;
                            }

                        nilaiangka:
                            Console.Write("Nilai Angka  : ");
                            double nilaiangka = double.Parse(Console.ReadLine());
                            if (nilaiangka <= 0)
                            {
                                Console.WriteLine("Inputan salah");
                                goto nilaiangka;
                            }

                        nilaihuruf:
                            Console.Write("Nilai Huruf  : ");
                            string nilaihuruf = Console.ReadLine();
                            if (nilaihuruf == "")
                            {
                                Console.WriteLine("Harap diisi");
                                goto nilaihuruf;
                            }

                            Nilai databaru = new Nilai(idsmstrnilai, kodemknilai, nim, nilaiangka, nilaihuruf);

                        konfirmasinilai:
                            Console.Write("Apakah anda ingin menambahkan data lagi ? (Y/T) :");
                            string tambah = Console.ReadLine();
                            Console.WriteLine("");
                            if (tambah == "Y")
                            {
                                goto tambahnilai;
                            }
                            else if (tambah == "T")
                            {
                                goto PilihanNilai;
                            }
                            else
                            {
                                Console.WriteLine("Pilih Y (Ya) atau T (Tidak)!");
                                goto konfirmasinilai;
                            }
                            goto PilihanNilai;

                        case "3":
                       
                            Console.WriteLine("Ubah Data Nilai");

                            Console.Write("Masukkan NIM : ");
                            nim = Console.ReadLine();

                            Console.Write("Masukkan ID Semester : ");
                            idsmstrnilai = int.Parse(Console.ReadLine());

                            Console.Write("Masukkan Kode MK : ");
                            kodemknilai = Console.ReadLine();

                        angkaubah:
                            Console.Write("Masukkan Nilai Angka Baru : ");
                            double angkabaru = double.Parse(Console.ReadLine());
                            if (angkabaru <= 0)
                            {
                                Console.WriteLine("Inputan Salah");
                                goto angkaubah;
                            }

                        hurufbaru:
                            Console.Write("Masukkan Nilai Huruf Baru : ");
                            string hurufbaru = Console.ReadLine();
                            if (hurufbaru == "")
                            {
                                Console.WriteLine("Harap diisi");
                                goto hurufbaru;
                            }

                            Nilai.Edit(idsmstrnilai, kodemknilai, nim, angkabaru, hurufbaru);

                            goto PilihanNilai;

                        case "4":
                        hapusnilailagi:
                            Console.WriteLine("Hapus Nilai");

                        Hapusnilai:
                            Console.Write("Masukkan NIM : ");
                            nim = Console.ReadLine();

                            Console.Write("Masukkan ID Semester : ");
                            idsmstrnilai = int.Parse(Console.ReadLine());

                            Console.Write("Masukkan Kode MK : ");
                            kodemknilai = Console.ReadLine();

                            Nilai.Hapus(nim, idsmstrnilai, kodemknilai);

                        konfirmnilai:
                            Console.Write("Apakah anda ingin menghapus data lagi ? (Y/T) :");
                            Console.WriteLine("");
                            string hapus = Console.ReadLine();
                            if (hapus == "Y" )
                            {
                                goto hapusnilailagi;
                            }
                            else if (hapus == "T")
                            {
                                goto PilihanNilai;
                            }
                            else
                            {
                                Console.WriteLine("Pilih Y (Ya) atau T (Tidak)!");
                                goto konfirmnilai;
                            }
                           

                            goto PilihanNilai;
                            goto PilihanNilai;
                        case "5":

                            goto MenuUtama;

                        default:
                            break;
                    }
                    goto Menu;



            }

        }
        internal class Mahasiswa
        {
            public string Nim { get; set; } //Key
            public string Nama { get; set; }
            public bool JenisKelamin { get; set; }
            public string Angkatan { get; set; }

            private static List<Mahasiswa> ListMahasiwa = new List<Mahasiswa>();

            public Mahasiswa(string nim, string nama, bool jenisKelamin, string angkatan)
            {
                var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

                if (mahasiswa != null)
                {
                    Console.WriteLine("Mahasiswa dengan nim : {0} sudah ada.", nim);

                    return;
                }

                Nim = nim;
                Nama = nama;
                JenisKelamin = jenisKelamin;
                Angkatan = angkatan;

                ListMahasiwa.Add(this);
            }

            public static void Cetak()
            {
                Console.WriteLine("Daftar Mahasiswa");

                if (ListMahasiwa.Count == 0)
                {
                    Console.WriteLine("Belum ada data.");

                    return;
                }

                for (int i = 0; i < ListMahasiwa.Count; i++)
                {
                    var mahasiswa = ListMahasiwa[i];
                    string strJk = mahasiswa.JenisKelamin == true ? "Laki-laki" : "Perempuan";
                    Console.WriteLine("{0}. NIM : {1}, Nama : {2}, JK : {3}, Angkatan : {4}", i + 1, mahasiswa.Nim, mahasiswa.Nama, strJk, mahasiswa.Angkatan);
                }
            }

            public static void Edit(string nim, string namaBaru, bool jkBaru, string angkatanBaru)
            {
                var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

                if (mahasiswa != null)
                {
                    mahasiswa.Nama = namaBaru;
                    mahasiswa.JenisKelamin = jkBaru;
                    mahasiswa.Angkatan = angkatanBaru;
                }
            }

            public static void Edit(Mahasiswa newData)
            {

                var mahasiswa = ListMahasiwa.Find(x => x.Nim == newData.Nim);

                if (mahasiswa != null)
                {
                    mahasiswa.Nama = newData.Nama;
                    mahasiswa.JenisKelamin = newData.JenisKelamin;
                    mahasiswa.Angkatan = newData.Angkatan;
                }
            }

            public static void Hapus(string nim)
            {
                var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

                if (mahasiswa != null)
                {
                    ListMahasiwa.Remove(mahasiswa);
                    Console.WriteLine("Data telah dihapus");
                }
                else
                {
                    Console.WriteLine("NIM tidak ditemukan. Tidak ada data yang dihapus.");
                }
            }


        }
        internal class MataKuliah
        {
            public string KodeMataKuliah { get; set; } //Key
            public string NamaMataKuliah { get; set; }
            public string Deskripsi { get; set; }
            public double JumlahSks { get; set; }

            private static List<MataKuliah> ListMataKuliah = new List<MataKuliah>();

            public MataKuliah(string kodeMataKuliah, string namaMataKuliah, string deskripsi, double jumlahSks)
            {
                var matakuliah = ListMataKuliah.Find(y => y.KodeMataKuliah == kodeMataKuliah);

                if (matakuliah != null)
                {
                    Console.WriteLine("Mata Kuliah dengan kode : {0} sudah ada.", kodeMataKuliah);

                    return;
                }

                KodeMataKuliah = kodeMataKuliah;
                NamaMataKuliah = namaMataKuliah;
                Deskripsi = deskripsi;
                JumlahSks = jumlahSks;

                ListMataKuliah.Add(this);
            }

            public static void Cetak()
            {
                Console.WriteLine("Daftar Mata Kuliah");
                for (int i = 0; i < ListMataKuliah.Count; i++)
                {
                    var matakuliah = ListMataKuliah[i];
                    Console.WriteLine("Kode MK : {0}, Nama MK : {1}, Deskripsi : {2}, Jumlah Sks : {3}", matakuliah.KodeMataKuliah, matakuliah.NamaMataKuliah, matakuliah.Deskripsi, matakuliah.JumlahSks);
                }
                if (ListMataKuliah.Count == 0)
                {
                    Console.WriteLine("Belum ada data Mata Kuliah");
                    return;
                }
            }

            public static void Edit(string kodeMataKuliah, string namaMataKuliahBaru, string deskripsiBaru, double jumlahSksBaru)
            {
                var matakuliah = ListMataKuliah.Find(y => y.KodeMataKuliah == kodeMataKuliah);

                if (matakuliah != null)
                {
                    matakuliah.NamaMataKuliah = namaMataKuliahBaru;
                    matakuliah.Deskripsi = deskripsiBaru;
                    matakuliah.JumlahSks = jumlahSksBaru;
                }
            }

            public static void Edit(MataKuliah newData)
            {
                var matakuliah = ListMataKuliah.Find(y => y.KodeMataKuliah == newData.KodeMataKuliah);

                if (matakuliah != null)
                {
                    matakuliah.NamaMataKuliah = newData.NamaMataKuliah;
                    matakuliah.Deskripsi = newData.Deskripsi;
                    matakuliah.JumlahSks = newData.JumlahSks;
                }
            }

            public static void Hapus(string kodeMataKuliah)
            {
                var matakuliah = ListMataKuliah.Find(y => y.KodeMataKuliah == kodeMataKuliah);

                if (matakuliah != null)
                {
                    ListMataKuliah.Remove(matakuliah);
                }
            }
        }
        internal class Semester
        {
            public int IdSemester { get; set; } //Key
            public string NamaSemester { get; set; }

            private static List<Semester> ListSemester = new List<Semester>();

            public Semester(int idSemester, string namaSemester)
            {
                var semester = ListSemester.Find(z => z.IdSemester == idSemester);

                if (semester != null)
                {
                    Console.WriteLine("Semester dengan ID : {0} sudah ada.", idSemester);

                    return;
                }

                IdSemester = idSemester;
                NamaSemester = namaSemester;


                ListSemester.Add(this);
            }

            public static void Cetak()
            {
                Console.WriteLine("Daftar Semester");
                for (int i = 0; i < ListSemester.Count; i++)
                {
                    var semester = ListSemester[i];
                    Console.WriteLine("ID Semester : {0}, Nama Semester : {1}", semester.IdSemester, semester.NamaSemester);
                }
                if (ListSemester.Count == 0)
                {
                    Console.WriteLine("Belum ada data semester.");
                    return;
                }
            }

            public static void Edit(int idSemester, string namaSemesterBaru)
            {
                var semester = ListSemester.Find(z => z.IdSemester == idSemester);

                if (semester != null)
                {
                    semester.NamaSemester = namaSemesterBaru;
                }
            }

            public static void Edit(Semester newData)
            {
                var semester = ListSemester.Find(z => z.IdSemester == newData.IdSemester);

                if (semester != null)
                {
                    semester.NamaSemester = newData.NamaSemester;
                }
            }

            public static void Hapus(int idSemester)
            {
                var semester = ListSemester.Find(z => z.IdSemester == idSemester);

                if (semester != null)
                {
                    ListSemester.Remove(semester);
                }
            }
        }

        internal class Nilai
        {
            public int IdSemester { get; set; } //Key
            public string KodeMataKuliah { get; set; } //Key
            public string Nim { get; set; } //Key
            public double NilaiAngka { get; set; }
            public string NilaiHuruf { get; set; }

            private static List<Nilai> ListNilai = new List<Nilai>();

            public Nilai(int idSemester, string kodeMataKuliah, string nim, double nilaiAngka, string nilaiHuruf)
            {
                var nilai = ListNilai.Find(w => w.Nim == nim);

                if (nilai != null)
                {
                    Console.WriteLine("NIM : {0} di mk : {1} pada semester : {2} sudah ada nilai.", nim, kodeMataKuliah, idSemester);
                    return;
                }

                IdSemester = idSemester;
                KodeMataKuliah = kodeMataKuliah;
                Nim = nim;
                NilaiAngka = nilaiAngka;
                NilaiHuruf = nilaiHuruf;


                ListNilai.Add(this);
            }
            public static void Cetak()
            {
                Console.WriteLine("Daftar Nilai");
                for (int i = 0; i < ListNilai.Count; i++)
                {
                    var nilai = ListNilai[i];
                    Console.WriteLine("ID Semester : {0}, Kode MK : {1}, NIM : {2}, Nilai Angka : {3}, Nilai Huruf : {4}", nilai.IdSemester, nilai.KodeMataKuliah, nilai.Nim, nilai.NilaiAngka, nilai.NilaiHuruf);
                }
                if (ListNilai.Count == 0)
                {
                    Console.WriteLine("Belum ada daftar nilai.");
                    return;
                }
            }

            public static void Edit(int idSemester, string kodeMataKuliah, string nim, double nilaiAngkaBaru, string nilaiHurufBaru)
            {
                var nilai = ListNilai.Find(w => w.Nim == nim);

                if (nilai != null)
                {
                    nilai.NilaiAngka = nilaiAngkaBaru;
                    nilai.NilaiHuruf = nilaiHurufBaru;
                }
            }

            public static void Edit(Nilai newData)
            {
                var nilai = ListNilai.Find(w => w.Nim == newData.Nim);

                if (nilai != null)
                {
                    nilai.NilaiAngka = newData.NilaiAngka;
                    nilai.NilaiHuruf = newData.NilaiHuruf;
                }
            }

            public static void Hapus(string nim, int idSemester, string kodeMataKuliah)
            {
                var nilai = ListNilai.Find(w => w.Nim == nim && w.IdSemester == idSemester && w.KodeMataKuliah == kodeMataKuliah);

                if (nilai != null)
                {
                    ListNilai.Remove(nilai);
                }
            }

        }
    }
}
