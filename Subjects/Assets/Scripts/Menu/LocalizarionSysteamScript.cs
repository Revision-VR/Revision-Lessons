using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalizarionSysteamScript : MonoBehaviour
{

    [SerializeField]
    private TMP_Text _namePage;

    public void ChangeLanguage(int _index)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_index];

        switch (_index)
        {
            case 0:
                PlayerPrefs.SetString("Language", "en");
                _namePage.text = "Settings";

                break;

            case 1:
                PlayerPrefs.SetString("Language", "ru");
                _namePage.text = "Настройки";

                break;

            case 2:
                PlayerPrefs.SetString("Language", "uz");
                _namePage.text = "Sozlamalar";

                break;
        }

    }


}
