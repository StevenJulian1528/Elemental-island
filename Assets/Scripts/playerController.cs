using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public int chapter,level;
    public bool isDie;
    Animator anim;
    public AudioSource died;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDie == true)
        {
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Spike") || collision.gameObject.tag.Equals("Enemy") || collision.gameObject.tag.Equals("River"))
        {
            isDie = true;
        }
        if(collision.gameObject.tag.Equals("GroundBoss"))
        {
            Camera.main.orthographicSize = 15f;

        }
    }

    void LoadSceneAgain()
    {
        deathManager.death++;
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void Die()
    {
        died.Play();
        anim.SetBool("isDie", true);
        Invoke("LoadSceneAgain", 0.5f);
        print("Death: " + deathManager.death);
        isDie = false;
    }
}
