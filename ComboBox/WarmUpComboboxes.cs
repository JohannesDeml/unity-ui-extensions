using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class WarmUpComboboxes : MonoBehaviour
{

    public AutoCompleteComboBox acb;
    public ComboBox cb;
    public DropDownList ddl;

    private string[] dropDownItems = { "More", "ComboBox", "Example", "Goodness" };

    // Refreshing the items in a DropDOwn can happen anytime after the initial initialisation
    void Start()
    {
        // Set the currect set of items for the auto-complete combobox, removes original list
        acb.SetAvailableOptions(dropDownItems);

        // Set the currect set of items for the combobox, removes original list
        cb.SetAvailableOptions(dropDownItems);

        // Set the currect set of items for the DropDownList combobox, removes original list
        ddl.RefreshItems(dropDownItems);
    }
}
