using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation;

    public class Yazar
    {
        public string FirstName;
        public string LastName;
        public string Yayinevi;
        public string Baslik;
        public string Aciklama;
        public string BasimTarihi;

        private string firstName;
        private string lastName;
        private string yayinevi;
        private string baslik;
        private string aciklama;
        private string basimtarihi;


      //public string FullName => $"{Yayinevi}:{BasimTarihi}"; bu da aşağıdaki kodla aynı görevi görür


    public string FullName
        {

            get
            {
                return $"{Yayinevi}:{BasimTarihi}";
            }
            private set
            {
                
                FullName = $"{yayinevi}:{basimtarihi}";
            }
        }
       

        public override string ToString()
        {
            return $"Yazar adı: {firstName}, Soyadı: {lastName}, Kitap: {baslik}, Açıklama: {aciklama}, Yayınevi: {yayinevi}, Basım Tarihi: {baslik} ";
        }

    }

