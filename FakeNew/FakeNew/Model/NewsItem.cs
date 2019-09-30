using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNew.Model
{
    class NewsItem
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string Headline { get; set; }

        public string Subhead { get; set; }

        public string Dateline { get; set; }

        public string Image { get; set; }
    }
    public class NewManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();

            var filteredNewItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewItems.ForEach(p => newsItems.Add(p));

        }
        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem()
            {
            Id = 1,
            Category = "financial",
            Headline = "lorem ipsum",
            Subhead = "DORO SIT AMET",
            Dateline= "Nunc tristique nec",
            Image = "Assets/Financial1.png"
            });
            items.Add(new NewsItem()
            {
                Id = 2,
                Category = "financial",
                Headline = "Etiam ac felis viverra",
                Subhead = "vulputate nisl ac, aliquet nisi",
                Dateline = "tortor porttitor, eu fermentum ante congue",
                Image = "Assets/Financial2.png"
            });
            items.Add(new NewsItem()
            {
                Id = 3,
                Category = "financial",
                Headline = "Integer sed turpis erat",
                Subhead = "Sed puis hendrerit lorem, quis interdum dolor",
                Dateline = "in viverre metus facilisis sed",
                Image = "Assets/Financial3.png"
            });
            items.Add(new NewsItem()
            {
                Id = 4,
                Category = "financial",
                Headline = "Proin sem neque",
                Subhead = "aliquet quis ipsum tincidunt",
                Dateline = "integer eleifend",
                Image = "Assets/Financial4.png"
            });
            items.Add(new NewsItem()
            {
                Id = 5,
                Category = "financial",
                Headline = "Mauris bibendum non leo vitae tempor",
                Subhead = "in nisl tortor, eleifend sed ipsum eget",
                Dateline = "Curebitur dictum augue vitae elementum ultrices",
                Image = "Assets/Financial5.png"
            });
            items.Add(new NewsItem()
            {
                Id = 6,
                Category = "Food",
                Headline = "lorem ipsum",
                Subhead = "dolor sit amet",
                Dateline = "Nunc tristique nec",
                Image = "Assets/Food1.png"
            });
            items.Add(new NewsItem()
            {
                Id = 7,
                Category = "Food",
                Headline = "Etiam ac felis viverra",
                Subhead = "vulputate nisl ac, aliquet nisi",
                Dateline = "tortor porttitor, eu fermentum ante congue",
                Image = "Assets/Food2.png"
            });
            items.Add(new NewsItem()
            {
                Id = 8,
                Category = "Food",
                Headline = "Integer sed turpis erat",
                Subhead = "Sed puis hendrerit lorem, quis interdum dolor",
                Dateline = "in viverre metus facilisis sed",
                Image = "Assets/Food3.png"
            });
            items.Add(new NewsItem()
            {
                Id = 9,
                Category = "Food",
                Headline = "Proin sem neque",
                Subhead = "aliquet quis ipsum tincidunt",
                Dateline = "integer eleifend",
                Image = "Assets/Food4.png"
            });
            items.Add(new NewsItem()
            {
                Id = 10,
                Category = "Food",
                Headline = "Mauris bibendum non leo vitae tempor",
                Subhead = "in nisl tortor, eleifend sed ipsum eget",
                Dateline = "Curebitur dictum augue vitae elementum ultrices",
                Image = "Assets/Food5.png"
            });

            return items;
        }

        internal static void GetNews(string v, object newsItems)
        {
            throw new NotImplementedException();
        }
    }
}
