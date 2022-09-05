using Web.SeleniumTest.TelefonRehberi.Models;
using TelefonRehberi.Models;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Web.SeleniumTest.TelefonRehberi
{
    class Tests
    {
        static void Main(string[] args)
        {
            Rehber telefonRehberi = new Rehber();
            telefonRehberi.Ad = "İbrahim";
            telefonRehberi.Soyad = "Şimşek";
            telefonRehberi.Telefon_Numarasi = "5367748301";
            telefonRehberi.Fax_Numarasi = "534568978";
            telefonRehberi.E_Mail = "ibrahimsimsek@gmail.com";



            Elements elements = new Elements();
            elements.Link = @"http://localhost:5141/";
            #region Element ->Id
            elements.ClickYeni_Kayit = "yeni_kayit";
            elements.ClickSave = "save";

            elements.txtAd = "txt_ad";
            elements.txtSoyad = "txt_soyad";
            elements.txtTelNo = "txt_telno";
            elements.txtFaxNo = "txt_faxno";
            elements.txtEmail = "txt_email";

            #endregion


            #region Xpath
            elements.EklenenKisiAdi = "//tbody/tr[1]/td[1]";
            elements.GuncelleSayfasinaGit = "//tbody/tr[1]/td[6]/a[1]";

            #endregion


            ChromeOptions chromeOptions = new ChromeOptions();
            Console.WriteLine("Sertifika Ayarlaması Yapılıyor");
            chromeOptions.AcceptInsecureCertificates = true;

            IWebDriver driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl(elements.Link);

            Console.WriteLine("Tarayıcının Tam Ekranda Açılması Sağlanıyor");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Console.WriteLine("Yeni Kayıt İçin Ekle Butonuna Basılıyor");
            driver.FindElement(By.Id(elements.ClickYeni_Kayit)).Click();

            #region Veri Girişi - Kaydetme işlemi
            Console.WriteLine("Yeni Kişi Bilgileri Giriliyor");

            driver.FindElement(By.Id(elements.txtAd)).SendKeys(telefonRehberi.Ad);//Ad alanına kişi bilgileri girliyor..
            driver.FindElement(By.Id(elements.txtSoyad)).SendKeys(telefonRehberi.Soyad);//Soyad alanına kişi bilgileri girliyor..
            driver.FindElement(By.Id(elements.txtTelNo)).SendKeys(telefonRehberi.Telefon_Numarasi);//Telno alanına kişi bilgileri girliyor..
            driver.FindElement(By.Id(elements.txtFaxNo)).SendKeys(telefonRehberi.Fax_Numarasi);//Fax alanına kişi bilgileri girliyor..
            driver.FindElement(By.Id(elements.txtEmail)).SendKeys(telefonRehberi.E_Mail);//Email alanına kişi bilgileri girliyor..

            Console.WriteLine("Yeni Kişi Kaydediliyor");
            driver.FindElement(By.Id(elements.ClickSave)).Click();

            string eklenenKisiAdi = driver.FindElement(By.XPath(elements.EklenenKisiAdi)).Text; // Veriyi Getir
            try
            {
                Assert.AreEqual(telefonRehberi.Ad, eklenenKisiAdi);
                Console.WriteLine("Rehber'e Ekleme işlemi testi başarılı bir şekilde tamamlandı.");
            }
            catch (Exception)
            {
                Console.WriteLine("\n\n Ekleme İşlemi Hatalı!!! \n\n");
            }


            #endregion


            #region Güncelleme

            Console.WriteLine("Güncelleme İşlemi Test Ediliyor. ");

            driver.FindElement(By.XPath(elements.GuncelleSayfasinaGit)).Click();

            Console.WriteLine("Güncelleme Testi İçin Alanlar Temizleniyor");
            driver.FindElement(By.Id(elements.txtAd)).Clear();
            driver.FindElement(By.Id(elements.txtSoyad)).Clear();
            driver.FindElement(By.Id(elements.txtTelNo)).Clear();
            driver.FindElement(By.Id(elements.txtFaxNo)).Clear();
            driver.FindElement(By.Id(elements.txtEmail)).Clear();

            Console.WriteLine("Yeni Kişi Bilgileri Giriliyor");
            driver.FindElement(By.Id(elements.txtAd)).SendKeys(telefonRehberi.Ad);//Ad alanına kişi bilgileri girliyor..
            driver.FindElement(By.Id(elements.txtSoyad)).SendKeys(telefonRehberi.Soyad);//Soyad alanına kişi bilgileri girliyor..
            driver.FindElement(By.Id(elements.txtTelNo)).SendKeys(telefonRehberi.Telefon_Numarasi);//Telno alanına kişi bilgileri girliyor..
            driver.FindElement(By.Id(elements.txtFaxNo)).SendKeys(telefonRehberi.Fax_Numarasi);//Fax alanına kişi bilgileri girliyor..
            driver.FindElement(By.Id(elements.txtEmail)).SendKeys(telefonRehberi.E_Mail);//Email alanına kişi bilgileri girliyor..

            Console.WriteLine("Yeni Kişi Güncelleniyor");
            driver.FindElement(By.Id(elements.ClickSave)).Click();

            #endregion

            #region Silme ilemi




            #endregion





        }



    }
}