using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyIoC;

namespace IoCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = TinyIoCContainer.Current;
            container.Register<Iitem_base, item_edm>("edm"); // Singleton 
            container.Register<Iitem_base, item_edm>("sms"); // Singleton 

            Console.WriteLine("Hello !");
            Console.Write("你要使用(edm/sms)?: ");
            string itemType = Console.ReadLine();
            Iitem_base item = container.Resolve<Iitem_base>(itemType);
            if (item != null)
            {
                bool flag = true;
                int nCount = 1;
                while (flag)
                {
                    Console.Write("下指令(create/delete/bye): ");
                    string cmd = Console.ReadLine();
                    if (cmd == "create")
                        item.Create("C1", "item_" + nCount.ToString());
                    else if (cmd == "delete")
                        item.Delete("C1", nCount);
                    else
                    {
                        flag = false;
                        Console.WriteLine("結束，Bye ~");
                    }
                    nCount++;
                }
            }
            Console.ReadLine();  
        }
    }
}
