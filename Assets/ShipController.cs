using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

  [SerializeField]
  float speed = 4.1f;

  // Update is called once per frame
  void Update()
  {

    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    Vector2 movementX = new Vector2(moveX, 0);
    Vector2 movementY = new Vector2(0, moveY);

    Vector2 movement = movementX + movementY;

    transform.Translate(movement * speed * Time.deltaTime);

    if (Mathf.Abs(transform.position.x) > 5)
    {
      transform.Translate(-movementX * speed * Time.deltaTime);
    }


  }
}
