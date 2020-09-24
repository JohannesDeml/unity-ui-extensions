using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class AddComboBoxItems : MonoBehaviour
{
    public InputField input;
    public ComboBox comboBox;
    public DropDownList dropDownList;
    public AutoCompleteComboBox autoComplete;

    public void AddComboBox()
    {
        if (!string.IsNullOrWhiteSpace(input.text))
        {
            comboBox.AddItem(input.text);
        }
    }

    public void AddDropDownList()
    {
        if (!string.IsNullOrWhiteSpace(input.text))
        {
            dropDownList.AddItem(input.text);
        }
    }

    public void AddAutoComplete()
    {
        if (!string.IsNullOrWhiteSpace(input.text))
        {
            autoComplete.AddItem(input.text);
        }
    }
}
