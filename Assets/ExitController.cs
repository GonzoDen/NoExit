using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour
{    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Rabotaet");
            SceneManager.LoadScene(3);

        }
         
    }

}