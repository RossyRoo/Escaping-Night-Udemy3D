using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        //switch statements are conditionals that allow us to compare
        //one var to several constants
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("The level is over");
                break;
            case "Fuel":
                Debug.Log("You picked up fuel.");
                break;
            default:
                break;
        }
    }
}
