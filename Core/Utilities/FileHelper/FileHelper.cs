using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var result = newPath(file);
            var sourcepath = Path.GetTempFileName();//geçici bir dosya yolu oluşturur.almış olduğun ilk görselin dosya yolunu sourcepath adlı değişkenime ata

            if (file.Length > 0)//eğer dosya sıfırdan büyükse
                                //içinde bir dosya varsa bu işlemlei gerçekleştir
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))//file stream ile yeni bir dosya açabilir veya var olan dosya üzerinde okuma yazma işlemi yapaniliriz
                                                                                //(sourcepath, FileMode.Create.) parametrelerini alıyor,sourcepath=Dosyanın tam yolunu almaktadır. Örn: “C:\deneme.txt”  
                                                                                //(FileMode)Dosya açılacak mı oluşturulacak mı bunu belirtmek için kullanılır.Create yapılırsayeni bir dosya oluşturulsun varsa eğer aynı isimde dosya varsa üzerine yazılsın
                                                                                //dosya adı ve uzantısı verilir
                {
                    //sourcepath kaynağından stream hedefine dosya kopyalar
                    file.CopyTo(stream);//Belirtilen bir kaynaktan belirli bir hedefe dosya kopyalar.
                }
            }

            File.Move(sourcepath, result); //Belirtilen bir kaynaktan belirli bir hedefe dosyayı taşır. Yani kes yapıştır işlemini gerçekleştirir.
            return result;
        }
        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }
        public static string newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);// FileInfo sınıfı da tek bir dosya için bilgi almak amacı ile kullanılmaktadır.
            string fileExtension = ff.Extension;  //oluşturulan dosyanın uzantısını alır	Dosyanın uzantı bölümünü temsil eden kısmı verir. örnek .txt, .jpg

            string path = Environment.CurrentDirectory + @"\wwwroot\Images"; //çalışma dizininin tam yolunu alır veya ayarlar. Uygunlamamnın çalıştıgı aktif klasör yolu
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;
            //Guid.NewGuid() metodu ile yeni bir guid oluşturulabilir ve bununla ilgili işlemler yapılabilir. Guid yapısı ise bize benzersiz değerler üretir

            string result = $@"{path}\{newPath}";
            return result;
        }


    }
}
