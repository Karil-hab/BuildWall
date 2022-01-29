using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnContr : MonoBehaviour
{
    public GameObject bullet;
    Transform TRbulet;
    GameObject clonBullet;
    Rigidbody RBbulet;

    // Start is called before the first frame update
    void Start()
    {
        TRbulet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        clonBullet = Instantiate(bullet,TRbulet.position,TRbulet.rotation);
        RBbulet = clonBullet.GetComponent<Rigidbody>();
        RBbulet.AddForce(TRbulet.forward * 1000f);
        Destroy(clonBullet,3);
    }
}
