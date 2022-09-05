using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.SeleniumTest.TelefonRehberi.Models
{
    public class Elements
    {
        #region ElementId

        public string Link { get; set; }
        public string ClickYeni_Kayit { get; set; }
        public string ClickSave { get; set; }

        public string ClickGoBack { get; set; }
        public string txtAd { get; set; }
        public string txtSoyad { get; set; }
        public string txtTelNo { get; set; }
        public string txtFaxNo { get; set; }
        public string txtEmail { get; set; }


        #endregion

        #region XPath
        public string EklenenKisiAdi { get; set; }
        public string GuncelleSayfasinaGit { get; set; }
        public string SilmeIslemi { get; set; }
        public string GoBackList { get; set; }
        #endregion









    }
}
