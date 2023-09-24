using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
  [SerializeField]
  float speed = 3;

  void Start() {
    float x = Random.Range(-7f, 7f);

    Vector2 pos = new Vector2(x, 5.5f);

    transform.position = pos;
  }

  void Update()
  {
    Vector2 movement = Vector2.down;
    transform.Translate(movement * speed * Time.deltaTime);

    if (transform.position.y < -5.5f)
    {
      Destroy(this.gameObject);
    }
  }
}
