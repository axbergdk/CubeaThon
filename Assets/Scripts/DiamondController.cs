using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            Debug.Log("Diamond hit by player");           
            
            FindObjectOfType<Score>().IncrementGems();
        }
        else
        {
            Debug.Log("Diamond hit by something else !!!!!!");
        }
    }
}
