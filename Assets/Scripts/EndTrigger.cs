using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager1 gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
