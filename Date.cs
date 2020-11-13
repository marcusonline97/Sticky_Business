using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Date : MonoBehaviour
{
    //public TextMeshPro dateText;
    
    private const string saveName = "Last login date: ";
    private const string arrayLengthSaveName = "Array length: ";
    public int dailyStreak;
    int[] currentDateArray = new int[Enum.GetNames(typeof(Calender)).Length];
    int[] savedDateArray = new int[Enum.GetNames(typeof(Calender)).Length];
    
    enum Calender
    {
        Year,
        Month,
        Day,
        Hour,
        Minute,
        Second
    }
    
    void UpdateCurrentLogin()
    {
        currentDateArray[(int) Calender.Year] = DateTime.Today.Year;
        currentDateArray[(int) Calender.Month] = DateTime.Today.Month;
        currentDateArray[(int) Calender.Day] = DateTime.Today.Day;
        currentDateArray[(int) Calender.Hour] = DateTime.Now.Hour;
        currentDateArray[(int) Calender.Minute] = DateTime.Now.Minute;
        currentDateArray[(int) Calender.Second] = DateTime.Now.Second;
    }

    public int DailyStreakAmount()
    {
        savedDateArray = GetArrayFromPlayerPref();
        DateTime savedDate = new DateTime(
            savedDateArray[(int) Calender.Year], 
            savedDateArray[(int) Calender.Month], 
            savedDateArray[(int) Calender.Day],
            savedDateArray[(int) Calender.Hour],
            savedDateArray[(int) Calender.Minute],
            savedDateArray[(int) Calender.Second]
            );

        DateTime currentDate = DateTime.Now;
        long elapsedTicks = currentDate.Ticks - savedDate.Ticks;
        TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);

        if (elapsedSpan.Days < 1) return dailyStreak;
        else if (elapsedSpan.Days < 2)
        {
            UpdateCurrentLogin();
            SaveArrayToPlayerPref(currentDateArray);
            return dailyStreak++;
        }
        else return dailyStreak = 0;
    }
    // Takes the saved date and compares with current date and acts accordingly
    
    public void SaveArrayToPlayerPref(int[] arrayToSave)
    {
        for (int i = 0; i < arrayToSave.Length; i++)
        {
            PlayerPrefs.SetInt(saveName + i, arrayToSave[i]);
            PlayerPrefs.SetInt(saveName + arrayLengthSaveName, arrayToSave.Length);
        }
 
    }
    // Converts values from an Array into playerPrefs values
    
    public int[] GetArrayFromPlayerPref()
    {
        int[] reconstructedArray = new int[PlayerPrefs.GetInt(saveName + arrayLengthSaveName)];
 
        for (int i = 0; i < reconstructedArray.Length; i++)
        {
            reconstructedArray[i] = PlayerPrefs.GetInt(saveName + i);
        }
 
        return reconstructedArray;
    }
    // Converts values from playerPrefs into an array
    
    // Just for testing to see if saving works.
    /*
    void Start()
    {
        savedDateArray = GetArrayFromPlayerPref(playerPrefSaveName);
        UpdateCurrentLogin();
        
        string currentLoginDate = System.DateTime.UtcNow.ToLocalTime().ToString("dd/MM/yyyy  HH:mm");
        dateText.text = currentLoginDate;
        
        Debug.Log("Date: " + String.Join(", ",
            new List<int>(currentDateArray)
                .ConvertAll(i => i.ToString())
                .ToArray()));
    }
    */
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Saved!!");
            SaveArrayToPlayerPref(currentDateArray, playerPrefSaveName);
        }
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Load!!");
            currentDateArray = GetArrayFromPlayerPref(playerPrefSaveName);
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            // A way of printing and array in debug log
            Debug.Log("Date: " + String.Join(", ",
                new List<int>(currentDateArray)
                    .ConvertAll(i => i.ToString())
                    .ToArray()));
        }
    }
    */
}