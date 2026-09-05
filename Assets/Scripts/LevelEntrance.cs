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
        GameManager.instance.ChangeLevelTo(nextLevelName);
    }


}
