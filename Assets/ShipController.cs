using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
  [SerializeField]
  float speed = 4.1f;

  [SerializeField]
  GameObject boltPrefab;

  [SerializeField]
  GameObject gun;

  [SerializeField]
  float timeBetweenShots = 0.5f;
  float timeSinceLastShot = 0;

  // Update is called once per frame
  void Update()
  {

    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    Vector2 movementX = new Vector2(moveX, 0);
    Vector2 movementY = new Vector2(0, moveY);

    Vector2 movement = movementX + movementY;

    transform.Translate(movement * speed * Time.deltaTime);

    if (Mathf.Abs(transform.position.x) > 8.5f)
    {
      transform.Translate(-movementX * speed * Time.deltaTime);
    }

    if (Mathf.Abs(transform.position.y) > 4.5f)
    {
      transform.Translate(-movementY * speed * Time.deltaTime);
    }

    // SKjutande

    timeSinceLastShot += Time.deltaTime;

    if (Input.GetAxisRaw("Fire1") > 0 && timeSinceLastShot > timeBetweenShots)
    {
      timeSinceLastShot = 0;
      Instantiate(boltPrefab, gun.transform.position, Quaternion.identity);
    }


  }
}
/*
- Skjuta skott
- Fiender
- Liv
- Score
- Startmeny
*/