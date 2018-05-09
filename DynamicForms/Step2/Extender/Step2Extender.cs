using DynamicForms.Step2.Business;
using Soneta.Business;

[assembly: Worker(typeof(DynamicForms.Step2.Extender.Step2Extender))]

namespace DynamicForms.Step2.Extender {
    public partial class Step2Extender : ContextBase {

        private Params _parameters;

        public Step2Extender(Context cx) : base(cx) {
        }

        public Params FilterParameters => _parameters ?? (_parameters = new Params(Context));

        public TaskProxy[] Tasks {
            get {
                checkBuffer();
                if (tasks == null) {
                    RefreshTasks();
                }
                return tasks;
            }
        }
    }
}
