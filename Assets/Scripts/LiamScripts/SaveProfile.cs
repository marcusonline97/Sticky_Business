using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveProfile : MonoBehaviour
{
    public GameObject retryTextObj;
    public InputField inputFieldObj;
    public GameObject objOriginal;
    public GameObject objParent;
    public LoadSceneUsingName loadSceneScript;
    List<GameObject> buttonsList = new List<GameObject>();
    public float loadButtonsOffset = 26.48f;
    public const string isAvailable = "Available";
    private const string buttonSaveNames = "Save Buttons ";
    private const string length = "length: ";
    private const string currentlyUsedSaveFile = "Currently Used SaveFile: ";

    public void CreateSaveName()
    {
        var saveName = inputFieldObj.text;
        
        if (PlayerPrefs.GetString("Save File " + saveName, isAvailable) == isAvailable)
        {
            PlayerPrefs.SetString("Save File " + saveName, "Occupied");
            
            int getLength = PlayerPrefs.GetInt(buttonSaveNames + length, 0);
            PlayerPrefs.SetInt(buttonSaveNames + length, getLength + 1);
            Debug.Log(saveName + "savename");
            PlayerPrefs.SetString(currentlyUsedSaveFile, saveName);
            Debug.Log(PlayerPrefs.GetString(currentlyUsedSaveFile));
            PlayerPrefs.SetString(buttonSaveNames + PlayerPrefs.GetInt(buttonSaveNames + length).ToString(), saveName);
            loadSceneScript.NewGameLoadScene();
            return;
        }
        saveName = "";
        inputFieldObj.text = "";
            
        retryTextObj.SetActive(true);
    }

    public void LoadButtons()
    { 
        foreach (var button in buttonsList) Destroy(button);

        for (int i = 1; i < PlayerPrefs.GetInt(buttonSaveNames + length, 0) + 1; i++)
        {
            var objButton = Instantiate(objOriginal, objParent.transform);
            objButton.SetActive(true);
            objButton.transform.position = new Vector3(
                objButton.transform.position.x,
                objButton.transform.position.y - loadButtonsOffset * (i - 1), 
                objButton.transform.position.z);

            objButton.GetComponentInChildren<Text>().text = PlayerPrefs.GetString(buttonSaveNames + i.ToString());
            
            buttonsList.Add(objButton);
        }
    }
}
