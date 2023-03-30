using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameManager gm;
    public GameObject Cannonball;
    //public UI ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * gm.moveSpeed * vAxis, Space.World);
        gameObject.transform.Rotate(0, gm.rotateSpeed * Time.deltaTime * hAxis, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Vector3 vector = gameObject.transform.forward;
            //vector.y = -vector.y;
            //vector.z = -vector.z;
            GameObject cannonball = Instantiate(Cannonball, gameObject.transform.position, Quaternion.identity);
            Rigidbody rb = cannonball.GetComponent<Rigidbody>();
            rb.AddForce(gameObject.transform.forward * 15000);
            //float rotXAmount = Random.Range(-89, -10);
            //float rotYAmount = Random.Range(0, 360);
            //car.transform.Rotate(rotXAmount, rotYAmount, 0);
            //Rigidbody rb = car.GetComponent<Rigidbody>();
            //rb.AddForce(car.transform.forward * 1000);
        }

            /*
            // This will instantiate 100 spheres of random colors
            for (int i = 0; i < 100; i++)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                sphere.name = "sphere" + i;

                Renderer sRend = sphere.GetComponent<Renderer>();
                sRend.material.color = new Color(Random.value, Random.value, Random.value);

                sphere.transform.position = gameObject.transform.position;
                float rotXAmount = Random.Range(-89, -10);
                float rotYAmount = Random.Range(0, 360);
                sphere.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody sphereRB = sphere.AddComponent<Rigidbody>();
                sphereRB.AddForce(sphere.transform.forward * 1000);

                Destroy(sphere, 2f);
            }
            */
    }
}
