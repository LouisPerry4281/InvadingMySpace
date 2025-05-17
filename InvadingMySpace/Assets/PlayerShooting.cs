using System.Collections;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{


    [SerializeField] float reloadTime;

    bool isReloading = false;

    public void InitialiseShot()
    {
        if (isReloading || !PlayerManager.instance.CanAct())
            return;

        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        isReloading = true;

        //Shooting Stuff
        print("Pew");

        yield return new WaitForSeconds(reloadTime);

        isReloading = false;
    }
}
