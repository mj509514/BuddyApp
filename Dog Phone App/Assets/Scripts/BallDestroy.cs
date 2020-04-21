using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{

   // public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Random.Range(1,9));
    }

    // Update is called once per frame
    void Update()
    {
    }



   /* IEnumerator kill()
    {
        yield return new WaitForSeconds(2);

        Destroy(self);

    } */

}
