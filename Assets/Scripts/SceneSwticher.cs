using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwticher : MonoBehaviour
{
    public void toMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void toCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void toSetting()
    {
        SceneManager.LoadScene("GameSetting");
    }
}
