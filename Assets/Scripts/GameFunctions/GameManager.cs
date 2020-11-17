using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
   public KeyCode ResetButton;
   public GameObject[] EnterExitButtons;

   public EnterExitMenu[] EnterExitMenu;

    float[] TimeScales = { 0, 1 };
    void Start()
    {

        for(int i = 0; i< EnterExitButtons.Length; i++)
        {
            EnterExitMenu[i] = EnterExitButtons[i].GetComponent<EnterExitMenu>();
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
            if (EnterExitMenu[i].MenuActive)
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
