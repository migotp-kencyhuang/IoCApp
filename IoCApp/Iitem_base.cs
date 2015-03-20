using System;
namespace IoCApp
{
    interface Iitem_base
    {
        //string strError { get; set; }
        int Create(string strCampaignID, string strName);
        int Delete(string strCampaignID, int nID);
    }
}
