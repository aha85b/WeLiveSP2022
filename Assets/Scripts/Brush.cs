using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    public GameObject BrushGO;
    public float BrushSize = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided!");

        if (collision.gameObject.tag == "board")
        {
            //instanciate a brush
            Vector3 contactPoint = collision.contacts[0].point;
            var go = Instantiate(BrushGO, contactPoint + Vector3.up * 0.1f, Quaternion.identity, transform);
            go.transform.localScale = Vector3.one * BrushSize;
        }
    }
}
