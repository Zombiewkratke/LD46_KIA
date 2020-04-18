using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float Distance;
    public GameObject Target;
    public float health = 100;
    public float timeBTA;
    void Start()
    {
        Target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
        Distance = Vector2.Distance(transform.position,Target.transform.position);
        if(Distance < 10)
        {
            transform.position = Vector2.MoveTowards(transform.position,Target.transform.position,Time.deltaTime);
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        print("f");
        if (collision.gameObject.CompareTag("Player")&& timeBTA <= 0)
        {
            collision.gameObject.GetComponent<Player>().Health -= 10;
            timeBTA = 1f;
        }
        if(timeBTA >= 0)
        {
            timeBTA -= Time.deltaTime;
        }
    }
}
