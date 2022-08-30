using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Start,
    Playing,
    GameOver,
    Victory,
    Ending
}

public class gamemanager : MonoBehaviour
{
    public static gamemanager Instance;
    
    public GameState gameState;
    
    [SerializeField]
    private GameObject playerAndCameraPrefeb;

    [SerializeField] private string locationToLoad;

    [SerializeField] private string guiScene;

    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "initialization")
        {
            StartGameFromInitialization();
            
        }
        else
        {
            StartGameFromLevel();
        }
    }

    private void StartGameFromLevel()
    {
        SceneManager.LoadScene(guiScene, LoadSceneMode.Additive);
        Vector3 starPosition = GameObject.Find("playerstart").transform.position;

        Instantiate(playerAndCameraPrefeb, starPosition, Quaternion.identity);
        gameState = GameState.Playing;
    }

    // Start is called before the first frame update
    private void StartGameFromInitialization()
    {
        SceneManager.LoadScene("Splash");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
        
    }
    
    public void StartGame()
    {
   
       SceneManager.LoadScene(guiScene);
       //SceneManager.LoadScene(locationToLoad, LoadSceneMode.Additive);
       SceneManager.LoadSceneAsync(locationToLoad, LoadSceneMode.Additive).completed += operation =>
       {
           Scene locationScene = default;
           for (int i = 0; i < SceneManager.sceneCount; i++)
           {
               if (SceneManager.GetSceneAt(i).name == locationToLoad)
               {
                   locationScene = SceneManager.GetSceneAt(i);
                   break;
               }
           }
           if (locationScene != default) SceneManager.SetActiveScene(locationScene);
               
           Vector3 starPosition = GameObject.Find("playerstart").transform.position;

           Instantiate(playerAndCameraPrefeb, starPosition, Quaternion.identity);
       };
    }

    public void CallVictory()
    {
        SceneManager.LoadScene("Victory", LoadSceneMode.Additive);
        gameState = GameState.Victory;
    }
    
    public void CallGameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        gameState = GameState.GameOver;
    }
    
    public void LoadEnding()
    {
        SceneManager.LoadScene("Ending");
        gameState = GameState.Ending;
    }

   
}
