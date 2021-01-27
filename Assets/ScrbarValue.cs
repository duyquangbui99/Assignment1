using UnityEngine.UI;
using UnityEngine;

public class ScrbarValue : MonoBehaviour
{
    Text scrbarValue;
    void Start()
    {
        scrbarValue = GetComponent<Text>();
    }

    // Update is called once per frame
    public void textUpdate(float value)
    {
        scrbarValue.text = "SPEED: "+  Mathf.RoundToInt(value * 10000).ToString();
    }
}
