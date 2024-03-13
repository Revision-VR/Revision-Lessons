using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTheme : MonoBehaviour
{

    private bool isDark = false;
    
    public void ChangeThemeButton()
    {
        if (isDark)
        {
            ChangeThemeToDark();
        }
        else
        {
            ChangeThemeToWhite();
        }

        isDark = !isDark;
    }


    void ChangeThemeToDark()
    {

    }

    void ChangeThemeToWhite()
    {

    }

}
