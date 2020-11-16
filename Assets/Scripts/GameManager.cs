using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public KeyCode ResetButton;
   public GameObject[] EnterExitButtons;

   public EnterExitStore[] EnterExitStore;

    float[] TimeScales = { 0, 1 };
    void Start()
    {

        for(int i = 0; i< EnterExitButtons.Length; i++)
        {
            EnterExitStore[i] = EnterExitButtons[i].GetComponent<EnterExitStore>();
        }

    }

    void Update()
    {
        PauseGame();
        ResetGame();

    }

  void PauseGame()
    {
        for (int i = 0; i < EnterExitButtons.Length; i++)
        {
            if (EnterExitStore[i].MenuActive)
            {
                Time.timeScale = TimeScales[0];
            }
            else
            {
                Time.timeScale = TimeScales[1];

            }
        }
    }

    void ResetGame()
    {
        if (Input.GetKey(ResetButton))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
