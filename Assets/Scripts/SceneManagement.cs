using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void Main()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void List()
    {
        SceneManager.LoadScene("List");
    }

    public void Add()
    {
        SceneManager.LoadScene("New Pending");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
