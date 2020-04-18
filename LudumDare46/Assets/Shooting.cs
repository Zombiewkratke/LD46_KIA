using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject gun;
    Vector2 LookAt;
    private float timeBetwenShots;
    public LayerMask layerl;
    public GameObject HitEffect;
    public ParticleSystem flash;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        
        LookAt = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.right = LookAt;
        if (Input.GetMouseButtonDown(0) && timeBetwenShots <= 0)
        {
            Shoot();
        }
        else if(timeBetwenShots > 0)
        {
            timeBetwenShots -= Time.deltaTime;
        }
    }
    void Shoot()
    {
        flash.Emit(1);
        RaycastHit2D Hit = Physics2D.Raycast(transform.position, LookAt,10, layerl);
        timeBetwenShots = .5f;
        if(Hit.collider != null)
        {
            print(Hit.collider.gameObject);
            GameObject expl = Instantiate(HitEffect, Hit.point, Quaternion.identity);
            Destroy(expl.gameObject, 2);
        }
        
    }
}
