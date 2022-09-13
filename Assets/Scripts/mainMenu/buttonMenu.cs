using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonMenu : MonoBehaviour
{
    public AudioSource click;
    public int level;
    public GameObject chapterLevel;
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void quitGame()
    {
        playClick();
        Application.Quit(1);
    }
    public void playScene()
    {
        playClick();
        Invoke("invokeplayScene", 0.5f);
    }
    public void invokeskipScene()
    {
        SceneManager.LoadScene("1-1");
    }
    public void invokeplayScene()
    {
        SceneManager.LoadScene("playVideo");
    }
    public void playClick()
    {
        click.Play();
    }
    public void skipScene()
    {
        playClick();
        Invoke("invokeskipScene", 0.5f);

    }
    public void invokeLevel()
    {
        SceneManager.LoadScene("Button");
    }
    public void chooseLevel()
    {
        SceneManager.LoadScene("Button");
        playClick();
    }

    public void levelPilih1()
    {
        SceneManager.LoadScene("1-1");
        playClick();
    }
    public void levelPilih2()
    {
        SceneManager.LoadScene("1-2");
        playClick();
    }
    public void levelPilih3()
    {
        SceneManager.LoadScene("1-3");
        playClick();
    }
    public void levelPilih4()
    {
        SceneManager.LoadScene("1-4");
        playClick();
    }
    public void levelPilih5()
    {
        SceneManager.LoadScene("1-5");
        playClick();
    }
    public void levelPilih6()
    {
        SceneManager.LoadScene("1-6");
        playClick();
    }
    public void levelPilih7()
    {
        SceneManager.LoadScene("1-7");
        playClick();
    }
    public void levelPilih8()
    {
        SceneManager.LoadScene("1-8");
        playClick();
    }

    public void exitLevel()
    {
        playClick();
        chapterLevel.SetActive(false);
        mainMenu.SetActive(true);

    }
    public void enterLevel()
    {
                playClick();
        chapterLevel.SetActive(true);
        mainMenu.SetActive(false); 
    }

}
