using UnityEngine;
using UnityEngine.UI;

public class Sladvalue : MonoBehaviour
{
    Text slidervalue;

    void Start()
    {
        slidervalue = GetComponent<Text>();
    }

    public void valueUpdate (float value)
    {
        slidervalue.text = Mathf.RoundToInt(value * 100).ToString();
    }
}
