using Soneta.Business;
using Soneta.Business.App;

[assembly: Worker(typeof(DynamicForms.Step1.Step1Extender))]

namespace DynamicForms.Step1 {
    public partial class Step1Extender : ContextBase {
        public Step1Extender(Context cx) : base(cx) {
        }

        public Operator Operator => Context.Login.Operator;

        public NamedStream Image  => Operator.DefaultImage;
    }
}
