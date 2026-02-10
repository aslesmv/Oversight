using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Create a field where we select our Player object (so it becomes the focused target of this code)
    public Transform player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
