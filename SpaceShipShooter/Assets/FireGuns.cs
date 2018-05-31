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

    private float offSetMultiplyer = 0.5f;
    private int j = 0;

    public void fireGuns()
    {
        if (!alternating)
        {
            for (int i = 0; i < amountOfBullets; i++)
            {
                if (amountOfBullets % 2 != 0 && i == 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2(transform.position.x, transform.position.y + bulletsYOffSet), transform.rotation) as Rigidbody2D;
                    bulletInstance.velocity = new Vector2(0, bulletSpeed);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    Debug.Log("Created center bullet");
                    offSetMultiplyer = 1;
                }
                else if (i % 2 == 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2(transform.position.x - (bulletsXOffset * offSetMultiplyer), transform.position.y + bulletsYOffSet), new Quaternion(0, 0, 0, 0)) as Rigidbody2D;
                    bulletInstance.rotation = bulletRotation * offSetMultiplyer;
                    bulletInstance.velocity = new Vector2((bulletSpeed / bulletSpread) * -offSetMultiplyer, bulletSpeed - (bulletSpeed / bulletSpread) * offSetMultiplyer);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    if (amountOfBullets % 2 != 0)
                    {
                        offSetMultiplyer++;
                    }
                }
                else if (i % 2 != 0)
                {
                    Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2(transform.position.x + (bulletsXOffset * offSetMultiplyer), transform.position.y + bulletsYOffSet), new Quaternion(0, 0, 0, 0)) as Rigidbody2D;
                    bulletInstance.rotation = -bulletRotation * offSetMultiplyer;
                    bulletInstance.velocity = new Vector2((bulletSpeed / bulletSpread) * offSetMultiplyer, bulletSpeed - (bulletSpeed / bulletSpread) * offSetMultiplyer);
                    Physics2D.IgnoreLayerCollision(8, 8);
                    Physics2D.IgnoreLayerCollision(8, 9);
                    Physics2D.IgnoreLayerCollision(8, 13);
                    if (amountOfBullets % 2 == 0)
                    {
                        offSetMultiplyer++;
                    }
                }
            }
            offSetMultiplyer = 0.5f;
        }
        else
        {
            
            if (amountOfBullets % 2 != 0 && j == 0)
            {
                Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2(transform.position.x, transform.position.y + bulletsYOffSet), transform.rotation) as Rigidbody2D;
                bulletInstance.velocity = new Vector2(0, bulletSpeed);
                Physics2D.IgnoreLayerCollision(8, 8);
                Physics2D.IgnoreLayerCollision(8, 9);
                Physics2D.IgnoreLayerCollision(8, 13);
                offSetMultiplyer = 1;
                j++;
            }
            else if (j % 2 == 0)
            {
                Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2(transform.position.x - (bulletsXOffset * offSetMultiplyer), transform.position.y + bulletsYOffSet), new Quaternion(0, 0, 0, 0)) as Rigidbody2D;
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
                Rigidbody2D bulletInstance = Instantiate(bullet, new Vector2(transform.position.x + (bulletsXOffset * offSetMultiplyer), transform.position.y + bulletsYOffSet), new Quaternion(0, 0, 0, 0)) as Rigidbody2D;
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
            if(j >= amountOfBullets)
            {
                offSetMultiplyer = 0.5f;
                j = 0;
            }
        }
    }
}
