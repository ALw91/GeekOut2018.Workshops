using SaveInvoicesGroupingByContractor;
using Soneta.Business;
using Soneta.Magazyny;

[assembly: Worker(typeof(SaveInvoices), typeof(Obrot))]

namespace SaveInvoicesGroupingByContractor
{
    public class SaveInvoices
    {

        [Action("Zapisz faktury",
            Target = ActionTarget.ToolbarWithText | ActionTarget.Menu | ActionTarget.LocalMenu | ActionTarget.Divider,
            Mode = ActionMode.SingleSession)]
        public object SaveDataWorker()
        {
            return null;
        }

    }

}
