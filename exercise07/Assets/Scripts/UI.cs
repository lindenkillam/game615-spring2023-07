using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameManager gm;
    [SerializeField] Text wallHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wallHealth.text = "Wall Integrity: " + gm.wallIntegrity.ToString ("0");   
    }
}
