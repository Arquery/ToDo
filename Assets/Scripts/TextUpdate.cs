using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = gameObject.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(text);
    }
}
