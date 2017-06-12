using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Telerik.Windows.Controls;
//using Telerik.Windows.Controls.RadToggleSwitch;

namespace Convert
{
    public partial class CalcPage : PhoneApplicationPage
    {
        private string to;
        private string from;

        public CalcPage()
        {
            InitializeComponent();

            to = "to";          
            from = "from";
            InverseToggleSwitch.CheckedChanged += InverseToggleSwitch_CheckedChanged;
            outputTextBlock.Opacity = 0.0;

        }

        void InverseToggleSwitch_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                this.toTextBlock.Text = to;
                this.fromTextBlock.Text = from;
            }
            else
            {
                this.toTextBlock.Text = from;
                this.fromTextBlock.Text = to;

            }

            outputTextBlock.Opacity = 0.0f;
            // throw new NotImplementedException();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string ToStr;
            string fromStr;
            if (NavigationContext.QueryString.TryGetValue("to", out ToStr))
            {
                to = ToStr;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("*** No 'TO' query string ***");
            }

            if (NavigationContext.QueryString.TryGetValue("from", out fromStr))
            {
                from = fromStr;
            }
            else
            {
                // TODO: throw or assert here when debugging.
                System.Diagnostics.Debug.WriteLine("*** No 'FROM' query string ***");
            }

            this.toTextBlock.Text = to;
            this.fromTextBlock.Text = from;

