using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalizarionSysteamScript : MonoBehaviour
{
    

    public void ChangeLanguage(int _index)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_index];

        switch (_index)
        {
            case 0:
                PlayerPrefs.SetString("Language", "en");
                break;

            case 1:
                PlayerPrefs.SetString("Language", "ru");
                break;

            case 2:
                PlayerPrefs.SetString("Language", "uz");
                break;
        }

    }


}
