using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Bot.Instagram.Profile
{
    static class Instragram
    {
        public static Profile GetProfileByUser(string userName)
        {
            var profile = new Profile(userName);

            string url = @"https://www.instagram.com/" + userName + "/?hl=pt-br";
            string html;

            using (WebClient wc = new WebClient())
            {
                html = wc.DownloadString(url);
            }

            HtmlAgilityPack.HtmlDocument conteudoHtml = new HtmlAgilityPack.HtmlDocument();
            conteudoHtml.LoadHtml(html);

            return profile;
        }
    }
}
  