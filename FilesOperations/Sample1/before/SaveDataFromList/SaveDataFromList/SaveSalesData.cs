using SaveDataFromList;
using Soneta.Business;
using Soneta.Magazyny;

[assembly: Worker(typeof(SaveSalesData), typeof(Obrot))]

namespace SaveDataFromList
{
    public class SaveSalesData
    {

        [Action("Zapisz dane do pliku",
            Target = ActionTarget.ToolbarWithText | ActionTarget.Menu | ActionTarget.LocalMenu | ActionTarget.Divider,
            Mode = ActionMode.SingleSession)]
        public NamedStream SaveDataWorker()
        {

            return null;
        }

    }

}
