using Soneta.Business.UI;

namespace DynamicForms.Step0 {
    public partial class Extender {
        private StackContainer stack;

        public UIElement GetStackElement() {
            if (stack == null) {
                stack = new StackContainer();
            }
            return stack;
        }

    }
}
