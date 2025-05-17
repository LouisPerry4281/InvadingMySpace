using Unity.VisualScripting;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public static BulletManager instance;

    public GameObject[] bulletPrefabs;

    public int playerBulletPrefabPointer = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this);
    }
}
