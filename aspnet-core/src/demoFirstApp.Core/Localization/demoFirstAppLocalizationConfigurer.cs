using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace demoFirstApp.Localization
{
    public static class demoFirstAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(demoFirstAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(demoFirstAppLocalizationConfigurer).GetAssembly(),
                        "demoFirstApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
