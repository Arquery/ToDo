using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskList : MonoBehaviour
{
    public GameObject taskElement;
    public Text order;
    public Text taskText;
    public GameObject panel;

    private int taskCount;
    public RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {
        taskCount = PlayerPrefs.GetInt("Count");

        AsignData();
    }

    // Update is called once per frame
    void Update()
    {
        if (rt.rect.height < 500 * taskCount)
        {
            rt.sizeDelta = new Vector2(rt.rect.width, 500 * taskCount);
        }
    }

    public void AsignData()
    {
        for (int i = 1; i <= taskCount; i++)
        {
            Instantiate(taskElement, new Vector3(540, 1872 + (-500 * i), 0), Quaternion.identity, panel.transform);

            order = GameObject.Find("OrderText").GetComponent<Text>();
            order.name = "OrderText" + i;
            order = GameObject.Find("OrderText" + i).GetComponent<Text>();
            order.text = i.ToString();

            taskText = GameObject.Find("PendingText").GetComponent<Text>();
            taskText.name = "PendingText" + i;
            taskText = GameObject.Find("PendingText" + i).GetComponent<Text>();
            taskText.text = PlayerPrefs.GetString("Task" + i);
        }
    }
}
