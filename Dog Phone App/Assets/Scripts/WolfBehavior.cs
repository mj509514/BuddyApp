using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfBehavior : MonoBehaviour
{   
    [Header ("Layers")]
    [SerializeField] private LayerMask clicks;
    [SerializeField] private LayerMask floor;
    
    [Header ("Public Objects")]
    public AudioSource bark1;
    public AudioSource bark2;
    public AudioSource bark3;
    public AudioSource whoosh;
    public Animator dog;
    public GameObject ball;
    public GameObject actualDog;

    [Header ("Private Stuff")]
    private int pickSound;
    private int pickAnim;
    Vector3 targetPosition;
    Vector3 origPosition;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, clicks))
            {
                pickSound = Random.Range(1, 4);

                pickAnim = Random.Range(1, 4);

                playSound();

                playAnim();

                Debug.Log("hit!");

                StartCoroutine(stopAnim());

            }

            else
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, floor))
                {
                    whoosh.Play();

                    Instantiate(ball, hit.point, Quaternion.identity);
                 
                }              
                               
            }
        }
    }

    void playSound()
    {
        if(pickSound == 1)
        {
            bark1.Play();
        }

        if (pickSound == 2)
        {
            bark2.Play();
        }
        if (pickSound == 3)
        {
            bark3.Play();
        }

    }

    void playAnim()
    {
        if (pickAnim == 1)
        {
            dog.Play("ButtWag");
        }

        if (pickAnim == 2)
        {
            dog.Play("HappyJump");
        }
        if (pickAnim == 3)
        {
            dog.Play("Beg");
        }

    }

   

    IEnumerator stopAnim()
    {

        yield return new WaitForSeconds(1);
        dog.Play("Stationary");

    }


}
