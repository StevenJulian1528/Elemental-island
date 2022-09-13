using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleMove : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    bool runText;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        runText = false;
        runningText();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
    public void okay()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    void runningText()
    {
        if (!runText)
        {
            nextPos = startPos.position;
            Vector3 pos = transform.position;
            transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
            pos.z = 0;
            transform.position = pos;
        }
        runText = true;
    }
}
