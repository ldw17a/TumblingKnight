using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
	public Transform PlayerTransform;
	public Transform TeleportGoal;
	
    void OnCollisionEnter2D(Collision2D otherGuy) 
    {
        if (otherGuy.gameObject.tag == "Player") 
        {
            PlayerTransform.position = TeleportGoal.position;
        }
    }
}
