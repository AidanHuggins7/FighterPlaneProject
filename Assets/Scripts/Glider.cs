using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glider : MonoBehaviour
{

    public bool goingUp;
    public float speed;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goingUp == false)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        } else if (goingUp == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (transform.position.y >= gameManager.verticalScreenSize * 6.5f || transform.position.y <= -gameManager.verticalScreenSize * 6.5f)
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.x >= gameManager.horizontalScreenSize* 10f || transform.position.x <= -gameManager.verticalScreenSize* 10f)
        {
            Destroy(this.gameObject);
        }
    }
}
