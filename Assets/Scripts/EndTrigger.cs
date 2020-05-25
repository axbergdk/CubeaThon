using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager manager;
    private void OnTriggerEnter(Collider other)
    {
        manager.CompleteLevel();
    }
}
