using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MerilTicaret.Models;
namespace MerilTicaret.App_Classes
{
    public class Context
    {
        private static MerilContext baglanti;

        public static MerilContext Baglanti
        {
            get
            {
                if (baglanti == null)
                    baglanti = new MerilContext();
                return baglanti;
            }
            set { baglanti = value; }
        }
    }
}