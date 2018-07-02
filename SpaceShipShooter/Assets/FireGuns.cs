using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGuns : MonoBehaviour {
    public int fireRate;
    public Rigidbody2D bullet;
    public int amountOfBullets;
    public float bulletsXOffset;
    public float bulletsYOffSet;
    public float bulletRotation;
    public float bulletSpeed;
    public int bulletSpread;
    public bool alternating;
    public int bulletPerFire;
    public int counterStart;
    public int burstFireAmount = 1;
    public int burstFireDelay;
    public float bulletXSpawn;
    public float bulletYSpawn;

    private int burstCounter = 1;
    private float offSetMultiplyer = 0.5f;
    private int j = 0;
    private int counter;

    private void Awake()
    {
        counter = counterStart;
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
            counter++;
        if(counter == fireRate)
        {
            fireGuns();
            if (burstFireAmount > 1)
            {
                counter = fireRate - burstFireDelay;
                burstFireAmount--;
            }
            else
            {
                counter = 0;
                burstCounter = burstFireAmount;
            }
        }
    }

    public void fireGuns()
    {
        if (!alternating)
        {
            for (int i = 0; i < amountOfBullets; i++)
            {
                if (amountOfBullets % 2 != 0 && i == 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2(transform.position.x + bulletXSpawn, transform.position.y + bulletsYOffSet + bulletYSpawn), transform.rotation) as Rigidbody2D;
                    bulletInstance.velocity = new Vector2(0, bulletSpeed);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    offSetMultiplyer = 1;
                    Debug.Log("Made bullet here");
                }
                else if (i % 2 == 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2((transform.position.x + bulletXSpawn) - (bulletsXOffset * offSetMultiplyer), transform.position.y + bulletsYOffSet + bulletYSpawn), new Quaternion(0, 0, 0, 0)) as Rigidbody2D;
                    bulletInstance.rotation = bulletRotation * offSetMultiplyer;
                    bulletInstance.velocity = new Vector2((bulletSpeed / bulletSpread) * -offSetMultiplyer, bulletSpeed - (bulletSpeed / bulletSpread) * offSetMultiplyer);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    if (amountOfBullets % 2 != 0)
                    {
                        offSetMultiplyer++;
                    }
                    Debug.Log("Made bullet there");
                }
                else if (i % 2 != 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2((transform.position.x + bulletXSpawn) + (bulletsXOffset * offSetMultiplyer), transform.position.y + bulletsYOffSet + bulletYSpawn), new Quaternion(0, 0, 0, 0)) as Rigidbody2D;
                    bulletInstance.rotation = -bulletRotation * offSetMultiplyer;
                    bulletInstance.velocity = new Vector2((bulletSpeed / bulletSpread) * offSetMultiplyer, bulletSpeed - (bulletSpeed / bulletSpread) * offSetMultiplyer);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    if (amountOfBullets % 2 == 0)
                    {
                        offSetMultiplyer++;
                    }
                    Debug.Log("Made bullet in here");
                }
            }
            offSetMultiplyer = 0.5f;
        }
        else
        {

            for(int i = 0; i < bulletPerFire; i++)
            {
                if (amountOfBullets % 2 != 0 && j == 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2(transform.position.x + bulletXSpawn, transform.position.y + bulletsYOffSet + bulletYSpawn), transform.rotation) as Rigidbody2D;
                    bulletInstance.velocity = new Vector2(0, bulletSpeed);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    offSetMultiplyer = 1;
                    j++;
                }
                else if (j % 2 == 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2((transform.position.x + bulletXSpawn) - (bulletsXOffset * offSetMultiplyer), transform.position.y + bulletsYOffSet + bulletYSpawn), new Quaternion(0, 0, 0, 0)) as Rigidbody2D;
                    bulletInstance.rotation = bulletRotation * offSetMultiplyer;
                    bulletInstance.velocity = new Vector2((bulletSpeed / bulletSpread) * -offSetMultiplyer, bulletSpeed - (bulletSpeed / bulletSpread) * offSetMultiplyer);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    j++;
                    if (amountOfBullets % 2 != 0)
                    {
                        offSetMultiplyer++;
                    }
                }
                else if (j % 2 != 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2((transform.position.x + bulletXSpawn) + (bulletsXOffset * offSetMultiplyer), transform.position.y + bulletsYOffSet + bulletYSpawn), new Quaternion(0, 0, 0, 0)) as Rigidbody2D;
                    bulletInstance.rotation = -bulletRotation * offSetMultiplyer;
                    bulletInstance.velocity = new Vector2((bulletSpeed / bulletSpread) * offSetMultiplyer, bulletSpeed - (bulletSpeed / bulletSpread) * offSetMultiplyer);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    j++;
                    if (amountOfBullets % 2 == 0)
                    {
                        offSetMultiplyer++;
                    }
                }
                if (j >= amountOfBullets)
                {
                    offSetMultiplyer = 0.5f;
                    j = 0;
                }
            }
        }
    }
}
