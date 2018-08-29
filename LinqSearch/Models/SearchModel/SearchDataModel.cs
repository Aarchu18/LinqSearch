using LinqSearch.Models.SearchModel;
using System.Collections.Generic;
using System.Linq;

namespace LinqSearch.Models.SearchData
{
    public class SearchDataModel
    {
        public static List<SearchList> GetStudentDetail()
        {
            return new List<SearchList>
            {
                new SearchList
                {
                    StudentId=1,
                    StudentName="Archana",
                    StudentAge="20",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=2,
                    StudentName="Ranjana",
                    StudentAge="21",
                    StudentClass="12th"
                },
                new SearchList
                {
                    StudentId=3,
                    StudentName="Abhi",
                    StudentAge="17",
                    StudentClass="9th"
                },
                new SearchList
                {
                    StudentId=4,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=5,
                    StudentName="Tanya",
                    StudentAge="19",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=6,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=7,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=8,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=9,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=10,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=11,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=12,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=13,
                    StudentName="Richa",
                    StudentAge="7",
                    StudentClass="4th"
                },
                new SearchList
                {
                    StudentId=14,
                    StudentName="Richaa",
                    StudentAge="18",
                    StudentClass="5th"
                },
                new SearchList
                {
                    StudentId=15,
                    StudentName="RichaPriya",
                    StudentAge="7",
                    StudentClass="6th"
                },
            };

        }

        public static List<SearchList> GetStudentByName(string name)
        {
            List<SearchList> searchList = new List<SearchList>();

            searchList = (from s in GetStudentDetail()
                          where s.StudentName.ToLower().Contains(name.ToLower())
                          select s).ToList();
            return searchList;
            //return GetStudentDetail().Where(x => x.StudentName.Contains(name)).ToList();
        }
    }
}
