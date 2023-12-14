using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{

    public GameObject Food;

    public Transform BorderTop;
    public Transform BorderBottom;
    public Transform BorderLeft;
    public Transform BorderRight;

    GameObject currentfood;

    void Spawn()
    {
        // x position between left & right border
        int x = (int)Random.Range(BorderLeft.position.x,
                                  BorderRight.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(BorderBottom.position.y,
                                  BorderTop.position.y);

        // Instantiate the food at (x, y)
        currentfood = Instantiate(Food,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Spawn", 3, 4);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentfood == null)
        {
            Spawn();
        }
    }
}
