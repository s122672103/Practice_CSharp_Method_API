using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度")]
    [Range(0,50)]
    public float speed = 10f;
    public Rigidbody2D rig;
    public SpriteRenderer sr;


    private void Update()
    {

        FoxMove();

    }

    private void FoxMove()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {

            Vector3 vecR = new Vector3(speed * Time.deltaTime, 0, 0);
            sr.transform.Translate(vecR);
            sr.flipX = false;
            rig.AddForce(new Vector2(speed * Time.deltaTime, 0));

        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {


            Vector3 vecL = new Vector3(-speed * Time.deltaTime, 0, 0);
            sr.transform.Translate(vecL);
            sr.flipX = true;
            rig.AddForce(new Vector2(-speed * Time.deltaTime, 0));
        }
    }


}
