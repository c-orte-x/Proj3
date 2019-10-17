using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3.Models;
using MongoDB.Driver;
using Project3.Services;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project3.Controllers
{
    public class ChartsController : Controller
    {
        private readonly OrdersService ordersService;
        private readonly ReturnsService returnsService;

        public ChartsController(OrdersService ordersService, ReturnsService returnsService)
        {
            this.ordersService = ordersService;
            this.returnsService = returnsService;
        }

        public IActionResult BarChartOrdersAndReturns()
        {
            int cntOrders = ordersService.Get().Count();
            int cntReturns = returnsService.Get().Count();

            var lstModel = new List<SimpleReportViewModel>();
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Orders",
                Quantity = cntOrders
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Returns",
                Quantity = cntReturns
            });
            return View(lstModel);
        }

        public IActionResult BarChartMostReturnsPerRegion()
        {
            string region1st = "";
            string region2nd = "";

            int returns1st = 0;
            int return2nd = 0;

            int CentralUS = 0;
            int Oceania = 0;
            int EasternAsia = 0;
            int WesternEurope = 0;
            int SouthernEurope = 0;
            int SouthernAsia = 0;
            int EasternUS = 0;

            foreach (var item in returnsService.Get())
            {
                if (item.Region.Equals("Central US"))
                {
                    CentralUS++;
                }
                if (item.Region.Equals("Oceania"))
                {
                    Oceania++;
                }
                if (item.Region.Equals("Eastern Asia"))
                {
                    EasternAsia++;
                }
                if (item.Region.Equals("Western Europe"))
                {
                    WesternEurope++;
                }
                if (item.Region.Equals("Southern Europe"))
                {
                    SouthernEurope++;
                }
                if (item.Region.Equals("Southern Asia"))
                {
                    SouthernAsia++;
                }
                if (item.Region.Equals("Eastern US"))
                {
                    EasternUS++;
                }
            }
            ArrayList regions = new ArrayList();
            regions.Add(CentralUS);
            regions.Add(Oceania);
            regions.Add(EasternAsia);
            regions.Add(WesternEurope);
            regions.Add(SouthernEurope);
            regions.Add(SouthernAsia);
            regions.Add(EasternUS);

            ArrayList regionsNames = new ArrayList();
            regionsNames.Add("Central US");
            regionsNames.Add("Oceania");
            regionsNames.Add("Eastern Asia");
            regionsNames.Add("Western Europe");
            regionsNames.Add("Southern Europe");
            regionsNames.Add("Southern Asia");
            regionsNames.Add("Eastern US");

            for (int i = 0; i < regions.Count; i++)
            {
                if(Convert.ToInt32(regions[i]) > returns1st)
                {
                    region1st = regionsNames[i].ToString();
                    returns1st = Convert.ToInt32(regions[i]);
                }
                if((Convert.ToInt32(regions[i]) < returns1st) && (Convert.ToInt32(regions[i]) > return2nd))
                {
                    region2nd = regionsNames[i].ToString();
                    return2nd = Convert.ToInt32(regions[i]);
                }
            }

            var lstModel = new List<SimpleReportViewModel>();
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = region1st,
                Quantity = returns1st
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = region2nd,
                Quantity = return2nd
            });
            return View(lstModel);
        }

        public IActionResult PieChartAllOrdersByCountry()
        {
            int cntUS = 0;
            int cntAustralia = 0;
            int cntSenegal = 0;
            int cntNewZealand = 0;
            int cntGermany = 0;
            int cntAfghanistan = 0;
            int cntBrazil = 0;
            int cntChina = 0;
            int cntSaudiArabia = 0;
            int cntFrance = 0;
            int cntItaly = 0;
            int cntTanzania = 0;
            int cntPoland = 0;
            int cntUnitedKingdom = 0;
            int cntDominicanRepublic = 0;
            int cntMexico = 0;
            int cntDemocraticRepublicoftheCongo = 0;
            int cntElSalvador = 0;
            int cntIndia = 0;
            int cntTaiwan = 0;
            int cntIndonesia = 0;
            int cntUruguay = 0;
            int cntIran = 0;
            int cntMozambique = 0;
            int cntBangladesh = 0;
            int cntSpain = 0;

            foreach (var item in ordersService.Get())
            {
                if (item.Country.Equals("United States"))
                {
                    cntUS++;
                }
                if (item.Country.Equals("Australia"))
                {
                    cntAustralia++;
                }
                if (item.Country.Equals("Senegal"))
                {
                    cntSenegal++;
                }
                if (item.Country.Equals("New Zealand"))
                {
                    cntNewZealand++;
                }
                if (item.Country.Equals("Germany"))
                {
                    cntGermany++;
                }
                if (item.Country.Equals("Afghanistan"))
                {
                    cntAfghanistan++;
                }
                if (item.Country.Equals("Brazil"))
                {
                    cntBrazil++;
                }
                if (item.Country.Equals("China"))
                {
                    cntChina++;
                }
                if (item.Country.Equals("Saudi Arabia"))
                {
                    cntSaudiArabia++;
                }
                if (item.Country.Equals("France"))
                {
                    cntFrance++;
                }
                if (item.Country.Equals("Italy"))
                {
                    cntItaly++;
                }
                if (item.Country.Equals("Tanzania"))
                {
                    cntTanzania++;
                }
                if (item.Country.Equals("Poland"))
                {
                    cntPoland++;
                }
                if (item.Country.Equals("United Kingdom"))
                {
                    cntUnitedKingdom++;
                }
                if (item.Country.Equals("Dominican Republic"))
                {
                    cntDominicanRepublic++;
                }
                if (item.Country.Equals("Mexico"))
                {
                    cntMexico++;
                }
                if (item.Country.Equals("Democratic Republic of the Congo"))
                {
                    cntDemocraticRepublicoftheCongo++;
                }
                if (item.Country.Equals("El Salvador"))
                {
                    cntElSalvador++;
                }
                if (item.Country.Equals("India"))
                {
                    cntIndia++;
                }
                if (item.Country.Equals("Taiwan"))
                {
                    cntTaiwan++;
                }
                if (item.Country.Equals("Indonesia"))
                {
                    cntIndonesia++;
                }
                if (item.Country.Equals("Uruguay"))
                {
                    cntUruguay++;
                }
                if (item.Country.Equals("Iran"))
                {
                    cntIran++;
                }
                if (item.Country.Equals("Mozambique"))
                {
                    cntMozambique++;
                }
                if (item.Country.Equals("Bangladesh"))
                {
                    cntBangladesh++;
                }
                if (item.Country.Equals("Spain"))
                {
                    cntSpain++;
                }
            }

            var lstModel = new List<SimpleReportViewModel>();
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "United States",
                Quantity = cntUS
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Australia",
                Quantity = cntAustralia
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Senegal",
                Quantity = cntSenegal
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "New Zealand",
                Quantity = cntNewZealand
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Germany",
                Quantity = cntNewZealand
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Afghanistan",
                Quantity = cntAfghanistan
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Brazil",
                Quantity = cntBrazil
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "China",
                Quantity = cntChina
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "France",
                Quantity = cntSaudiArabia
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Italy",
                Quantity = cntItaly
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Tanzania",
                Quantity = cntTanzania
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Poland",
                Quantity = cntPoland
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "United Kingdom",
                Quantity = cntUnitedKingdom
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Dominican Republic",
                Quantity = cntDominicanRepublic
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Mexico",
                Quantity = cntMexico
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "DRC",
                Quantity = cntDemocraticRepublicoftheCongo
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "El Salvador",
                Quantity = cntElSalvador
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "India",
                Quantity = cntIndia
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Taiwan",
                Quantity = cntTaiwan
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Indonesia",
                Quantity = cntIndonesia
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Uruguay",
                Quantity = cntUruguay
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Iran",
                Quantity = cntIran
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Mozambique",
                Quantity = cntMozambique
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Bangladesh",
                Quantity = cntBangladesh
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Spain",
                Quantity = cntSpain
            });
            return View(lstModel);
        }

        public IActionResult LineChartSalesOverYears()
        {
            string profit = "";
            string remProfit = "";
            int prof = 0;
            int maxProf2012 = 0;
            int maxProf2013 = 0;
            int maxProf2014 = 0;
            int maxProf2015 = 0;

            foreach (var item in ordersService.Get())
            {
                string date = item.OrderDate;
                date = date.Substring(date.LastIndexOf("/") + 1);
                if (date.Equals("2012"))
                {
                    profit = item.Sales;
                    remProfit = profit.Replace(",", "");
                    prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));

                    maxProf2012 = maxProf2012 + prof;
                }
                else if (date.Equals("2013"))
                {
                    profit = item.Sales;
                    remProfit = profit.Replace(",", "");
                    prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));

                    maxProf2013 = maxProf2013 + prof;

                }
                else if (date.Equals("2014"))
                {
                    profit = item.Sales;
                    remProfit = profit.Replace(",", "");
                    prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));

                    maxProf2014 = maxProf2014 + prof;
                }
                else if (date.Equals("2015"))
                {
                    profit = item.Sales;
                    remProfit = profit.Replace(",", "");
                    prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));

                    maxProf2015 = maxProf2015 + prof;
                }
            }

            var lstModel = new List<SimpleReportViewModel>();
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "2012",
                Quantity = maxProf2012
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "2013",
                Quantity = maxProf2013
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "2014",
                Quantity = maxProf2014
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "2015",
                Quantity = maxProf2015
            });

            return View(lstModel);
        }

        public IActionResult LineChartProfitOverYears()
        {
            string profit = "";
            string remProfit = "";
            int prof = 0;
            int maxProf2012 = 0;
            int maxProf2013 = 0;
            int maxProf2014 = 0;
            int maxProf2015 = 0;

            foreach (var item in ordersService.Get())
            {
                string date = item.OrderDate;
                date = date.Substring(date.LastIndexOf("/") + 1);
                if (date.Equals("2012"))
                {
                    profit = item.Profit;
                    remProfit = profit.Replace(",", "");
                    //remProfit = remProfit.Replace("$", "");
                    if(remProfit.Substring(0,1).Equals("("))
                    {
                        remProfit = remProfit.Replace("(", "");
                        remProfit = remProfit.Replace(")", "");

                        prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));
                        maxProf2012 = maxProf2012 - prof;
                    }
                    else
                    {
                        prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));

                        maxProf2012 = maxProf2012 + prof;
                    }
                }
                if (date.Equals("2013"))
                {
                    profit = item.Profit;
                    remProfit = profit.Replace(",", "");

                    if (remProfit.Substring(0, 1).Equals("("))
                    {
                        remProfit = remProfit.Replace("(", "");
                        remProfit = remProfit.Replace(")", "");

                        prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));
                        maxProf2013 = maxProf2013 - prof;
                    }
                    else
                    {
                        prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));

                        maxProf2013 = maxProf2013 + prof;
                    }
                }
                if (date.Equals("2014"))
                {
                    profit = item.Profit;
                    remProfit = profit.Replace(",", "");

                    if (remProfit.Substring(0, 1).Equals("("))
                    {
                        remProfit = remProfit.Replace("(", "");
                        remProfit = remProfit.Replace(")", "");

                        prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));
                        maxProf2014 = maxProf2014 - prof;
                    }
                    else
                    {
                        prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));

                        maxProf2014 = maxProf2014 + prof;
                    }
                }
                if (date.Equals("2015"))
                {
                    profit = item.Profit;
                    remProfit = profit.Replace(",", "");

                    if (remProfit.Substring(0, 1).Equals("("))
                    {
                        remProfit = remProfit.Replace("(", "");
                        remProfit = remProfit.Replace(")", "");

                        prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));
                        maxProf2015 = maxProf2015 - prof;
                    }
                    else
                    {
                        prof = Convert.ToInt32(remProfit.Substring(1, remProfit.IndexOf(".") - 1));

                        maxProf2015 = maxProf2015 + prof;
                    }
                }
            }

            var lstModel = new List<SimpleReportViewModel>();
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "2012",
                Quantity = maxProf2012
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "2013",
                Quantity = maxProf2013
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "2014",
                Quantity = maxProf2014
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "2015",
                Quantity = maxProf2015
            });

            return View(lstModel);
        }
    }
}
