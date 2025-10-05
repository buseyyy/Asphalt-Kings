using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    Scene scene;


    private void Awake()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void DeadScene()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
    public void FinishScene()
    {
        SceneManager.LoadScene(scene.buildIndex + 2);
    }

}
