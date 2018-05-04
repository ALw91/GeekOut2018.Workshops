using Soneta.Business.UI;

namespace DynamicForms.Step1 {
    public partial class Step1Extender {
        private StackContainer stackRoot;
        private StackContainer stackHorizontal;
        private StackContainer stackVertical;

        public UIElement GetStackElement() {
            if (stackRoot == null) {
                stackRoot = new StackContainer();
                stackRoot.Elements.Add(GetHorizontalElements());
                stackRoot.Elements.Add(new GapElement {
                    Width = "4",
                    Height = "4"
                });
                stackRoot.Elements.Add(GetVerticalElements());
            }
            return stackRoot;
        }

        private UIElement GetHorizontalElements() {
            if (stackHorizontal == null) {
                stackHorizontal = new StackContainer {
                    Height = "250px"
                };

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
                stackHorizontal.Elements.Add(group0);
            }
            return stackHorizontal;
        }

        private UIElement GetVerticalElements() {
            if (stackVertical == null) {
                stackVertical = new StackContainer();

                var group0 = new GroupContainer {
                    Name = "groupV0",
                    CaptionHtml = "Element typu GroupContainer - układ pionowy",
                    Width = "*",
                    Height = "400px"
                };

                var stack1 = new StackContainer {
                    LabelWidth = "20"
                };
                var stack2 = new StackContainer();

                var label1 = new LabelElement {
                    Name = "label1V",
                    CaptionHtml = "Nazwa"
                };
                var field1 = new FieldElement {
                    Name = "fieldV1",
                    CaptionHtml = "",
                    EditValue = "{Operator.Name}",
                    Width = "35"
                };

                var label2 = new LabelElement {
                    Name = "label2V",
                    CaptionHtml = "Pełna nazwa"
                };
                var field2 = new FieldElement {
                    Name = "fieldV2",
                    CaptionHtml = "",
                    EditValue = "{Operator.FullName}",
                    Width = "35"
                };

                var field3 = new FieldElement {
                    Name = "fieldV3",
                    CaptionHtml = "Standardowy operator",
                    EditValue = "{Operator.IsStandard}",
                    Width = "8",
                    OuterWidth = "37"
                };
                var field4 = new FieldElement {
                    Name = "fieldV4",
                    CaptionHtml = "",
                    EditValue = "{Image}",

                    Class = new UIClass[] { UIClass.ImageEdit },
                    Width = "200px",
                    Height = "200px"
                };

                stack1.Elements.Add(label1);
                stack1.Elements.Add(field1);

                stack1.Elements.Add(label2);
                stack1.Elements.Add(field2);

                stack1.Elements.Add(field3);
                stack2.Elements.Add(field4);

                group0.Elements.Add(stack2);
                group0.Elements.Add(stack1);
                stackVertical.Elements.Add(group0);
            }
            return stackVertical;
        }
    }
}
