using DynamicForms.Step1;
using Soneta.Business.Licence;
using Soneta.Business.UI;

//[assembly: FolderView("GeekOut",
//    Priority = 9000,
//    Description = "Konferencja GeekOut 2018 - Warsztaty Programistyczne",
//    IconName = "komentarz",
//    Contexts = new object[] { LicencjeModułu.All }
//)]

//[assembly: FolderView("GeekOut/DynamicForms",
//    Description = "Dynamiczne formularze",
//    Priority = 9000,
//    IconName = "komentarz",
//    Contexts = new object[] { LicencjeModułu.All }
//)]

[assembly: FolderView("GeekOut/DynamicForms/Krok 1", Priority = 20,
    IconName = "komentarz",
    Description = "Rozmieszczenie układu dynamicznego formularza",
    ObjectType = typeof(Step1Extender),
    ObjectPage = "Step1.Ogolne.pageform.xml",
    ReadOnlySession = true,
    ConfigSession = false,
    Contexts = new object[] { LicencjeModułu.All }
)]