using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public string BoatName;
    public int level;
    private int level_tmp;
    public bool is_detected = false;
    private int x;

    public Boat(string NAME, int LEVEL, bool IS_DETECTED)
    {
        name = NAME;
        level = LEVEL;
        is_detected = IS_DETECTED;
    }


    private void Start()
    {
        x = Random.Range(0, 2);
    }


    private void Update()
    {
        if (x == 0)
        {
            transform.Translate(new Vector3(1, 0, 0));
        }
        else
        {
            transform.Translate(new Vector3(-1, 0, 0));
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        SpawnManager._instance.boatCount--;
        Destroy(this.gameObject);
    }


    public void BoatClick()
    {
        level_tmp = this.level;
        if(DogamManager.dogam_instance.BoatList[level_tmp - 1].is_detected == false)
        {
            DogamManager.dogam_instance.BoatList[level_tmp - 1].is_detected = true;
        }
        else
        {
            
        }
    }


}
