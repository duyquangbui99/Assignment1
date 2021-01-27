using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public string thename;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        thename = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Hello " + thename + ". Enjoy the game!";

    }

}
