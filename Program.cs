// ==========================================================
// ================  AMALIY VAZIFA #1  ======================
// ==========================================================

// ====================== 1-VAZIFA ==========================
// Konsoldan radiusni o'qiymiz
double radius = Convert.ToDouble(Console.ReadLine());
// Pi qiymatini e'lon qilamiz
double pi = 3.14;
// Doira yuzini hisoblaymiz
double S = pi * radius * radius;
// Aylana uzunligini hisoblaymiz
double L = 2 * pi * radius;
// Natijani ekranga chiqaramiz
Console.WriteLine($"S={S}, L={L}");

// ====================== 2-VAZIFA ==========================
// Summani e'lon qilamiz
int qiymat = 2;
// Kursni e'lon qilamiz
int kurs = 12400;
// Konvertatsiya qilamiz
int natija = qiymat * kurs;
// Natijani ekranga chiqaramiz
Console.WriteLine($"{natija} so'm");

// ====================== 3-VAZIFA ==========================
// Tug'ilgan yilni o'qiymiz
int x = Convert.ToInt32(Console.ReadLine());
// Kunlar farqini hisoblaymiz
int kunlar = (new DateTime(2023, 1, 1) - new DateTime(x, 1, 1)).Days;
// Natijani ekranga chiqaramiz
Console.WriteLine(kunlar);
