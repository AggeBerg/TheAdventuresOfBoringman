using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform Muzzle;
    public int Layer;
    public SpriteRenderer Sprite;
    public float Flashtime;
    private float TimeSinceLastShoot;
    private float LastShoot;

    void Start(){
        
        Sprite.color = new Color(1f, 1f ,1f , 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeSinceLastShoot = Time.time - LastShoot;
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("First thing today");
            Physics2D.Raycast(Muzzle.position, new Vector2(Muzzle.rotation.x, Muzzle.rotation.y), 500, Layer);
            Sprite.color = new Color(1f, 1f ,1f , 1f);
            LastShoot = Time.time;
        } else if (TimeSinceLastShoot > Flashtime) {
            Sprite.color = new Color(1f, 1f ,1f , 0f);
        }
    }
}
