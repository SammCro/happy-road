<?php
$baglanti = new mysqli("localhost","root","","user");

// Check connection
if ($baglanti -> connect_errno) {
  echo "Failed to connect to MySQL: " . $baglanti -> connect_error;
  exit();
}
 
 if($_POST['unity']=="kayitOlma")
 {
	 $kullaniciadi=$_POST['kullaniciAdi'];
	 $sifre=$_POST['sifre'];
	 
	 $sorgu="insert into register(name,password) Values ('$kullaniciadi', '$sifre' )";
	 
	 $sorgusonucu = mysqli_query($baglanti,$sorgu);
	 
	 if($sorgusonucu){
		 echo "Kayıt Başarılıdır";
	 }
	 else{
		 echo "Kayıt Başarısızdır";
	 }
	 
 }
 
  if($_POST['unity']=="girisYapma")
 {
	 $kullaniciadi=$_POST['kullaniciAdi'];
	 $sifre=$_POST['sifre'];
	 
	 $sorgu="select * from register where name='$kullaniciadi' and password='$sifre'";
	 
	 $sorgusonucu = mysqli_query($baglanti,$sorgu);
	 
	 if($sorgusonucu->num_rows>0){
		 echo "Giriş Başarılı";
	 }
	 else{
		 echo "Giriş Başarısız";
	 }
	 
 }
 


?>