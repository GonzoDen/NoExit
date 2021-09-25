using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

 public class PlayerController : MonoBehaviour
{
    private NavMeshAgent agent;

    public AudioClip PlayerSound;
    private AudioSource audioSource;
    private float sqeekCoolDown;
    public float sqeekCoolDownMax = 300;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        audioSource = GetComponent<AudioSource>();

        sqeekCoolDown = sqeekCoolDownMax;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                agent.SetDestination(hit.point);
            }
        }
        sqeekCoolDown--;

        if(sqeekCoolDown <= 0) {
            audioSource.PlayOneShot(PlayerSound);
            sqeekCoolDown = sqeekCoolDownMax;
        }
    }

     void OnTriggerEnter(Collider collision) {
        //Debug.Log(collision.gameObject.name);
        
        if (collision.gameObject.CompareTag("Enemy")) {
            SceneManager.LoadScene(2);

        } 
        
        /*else if (collision.gameObject.CompareTag("Exit")) {
            SceneManager.LoadScene(3);
        }*/
    }  
}