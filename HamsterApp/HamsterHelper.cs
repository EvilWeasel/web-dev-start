using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HamsterApp
{
    public class HamsterHelper
    {
        public static string CreateMenu(int aktuell)
        {
            string[] cls = { "", "", "", "", "" };
            cls[aktuell] = "class=\"aktuell\"";
            string menu = $@"<ul>
            <li {cls[0]}><a href=""index.cshtml"">Start</a></li>
            <li {cls[1]}><a href=""info.cshtml"">Info</a></li>
            <li {cls[2]}><a href=""eingabe.cshtml"">Eingabe</a></li>
            <li {cls[3]}><a href=""anzeigen.cshtml"">Anzeigen</a></li>
            <li {cls[4]}><a href=""hilfe.cshtml"">Hilfe</a></li>
            </ul>";
            return menu;
        }


    }

}