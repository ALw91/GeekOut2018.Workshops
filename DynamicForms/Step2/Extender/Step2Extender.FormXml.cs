using Soneta.Business.UI;

namespace DynamicForms.Step2.Extender {
    public partial class Step2Extender {
        private GroupContainer root;

        public UIElement GetStackElement() {
            checkBuffer();
            if (root == null) {
                root = new GroupContainer {
                    CaptionHtml = "Generowana lista spotkań",
                    Height = "*",
                    Width = "*"
                };

                root.Elements.Add(new GapElement {
                    Height = "5",
                    Width = "*"
                });
            }
            return root;
        }

    }
}
