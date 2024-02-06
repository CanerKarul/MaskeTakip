<h1>C# Maske Takip Uygulaması </h1>
<h3>Bu uygulama Engin Demiroğ 2024 C# Kampı Ödev-1 İçin Yapılmıştır!</h3>

💡Temel Özellikler:

<b>Dependency Injection (Bağımlılık Enjeksiyonu):</b>

* PttManager sınıfı, IApplicantService arayüzünü kullanarak bir bağımlılığa sahiptir. Bu bağımlılık, sınıfın kurucu yöntemi aracılığıyla enjekte edilir. Bu tasarım deseni, kodun bağımlılıklarını azaltır, test edilebilirliği artırır ve kodun daha esnek olmasını sağlar.

<b>Arayüzler (Interfaces):</b>

* IApplicantService ve ISupplierService gibi arayüzler, belirli işlevleri tanımlayan sözleşmelerdir. Bu arayüzler, farklı sınıfların aynı işlevselliği sağlaması ve kodun daha modüler olmasını sağlar. Örneğin, PttManager sınıfı, IApplicantService arayüzü üzerinden çalışır, bu da sınıfın farklı uygulamalarla etkileşime girmesine olanak tanır.

<b>SOAP Web Servisine Bağlanma:</b>

* PersonManager sınıfı, Mernis kimlik doğrulama hizmetini kullanarak bir kişinin TC kimlik numarasını doğrulamak için bir SOAP web servisine bağlanır. Bu, dış hizmetlerle etkileşim kurma ve uzak hizmetlerin işlevselliğinden yararlanma özelliğidir.

<b>İstisnai Durumlar (Exceptions):</b>

* Bazı sınıflar, işlevselliğin henüz uygulanmadığını belirtmek için NotImplementedException istisnai durumunu kullanır. Örneğin, ForeignerManager sınıfı, arayüz metotlarını henüz uygulamamıştır ve bu nedenle bu metotlar NotImplementedException ile işaretlenmiştir.

<b>Kodun Modülerliği:</b>

* Kod, farklı işlevleri yerine getiren modüller ve sınıflar arasında bölünmüştür. Bu modüler yapı, kodun daha okunabilir, bakımı daha kolay ve yeniden kullanılabilir olmasını sağlar. Örneğin, PersonManager sınıfı, kişilerle ilgili işlemleri gerçekleştirirken PttManager sınıfı, maskelerin dağıtımını kontrol eder.
