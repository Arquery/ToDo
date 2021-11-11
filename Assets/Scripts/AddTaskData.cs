using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTaskData : MonoBehaviour
{
    public InputField inputText;
    public Text outputText;

    private int taskCount;
    
    void Start()
    {
        taskCount = PlayerPrefs.GetInt("Count");
    }

    void Update()
    {
        
    }

    public void Save()
    {
        taskCount++;

        PlayerPrefs.SetInt("Count", taskCount);
        Debug.Log(PlayerPrefs.GetInt("Count"));
        PlayerPrefs.SetString("Task" + taskCount, inputText.text);
        for (int i = 1; i <= taskCount; i++)
        {
            Debug.Log(PlayerPrefs.GetString("Task" + i));
        }
        
    }
}
