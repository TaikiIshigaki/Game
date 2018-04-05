using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))//RでMainSceneをロード
        {
            SceneManager.LoadScene("MainScene");
        }

        if (Input.GetKey(KeyCode.F))//RでMainSceneをロード
        {
            SceneManager.LoadScene("Title");
        }
    }
}
