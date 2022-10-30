using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button level1 = GameObject.FindGameObjectWithTag("LoadLevel1").GetComponent<Button>();
        level1.onClick.AddListener(loadGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadGame()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {
            Button quitButton = GameObject.FindGameObjectWithTag("QuitButton").GetComponent<Button>();
            quitButton.onClick.AddListener(QuitGame);
        }
    
    }
}
