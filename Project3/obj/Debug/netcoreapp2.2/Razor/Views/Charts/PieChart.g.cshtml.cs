#pragma checksum "C:\Users\wwwar\OneDrive\Desktop\Project 3\Project3\Views\Charts\PieChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0777f208dd37fd22e12aaee46cb6864b857ce575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charts_PieChart), @"mvc.1.0.view", @"/Views/Charts/PieChart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Charts/PieChart.cshtml", typeof(AspNetCore.Views_Charts_PieChart))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\wwwar\OneDrive\Desktop\Project 3\Project3\Views\_ViewImports.cshtml"
using Project3;

#line default
#line hidden
#line 2 "C:\Users\wwwar\OneDrive\Desktop\Project 3\Project3\Views\_ViewImports.cshtml"
using Project3.Models;

#line default
#line hidden
#line 1 "C:\Users\wwwar\OneDrive\Desktop\Project 3\Project3\Views\Charts\PieChart.cshtml"
using System.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0777f208dd37fd22e12aaee46cb6864b857ce575", @"/Views/Charts/PieChart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8892e2d58655ce37e7300b7883175dc3939288c", @"/Views/_ViewImports.cshtml")]
    public class Views_Charts_PieChart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SimpleReportViewModel>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\wwwar\OneDrive\Desktop\Project 3\Project3\Views\Charts\PieChart.cshtml"
  
    var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Select(x => x.DimensionOne).ToList());
    var YValues = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Select(x => x.Quantity).ToList());
    ViewData["Title"] = "Pie Chart";

#line default
#line hidden
            BeginContext(314, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(343, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0777f208dd37fd22e12aaee46cb6864b857ce5753887", async() => {
                BeginContext(349, 106, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Orders Per Country Chart</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(462, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(464, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0777f208dd37fd22e12aaee46cb6864b857ce5755182", async() => {
                BeginContext(470, 174, true);
                WriteLiteral("\r\n    <div class=\"box-body\">\r\n\r\n        <div class=\"chart-container\">\r\n            <canvas id=\"chart\" style=\"width:100%; height:500px\"></canvas>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(651, 411, true);
            WriteLiteral(@"
</html>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>

<script type=""text/javascript"">

            $(function () {
        var chartName = ""chart"";
            var ctx = document.getElementById(chartName).getContext('2d');
            var data = {
                    labels: ");
            EndContext();
            BeginContext(1063, 17, false);
#line 35 "C:\Users\wwwar\OneDrive\Desktop\Project 3\Project3\Views\Charts\PieChart.cshtml"
                       Write(Html.Raw(XLabels));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 2823, true);
            WriteLiteral(@",
                    datasets: [{
                        label: ""Orders Per Country Chart"",
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)',
                            'rgba(255, 206, 86, 0.2)',
                            'rgba(75, 192, 192, 0.2)',
                            'rgba(153, 102, 255, 0.2)',
                            'rgba(255, 159, 64, 0.2)',
                            'rgba(255, 0, 0)',
                            'rgba(0, 255, 0)',
                            'rgba(0, 0, 255)',
                            'rgba(192, 192, 192)',
                            'rgba(255, 255, 0)',
                            'rgba(255, 0, 255)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)',
                            'rgba(255, 206, 86, 0.2)',
                            'rgba(75, 192, 192, 0.2)',
                          ");
            WriteLiteral(@"  'rgba(153, 102, 255, 0.2)',
                            'rgba(255, 159, 64, 0.2)',
                            'rgba(255, 0, 0)',
                            'rgba(0, 255, 0)',
                            'rgba(0, 0, 255)',
                            'rgba(192, 192, 192)',
                            'rgba(255, 255, 0)',
                            'rgba(255, 0, 255)'
                        ],
                        borderColor: [
                            'rgba(255,99,132,1)',
                            'rgba(54, 162, 235, 1)',
                            'rgba(255, 206, 86, 1)',
                            'rgba(75, 192, 192, 1)',
                            'rgba(153, 102, 255, 1)',
                            'rgba(255, 159, 64, 1)',
                            'rgba(255, 0, 0)',
                            'rgba(0, 255, 0)',
                            'rgba(0, 0, 255)',
                            'rgba(192, 192, 192)',
                            'rgba(255, 255, 0)',
      ");
            WriteLiteral(@"                      'rgba(255, 0, 255)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)',
                            'rgba(255, 206, 86, 0.2)',
                            'rgba(75, 192, 192, 0.2)',
                            'rgba(153, 102, 255, 0.2)',
                            'rgba(255, 159, 64, 0.2)',
                            'rgba(255, 0, 0)',
                            'rgba(0, 255, 0)',
                            'rgba(0, 0, 255)',
                            'rgba(192, 192, 192)',
                            'rgba(255, 255, 0)',
                            'rgba(255, 0, 255)'
                        ],
                        borderWidth: 1,
                        data: ");
            EndContext();
            BeginContext(3904, 17, false);
#line 91 "C:\Users\wwwar\OneDrive\Desktop\Project 3\Project3\Views\Charts\PieChart.cshtml"
                         Write(Html.Raw(YValues));

#line default
#line hidden
            EndContext();
            BeginContext(3921, 200, true);
            WriteLiteral("\r\n        }]\r\n                };\r\n\r\n\r\n\r\n           var myChart = new  Chart(ctx, {\r\n                    data: data,\r\n                    type:\'pie\'\r\n\r\n                });\r\n            });\r\n</script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SimpleReportViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
