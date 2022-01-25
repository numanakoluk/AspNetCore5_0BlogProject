function tabloOlustur(dizi)
{
     let elemanSayisi = dizi.length; //her seferinde onun boyutunu hesaplamasin diye.
     document.writeln("<table border=1>");

     document.writeln("<tr>")
         for(baslik in dizi[0])
     {
         document.writeln("<th>" + baslik + "</th>")
     }
      
     document.writeln("</tr>")    
     for(let i=0; i<elemanSayisi; i++)
     {
         /*Eski Usül:Ortam Bagimli
         document.writeln("<tr><td>" + dizi[i].KitapID + "</td><td>" +
              dizi[i].KitapAdi + "</td><td>" + dizi[i].Yazar + "</td></td>" + 
              dizi[i].Fiyat + "</td></tr>"); */ 
         //header olustur

         
          document.writeln("<tr>")
          for(prop in dizi[i]) //2 Boyutlu dizilerde mantıgı bu.Tablo Olusturma Her yerde calisir
         {
             document.writeln("<td>" + dizi[i][prop] + "</td>");  //Sadece datayi gondermemiz yeterli.Data Servisten gelir önyüzde kullaniciya gösteririr
         }
     document.writeln("<tr>")
     }
     document.writeln("</table>");


}
function minMaxRandom(min,max)
        {
            let fark=max-min;
            let rnd=Math.floor(Math.random()*fark);
            return min+rnd;
        }  


 
 