using System.Web;
using System.Web.Optimization;

namespace Seguros.Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.js",
                        "~/js/plugin/jquery.dataTables.min.js",
                        "~/js/HttpService/Api.js",
                        "~/js/Utils/JsonUtils.js",
                        "~/js/Utils/RoutesUtils.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/JqueryValidation").Include(
                "~/js/plugin/jquery.validate.min.js"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/css/jquery.dataTables.min.css"));

            bundles.Add(new StyleBundle("~/Content/Login").Include(
                      "~/css/login.css"));

            bundles.Add(new ScriptBundle("~/js/User/Login").Include(
                "~/js/User/Login.js"
            ));

            bundles.Add(new ScriptBundle("~/js/Home/Insurance").Include(
                "~/js/Home/Insurance.js"
            ));

            bundles.Add(new ScriptBundle("~/js/Home/Customer").Include(
                "~/js/Home/Customer.js"
            ));

            bundles.Add(new ScriptBundle("~/js/Home/CreateInsurance").Include(
                "~/js/Home/CreateInsurance.js"
            ));

            bundles.Add(new ScriptBundle("~/js/Home/PolicyClient").Include(
                "~/js/Home/PolicyClient.js"
            ));

            bundles.Add(new ScriptBundle("~/js/Home/CustomerInsurances").Include(
                "~/js/Home/CustomerInsurances.js"
            ));
        }
    }
}
