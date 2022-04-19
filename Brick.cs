using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    public GameObject dyingEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject insE = Instantiate(dyingEffect, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(insE, 2f);
        Destroy(gameObject);
        FindObjectOfType<BrickManager>().RemoveBrick(this);
    }
}