            this.pageNameTextBlock.Text = from + "/" + to;
        }


        private double foot2meter()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;

            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);


            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 0.3048;
            }
            else
            {
                result = input / 0.3048;
            }

            return result;
        }

        private double inch2cm()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 2.54;
            }
            else
            {
                result = input / 2.54;
            }

            return result;
        }
        private double mile2km()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 1.609344;
            }
            else
            {
                result = input / 1.609344;
            }

            return result;
        }
        private double nautMile2km()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 1.853184;
            }
            else
            {
                result = input / 1.853184;
            }

            return result;
        }
        private double yard2meter()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 0.9144;
            }
            else
            {
                result = input / 0.9144;

            }

            return result;
        }
        private double chain2meter()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 20.11684;
            }
            else
            {
                result = input / 20.11684;
            }

            return result;
        }
        private double fathom2meter()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 1.8288;
            }
            else
            {
                result = input / 1.8288;
            }

            return result;
        }
        private double astro2km()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 149597870.7;
            }
            else
            {
                result = input / 149597870.7;
            }

            return result;
        }
        private double lightYr2km()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 9.4607304725808e+12;
            }
            else
            {
                result = input / 9.4607304725808e+12;
            }

            return result;
        }
        private double acre2meterSQ()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  4046.8564224;
            }
            else
            {
                result = input /  4046.8564224;
            }

            return result;
        }
        private double hectare2meterSQ()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 10000;
            }
            else
            {
                result = input / 10000;
            }

            return result;
        }
        private double squares2meterSQ()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 9.290304;
            }
            else
            {
                result = input / 9.290304;
            }

            return result;
        }
        private double feet2meterSQ()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  9.290304e-2;
            }
            else
            {
                result = input / 9.290304e-2;
            }

            return result;
        }

        private double barrel2meter3()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  0.158987294928;
            }
            else
            {
                result = input /  0.158987294928;
            }

            return result;
        }
        private double ounces2meter3()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 29.5735295625e-6;
            }
            else
            {
                result = input / 29.5735295625e-6; 
            }

            return result;
        }
        private double pints2meter3()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  568.26125e-6;
            }
            else
            {
                result = input /  568.26125e-6;
            }

            return result;
        }
        private double quarts2meter3()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 946.352946e-6;
            }
            else
            {
                result = input / 946.352946e-6;
            }

            return result;
        }
        private double gallons2meter3()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  3.785411784e-3;
            }
            else
            {
                result = input /  3.785411784e-3;
            }

            return result;
        }
        private double kt2kg()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 0.205196548333; 
            }
            else
            {
                result = input / 0.205196548333;
            }

            return result;
        }
        private double ct2kg()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 0.200;                               
            }
            else
            {
                result = input / 0.200;
            }

            return result;
        }
        private double eV2kg()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 1.7826e-36;                   
            }
            else
            {
                result = input / 1.7826e-36;
            }

            return result;
        }
        private double ounce2kg()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 0.028;
            }
            else
            {
                result = input / 0.028;
            }

            return result;
        }
        private double pound2kg()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  0.45359237; 
            }
            else
            {
                result = input /  0.45359237;
            }

            return result;
        }
        private double stone2kg()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  6.35029318; 
            }
            else
            {
                result = input / 6.35029318; 
            }

            return result;
        }
        private double rpm2rad()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  0.104719755;
            }
            else
            {
                result = input /  0.104719755;
            }

            return result;
        }
        private double mph2kph()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 0.44704;
            }
            else
            {
                result = input / 0.44704;
            }

            return result;
        }
        private double knotts2kph()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  1.852;
            }
            else
            {
                result = input /  1.852;
            }

            return result;
        }
        private double forcepound2newtons()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  4.4482216152605;
            }
            else
            {
                result = input /  4.4482216152605;
            }

            return result;
        }
        private double atmosphere2pa()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 101325; 
            }
            else
            {
                result = input / 101325;
            }

            return result;
        }
        private double bar2pa()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 10e+5;
            }
            else
            {
                result = input / 10e+5;
            }

            return result;
        }
        private double cmm2pa()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  1.33322e+3;
            }
            else
            {
                result = input /  1.33322e+3;
            }

            return result;
        }
        private double calorie2joule()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  4.19002;
            }
            else
            {
                result = input / 4.19002;
            }

            return result;
        }
        private double eV2joule()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 1.60217733e-19;
            }
            else
            {
                result = input / 1.60217733e-19;
            }

            return result;
        }
        private double hp2joule()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 2.684519537696172792e+6;
            }
            else
            {
                result = input / 2.684519537696172792e+6;
            }

            return result;
        }
        private double hp2watt()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  735.49875; 
            }
            else
            {
                result = input /  735.49875;
            }

            return result;
        }
        private double faraday2coulumb()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  96485.3383;
            }
            else
            {
                result = input /  96485.3383;
            }

            return result;
        }
        private double f2c()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = (input - 32) * 5.0/9.0;
            }
            else
            {
                result = (input * 9/5) + 32;
            }

            return result;
        }
        private double k2c()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input - 273.15;
            }
            else
            {
                result = input + 273.15; 
            }

            return result;
        }
        private double curie2becquerel()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  3.7e+10;
            }
            else
            {
                result = input / 3.7e+10;
            }

            return result;
        }
        private double ruhterford2becquerel()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input * 10e+6;
            }
            else
            {
                result = input / 10e+6;
            }

            return result;
        }
        private double rad2gray()
        {
            double result = 0.0;
            double input;
            string data = InputRadTextBox.Text;
            // Empty input is a zero result.
            if (data == "")
            {
                input = 0.0;
                InputRadTextBox.Text = "0";
            }
            else
                input = System.Convert.ToDouble(data);

            bool isMetric = !InverseToggleSwitch.IsChecked;

            if (isMetric)
            {
                result = input *  0.01;
            }
            else
            {
                result = input /  0.01;
            }

            return result;
        }



        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isMetric = !InverseToggleSwitch.IsChecked;

            double result = 0.0;


            // do some kind of calculation.
            // Great big if staircase of statements for each calculation type.

            if (from.Equals("foot") && to.Equals("meter"))
            {
                // from=foot&to=meter
                result = foot2meter();
            }
            else if (from.Equals("inch") && to.Equals("cm"))
            {
                //   from=inch&to=cm
                result = inch2cm();

            }
            else if (from.Equals("mile") && to.Equals("km"))
            {
                // from=mile&to=km

                result = mile2km();
            }
            else if (from.Equals("naut. mile") && to.Equals("km"))
            {
                //  naut. mile&to=km
                result = nautMile2km();

            }
            else if (from.Equals("yard") && to.Equals("meter"))
            {
                //from=yard&to=meter
                result = yard2meter();
            }
            else if (from.Equals("chain") && to.Equals("meter"))
            {
                // from=chain&to=meter
                result = chain2meter();
            }
            else if (from.Equals("fathom") && to.Equals("meter"))
            {
                // from=fathom&to=meter
                result = fathom2meter();
            }
            else if (from.Equals("astronomical unit") && to.Equals("km"))
            {
                // from=astronomical unit&to=km
                result = astro2km();
            }
            else if (from.Equals("light year") && to.Equals("km"))
            {
                // from=light year&to=km
                result = lightYr2km();
            }
            else if (from.Equals("acre") && to.Equals("meter^2"))
            {
                // from=acre&to=meter^2
                result = acre2meterSQ();
            }
            else if (from.Equals("hectare") && to.Equals("m^2"))
            {
                //   from=hectare&to=m^2
                result = hectare2meterSQ();

            }
            else if (from.Equals("squares") && to.Equals("m^2"))
            {
                //   from=squares&to=m^2
                result = squares2meterSQ();

            }
            else if (from.Equals("feet^2") && to.Equals("m^2"))
            {
                //   from=feet^2&to=m^2
                result = feet2meterSQ();

            }
            else if (from.Equals("barrels") && to.Equals("m^3"))
            {
                //   from=barrels&to=m^3
                result = barrel2meter3();

            }
            else if (from.Equals("ounces") && to.Equals("m^3"))
            {
                //     from=ounces&to=m^3
                result = ounces2meter3();
            }
            else if (from.Equals("pints") && to.Equals("m^3"))
            {
                //     from=pints&to=m^3
                result = pints2meter3();

            }
            else if (from.Equals("quarts") && to.Equals("m^3"))
            {
                //     from=quarts&to=m^3
                result = quarts2meter3();

            }
            else if (from.Equals("gallons") && to.Equals("litres"))
            {
                //     from=gallons&to=litres
                result = gallons2meter3();

            }
            else if (from.Equals("carat(kt)") && to.Equals("kg"))
            {
                //     from=carat(kt)&to=kg
                result = kt2kg();

            }
            else if (from.Equals("carat(ct)") && to.Equals("kg"))
            {
                //     from=carat(ct)&to=kg
                result = ct2kg();
            }
            else if (from.Equals("eV") && to.Equals("kg"))
            {
                //     from=eV&to=kg
                result = eV2kg();

            }
            else if (from.Equals("ounce") && to.Equals("kg"))
            {
                //     from=ounce&to=kg
                result = ounce2kg();
            }
            else if (from.Equals("pounds") && to.Equals("kg"))
            {
                //     from=pounds&to=kg
                result = pound2kg();

            }
            else if (from.Equals("stone") && to.Equals("kg"))
            {
                //     from=stone&to=kg
                result = stone2kg();
            }
            else if (from.Equals("rpm") && to.Equals("rad"))
            {
                //     from=rpm&to=rad
                result = rpm2rad();

            }
            else if (from.Equals("mph") && to.Equals("kph"))
            {
                //     from=mph&to=kph
                result = mph2kph();

            }
            else if (from.Equals("knotts") && to.Equals("kph"))
            {
                //     from=knotts&to=kph
                result = knotts2kph();
            }
            else if (from.Equals("force pound") && to.Equals("newtons"))
            {
                //     from=force pound&to=newtons
                result = forcepound2newtons();
            }
            else if (from.Equals("atmosphere") && to.Equals("pa"))
            {
                //     from=atmosphere&to=pa
                result = atmosphere2pa();

            }
            else if (from.Equals("bar") && to.Equals("pa"))
            {
                //     from=bar&to=pa
                result = bar2pa();

            }
            else if (from.Equals("cm-mercury") && to.Equals("pa"))
            {
                //     from=cm-mercury&to=pa
                result = cmm2pa();
            }
            else if (from.Equals("calorie") && to.Equals("joule"))
            {
                //     from=calorie&to=joule
                result = calorie2joule();
            }
            else if (from.Equals("eV") && to.Equals("joule"))
            {
                //     from=eV&to=joule
                result = eV2joule();
            }
            else if (from.Equals("hp") && to.Equals("joule"))
            {
                //     from=hp&to=joule
                result = hp2joule();
            }
            else if (from.Equals("hp(metric)") && to.Equals("watt"))
            {
                //     from=hp(metric)&to=watt
                result = hp2watt();
            }
            else if (from.Equals("faraday") && to.Equals("coulumb"))
            {
                //     from=faraday&to=coulumb
                result = faraday2coulumb();
            }
            else if (from.Equals("fahrenheit") && to.Equals("celsius"))
            {
                //     from=fahrenheit&to=celsius
                result = f2c();
            }
            else if (from.Equals("kelvin") && to.Equals("celsius"))
            {
                //     from=kelvin&to=celsius
                result = k2c();
            }
            else if (from.Equals("curie") && to.Equals("becquerel"))
            {
                //     from=curie&to=becquerel
                result = curie2becquerel();
            }
            else if (from.Equals("rutherford") && to.Equals("becquerel"))
            {
                //     from=rutherford&to=becquerel
                result = ruhterford2becquerel();
            }
            else if (from.Equals("rads") && to.Equals("gray"))
            {
                //  from=rads&to=gray
                result = rad2gray();
            }
            else
            {
                // **** UNKNOWN STATE ****
                throw new UnauthorizedAccessException();
            }

            // display result, whatever that may be.
            outputTextBlock.Text = "" + result;
            outputTextBlock.Opacity = 1.0;
        }


        /***
         *          
                    double result = 0.0f;
            String AmountString = AmountTextBox.Text;
            String RequiredRateString = RequiredRateTextBox.Text;
            float income = 0.0f; // System.Convert.ToSingle(AmountTextBox.Text); 
            float requireRate = 0.0f; // System.Convert.ToSingle(RequiredRateTextBox.Text);

            if( AmountString.Length != 0 )
                income = System.Convert.ToSingle(AmountString);

            if( RequiredRateString.Length != 0 )
                requireRate = System.Convert.ToSingle(RequiredRateString); 


            if( requireRate != 0.0f )
                result = Math.Round( income / (requireRate / 100.0f), 2);
          ***/
    }
}