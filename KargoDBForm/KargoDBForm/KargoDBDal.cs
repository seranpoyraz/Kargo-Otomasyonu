using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    class KargoDBDal
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J80F3DV;Initial Catalog=KargoDB;Integrated Security=True");

        public void ConnectionControl()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public bool KullaniciGirisi(Kullanicilar kullanici, YonetimPaneli menuForm, Label lbl)
        {
            ConnectionControl();
            bool durum;

            SqlCommand command = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi=@kullaniciadi AND Sifre=@sifre", conn);
            command.Parameters.AddWithValue("kullaniciadi", kullanici.KullaniciAdi);
            command.Parameters.AddWithValue("sifre", kullanici.Sifre);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                menuForm.Show();
                durum = true;
            }

            else
            {
                lbl.Text = "Kullanıcı adı veya şifreniz hatalı!";
                durum = false;
            }



            reader.Close();
            conn.Close();

            return durum;

        }

        //Get
        public List<Musteriler> GetMusteriler()
        {

            ConnectionControl();


            SqlCommand command = new SqlCommand("SELECT * FROM Musteriler", conn);

            SqlDataReader reader = command.ExecuteReader();

            List<Musteriler> Musteri = new List<Musteriler>();

            while (reader.Read())
            {
                Musteriler m = new Musteriler(Convert.ToInt32(reader["MusteriID"]), reader["Ad"].ToString(), reader["Soyad"].ToString(), reader["Adres"].ToString(), reader["Telefon"].ToString());
                Musteri.Add(m);

            }

            reader.Close();
            conn.Close();
            return Musteri;
        }

        public List<KargoTuru> GetKargoTurleri()
        {
            ConnectionControl();


            SqlCommand command = new SqlCommand("SELECT * FROM KargoTuru", conn);

            SqlDataReader reader = command.ExecuteReader();

            List<KargoTuru> KargoTuru = new List<KargoTuru>();

            while (reader.Read())
            {
                KargoTuru kt = new KargoTuru(Convert.ToInt32(reader["KargoTuruID"]), reader["Icerik"].ToString());
                KargoTuru.Add(kt);

            }

            reader.Close();
            conn.Close();
            return KargoTuru;
        }

        public List<Subeler> GetSubeler()
        {
            ConnectionControl();


            SqlCommand command = new SqlCommand("SELECT * FROM Subeler", conn);

            SqlDataReader reader = command.ExecuteReader();

            List<Subeler> Sube = new List<Subeler>();

            while (reader.Read())
            {
                Subeler s = new Subeler(Convert.ToInt32(reader["SubeID"]), reader["Ad"].ToString(), reader["Telefon"].ToString(), reader["Adres"].ToString());
                Sube.Add(s);

            }

            reader.Close();
            conn.Close();
            return Sube;
        }

        public List<Kuryeler> GetKuryeler()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Kuryeler", conn);

            SqlDataReader reader = command.ExecuteReader();

            List<Kuryeler> Kurye = new List<Kuryeler>();

            while (reader.Read())
            {
                Kuryeler k = new Kuryeler(Convert.ToInt32(reader["KuryeID"]), Convert.ToInt32(reader["SubeID"]), reader["Ad"].ToString(), reader["Soyad"].ToString());
                Kurye.Add(k);

            }

            reader.Close();
            conn.Close();
            return Kurye;

        }

        public List<KHareketleriJoin> GetKargoHareketleri()
        {
            ConnectionControl();
            //SqlCommand command = new SqlCommand("SELECT * FROM KargoHareketleri", conn);
            SqlCommand command = new SqlCommand("SELECT kh.HareketID AS [HareketID],kargo.KargoID AS [KargoID],gonderici.Ad+' '+Gonderici.Soyad AS [Gönderici],Alici.Ad+' '+Alici.Soyad AS [Alıcı],convert (char, Kargo.TeslimTarih) AS [Teslim Tarihi], kh.KuryeID,Kuryeler.Ad+' '+Kuryeler.Soyad AS [Kurye Ad Soyad],Subeler.SubeID,Subeler.Ad AS [Şube Adı],kh.Durum FROM Kargo INNER JOIN Musteriler Gonderici ON kargo.GondericiID=gonderici.MusteriID INNER JOIN Musteriler Alici ON kargo.AliciID=alici.MusteriID INNER JOIN KargoHareketleri KH ON KH.KargoID=Kargo.KargoID INNER JOIN Kuryeler ON kh.KuryeID=Kuryeler.KuryeID INNER JOIN Subeler ON Kuryeler.SubeID=Subeler.SubeID", conn);


            SqlDataReader reader = command.ExecuteReader();

            List<KHareketleriJoin> Hareket = new List<KHareketleriJoin>();

            while (reader.Read())
            {
                KHareketleriJoin h = new KHareketleriJoin(Convert.ToInt32(reader["HareketID"]), Convert.ToInt32(reader["KargoID"]), reader["gönderici"].ToString(), reader["Alıcı"].ToString(), Convert.ToDateTime(reader["Teslim Tarihi"]), Convert.ToInt32(reader["KuryeID"]), reader["Kurye Ad Soyad"].ToString(), Convert.ToInt32(reader["SubeID"]), reader["Şube Adı"].ToString(), reader["Durum"].ToString());
                Hareket.Add(h);

            }

            reader.Close();
            conn.Close();
            return Hareket;
        }

        public List<Kargo> GetKargo()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Kargo", conn);

            SqlDataReader reader = command.ExecuteReader();

            List<Kargo> Kargolar = new List<Kargo>();

            while (reader.Read())
            {
                Kargo k = new Kargo(Convert.ToInt32(reader["KargoID"]), Convert.ToInt32(reader["AliciID"]), Convert.ToInt32(reader["GondericiID"]), Convert.ToInt32(reader["KargoTuruID"]), Convert.ToDateTime(reader["TeslimTarih"]), Convert.ToDecimal(reader["Desi"]), Convert.ToDecimal(reader["Agirlik"]), Convert.ToBoolean(reader["KimOdeyecek"]), Convert.ToDecimal(reader["Ucret"]));
                Kargolar.Add(k);

            }

            reader.Close();
            conn.Close();
            return Kargolar;
        }

        //Load

        public void LoadKargoTurleri(ComboBox cbxKargoTurleri)
        {
            cbxKargoTurleri.ValueMember = "Icerik";
            cbxKargoTurleri.DataSource = GetKargoTurleri();
        }

        public void LoadListBoxKargoTurleri(ListBox lbxKargoTurleri)
        {
            lbxKargoTurleri.ValueMember = "Icerik";
            lbxKargoTurleri.DataSource = GetKargoTurleri();
        }

        public void LoadSubeler(DataGridView dgwSubeler)
        {
            dgwSubeler.DataSource = GetSubeler();
            dgwSubeler.Columns["SubeID"].Visible = false;
        }

        public void LoadComboBoxSubeler(ComboBox cbxSubeler)
        {
            cbxSubeler.ValueMember = "Ad";
            cbxSubeler.DataSource = GetSubeler();

        }

        public void LoadMusteriler(DataGridView dgwMusteriler)
        {
            dgwMusteriler.DataSource = GetMusteriler();
            dgwMusteriler.Columns["MusteriID"].Visible = false;
        }

        public void LoadKuryeler(DataGridView dgwKuryeler)
        {
            dgwKuryeler.DataSource = GetKuryeler();
            dgwKuryeler.Columns["KuryeID"].Visible = false;
        }

        public void LoadKargolar(DataGridView dgwKargo)
        {
            dgwKargo.DataSource = GetKargo();
            dgwKargo.Columns["KargoID"].Visible = false;
            //foreach (DataGridViewRow row in dgwKargo.Rows)

            //{

            //    if (row.Cells[4].Value.ToString() == "01.01.2000")
            //    {
            //        row.Cells[4].Value = "01.01.1999";
            //    }

            //}
        }

        public void LoadKargoHareket(DataGridView dgwKHareket)
        {
            dgwKHareket.DataSource = GetKargoHareketleri();

            dgwKHareket.Columns["HareketID"].Visible = false;
            dgwKHareket.Columns["KargoID1"].Visible = false;
            dgwKHareket.Columns["KuryeID"].Visible = false;
            dgwKHareket.Columns["SubeID"].Visible = false;

        }

        public void LoadComboBoxKuryeler(ComboBox cbxkuryeler)
        {
            cbxkuryeler.ValueMember = "Ad";
            cbxkuryeler.DataSource = GetKuryeler();
        }


        //Musteri

        public void MusteriEkle(Musteriler yeniMusteri)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Musteriler VALUES (@ad,@soyad,@adres,@telefon)", conn);
            command.Parameters.AddWithValue("ad", yeniMusteri.Ad);
            command.Parameters.AddWithValue("soyad", yeniMusteri.Soyad);
            command.Parameters.AddWithValue("adres", yeniMusteri.Adres);
            command.Parameters.AddWithValue("telefon", yeniMusteri.Telefon);
            command.ExecuteNonQuery();

            conn.Close();

        }

        public void MusteriGuncelle(Musteriler yeniMusteri)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE Musteriler SET Ad=@ad, Soyad=@soyad, Adres=@adres,Telefon=@telefon WHERE MusteriID=@musteriID", conn);


            command.Parameters.AddWithValue("musteriId", yeniMusteri.MusteriID);
            command.Parameters.AddWithValue("ad", yeniMusteri.Ad);
            command.Parameters.AddWithValue("soyad", yeniMusteri.Soyad);
            command.Parameters.AddWithValue("adres", yeniMusteri.Adres);
            command.Parameters.AddWithValue("telefon", yeniMusteri.Telefon);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void MusteriSil(int MusteriID)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE FROM Musteriler WHERE MusteriID=@musteriID", conn);


            command.Parameters.AddWithValue("musteriId", MusteriID);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void MusteriAra(string aramaMetni, DataGridView dgwMusteriler)
        {
            dgwMusteriler.DataSource = GetMusteriler().Where(p => p.Ad.ToLower().Contains(aramaMetni.ToLower())).ToList();
            dgwMusteriler.Columns["MusteriID"].Visible = false;


        }

        //Sube

        public void SubeEkle(Subeler yeniSube)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Subeler VALUES (@ad,@telefon,@adres)", conn);
            command.Parameters.AddWithValue("ad", yeniSube.Ad);
            command.Parameters.AddWithValue("telefon", yeniSube.Telefon);
            command.Parameters.AddWithValue("adres", yeniSube.Adres);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void SubeGuncelle(Subeler yeniSube)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE Subeler SET Ad=@ad,Telefon=@telefon,Adres=@adres WHERE SubeID=@subeID)", conn);
            command.Parameters.AddWithValue("subeID", yeniSube.SubeID);
            command.Parameters.AddWithValue("ad", yeniSube.Ad);
            command.Parameters.AddWithValue("telefon", yeniSube.Telefon);
            command.Parameters.AddWithValue("adres", yeniSube.Adres);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void SubeAra(DataGridView dgwSubeler, string aramaMetni)
        {
            dgwSubeler.DataSource = GetSubeler().Where(p => p.Ad.ToLower().Contains(aramaMetni.ToLower())).ToList();
            dgwSubeler.Columns["SubeID"].Visible = false;
        }

        public void SubeSil(int SubeID)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE FROM Subeler WHERE SubeID=@subeID", conn);


            command.Parameters.AddWithValue("subeID", SubeID);
            command.ExecuteNonQuery();

            conn.Close();
        }


        //Kurye
        public void KuryeEkle(Kuryeler yeniKurye)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Kuryeler VALUES (@subeID,@ad,@soyad)", conn);
            command.Parameters.AddWithValue("subeID", yeniKurye.SubeID);
            command.Parameters.AddWithValue("ad", yeniKurye.Ad);
            command.Parameters.AddWithValue("soyad", yeniKurye.Soyad);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void KuryeGuncelle(Kuryeler yeniKurye)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE Kuryeler SET SubeID=@subeID,Ad=@ad,Soyad=@soyad WHERE KuryeID=@kuryeID)", conn);
            command.Parameters.AddWithValue("kuryeID", yeniKurye.KuryeID);
            command.Parameters.AddWithValue("subeID", yeniKurye.SubeID);
            command.Parameters.AddWithValue("ad", yeniKurye.Ad);
            command.Parameters.AddWithValue("soyad", yeniKurye.Soyad);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void KuryeSil(int KuryeID)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE FROM Kuryeler WHERE KuryeID=@kuryeID", conn);


            command.Parameters.AddWithValue("kuryeID", KuryeID);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void KuryeAra(DataGridView dgwKuryeler, string aramaMetni)
        {
            dgwKuryeler.DataSource = GetKuryeler().Where(p => p.Ad.ToLower().Contains(aramaMetni.ToLower())).ToList();
            dgwKuryeler.Columns["KuryeID"].Visible = false;
        }

        //Kargo ve Hareketleri

        public void KargoEkle(Kargo yeniKargo)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Kargo VALUES (@aliciID,@gondericiID,@kargoturuID,@teslimtarih,@desi,@agirlik,@kimodeyecek,@ucret)", conn);
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime("01.01.2000");
            yeniKargo.Teslimtarih = dt;
            command.Parameters.AddWithValue("aliciID", yeniKargo.AliciID);
            command.Parameters.AddWithValue("gondericiID", yeniKargo.GondericiID);
            command.Parameters.AddWithValue("kargoturuID", yeniKargo.KargoturuID);
            command.Parameters.AddWithValue("teslimtarih", yeniKargo.Teslimtarih);
            command.Parameters.AddWithValue("desi", yeniKargo.Desi);
            command.Parameters.AddWithValue("agirlik", yeniKargo.Agirlik);
            command.Parameters.AddWithValue("kimodeyecek", yeniKargo.KimOdeyecek);
            command.Parameters.AddWithValue("ucret", yeniKargo.Ucret);

            command.ExecuteNonQuery();

            conn.Close();
        }

        public void KargoGuncelle2(Kargo yeniKargo)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE Kargo SET AliciID=@aliciID,GondericiID=@gondericiID,KargoturuID=@kargoturuID,TeslimTarih=@teslimtarih,Desi=@desi,Agirlik=@agilik,KimOdeyecek=@kimodeyecek,Ucret=@ucret WHERE KargoID=@kargoID)", conn);

            command.Parameters.AddWithValue("kargoID", yeniKargo.KargoID);
            command.Parameters.AddWithValue("aliciID", yeniKargo.AliciID);
            command.Parameters.AddWithValue("gondericiID", yeniKargo.GondericiID);
            command.Parameters.AddWithValue("kargoturuID", yeniKargo.KargoturuID);
            command.Parameters.AddWithValue("teslimtarih", yeniKargo.Teslimtarih);
            command.Parameters.AddWithValue("desi", yeniKargo.Desi);
            command.Parameters.AddWithValue("agirlik", yeniKargo.Agirlik);
            command.Parameters.AddWithValue("kimodeyecek", yeniKargo.KimOdeyecek);
            command.Parameters.AddWithValue("ucret", yeniKargo.Ucret);

            command.ExecuteNonQuery();

            conn.Close();
        }

        public void KargoGuncelle(Kargo yeniKargo)
        {
            ConnectionControl();
            string sql = "UPDATE Kargo SET TeslimTarih=@teslimtarih WHERE KargoID=@kargoID";
            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("kargoID", yeniKargo.KargoID);
            command.Parameters.AddWithValue("teslimtarih", yeniKargo.Teslimtarih);


            command.ExecuteNonQuery();

            conn.Close();
        }

        public void KargoSil(int KargoID)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE FROM Kargo WHERE KargoID=@kargoID", conn);


            command.Parameters.AddWithValue("kuryeID", KargoID);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public int SonKargoIDAl()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT TOP 1 KargoID FROM Kargo ORDER BY KargoID DESC", conn);

            SqlDataReader reader = command.ExecuteReader();


            reader.Read();

            int KargoID = Convert.ToInt32(reader["KargoID"]);



            reader.Close();
            conn.Close();
            return KargoID;
        }

        public int RastgeleKuryeIDAl()
        {


            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT TOP 1 KuryeID FROM Kuryeler ORDER BY NEWID()", conn);

            SqlDataReader reader = command.ExecuteReader();


            reader.Read();

            int KuryeID = Convert.ToInt32(reader["KuryeID"]);



            reader.Close();
            conn.Close();
            return KuryeID;
        }

        public void KHareketFiltreMusteriAd(DataGridView dgwKargolar, string aramaMetni)
        {
            dgwKargolar.DataSource = GetKargoHareketleri().Where(p => p.Gönderici.ToLower().Contains(aramaMetni.ToLower())).ToList();
            dgwKargolar.DataSource = GetKargoHareketleri().Where(p => p.Alici.ToLower().Contains(aramaMetni.ToLower())).ToList();


        }

        public void KHareketFiltreKuryeAd(DataGridView dgwKargolar, string aramaMetni)
        {

            dgwKargolar.DataSource = GetKargoHareketleri().Where(p => p.KuryeAdSoyad.ToLower().Contains(aramaMetni.ToLower())).ToList();

        }

        public void KHareketFiltreSubeAra(DataGridView dgwKargolar, string aramaMetni)
        {

            dgwKargolar.DataSource = GetKargoHareketleri().Where(p => p.SubeAdi.ToLower().Contains(aramaMetni.ToLower())).ToList();


        }

        public void KargoHareketEkle(KHareketleri yeniHareket)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO KargoHareketleri VALUES (@KargoID,@KuryeID,@Durum)", conn);

            command.Parameters.AddWithValue("KargoID", yeniHareket.KargoID);
            command.Parameters.AddWithValue("KuryeID", yeniHareket.KuryeID);
            command.Parameters.AddWithValue("Durum", yeniHareket.Durum);


            command.ExecuteNonQuery();

            conn.Close();
        }

        public void KargoHareketGuncelle(KHareketleri guncelHareket)
        {
            ConnectionControl();
            string sql = "UPDATE KargoHareketleri SET KargoID=@kargoID,KuryeID=@kuryeID,Durum=@durum WHERE HareketID=@hareketID";
            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("hareketID", guncelHareket.HareketID);
            command.Parameters.AddWithValue("kargoID", guncelHareket.KargoID);
            command.Parameters.AddWithValue("kuryeID", guncelHareket.KuryeID);
            command.Parameters.AddWithValue("durum", guncelHareket.Durum);


            command.ExecuteNonQuery();

            conn.Close();
        }




    }
}
