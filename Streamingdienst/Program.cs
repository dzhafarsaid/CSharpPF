using Streamingdienst.model;

Genre genre1 = new Genre("Sci-Fi", "Sci-Fi genre");
Genre genre2 = new Genre("Comedy", "Comedy genre");
Genre genre3 = new Genre("News", "News genre");

Content[] list = new Content[4];
list[0] = new Film("Inception", 2010, 16, genre1, 148, "Christopher Nolan");
list[1] = new Serie("The Office", 2005, 12, genre2, 9, 201);
list[2] = new Podcast("Spotify Daily", 2024, 0, genre3, "Miles", 45);
list[3] = new Film("Incredible", 2002, 12, genre1, 120, "Niks");

foreach (Content item in list)
{
    Console.WriteLine(item.InfoTonen());
}

List<IDownloadbaar> downloadList = new List<IDownloadbaar>();

foreach (Content item in list)
{
    if (item is IDownloadbaar downloadItem)
        downloadList.Add(downloadItem);
}

foreach (IDownloadbaar item in downloadList)
{
    Console.WriteLine(item.Downloaden());
}

List<IBekroonbaar> awardList = new List<IBekroonbaar>();

foreach (Content item in list)
{
    if (item is IBekroonbaar awarditem)
        awardList.Add(awarditem);
}
awardList[0].PrijsToekennen("Oscar");
awardList[1].PrijsToekennen("Emmy");

int downloadCount = 0;
int awardCount = 0;

foreach (Content item in list)
{
    if (item is IDownloadbaar) downloadCount++;
    if (item is IBekroonbaar) awardCount++;
}

Console.WriteLine($"Downloadable: {downloadCount}");
Console.WriteLine($"Awardable: {awardCount}");