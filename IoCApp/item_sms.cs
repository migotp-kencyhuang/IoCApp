using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCApp
{
    class item_sms : IoCApp.Iitem_base
    {
        public int Create(string strCampaignID, string strName)
        {
            // create edm to db
            int nEdmID = 1;
            // create edm to folder
            // ........
            Console.WriteLine("建立 SMS !");
            return (nEdmID);
        }

        public int Delete(string strCampaignID, int nID)
        {
            // delete edm from db
            // delete edm from folder
            // ........
            Console.WriteLine("刪除 SMS !");
            return (1);
        }

    }
}
