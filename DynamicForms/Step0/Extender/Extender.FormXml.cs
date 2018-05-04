using Soneta.Business.UI;

namespace DynamicForms.Step0 {
    public partial class Extender {
        private StackContainer stackRoot;

        public UIElement GetStackElement() {
            if (stackRoot == null) {
                stackRoot = new StackContainer();
                var group0 = new GroupContainer {
                    Name = "group0",
                    CaptionHtml = "Element typu GroupContainer, układ poziomy",
                    Width = "*",
                    Height = "220px"
                };

                var row = new RowContainer();

                var stack1 = new StackContainer {
                    LabelWidth = "20"
                };
                var stack2 = new StackContainer();

                var field1 = new FieldElement {
                    Name = "fieldH1",
                    CaptionHtml = "Nazwa",
                    EditValue = "{Operator.Name}",
                    Width = "30"
                };
                var field2 = new FieldElement {
                    Name = "fieldH2",
                    CaptionHtml = "Pełna nazwa",
                    EditValue = "{Operator.FullName}",
                    Width = "30"
                };
                var field3 = new FieldElement {
                    Name = "fieldH3",
                    CaptionHtml = "Standardowy operator",
                    EditValue = "{Operator.IsStandard}",
                    Width = "8"
                };
                var field4 = new FieldElement {
                    Name = "fieldH4",
                    CaptionHtml = "",
                    EditValue = "{Image}",

                    Class = new UIClass[] { UIClass.ImageEdit },
                    Width = "200px",
                    Height = "200px"
                };

                stack1.Elements.Add(field1);
                stack1.Elements.Add(field2);
                stack1.Elements.Add(field3);
                stack2.Elements.Add(field4);

                row.Elements.Add(stack2);
                row.Elements.Add(stack1);

                group0.Elements.Add(row);
                stackRoot.Elements.Add(group0);
            }
            return stackRoot;
        }
    }
}
