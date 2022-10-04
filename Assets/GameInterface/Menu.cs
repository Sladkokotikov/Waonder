using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Menu : MonoBehaviour
{
    public void SetLanguage(string lang)
        => StartCoroutine(LanguageSetter(lang));

    private IEnumerator LanguageSetter(string lang)
    {
        var localeNumber = lang switch
        {
            "ru"  => 1,
            "ua" => 2,
            _ => 0
        };
        
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeNumber];
        Debug.Log($"set {lang} language");
    }
}
