using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadFirstScene();
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}

