using ReadFileFromList.Workers;
using Soneta.Business;
using Soneta.Handel;

[assembly: Worker(typeof(ReadFile), typeof(DokHandlowe))]

namespace ReadFileFromList.Workers
{
    public class ReadFile
    {

        [Action("Odczytaj dane",
            Target = ActionTarget.ToolbarWithText | ActionTarget.Menu | ActionTarget.LocalMenu | ActionTarget.Divider,
            Mode = ActionMode.SingleSession)]
        public object ReadDataWorker()
        {
            return null;
        }

    }

}
