using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Collections.ObjectModel;

namespace Yobit_notify
{
    public class Yobit
    {
        private string key = "3866E64F99113C1B49B962F3F009FD98";
        private string secret = "2992ec436b0023855195d679ea532518";

        private string apiInfoUrl = "https://yobit.net/api/3/info";
        private string apiTicker = "https://yobit.net/api/3/ticker/";


        public Dictionary<string, YobitPair> valutes;

        public List<TickerList> tickerList;

        public Yobit()
        {
            valutes = new Dictionary<string, YobitPair>();
            tickerList = new List<TickerList>();
        }

        private string getYobitApi(string str)
        {
            using (WebClient wc = new WebClient())
            {
                var response =  wc.DownloadString(str);
                return response;
            }
        }

        public Dictionary<string, YobitPair> getPairsList()
        {
            var json = getYobitApi(apiInfoUrl);

            JObject jo = JObject.Parse(json);
            JObject objResponse = (JObject)jo["pairs"];
            dynamic res = JsonConvert.DeserializeObject<dynamic>(objResponse.ToString());

            foreach (JProperty a in res)
            {
                var name = a.Path;
                //ticker += name + "-";
                var val = a.Value;
                var item = JsonConvert.DeserializeObject<YobitPair>(val.ToString());
                valutes.Add(name, item);
            }
            //ticker = ticker.Remove(ticker.Length - 1);
            getTickerList();
            return valutes;
        }

        private void getTickerList()
        {
            int iterator = 0;
            string url = apiTicker;
            foreach (var item in valutes)
            {
                if(iterator <= 15)
                {
                    url = url + item.Key + "-";
                    
                }
                iterator++;
                if (iterator == 15)
                {
                    url = url.Remove(url.Length - 1);
                    var json = getYobitApi(url);
                    iterator = 0;
                    url = apiTicker;
                }
                
            }
        }

    }

    public class TickerList
    {
        public string Name { get; set; }
        public double CurrentPrice { get; set; }
    }

    

    public class RootObject
    {
        [JsonProperty("pairs")]
        public List<YobitPair> pairs { get; set; }
    }


    public class Pair
    {
        public string name { get; set; }
    }

    public class YobitPair
    {
        public int decimal_places { get; set; }
        public double min_price { get; set; }
        public double max_price { get; set; }
        public double min_amount { get; set; }
        public double min_total { get; set; }
        public double hidden { get; set; }
        public double fee { get; set; }
        public double fee_buyer { get; set; }
        public double fee_seller { get; set; }
    }
    
}

