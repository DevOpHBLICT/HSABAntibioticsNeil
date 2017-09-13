using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{
   


    public class GetFrontPage
    {
        public String Image{ get; set; }

        public string Name { get; set; }
        public GetFrontPage(string name, string image)
        {
            Name = name;
            Image = image;
         

        }

    }

   


    public static class ContentsData
    {


        public static Color BrandColor = Color.FromHex("#FAA128");
   


       
    }

    public class Contents : ContentPage
    {
      
    


        public Contents()
        {
           
            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Hertfordshire Primary Care", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };

         

            Title = "Antibiotics Guidelines";
            NavigationPage.SetHasNavigationBar(this, true);
               
            BackgroundColor = Color.White;
    
            if (Device.OS == TargetPlatform.Windows)
            {

                NavigationPage.SetHasNavigationBar(this, false);
                }
            else
            {
    

            }

            


            var logo = new StackLayout
            {
                Padding = new Thickness(5, 5, 5, 5),
                Orientation = StackOrientation.Horizontal,

                Children = {    new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.StartAndExpand,
                          HeightRequest=30,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "th.jpg" )
                },
          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.EndAndExpand,
                          HeightRequest=30,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "hbl.png" )
            }
                }

            };

            var i = new Image
            {

                    BackgroundColor =Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 80,
                //   WidthRequest=90,
                //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                Source = ImageSource.FromFile("icon.png")
            };




            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();
            string st = "<HTML><BODY style='text-align:center'> This version of the Herts Antibiotics Guidelines app is: <br/><br/><b>OUT OF DATE</b> <br/><br/>and no longer supported on this store.<br/>";

            if (Device.OS == TargetPlatform.Android)
            {

                st = st + "<br/>Please download the latest version from the <a href='https://play.google.com/store/apps/details?id=herts.antibiotics'> HBL ICT Services store </a>";
            }

            if (Device.OS == TargetPlatform.Windows)
            {

                st = st + "<br/><center>Please download the latest version from the <a href='https://www.microsoft.com/en-gb/store/p/herts-antibiotics-guidelines/9pdvp723fqc5?rtc=1'> HBL ICT Services store </a> ";
            }
            st = st + "or search for <b>herts antibiotics</b> on the store.";
            st = st + "<br/>The new version of the guideline is updated to include the latest guidance for the management of";
            st = st + "<br/>Urinary Tract Infections";
            st = st + "<br/><br/>We are very keen to hear your feedback so that we can continually develop the Herts Antibiotics Guidelines. If you could leave some feedback on the app store we would be very grateful.</CENTER></BODY></HTML>";

            htmlSource.Html = st;
            browser.HeightRequest = 500;
          //  browser.BackgroundColor = Color.Blue;
            browser.Source = htmlSource;
            var layout = new StackLayout
            {
              Children = { logo, i,browser }
            };
                Content = new ScrollView { Content = layout };





        }
    }
}