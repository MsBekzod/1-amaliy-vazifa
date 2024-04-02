// 1. Doira yuzi va aylana uzunligini hisoblash.
System.Console.WriteLine("Assalom alekum, men doira yuzi va aylana uzunligini hisoblab beraman buning uchun siz aylana radiusini kiritsangiz bas ! ");
System.Console.Write("Doira radiusini kiriting:");
string radius = Console.ReadLine();
int r = Convert.ToInt32(radius);
int pi = 3.14159265;
int javobL = 3.14159265*2*r;
int javobS = 3.14159265*r;

System.Console.WriteLine($"Doiraning yuzasi {javobS}, aylananing uzunligi esa {javobL}.");

