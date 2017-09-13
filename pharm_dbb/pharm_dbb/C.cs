using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{
   
    public class C : ContentPage
    {
        private ListView listView;
        private ListView _pharmacylist;
        public static int iAppear = 0;

        public C()
        {
           
         
            Title = "Antibiotics Guidelines";
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = " ";

            browser.BackgroundColor = Color.Blue;
            browser.Source = htmlSource;

            Content = browser;



           
            





         
         
        }
    }
}