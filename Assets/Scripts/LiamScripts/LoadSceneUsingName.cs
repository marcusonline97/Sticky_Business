using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneUsingName : MonoBehaviour
{
    public bool loadSave = false;
    public Text nameOfButton;
    public string nameOfScene = "Main_Scene";
    private const string currentlyUsedSaveFile = "Currently Used SaveFile: ";

    public void NewGameLoadScene()
    {
        SceneManager.LoadScene(nameOfScene); 
    }
    public void LoadScene()
    {
        if (loadSave) PlayerPrefs.SetString(currentlyUsedSaveFile, nameOfButton.text.ToString());
        Debug.Log(PlayerPrefs.GetString(currentlyUsedSaveFile, "Didn't load"));
        SceneManager.LoadScene(nameOfScene);
    }
}
