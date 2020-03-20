using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public string BoatName;
    public int level;
    public bool is_detected = false;
    public int side;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(new Vector3(1, 0, 0));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SpawnManager._instance.boatCount--;
        Destroy(this.gameObject);
    }


}
