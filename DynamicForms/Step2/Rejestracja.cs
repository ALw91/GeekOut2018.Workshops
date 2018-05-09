using DynamicForms.Step2.Extender;
using Soneta.Business.Licence;
using Soneta.Business.UI;

[assembly: FolderView("GeekOut/DynamicForms/Krok 2", Priority = 20,
    IconName = "komentarz",
    Description = "Generowana lista",
    ObjectType = typeof(Step2Extender),
    ObjectPage = "Step2.Ogolne.pageform.xml",
    ReadOnlySession = true,
    ConfigSession = false,
    Contexts = new object[] { LicencjeModułu.All }
)]