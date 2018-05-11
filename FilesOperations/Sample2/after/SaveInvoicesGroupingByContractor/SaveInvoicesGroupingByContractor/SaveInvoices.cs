using System.IO;
using System.Linq;
using SaveInvoicesGroupingByContractor;
using Soneta.Business;
using Soneta.Business.App;
using Soneta.Business.UI;
using Soneta.Handel;

[assembly: Worker(typeof(SaveInvoices), typeof(DokHandlowe))]

namespace SaveInvoicesGroupingByContractor
{
    public class SaveInvoices
    {

        [Context]
        public static Context Context { get; set; }

        [Context]
        public DokumentHandlowy[] DokumentyHandlowe { get; set; }

        [Action("Zapisz faktury",
            Target = ActionTarget.ToolbarWithText | ActionTarget.Menu | ActionTarget.LocalMenu | ActionTarget.Divider,
            Mode = ActionMode.SingleSession)]
        public object SaveDataWorker()
        {
            Context.Session.GetService(out IFileSystemService fss);
            if (fss == null)
                return null;

            var faktury = DokumentyHandlowe.GroupBy(f => f.Kontrahent);

            fss.CreateDirectory(@"C:\faktury\");

            foreach (var faktura in faktury)
            {
                var path = @"C:\faktury\" + faktura.Select(f => f.Kontrahent).First();
                fss.CreateDirectory(path);

                foreach (var fak in faktura)
                {
                    CreateCorrectContext(fak);
                    var report = GenerateReport();
                    var raportNamePath = path + "\\" + fak.Numer.NumerPelny.Replace(@"/", "") + ".pdf";
                    fss.WriteFile(raportNamePath, ((MemoryStream)report).ToArray());
                }
            }
            return null;
        }

        private void CreateCorrectContext(DokumentHandlowy fak)
        {
            DokumentyHandlowe = new[] { fak };
            Context.Set(DokumentyHandlowe);
        }

        private static Stream GenerateReport()
        {
            BusApplication.Instance.GetService(out IReportService rs);
            if (rs == null)
                return null;

            var raport = new ReportResult
            {
                Caption = "Dokument sprzedaży",
                Context = Context,
                Preview = false,
                TemplateFileName = "Handel/Dokumenty sprzedazy.aspx",
                Format = ReportResultFormat.PDF,
            };

            return rs.GenerateReport(raport);
        }

    }

}
