using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManualDropDown : MonoBehaviour
{

    //[SerializeField]
    private TMP_Dropdown dropdown;

    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        //dropdown.Show();
        // Add a listener to the dropdown to detect when an option is selected
        dropdown.onValueChanged.AddListener(delegate {
            OnDropdownValueChanged(dropdown);
        });

        //Invoke("ShowDropDown", 1);

    }


    void ShowDropDown()
    {
        dropdown.Show();
    }

    void OnDropdownValueChanged(TMP_Dropdown _dropDown)
    {
        //print("Nmadur");

        // Optionally, you can add your custom behavior here when an option is selected.
        // For example, you might want to trigger a certain action based on the selection.

        // Since you want the dropdown to remain visible after selection, you can prevent it from closing.
        _dropDown.Show();
    }
}
