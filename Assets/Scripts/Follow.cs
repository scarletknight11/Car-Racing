using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public GameObject followplayer;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = followplayer.transform.position + new Vector3(-3, offset, -7f);
    }
}
