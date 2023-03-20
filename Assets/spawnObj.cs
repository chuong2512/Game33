using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObj : MonoBehaviour
{
    public int index;

    public bool isCheck;
    public bool onCllider;

    public SpriteRenderer SpriteRenderer;
    public Sprite[] Sprite;

    public Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void CheckMovement()
    {
    }

    float speed;

    void Update()
    {
        if (!isCheck && GameUI.Instance.CheckDroping() && onCllider)
        {
            speed = rigidbody.velocity.magnitude;
            if (speed < 0.5)
            {
                rigidbody.velocity = new Vector3(0, 0, 0); 
                //Or
                rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;

                isCheck = true;

                GameUI.Instance.AddPoint();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        onCllider = true;
    }

    public void RandomIndex()
    {
        index = Random.Range(0, Sprite.Length);

        SpriteRenderer.sprite = Sprite[index];

        gameObject.SetActive(true);
    }

    public void SetImage(int i)
    {
        index = i;

        SpriteRenderer.sprite = Sprite[index];
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Show(object o)
    {
    }
}