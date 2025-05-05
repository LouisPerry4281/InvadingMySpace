using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    [Header("Player Scripts")]
    public PlayerMovement movement;
    public PlayerShooting shooting;

    [Header("Flags")]
    bool isPerformingAction = false; //Is this game object performing an action that it shouldn't be interrupted from?

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        shooting = GetComponent<PlayerShooting>();
    }

    public bool CanAct()
    {
        if (isPerformingAction)
            return false;

        else
            return true;
    }
}
