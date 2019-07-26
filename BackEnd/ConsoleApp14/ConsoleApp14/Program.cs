using ConsoleApp14.Models;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;

namespace ConsoleApp14
{
    class Program
    {
        static string url = "http://www.kobis.or.kr/kobis/business/mast/mvie/searchMovieListXls.do";
        static string headerName = "user-agent";
        static string headerValue = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.142 Safari/537.3";
        static string fileName = "MovieList.xls";

        static private void DownloadFile()
        {
            using (var w = new WebClient())
            {
                w.Headers.Add(headerName, headerValue);
                w.DownloadFile(url, fileName);
            }
        }

        static private void UpdateMovieTable()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            DataSet result;
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            using (var excelReader = ExcelReaderFactory.CreateBinaryReader(stream))
            {
                result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });
            }

            using (var context = new WOOWContext())
            {
                DataTable table = result.Tables[0];
                for (int i = 4; i < table.Rows.Count; i++)
                {
                    Console.WriteLine(i + "/" + table.Rows.Count);
                    string title = (string)table.Rows[i][0];
                    string multipleGenre = (string)table.Rows[i][5];

                    if (title == null || multipleGenre == null) continue;

                    // Movie, Genre 테이블 행 삽입
                    var movie = new Movie() { Title = title };

                    string[] namesOfgenre = multipleGenre.Split(',');
                    List<Genre> genres = new List<Genre>(namesOfgenre.Count());
                    foreach (var name in namesOfgenre)
                        genres.Add(new Genre { Name = name });

                    context.Movie.Add(movie);
                    context.Genre.AddRange(genres);
                    context.SaveChanges();

                    //MovieGenre 테이블 행 삽입
                    int movieId = context.Movie.Where(x => x.Title.Equals(title)).Select(x => x.MovieId).Single();
                    List<int> genreIds = new List<int>(genres.Count());
                    foreach (var name in namesOfgenre)
                        genreIds.Add(context.Genre.Where(x => x.Name.Equals(name)).Select(x => x.GenreId).Single());

                    List<MovieGenre> movieGenres = new List<MovieGenre>(genres.Count());
                    foreach (var genreId in genreIds)
                        movieGenres.Add(new MovieGenre { MovieId = movieId, GenreId = genreId });

                    context.MovieGenre.AddRange(movieGenres);
                    context.SaveChanges();
                }
            }



        }


        static void Main(string[] args)
        {
            //DownloadFile();
            UpdateMovieTable();

        }
    }
}
