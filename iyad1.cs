using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
public int level = 1;
public float speed = 5f;
private int health;

void Start()
{
    health = level; 
    Debug.Log("NPC Health: " + health);

}

void Update()
{

    Vector3 newPosition = transform.position;
    newPosition.z += speed * Time.deltaTime; 
    transform.position = newPosition; 
}
}
