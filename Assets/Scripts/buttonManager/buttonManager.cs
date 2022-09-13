using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    public Button[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int closureIndex = i;
            buttons[closureIndex].onClick.AddListener(() => TaskOnClick(closureIndex));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TaskOnClick(int indexbut)
    {
        SceneManager.LoadScene("1-" + (indexbut + 1));
    }
}
