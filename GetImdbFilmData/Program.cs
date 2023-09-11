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
    using System.Text;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    internal class Program
    {
        private const string Filename = "data.js";

        private static readonly WebClient Client = new WebClient();       

        internal static void Main()
        {
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

        private static void GetFilmData((string, string, double, bool) film)
        {
            Film filmData;

            var bytes = Client.DownloadData("https://www.imdb.com/title/" + film.Item2);
            var html = Encoding.UTF8.GetString(bytes).Replace("\n", string.Empty);
            filmData = GetFilmData(html, film.Item2, film.Item3, film.Item4);

            File.AppendAllText(Filename, JsonConvert.SerializeObject(filmData, Formatting.Indented) + ",\n", Encoding.Unicode);
        }

        private static Film GetFilmData(string html, string id, double time, bool naughty)
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
                Seconds = time,
                Naughty = naughty
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

            public bool Naughty { get; set; }
        }
    }    
}