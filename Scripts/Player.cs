using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveSpeed;
    float xInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");   

        Vector3 move = new Vector3(x, 0, 0);
        transform.Translate(move * moveSpeed * Time.deltaTime);
        if (transform.position.y < -5f)
        {
            Debug.Log("Player fell. Reloading scene...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stones")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//"Game"//);
        }
    }
}
