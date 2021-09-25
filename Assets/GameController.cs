using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static bool gameIsPaused;
    private GameObject[] pauseObjects;
    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale = 1;
       pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
       foreach(GameObject g in pauseObjects)
       {
			g.SetActive(false);
       }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")) 
        {
            //SceneManager.LoadScene(2);
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }

    }

    void PauseGame()
    {
        if(gameIsPaused)
        {
            Time.timeScale = 0f;
            foreach(GameObject g in pauseObjects)
       {
			g.SetActive(true);
       }
        }
        else
        {
            Time.timeScale = 1;
            foreach(GameObject g in pauseObjects)
       {
			g.SetActive(false);
       }
        }
    }
}
