//--------------------------------------------------------------//
// Program.cs
//
// Written by Robson
// <https://robson.plus>
//
// See the GitHub repository for licensing information.
// <https://github.com/Robson/Reel-Time>
//--------------------------------------------------------------//

namespace GetImdbFilmData
{
    using System;
    using System.Collections.Generic;    
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    internal class Program
    {
        private const string Filename = "data.js";

        private static HttpClient client = new HttpClient();

        internal static void Main()
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.5993.90 Safari/537.36");
            client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9");

            File.WriteAllText(Filename, "var data = [" + Environment.NewLine, Encoding.Unicode);

            var allFilms = Films.GetAllFilms();
            allFilms = allFilms.OrderBy(x => x.Item3).ToList();

            for (int i = 0; i < allFilms.Count; i++)
            {
                Console.WriteLine(i.ToString() + " of " + (allFilms.Count - 1) + ": " + allFilms[i].Item1);
                GetFilmData(allFilms[i]);
            }

            File.AppendAllText(Filename, "];", Encoding.Unicode);
        }

        private static void GetFilmData((string, string, double) film)
        {
            Film filmData;
            var response = client.GetAsync("https://www.imdb.com/title/" + film.Item2).Result;
            var html = response.Content.ReadAsStringAsync().Result.Replace("\n", string.Empty);

            filmData = GetFilmData(html, film.Item2, film.Item3);

            File.AppendAllText(Filename, JsonConvert.SerializeObject(filmData, Formatting.Indented) + ",\n", Encoding.Unicode);
        }

        private static Film GetFilmData(string html, string id, double time)
        {
            return new Film()
            {
                Id = id,
                Year = int.Parse(Regex.Match(html, "(\\d{4})\\) - IMDb</title>").Groups[1].Value),
                Name = Regex.Match(html, "<title>([^\\(]*)\\(").Groups[1].Value.Replace("&nbsp;", " ").Trim(),
                Rating = decimal.Parse(Regex.Match(html, "aggregateRating.*,\"ratingValue\":([\\d\\.]+)\\}").Groups[1].Value),
                Votes = int.Parse(Regex.Match(html, ",\"ratingCount\":(\\d+),").Groups[1].Value.Replace(",", string.Empty)),
                Metascore = Regex.Match(html, "{\"metascore\":{\"score\":([\\d+]+),\"").Groups[1].Value,
                Poster = Regex.Match(html, "<img alt=\"[^\"]+\" class=\"ipc-image\" loading=\"eager\" src=\"([^\"]+)\"").Groups[1].Value,
                Seconds = time
            };
        }

        internal class Film
        {
            public int Year { get; set; }

            public string Id { get; set; }

            public string Name { get; set; }

            public decimal Rating { get; set; }

            public int Votes { get; set; }

            public string Metascore { get; set; }

            public string Poster { get; set; }

            public double Seconds { get; set; }
        }
    }    
}