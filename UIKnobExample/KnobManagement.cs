using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class KnobManagement : MonoBehaviour
{
    public Text KnobValue;
    public InputField SetKnobValue;
    public UI_Knob Knob;
    
    // Start is called before the first frame update
    public void UpdateKnobValue()
    {
        Knob.SetKnobValue(float.Parse(SetKnobValue.text));
    }

    // Update is called once per frame
    void Update()
    {
        KnobValue.text = Knob.KnobValue.ToString();
    }
}
