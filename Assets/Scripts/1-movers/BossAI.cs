using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour
{
    private int Direction = 1;
    [SerializeField] float Speed = 3f;
    [SerializeField] float MaxPossition = 8f;
    [SerializeField] float MinPossition = -8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Direction * Speed * Time.deltaTime, 0, 0);
        if (transform.position.x > MaxPossition)
        {
            Direction = -1;
        }
        if (transform.position.x < MinPossition)
        {
            Direction = 1;
        }
    }
}
