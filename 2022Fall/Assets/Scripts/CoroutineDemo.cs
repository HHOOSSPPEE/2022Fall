using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineDemo : MonoBehaviour
{
    #region Combat Variables
    private bool _canShoot;
    #endregion


    public int beaker1, beaker2, beaker3; //how  much is in beaker right now
    public int beaker1max, beaker2max, beaker3max; //what is max


     

    #region coroutine stuff
    // Start is called before the first frame update
    void Start()
    {
        _canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canShoot == true)
        {

            //shoot
            Debug.Log("Bang.");

                StartCoroutine(ShootCooldown(2f));


        }
    }

    private IEnumerator ShootCooldown(float cooldown)
    {
        //cooldown
        //everything here happens BEFORE our wait
        _canShoot = false;

        for (int i = 0; i < 4; i++)
        {
            //
            yield return new WaitForSeconds(cooldown);
            ///
        }
        //can shoot again
        _canShoot = true;
    }
    #endregion

    public void Pour()
    {
        //source beaker
        //target beaker

    }
}
