// // 1. Doira yuzi va aylana uzunligini hisoblash.

System.Console.WriteLine("Assalom alekum, men doira yuzi va aylana uzunligini hisoblab beraman buning uchun siz doira radiusini kiritsangiz bas ! ");
System.Console.Write("Doira radiusini kiriting:");
string radius = Console.ReadLine();
int rad = Convert.ToInt32(radius);
decimal javobS = 3.14159265m*rad*rad;
decimal javobL = 3.14159265m*2*rad;
System.Console.WriteLine($"Doiraning yuzasi {javobS}, aylananing uzunligi esa {javobL}.");



// 2. Valyuta konvertri.

System.Console.WriteLine("Endi biz bilan Valyuta kursini so'mda qancha bo'lishini bilib olishingiz mumkin!!!");
string kurss = ("12600");
int kurs = Convert.ToInt32(kurss);
System.Console.WriteLine($"Hozirda 1 dollor kurs qiymati {kurs} so'mni tashkil qilmoqda!");
System.Console.Write("Summani kiriting($):");
string summ = Console.ReadLine();
int sum = Convert.ToInt32(summ);
decimal end = sum * kurs;
System.Console.WriteLine($"Natija: {sum} $ * {kurs} = {end} so'm.");



// 3. Yoshni hisoblash. 

System.Console.WriteLine("Salom, siz tug'ulgan kuningizdan boshlab hozirgacha nechi kun bo'lganini bilishni istaysizmi?");
System.Console.Write("Tug'ulgan yilingizni kiriting:");
string yil = Console.ReadLine();
int yill = Convert.ToInt32(yil);
decimal yechim = (2024-yill)*365-365;
System.Console.WriteLine($"Siz tug'ulganizga {yechim} kun bo'ldi !");


