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

                root.Elements.Add(GetFilterElements());
                root.Elements.Add(new GapElement { Height = "1", Width = "1" });
                root.Elements.Add(GetGroupElements());
            }
            return root;
        }

        private UIElement GetFilterElements() {
            var flow = new FlowContainer(new FieldElement {
                EditValue = "{FilterParameters.Month}",
                CaptionHtml = "Spotkania w miesiącu",
                Width = "20"
            });
            return flow;
        }

        private UIElement GetGroupElements() {
            var flow = new FlowContainer();
            var tasks = Tasks;
            for (var i = 0; i < tasks.Length; i++) {
                flow.Elements.Add(getUIElement(i));
            }
            return flow;
        }

        private UIElement getUIElement(int i) {
            var row = new RowContainer();
            var group = new GroupContainer {
                DataContext = "{Tasks[" + i + "]}",
                CaptionHtml = "{Title}",
                Width = "350px",
                Height = "80px"
            };

            var image = new FieldElement {
                CaptionHtml = "",
                EditValue = "{Zadanie.Przedstawiciel.DefaultImage}",
                Width = "110px",
                Height = "150px",
                Class = new UIClass[] { UIClass.ImageEdit }
            };

            var stackLeft = new StackContainer();
            var stackRight = new StackContainer {
                LabelWidth = "20"
            };

            var labelContact = new LabelElement {
                CaptionHtml = "{Zadanie.Przedstawiciel.Nazwa}",
                Class = new UIClass[] { UIClass.BoldLabel, UIClass.GreenFont },
                Width = "20"
            };

            var labelPhone = new LabelElement {
                CaptionHtml = "{Zadanie.Przedstawiciel.Kontakt.TelefonKomorkowy}",
                Class = new UIClass[] { UIClass.BoldLabel, UIClass.GreenFont },
                Width = "16"
            };

            var labelCompany = new LabelElement {
                CaptionHtml = "{Zadanie.Kontrahent.Kod}",
                Width = "20"
            };

            var labelAddress1 = new LabelElement {
                CaptionHtml = "{Zadanie.Kontrahent.Adres.Linia1}",
                Width = "30"
            };

            var labelAddress2 = new LabelElement {
                CaptionHtml = "{Zadanie.Kontrahent.Adres.Linia2}",
                Width = "30"
            };

            stackLeft.Elements.Add(image);
            stackRight.Elements.Add(labelContact);
            stackRight.Elements.Add(labelPhone);
            stackRight.Elements.Add(labelCompany);
            stackRight.Elements.Add(labelAddress1);
            stackRight.Elements.Add(labelAddress2);

            row.Elements.Add(stackLeft);
            row.Elements.Add(stackRight);

            group.Elements.Add(row);
            group.Elements.Add(new GapElement {
                Height = "1",
                Width = "0"
            });

            return group;
        }
    }
}
