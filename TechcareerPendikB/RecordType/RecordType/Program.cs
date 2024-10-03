// See https://aka.ms/new-console-template for more information
using RecordType;

Console.WriteLine("Hello, World!");

Category category = new Category(Id: 1, Name: "Random", Description: "ksdjhfkjdsdjsjssdj");
Product product = new Product
    (
    Name: "dkjfkdj", 
    Description: "kdjnkjnd", 
    Stock: "kjdnvkjnv", 
    Price: "dlfknvjdfnv",
    Category: category,
    );
Console.WriteLine(product);

//Category category = new Category(Id: 1, Name: "Random", Description: "ksdjhfkjdsdjsjssdj");
//Category category1 = new Category(Id: 2, Name: "Randomc", Description: "ksdjhfkjdsdjsjssdj", Product: product);
//Console.WriteLine(category);
//Console.WriteLine(category1);
// generics => iş yükümüz değişiyor ve diğer tüm her şey aynıysa kullanıyoruz