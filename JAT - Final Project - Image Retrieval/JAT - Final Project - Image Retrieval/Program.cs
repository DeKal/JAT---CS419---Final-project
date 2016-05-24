using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAT___Final_Project___Image_Retrieval
{
    static class Program
    {
        static SearchForm searchForm;
       
        static ResultForm currentResultForm;

        public static ResultForm CurrentResultForm
        {
            get
            {
                return currentResultForm;
            }

            set
            {
                currentResultForm = value;
            }
        }

        public static SearchForm SearchForm
        {
            get
            {
                return searchForm;
            }

            set
            {
                searchForm = value;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            searchForm = new SearchForm();
            Application.Run(SearchForm);
        }
    }
}
