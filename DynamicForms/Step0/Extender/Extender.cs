using Soneta.Business;

[assembly: Worker(typeof(DynamicForms.Step0.Extender))]

namespace DynamicForms.Step0 {
    public partial class Extender : ContextBase {
        public Extender(Context cx) : base(cx) {
        }
    }
}
