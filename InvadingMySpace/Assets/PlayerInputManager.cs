using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInputManager : MonoBehaviour
{
    public static PlayerInputManager instance;

    PlayerManager player;

    private void Awake()
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
        player = PlayerManager.instance;
    }

    void Update()
    {
        CheckControls();
    }

    public Vector2 GetInputDirection()
    {
        Vector2 inputDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        inputDirection.Normalize();

        return inputDirection;
    }

    void CheckControls()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            player.shooting.InitialiseShot();
        }
    }
}
