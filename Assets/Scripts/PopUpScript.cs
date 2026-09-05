using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    public GameObject ch;
    public float spawnRate;

    public float heightOffset;
    public static PopUpScript instance;

    Vector3 spawnPosition = new Vector3(154.24f, -3.35f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        instance = this;
    }


    public void spawnch()
    {

        // Quaternion.identity means "no rotation" or default alignment
        Quaternion spawnRotation = Quaternion.identity;

        Instantiate(ch, spawnPosition, spawnRotation);
    }

}
