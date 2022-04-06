using System.Web;
using System.Web.Optimization;

namespace SysPerson.App
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/componentes/checkbox").Include(
                    "~/Content/Componentes/checkbox.css"));

            bundles.Add(new ScriptBundle("~/bundles/views/pessoa/formulario").Include(
                  "~/Scripts/Views/Pessoa/formulario.js"));

            bundles.Add(new ScriptBundle("~/bundles/componentes/maskedinput").Include(
                    "~/Scripts/Componentes/jquery.maskedinput.min.js"
                  ));

            bundles.Add(new ScriptBundle("~/bundles/componentes/maskmoney").Include(
              "~/Scripts/Componentes/jquery.maskMoney.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/componentes/select2").Include(
              "~/Scripts/Componentes/select2.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/componentes/modals").Include(
                    "~/Scripts/Componentes/modals.js"
                  ));
        }
    }
}
