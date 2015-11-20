

using UnityEngine;
using System.Collections;

public class SliderText : MonoBehaviour {

    string sliderTextString = "0";
    public UnityEngine.UI.Text sliderText; // public is needed to ensure it's available to be assigned in the inspector.

    public void textUpdate(float textUpdateNumber)
    {
        sliderTextString = textUpdateNumber.ToString();
        sliderText.text = sliderTextString;
    }
}
