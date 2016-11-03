using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml;

namespace SWE2_Project1.Classes
{
    class ConnectionXML
    {
        private static int check;
        private const int errorNum = 2;
        
        public static bool Load_xml(string userType, string userName, string userPassword)
        {
            XmlDocument x = new XmlDocument();
            x.Load("Login");
            int numberOfNodes = x.SelectNodes("//" + userType + "/Emp").Count;
            while (numberOfNodes != 0)
            {
                XmlNode node1 = x.SelectSingleNode("/Login/" + userType + "/Emp[" + numberOfNodes + "]/username");
                XmlNode node2 = x.SelectSingleNode("/Login/" + userType + "/Emp[" + numberOfNodes + "]/password");

                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] hashTxtUserPassword = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(userPassword));
                byte[] hashTxtUserName = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(userName));
                string TxtUserPassword = Encoding.Default.GetString(hashTxtUserPassword);
                string TxtUserName = Encoding.Default.GetString(hashTxtUserName);
                if (node1 != null && node2 != null)
                {
                    if (TxtUserName.Equals(node1.InnerText) && TxtUserPassword.Equals(node2.InnerText))
                    {
                        return true;
                    }
                }
                numberOfNodes--;
            }
            if (check++ > errorNum)
                ;

            return false;
        }

        public static bool addUser(string userType, string userName, string userPassword)
        {
            try
            {
                XmlDocument xd = new XmlDocument();
                xd.Load("Login");

                XmlNode xn = xd.SelectSingleNode("//" + userType + "/Emp[last()]/@id");
                int count;
                if (xn != null)
                    count = int.Parse(xn.InnerText) + 1;
                else
                    count = 1;

                XmlNode root_node = xd.SelectSingleNode("/Login/" + userType);
                XmlElement crnode = xd.CreateElement("Emp");

                crnode.SetAttribute("id", count.ToString());

                XmlElement nameNode = xd.CreateElement("username");
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] hashUserName = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(userName));
                nameNode.InnerText = Encoding.Default.GetString(hashUserName);

                XmlElement passNode = xd.CreateElement("password");
                md5 = new MD5CryptoServiceProvider();
                byte[] hashUserPassword = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(userPassword));
                passNode.InnerText = Encoding.Default.GetString(hashUserPassword);

                crnode.AppendChild(nameNode);
                crnode.AppendChild(passNode);
                root_node.AppendChild(crnode);
                xd.DocumentElement.AppendChild(root_node);
                xd.Save("Login");
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
