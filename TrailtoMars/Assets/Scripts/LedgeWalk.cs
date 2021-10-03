using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LedgeWalk : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private bool ismoving = false;
    public float t = 50f;
    MeshRenderer rend;
    Vector3 a, b;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player.Player.ismoving);
        if (ismoving == true)
        {
            //Debug.Log(transform.position);
            a = Player.transform.position;
            b = transform.position;

            Player.transform.position = Vector3.MoveTowards(a, b, t * Time.deltaTime);
            //Player.transform.position = transform.position;
           
            if (a == b)
            {
                Debug.Log("done bitch");
                ismoving = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }

    }
    void OnMouseDown()
    {

        if (ismoving == false)
        {

            ismoving = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }

    }
}
