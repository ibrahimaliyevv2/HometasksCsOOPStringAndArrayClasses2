# HometasksCsOOPStringAndArrayClasses2

Tapşırıq:

Student class
 - FullName
 - GroupNo
 - AvgPoint

Group class
 - No
 - Students
 - AddStudent()
 - StudentLimit

Student class yaradırsınız və bu xüsusiyyətləri olur : FullName,GroupNo,AvgPoint. FullName
FullName dəyəri təyin olunmamış student yaradıla bilminməməlidir

Group class yaradırsınız və bu xüsusiyyətləri olur: No - qrupun nömrəsini ifadə edir, Studnets - groupdakı tələbələrdən ibarət array-dir, AddStudent() - bir studnet obyekti qəbul edir parametr olarq və qəbul etdiyi student obyektini Students array-ə əlavə edir (əgər StudentLimit aşılmırsa), StudentLimit - qrupdakı tələbə limitini ifadə edir

Proqram işə düşdükdə birdən group yaraqlaq üçün No fəyərini və StudentLimit dəyərini daxil etməyimizi istəməlidir.
No dəyəri 2 böyük hərflə başlamalı və sonrasında 3 rəqəm olmalıdır (BP202 kimi)
StudentLimit 0-dan kiçik və 20-dən böyük ola bilməz

Daha sonra Proqram bizə menu seçimi göstərir aşağıdakı kimi:
1. Tələbə əlavə et
2. Bütün tələbələrə bax
3. Tələbələr üzrə axtarış et
0. Proqramı bitir

Bu menu pəncərəsi görsəndikdən dərhal sonra proqram bizdən bir seçim etməyimizi istəməlidir
Əgər 1-i seçsək Tələbə yaratmaq üçün lazım olan bütün dataları console-dan daxil edirik və bir tələbə obyekti yaradıb group obyektimizin AddStudent metodu ilə onu qrupa əlavə edirik (bu zaman əgər qrupdakı tələbə limiti dolubsa istifadəçiyə bununla bağlı məlumat çıxsın və yeni bir seçim etməsi istənilsin)

Əgər 2-ni seçsək yaratmış olduğumuz group obyektindəki bütün tələbələrin məlumatları console pəncərəsində göstərilməlidir

Əgər 3-ü seçsək proqram bizdən bir axtarış dəyəri daxil etməyimizi istəməlidir və FullName dəyərində həmin axtarış dəyəri olan bütün tələbələrin məlumatları console pəncərəsində göstərilməlidir. Bir növ filterizasiya kimi.

Bu 3 seçimdəm hər hansı birini seçdikdən sonra proses bitdək sonra yenidən həmin menu seçimi qarşımıza çıxmalıdır.Misalcün 1-i seçdim,1 tələbənin datalarını console-dan daxil etdim bitirdimsə daha sonra yenidən bu 4 seçim göstərilməli və hansını seçmək istədiyim soruşulmalıdır.

Əgər 0-ı seçsək proses bitməlidir
