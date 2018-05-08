using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        #region DataMembers
        private string _title;
        private string _category;
        #endregion

        #region Properties
        public string Title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }

        public string Category
        {
            set
            {
                _category = value;
            }
            get
            {
                return _category;
            }
            #endregion
        }
        #region Constructors
        public Movie()
        {

        }

        public Movie (string t, string c)
        {
            Title = t;
            Category = c;
        }
        #endregion

        #region PrintInfoMethods
        public void PrintInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Category);
        }
        #endregion





    }
}
