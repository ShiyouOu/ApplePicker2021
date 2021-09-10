using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Prefab for isntantiation apples
    public GameObject applePrefab;
    //Speed at which the apple tree moves
    public float speed = 1f;
    //Distance where apple tree turns around
    public float leftAndRightEdge = 10f;
    //chance that the apple tree will change direction
    public float chanceToChangeDirections = 0.1f;
    //rate at which APples will be instantiated
    public float secondsBetweenAppleDrops = 1f;


    // Start is called before the first frame update
    void Start()
    {
        //dropping apples every second
        
    }

    // Update is called once per frame

    void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //changing direction
    }
}
