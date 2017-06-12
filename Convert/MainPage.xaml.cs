using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace Convert
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }


        // From About Panorama 
        private void feedbackButton_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask
            {
                To = "info@pymblesoftware.com",
                Subject = "Feedback on convert WP8"
            };

            task.Show();
        }

        private void websiteButton_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask task = new WebBrowserTask();
            task.Uri = new Uri("http://www.pymblesoftware.com", UriKind.Absolute);
            task.Show();
        }

        private void rateButton_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

        /*
          from=foot&to=meter
           from=inch&to=cm
          from=mile&to=km
          naut. mile&to=km
          from=yard&to=meter
          from=chain&to=meter
          from=fathom&to=meter
          from=astronomical unit&to=km
          from=light year&to=km
          from=acre&to=meter^2
          from=hectare&to=m^2
          from=squares&to=m^2
          from=feet^2&to=m^2
          from=barrels&to=m^3
            from=ounces&to=m^3
            from=pints&to=m^3
            from=quarts&to=m^3
            from=gallons&to=litres
            from=carat(kt)&to=kg
            from=carat(ct)&to=kg
            from=eV&to=kg
            from=ounce&to=kg
            from=pounds&to=kg
            from=stone&to=kg
            from=rpm&to=rad
            from=mph&to=kph
            from=knotts&to=kph
            from=force pound&to=newtons
            from=atmosphere&to=pa
            from=bar&to=pa
            from=cm-mercury&to=pa
            from=calorie&to=joule
            from=eV&to=joule
            from=hp&to=joule
            from=hp(metric)&to=watt
            from=faraday&to=coulumb
            from=fahrenheit&to=celsius
            from=kelvin&to=celsius
            from=curie&to=becquerel
            from=rutherford&to=becquerel
            from=rads&to=gray
         */

        // ------------------------------ Length Panorama item --------------------------------------

        private void lenghtFootButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=foot&to=meter", UriKind.RelativeOrAbsolute));
        }

        private void lenghtInchButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=inch&to=cm", UriKind.RelativeOrAbsolute));
        }

        private void lengthMileButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=mile&to=km", UriKind.RelativeOrAbsolute));

        }

        private void lengthNauticalButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=naut. mile&to=km", UriKind.RelativeOrAbsolute));

        }

        private void lengthYardButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=yard&to=meter", UriKind.RelativeOrAbsolute));

        }

        private void lengthChainButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=chain&to=meter", UriKind.RelativeOrAbsolute));

        }

        private void lengthFathomButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=fathom&to=meter", UriKind.RelativeOrAbsolute));

        }

        private void lengthAstroButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=astronomical unit&to=km", UriKind.RelativeOrAbsolute));

        }

        private void lengthLightyearButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=light year&to=km", UriKind.RelativeOrAbsolute));

        }

        // -------------------------------------  Area Panorama Item ---------------------------------------
        private void areaAcreButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=acre&to=meter^2", UriKind.RelativeOrAbsolute));

        }

        private void areaHectareButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=hectare&to=m^2", UriKind.RelativeOrAbsolute));

        }

        private void areaSquareButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=squares&to=m^2", UriKind.RelativeOrAbsolute));

        }

        private void areaFeetSqButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=feet^2&to=m^2", UriKind.RelativeOrAbsolute));

        }

        // Volume Panorama items --------------------------------------------------------
        private void volumeBarrelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=barrels&to=m^3", UriKind.RelativeOrAbsolute));

        }

        private void volumeOunceButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=ounces&to=m^3", UriKind.RelativeOrAbsolute));

        }

        private void volumePintButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=pints&to=m^3", UriKind.RelativeOrAbsolute));

        }

        private void volumeQuartButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=quarts&to=m^3", UriKind.RelativeOrAbsolute));

        }

        private void volumeGalButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=gallons&to=litres", UriKind.RelativeOrAbsolute));

        }

        // -- mass

        private void massKTButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=carat(kt)&to=kg", UriKind.RelativeOrAbsolute));

        }

        private void massCTButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=carat(ct)&to=kg", UriKind.RelativeOrAbsolute));

        }

        private void massEVButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=eV&to=kg", UriKind.RelativeOrAbsolute));

        }

        private void massOunceButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=ounce&to=kg", UriKind.RelativeOrAbsolute));

        }

        private void massPoundButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=pounds&to=kg", UriKind.RelativeOrAbsolute));

        }

        private void massStoneButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=stone&to=kg", UriKind.RelativeOrAbsolute));

        }

        // --- speed
        private void speedRPMButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=rpm&to=rad", UriKind.RelativeOrAbsolute));

        }

        private void speedmphButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=mph&to=kph", UriKind.RelativeOrAbsolute));

        }

        private void speedKnottsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=knotts&to=kph", UriKind.RelativeOrAbsolute));

        }

        // ---- force 
        private void forcePoundButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=force pound&to=newtons", UriKind.RelativeOrAbsolute));

        }

        private void forceAtmosphereButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=atmosphere&to=pa", UriKind.RelativeOrAbsolute));

        }

        private void forceBarButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=bar&to=pa", UriKind.RelativeOrAbsolute));

        }

        private void forceCMMButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=cm-mercury&to=pa", UriKind.RelativeOrAbsolute));

        }

        // -- energy 
        private void energyCalorieButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=calorie&to=joule", UriKind.RelativeOrAbsolute));

        }

        private void energyEVButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=eV&to=joule", UriKind.RelativeOrAbsolute));

        }

        private void energyHPButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=hp&to=joule", UriKind.RelativeOrAbsolute));

        }

        private void energyHPMButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=hp(metric)&to=watt", UriKind.RelativeOrAbsolute));

        }

        private void energyFaradayButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=faraday&to=coulumb", UriKind.RelativeOrAbsolute));

        }

        // --- temp ---
        private void tempF2CButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=fahrenheit&to=celsius", UriKind.RelativeOrAbsolute));

        }

        private void tempK2CButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=kelvin&to=celsius", UriKind.RelativeOrAbsolute));

        }

        // -- radiation

        private void radiationCurieButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=curie&to=becquerel", UriKind.RelativeOrAbsolute));

        }

        private void radiationRutherfordButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=rutherford&to=becquerel", UriKind.RelativeOrAbsolute));

        }

        private void radiationRadButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalcPage.xaml?from=rads&to=gray", UriKind.RelativeOrAbsolute));

        }

        private void InneractiveXamlAd1_Loaded(object sender, RoutedEventArgs e)
        {
            // ------- NAX Ad loaded --------
        }
    }
}