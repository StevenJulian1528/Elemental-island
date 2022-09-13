using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victoryGame : MonoBehaviour
{
    public AudioSource musicbg;
    doornextScene nextScene;
    public int level;
    public string nextChapter;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        musicbg.mute = !musicbg.mute;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void replayGame()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void levelPilih1()
    {
        SceneManager.LoadScene("1-1");
    }
    public void levelPilih2()
    {
        SceneManager.LoadScene("1-2");
    }
    public void levelPilih3()
    {
        SceneManager.LoadScene("1-3");
    }
    public void levelPilih4()
    {
        SceneManager.LoadScene("1-4");
    }
    public void levelPilih5()
    {
        SceneManager.LoadScene("1-5");
    }
    public void levelPilih6()
    {
        SceneManager.LoadScene("1-6");
 
    }
    public void levelPilih7()
    {
        SceneManager.LoadScene("1-7");
    }
    public void levelPilih8()
    {
        SceneManager.LoadScene("1-8");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
    public void NextChapter()
    {
        SceneManager.LoadScene(nextChapter);
    }
}
