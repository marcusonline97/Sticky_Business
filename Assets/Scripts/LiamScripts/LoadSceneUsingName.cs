using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneUsingName : MonoBehaviour
{
    public bool loadSave = true;
    public Text nameOfButton;
    public string nameOfScene;
    private const string currentlyUsedSaveFile = "Currently Used SaveFile: ";
    
    public void LoadScene(bool loaded)
    {
        if (loadSave && loaded) PlayerPrefs.SetString(currentlyUsedSaveFile, nameOfButton.ToString());
        SceneManager.LoadScene(nameOfScene);
    }
}
