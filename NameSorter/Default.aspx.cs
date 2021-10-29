using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NameSorter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string[] SortName()
        {
            string[] names = System.IO.File.ReadAllLines(Server.MapPath(@"~/FileText/unsorted-names-list.txt"));
            var sortKey = names.Select(SortLast).ToArray();
            System.Array.Sort(sortKey, names);
            return names;
        }

        private string SortLast(string name)
        {
            string[] names = name.Split(' ');
            var length = names.Length;

            return names[length - 1] + ' ' + string.Join(' '.ToString(), names, 0, length - 1);
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            var names = SortName();
            System.IO.File.WriteAllLines(Server.MapPath(@"~/FileText/sorted-names-list.txt"), names);
        }
    }
}

