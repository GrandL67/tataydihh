using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEntrance : MonoBehaviour
{
    [SerializeField] private string nextLevelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            PopUpScript.instance.spawnch();

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }


}

/*
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {

            Destroy(gameObject);
        }
    }
}

*/