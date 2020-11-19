using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    // Activate for testing
    //public TextMeshPro dateText;
    
    public int dailyStreak;
    public TMP_Text textToChange;
    int[] currentDateArray = new int[Enum.GetNames(typeof(Calender)).Length];
    int[] savedDateArray = new int[Enum.GetNames(typeof(Calender)).Length];
    private const string saveName = "Last login date: ";
    private const string dailyStreakCount = "DailyStreakCount: ";
    private const string arrayLengthSaveName = "Array length: ";
    private const string currentlyUsedSaveFile = "Currently Used SaveFile: ";
    
    enum Calender
    {
        Year,
        Month,
        Day,
        Hour,
        Minute,
        Second
    }

    void Start()
    {
        var getLoadSave = PlayerPrefs.GetString(currentlyUsedSaveFile, "default");
        
        dailyStreak = PlayerPrefs.GetInt(currentlyUsedSaveFile + getLoadSave + dailyStreakCount, 0);
        textToChange.text = "Daily Streak: " + DailyStreakAmount().ToString();
    }

    public int[] UpdateCurrentLogin()
    {
        currentDateArray[(int) Calender.Year] = DateTime.Today.Year;
        currentDateArray[(int) Calender.Month] = DateTime.Today.Month;
        currentDateArray[(int) Calender.Day] = DateTime.Today.Day;
        currentDateArray[(int) Calender.Hour] = DateTime.Now.Hour;
        currentDateArray[(int) Calender.Minute] = DateTime.Now.Minute;
        currentDateArray[(int) Calender.Second] = DateTime.Now.Second;
        return currentDateArray;
    }

    public int DailyStreakAmount()
    {
        DateTime savedDate = new DateTime();
        
        savedDateArray = GetArrayFromPlayerPref();
        
        if (savedDateArray[(int) Calender.Year] == 0) savedDate = DateTime.Now;
        else
        {
            savedDate = new DateTime(
                savedDateArray[(int) Calender.Year], 
                savedDateArray[(int) Calender.Month], 
                savedDateArray[(int) Calender.Day],
                savedDateArray[(int) Calender.Hour],
                savedDateArray[(int) Calender.Minute],
                savedDateArray[(int) Calender.Second]); 
        }

        DateTime currentDate = DateTime.Now;
        long elapsedTicks = currentDate.Ticks - savedDate.Ticks;
        
        TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);

        if (elapsedSpan.Days >= 1)
        {
            if (elapsedSpan.Days < 2) dailyStreak++;
            else dailyStreak = 0;
            
            var array = UpdateCurrentLogin();
            SaveArrayToPlayerPref(array);
        }

        var getLoadSave = PlayerPrefs.GetString(currentlyUsedSaveFile, "default");
        PlayerPrefs.SetInt(currentlyUsedSaveFile + getLoadSave + dailyStreakCount, dailyStreak);
        return dailyStreak;
    }
    // Takes the saved date and compares with current date and acts accordingly
    
    public void SaveArrayToPlayerPref(int[] arrayToSave)
    {
        var getLoadName = PlayerPrefs.GetString(currentlyUsedSaveFile, "default");
        for (int i = 0; i < arrayToSave.Length; i++) PlayerPrefs.SetInt(saveName + i + getLoadName, arrayToSave[i]);
        PlayerPrefs.SetInt(saveName + arrayLengthSaveName + getLoadName, arrayToSave.Length);
 
    }
    // Converts values from an Array into playerPrefs values
    
    public int[] GetArrayFromPlayerPref()
    {
        var getLoadName = PlayerPrefs.GetString(currentlyUsedSaveFile, "default");
        int[] reconstructedArray = new int[PlayerPrefs.GetInt(saveName + arrayLengthSaveName + getLoadName, 6)];
 
        for (int i = 0; i < reconstructedArray.Length; i++) reconstructedArray[i] = PlayerPrefs.GetInt(saveName + i + getLoadName);

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