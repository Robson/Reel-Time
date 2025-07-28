//--------------------------------------------------------------//
// Films.cs
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
    using System.Text;

    internal static class Films
    {
        internal static List<(string, string, double, bool)> GetAllFilms()
        {
            const long MINUTE = 60;
            const long HOUR = MINUTE * 60;
            const long DAY = HOUR * 24;
            const long WEEK = DAY * 7;
            const long MONTH = DAY * 30;
            const long YEAR = DAY * 365;
            const long DECADE = YEAR * 10;
            const long CENTURY = DECADE * 10;
            const long MILLENIUM = CENTURY * 10;

            return new List<(string, string, double, bool)>()
            {
                //( "No Time to Die", "tt2382320", 0, false ),
                ( "Zero Days", "tt5446858", 0, false ),
                ( "Split Second", "tt0105459", 0.5, false ),
                ( "One Second", "tt8959680", 1, false ),
                ( "Two Seconds", "tt0023629", 2, false ),
                ( "7 Seconds", "tt0417395", 7, false ),
                ( "8 Seconds", "tt0109021", 8, false ),
                ( "Ten Seconds to Hell", "tt0053341", 10, false ),
                ( "Thirty Seconds Over Tokyo", "tt0037366", 30, false ),
                ( "37 Seconds", "tt6156138", 37, false ),
                ( "57 Seconds", "tt18083578", 57, false ),
                ( "59 Seconds", "tt1720035", 59, false ),
                ( "Gone in Sixty Seconds", "tt0187078", MINUTE, false ),
                ( "Two-Minute Warning", "tt0075359", MINUTE * 2, false ),
                //( "Beyond the Infinite Two Minutes", "tt14500584", MINUTE * 2, false ),
                ( "3½ Minutes, Ten Bullets", "tt4126312", MINUTE * 3.5, false ),
                ( "4 Minute Mile", "tt2217895", MINUTE * 4, false ),
                ( "Five Minutes of Heaven", "tt1238291", MINUTE * 5, false ),
                ( "Six Minutes to Midnight", "tt5114840", MINUTE * 6, false ),
                ( "7 Minutes", "tt2828954", MINUTE * 7, false ),
                ( "10 Minutes Gone", "tt8809652", MINUTE * 10, false ),
                ( "11 Minutes", "tt3865478", MINUTE * 11, false ),
                ( "Thirteen Minutes", "tt9274670", MINUTE * 13, false ),
                //( "13 Minutes", "tt1708135", MINUTE * 13, false ),
                ( "15 Minutes", "tt0179626", MINUTE * 15, false ),
                ( "30 Minutes or Less", "tt1622547", MINUTE * 30, false ),
                ( "44 Minutes: The North Hollywood Shoot-Out", "tt0362389", MINUTE * 44, false ),
                ( "One Hour Photo" , "tt0265459", HOUR, false ),
                ( "Rush Hour", "tt0120812", HOUR, false ),
                ( "80 Minutes", "tt1119178", MINUTE * 80, false ),
                ( "88 Minutes", "tt0411061", MINUTE * 88, false ),
                ( "90 Minutes in Heaven", "tt4337690", MINUTE * 90, false ),
                ( "96 Minutes", "tt1641385", MINUTE * 96, false ),
                ( "97 Minutes", "tt16496386", MINUTE * 97, false ),
                ( "102 Minutes That Changed America", "tt1312203", MINUTE * 102, false ),
                ( "105 Minutes", "tt15290106", MINUTE * 105, false ),
                ( "2 Hours Love", "tt10452466", HOUR * 2, false ),
                ( "Four Hours at the Capitol", "tt15520020", HOUR * 4, false ),
                ( "One Fine Morning", "tt13482828", HOUR * 6, false ),
                ( "Dog Day Afternoon", "tt0072890", HOUR * 6, false ),
                ( "12 Hour Shift", "tt10309552", HOUR * 12, false ),
                //( "Night at the Museum", "tt0477347", HOUR * 12, false ),
                ( "13 Hours", "tt4172430", HOUR * 13, false ),
                ( "Fourteen Hours", "tt0043560", HOUR * 14, false ),
                //( "Independence Day" , "tt0116629", DAY, false ),
                ( "One Day", "tt1563738", DAY, false ),
                ( "25th Hour" , "tt0307901", HOUR * 25, false ),
                ( "36 Hours", "tt0057809", HOUR * 36, false ),
                ( "A Day and a Half", "tt20414642", HOUR * 36, false ),
                ( "Weekend at Bernie\"s", "tt0098627", DAY * 2, false ),
                ( "2 Days in New York", "tt1602472", DAY * 2, false ),
                ( "2 Days in Paris", "tt0841044", DAY * 2, false ),
                ( "48 Hrs.", "tt0083511", HOUR * 48, false ),
                ( "Three Days of the Condor", "tt0073802", DAY * 3, false ),
                ( "The Next Three Days", "tt1458175", DAY * 3, false ),
                ( "3 Days to Kill", "tt2172934", DAY * 3, false ),
                ( "Four Good Days", "tt10344522", DAY * 4, false ),
                ( "127 Hours", "tt1542344", HOUR * 127, false ),
                ( "5 Days of War", "tt1486193", DAY * 5, false ),
                ( "Five Days One Summer", "tt0083947", DAY * 5, false ),
                ( "6 Days", "tt4703048", DAY * 6, false ),
                ( "Six Days Seven Nights", "tt0120828", (DAY * 6) + (HOUR * 12), false ),
                ( "One Week", "tt1104806", WEEK, false ),
                //( "Seven Days in May", "tt0058576", DAY * 7, false ),
                //( "7 Days in Havana", "tt1797348", DAY * 7, false ),
                //( "7 Days", "tt14494586", DAY * 7, false ),
                //( "7 Days", "tt0445054", DAY * 7, false ),
                //( "Seven Days in Utopia", "tt1699147", DAY * 7, false ),
                //( "Seven Days to Noon", "tt0042949", DAY * 7, false ),
                //( "My Week with Marilyn", "tt1655420", DAY * 7, false ),
                ( "Eight Days a Week", "tt0119054", DAY * 8, false ),
                //( "The Beatles: Eight Days a Week - The Touring Years", "tt2531318", DAY * 8, false ),
                ( "Nine Days", "tt10451852", DAY * 9, false ),
                ( "How to Lose a Guy in 10 Days", "tt0251127", DAY * 10, false ),
                //( "Eleven Days, Eleven Nights", "tt0091002", DAY * 11, true ),
                ( "12 Days of Terror", "tt0373653", DAY * 12, false ),
                ( "Thirteen Days", "tt0146309", DAY * 13, false ),
                ( "Two Weeks Notice", "tt0313737", WEEK * 2, false ),
                ( "18 Days", "tt1982848", DAY * 18, false ),
                ( "20 Days in Mariupol", "tt24082438", DAY * 20, false ),
                ( "21 Days", "tt0032179", DAY * 21, false ),
                //( "28 Days Later", "tt0289043", DAY * 28, false ),
                ( "28 Days", "tt0191754", DAY * 28, false ),
                ( "30 Days of Night", "tt0389722", DAY * 30, false ),
                ( "Employee of the Month", "tt0424993", MONTH, false ),
                ( "August: Osage County", "tt1322269", DAY * 31, false ),
                ( "Five Weeks in a Balloon", "tt0055988", WEEK * 5, false ),
                ( "40 Days and 40 Nights", "tt0243736", DAY * 40, false ),
                ( "40 Days and Nights", "tt2439946", DAY * 40, false ),
                ( "Six Weeks", "tt0084691", WEEK * 6, false ),
                ( "55 Days at Peking", "tt0056800", DAY * 55, false ),
                ( "9½ Weeks", "tt0091635", (long)(WEEK * 9.5), false ),
                ( "Toby Tyler or Ten Weeks with a Circus", "tt0054390", WEEK * 10, false ),
                ( "Around the World in 80 Days", "tt0327437", DAY * 80, false ),
                ( "Around the World in 80 Days", "tt0048960", DAY * 80, false ),
                ( "Three Months", "tt5322004", MONTH * 3, false ),
                ( "Summer of 84", "tt5774450", DAY * 93.6, false ),
                ( "100 Days", "tt0101244", DAY * 100, false ),
                ( "100 Days to Live", "tt10949778", DAY * 100, false ),
                ( "100 Days of Love", "tt3995348", DAY * 100, false ),
                ( "4 Months, 3 Weeks & 2 Days", "tt1032846", (MONTH * 4) + (WEEK * 3) + (DAY * 2), false ),
                ( "24 Weeks", "tt5369484", WEEK * 24, false ),
                ( "28 Weeks Later", "tt0463854", WEEK * 28, false ),
                ( "May December", "tt13651794", DAY * 235, false ),
                ( "Nine Months", "tt0113986", MONTH * 9, false ),
                ( "32 Weeks", "tt13380288", WEEK * 32, false ),
                ( "365 Days", "tt10886166", DAY * 365, false ),
                ( "365 Days: This Day", "tt12996154", DAY * 365, false ),
                ( "A Good Year", "tt0401445", YEAR, false ),
                ( "Leap Year", "tt1216492", YEAR + DAY, false ),
                ( "400 Days", "tt3774790", DAY * 400, false ),
                ( "438 Days", "tt8325442", DAY * 438, false ),
                ( "500 Days of Summer", "tt1022603", DAY * 500, false ),
                ( "The Best Two Years", "tt0377038", YEAR * 2, false ),
                ( "Anne of the Thousand Days", "tt0064030", DAY * 1000, false ),
                ( "Tokyo Olympiad", "tt0059817", YEAR * 4, false ),
                ( "4 Years", "tt22297570", YEAR * 4, false ),
                ( "Four More Years", "tt1598496", YEAR * 4, false ),
                ( "David Bowie: Five Years", "tt2973408", YEAR * 5, false ),
                ( "The Last Five Years", "tt2474024", YEAR * 5, false ),
                ( "The Five-Year Engagement", "tt1195478", YEAR * 5, false ),
                ( "6 Years", "tt3799372", YEAR * 6, false ),
                ( "Seven Years in Tibet", "tt0120102", YEAR * 7, false ),
                ( "3096 Days", "tt1667355", DAY * 3096, false ),
                ( "10 Years", "tt1715873", YEAR * 10, false ),
                ( "A Decade Under the Influence", "tt0342275", DECADE, false ),
                ( "12 Years a Slave", "tt2024544", YEAR * 12, false ),                
                ( "16 Years of Alcohol", "tt0331338", YEAR * 16, false ),
                ( "20 Years After", "tt0825279", YEAR * 20, false ),
                ( "20,000 Days on Earth", "tt2920540", DAY * 20000, false ),
                ( "United Nation Three Decades of Drum & Bass", "tt6824530", DECADE * 3, false ),
                ( "The 40 Year-Old Virgin", "tt0405422", YEAR * 40, false ),
                ( "45 Years", "tt3544082", YEAR * 45, false ),
                //( "Twentieth Century", "tt0025919", CENTURY, false ),
                ( "The Hundred Year-Old Man Who Climbed Out of the Window and Disappeared", "tt2113681", YEAR * 100, false ),
                ( "125 Years Memory", "tt3512072", YEAR * 125, false ),
                ( "Millennium", "tt0097883", MILLENIUM, false ),
                ( "Three Thousand Years of Longing", "tt9198364", YEAR * 3000, false ),
                ( "20,000 Years in Sing Sing", "tt0023731", YEAR * 20000, false ),
                ( "From Here to Eternity", "tt0045793", long.MaxValue, false )
            };
        }
    }
}