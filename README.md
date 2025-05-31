# 📝 ToDoList - Konsol Uygulaması

Bu proje basit bir C# konsol uygulaması olarak geliştirilmiştir. Kullanıcının görev listesini oluşturmasına, görev ekleyip çıkarmasına ve mevcut görevleri görüntülemesine olanak tanır.

---

## 🚀 Başlangıç

Projeyi çalıştırmak için Visual Studio veya başka bir C# IDE'si kullanabilirsiniz.

### 🛠️ Gereksinimler

- .NET Framework veya .NET Core yüklü bir ortam
- C# destekli bir geliştirme ortamı (örn. Visual Studio, Rider, Visual Studio Code)

---

## 📌 Özellikler

- ✅ Görev listesine görev ekleme
- ❌ Görev silme (görev numarasına göre)
- 📋 Mevcut görevleri listeleme
- ❎ Uygulamadan çıkış

---

## 📸 Ekran Görüntüleri

### Başlangıç ve Menü

![Screenshot 1](https://github.com/MehmetOKZ/ToDoList/blob/master/ASSET/Screenshot-1.png?raw=true)

### Görev Ekleme

![Screenshot 2](https://github.com/MehmetOKZ/ToDoList/blob/master/ASSET/Screenshot-2.png?raw=true)

### Görev Silme

![Screenshot 3](https://github.com/MehmetOKZ/ToDoList/blob/master/ASSET/Screenshot-3.png?raw=true)

### Görev Listeleme

![Screenshot 4](https://github.com/MehmetOKZ/ToDoList/blob/master/ASSET/Screenshot-4.png?raw=true)

---

## 💻 Kod Parçası

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Yapılacaklar listesine hoşgeldin.");
    List<string> görevlistesi = new List<string>();
    string secenek = "";

    while(secenek != "ç")
    {
        Console.WriteLine("Ne yapmak istersin?");
        Console.WriteLine("Listenize görev eklemek için 1 yazınız.");
        Console.WriteLine("Listeden görev çıkartmak için 2 yazınız.");
        Console.WriteLine("Listeyi görüntülemek için 3 yazınız.");
        Console.WriteLine("Çıkış yapmak için ç yazınız.");

        secenek = Console.ReadLine();

        if (secenek == "1")
        {
            Console.WriteLine("Lütfen eklemek istediğiniz görevin ismini giriniz.");
            string görev = Console.ReadLine();

            görevlistesi.Add(görev);
            Console.WriteLine("Görev liseteye eklendi.");
        }
        else if (secenek == "2")
        {
            for (int i = 0; i < görevlistesi.Count; i++)
            {
                Console.WriteLine(i + " : " + görevlistesi[i]);
            }
            Console.WriteLine("Lütfen listeden çıkartmak istediğiniz görevin numarasını seçiniz.");
            int görevNumarası = Convert.ToInt32(Console.ReadLine());
            görevlistesi.RemoveAt(görevNumarası);
        }
        else if (secenek == "3")
        {
            Console.WriteLine("Listedeki mevcut görevleriniz : ");
            for (int i = 0; i < görevlistesi.Count; i++)
            {
                Console.WriteLine(görevlistesi[i]);
            }
        }
        else if (secenek == "ç")
        {
            Console.WriteLine("Programdan çıkılıyor");
        }
        else
        {
            Console.WriteLine("Geçersiz işlem, lütfen tekrar deneyin.");
        }
    }
}
