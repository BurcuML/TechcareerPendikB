// See https://aka.ms/new-console-template for more information
//Kullanıcının sisteme griş yapılması isteniyor
//User -> firstname, lastname, email, password, fullname
// firstname lastname en az 2 karakterli
// email @gmail ile bitmeli
//password 6 haneli olmalı


using Encapsulation;

//User user = new User()
//{
//    FirstName = "Burcu",
//    LastName = "jffjdg",
//    Email = "sdfkljdkdf@gmail.com",
//    Password = "dö5455",
//    UserName = "ldskfjsd",
//};
//Console.WriteLine(user);

//kitap -> başlık, açıklama, yazar adı, soyadı,
//yayınevi, basım tarihi, bunlar yan yana fullname basıldığında
//yazar tam adı, (yayınevi - basım tarihi) bunlar da yan yana

Yazar yazar = new Yazar()
{
    FirstName = "Burcu",
    LastName = "jffjdg",
    Baslik = "Baslik",
    Aciklama = "skfjnlsdjlksdlknlkcnsldd",
    Yayinevi = "Penguen",
    BasimTarihi = "11.16.2023",
};
Console.WriteLine(yazar.FullName);