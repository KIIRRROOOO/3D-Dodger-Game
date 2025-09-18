
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Stone;
    public float maxX;
    public Transform SpawnPosition;
    int score = 0;
    public TextMeshProUGUI Score;
    void Start()
    {
        InvokeRepeating("SpawnStone", 0.5f, 2f);
        InvokeRepeating("UpdateScore", 3f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnStone()
    {
        Vector3 Spawn = SpawnPosition.position;
        Spawn.x = Random.Range(-maxX, maxX);
        Instantiate(Stone, Spawn, Quaternion.identity);
    }
    void UpdateScore()
    {
        score++;
        Score.text = score.ToString();
    }
}
