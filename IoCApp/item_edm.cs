using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCApp
{
    class item_edm :  IoCApp.Iitem_base
    {
        public int Create(string strCampaignID, string strName)
        {
            // create edm db data
            int nEdmID = 1;
            // create edm folder
            // ........
            Console.WriteLine("建立 eDM !");
            return (nEdmID);
        }

        public int Delete(string strCampaignID, int nID)
        {
            // delete edm db data
            // delete edm  folder
            // ........
            Console.WriteLine("刪除 eDM !");
            return (1);
        }
    }
}
