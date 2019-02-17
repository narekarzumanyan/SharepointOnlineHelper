using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Xml.Linq;
using SharepointHelper.Models;
using System.IO;

namespace SharepointHelper.Utilities
{
    class XMLDataManager
    {
        private static XDocument _document;
        private static List<User> _users = new List<User>();
        private static string _xmlSource = "App_Data\\UserInfo.xml";

        static XMLDataManager()
        {
            Initialize();
        }

        private static void Initialize()
        {
            _document = XDocument.Load(_xmlSource);

            XElement userContainer = _document.Element("Users");
            IEnumerable<XElement> users = userContainer.Elements();

            DateTime? lastLoginDate;
            _users.Clear();

            foreach (XElement user in users)
            {
                if (!string.IsNullOrEmpty(user.Element("LastLoginDate").Value))
                    lastLoginDate = DateTime.Parse(user.Element("LastLoginDate").Value);
                else
                    lastLoginDate = null;

                _users.Add(new User
                {
                    SiteName = user.Element("SiteName").Value,
                    SiteURL = user.Element("SiteURL").Value,
                    Login = user.Element("Login").Value,
                    Password = EncryptionManager.Decrypt(user.Element("Password").Value),
                    LastLoginDate = lastLoginDate
                });
            }
        }

        public static User GetLastLoggedInUser()
        {
            return _users.OrderByDescending(x => x.LastLoginDate).FirstOrDefault();
        }

        public static List<UserSiteListItem> GetSiteNames()
        {
            List<UserSiteListItem> siteNames = new List<UserSiteListItem>();

            foreach (User user in _users)
                siteNames.Add(new UserSiteNameListItem { User = user });

            return siteNames;
        }

        public static List<UserSiteListItem> GetSiteURLs()
        {
            List<UserSiteListItem> siteURLs = new List<UserSiteListItem>();

            foreach (User user in _users)
                siteURLs.Add(new UserSiteURLListItem { User = user });

            return siteURLs;
        }

        public static bool IsUserAllowedToLogin(User user)
        {
            DateTime? lastLoginDate = user.LastLoginDate;
            return lastLoginDate.HasValue && DateTime.Compare(DateTime.Now, lastLoginDate.Value.AddDays(3)) <= 0;
        }

        public static bool EverLoggedIn(string siteURL)
        {
            return _users.Any(x => x.SiteURL == siteURL);
        }

        public static void UpdateSiteName(string siteURL, string siteName)
        {
            XElement userContainer = _document.Element("Users");
            XElement xUser = userContainer.Elements().FirstOrDefault(x => x.Element("SiteURL").Value == siteURL + "/");

            xUser.Element("SiteName").Value = siteName;

            _document.Save(_xmlSource);
            Initialize();
        }

        public static void AddNewEntry(string siteName, string siteURL, string login, string password)
        {
            XElement userContainer = _document.Element("Users");
            XElement xUser = new XElement("User");

            XElement xSiteName = new XElement("SiteName", siteName);
            XElement xSiteURL = new XElement("SiteURL", siteURL);
            XElement xLogin = new XElement("Login", login);
            XElement xPassword = new XElement("Password", EncryptionManager.Encrypt(password));
            XElement xLastLoginDate = new XElement("LastLoginDate", DateTime.Now.ToString());

            xUser.Add(xSiteName, xSiteURL, xLogin, xPassword, xLastLoginDate);
            userContainer.Add(xUser);

            _document.Save(_xmlSource);
            Initialize();
        }

        public static void UpdateEntry(string siteURL, string login, string password)
        {
            XElement userContainer = _document.Element("Users");
            XElement xUser = userContainer.Elements().FirstOrDefault(x => x.Element("SiteURL").Value == siteURL);

            xUser.Element("Login").Value = login;
            xUser.Element("Password").Value = EncryptionManager.Encrypt(password);
            xUser.Element("LastLoginDate").Value = DateTime.Now.ToString();

            _document.Save(_xmlSource);
            Initialize();
        }

        public static void RemoveDate(string siteURL)
        {
            XElement userContainer = _document.Element("Users");
            XElement xUser = userContainer.Elements().FirstOrDefault(x => x.Element("SiteURL").Value == siteURL);

            xUser.Element("LastLoginDate").Value = "";

            _document.Save(_xmlSource);
            Initialize();
        }

        public static bool RemoveCredentials(string siteURL)
        {
            XElement userContainer = _document.Element("Users");
            XElement xUser = userContainer.Elements().FirstOrDefault(x => x.Element("SiteURL").Value == siteURL);

            if (xUser != null)
            {
                xUser.Element("Login").Value = "";
                xUser.Element("Password").Value = "";
                xUser.Element("LastLoginDate").Value = "";

                _document.Save(_xmlSource);
                Initialize();

                return true;
            }

            return false;
        }
    }
}
