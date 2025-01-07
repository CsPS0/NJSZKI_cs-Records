#region 1.feladat
// a.
string[] April = File.ReadAllLines("aprilis.txt");

List<Competition> all = new List<Competition>();

string[] Class = new string[30];
int[] Points = new int[30];
for (int i = 0; i < April.Length; i++)
{
    string[] btw = April[i].Split(";");
    Class[i] = btw[0];
    Points[i] = int.Parse(btw[1]);
}

// b.
int max = 0;
string bestClass = " ";

for (int i = 0; i < all.Count; i++)
{
    if (all[i].Point > max)
    {
        max = all[i].Point;
        bestClass = all[i].Class;
    }
}
Console.WriteLine($"In April the best competetive class is nothing but the {bestClass}");

// c.
double average = 0;
for (int i = 0;i < all.Count;i++)
{
    average += all[i].Point;
}
average = average / April.Length;
Console.WriteLine($"The classes average points are: {average}");

// d.
int hundred = 0;
for (int i = 0; i< all.Count ; i++)
{
    if ( all[i].Point < 100)
    {
        hundred++;
    }
}
Console.WriteLine($"From the classes the people who got point under the score of 100 are: {hundred}.");

// e.
Console.Write("Give me a class name: ");
string className = Console.ReadLine();

for (int i = 0;i < all.Count ; i++)
{
    //
}

// f.
int fifty = 0;
for (int i = 0; i<all.Count ; i++)
{
    if (all[i].Point < 50)
    {
        fifty++;
    }
    Console.WriteLine(fifty);
}
#endregion

#region 2.feladat
// a.
string[] Like = File.ReadAllLines("like.txt");

List<string> list = new List<string>();

// b.


// c.


// d.


//e.


//f.


//g.


//h.


//i.
#endregion

#region 3.feladat
// a.


// b.


// c.


// d.


//e.


//f.
#endregion

public record Competition(string Class, int Point);
public record WebPage(string Monogram, int LikeCount);