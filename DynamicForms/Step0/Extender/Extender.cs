using Soneta.Business;
using Soneta.Business.App;

[assembly: Worker(typeof(DynamicForms.Step0.Extender))]

namespace DynamicForms.Step0 {
    public partial class Extender : ContextBase {
        public Extender(Context cx) : base(cx) {
        }

        public Operator Operator => Context.Login.Operator;

        public NamedStream Image  => Operator.DefaultImage;
    }
}
