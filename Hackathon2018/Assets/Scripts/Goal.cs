using UnityEngine;

public class Goal : MonoBehaviour
{
    public int Points = 0;
    private void OnTriggerEnter(Collider other)
    {
        GameObject weeble = other.gameObject;
        Destroy(weeble);
        Points = Points + 1;
    }   
    
}