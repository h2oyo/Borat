using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    public GameObject explosion;
	void OnCollisionEnter2D (Collision2D col) {
    
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        
	
	}
}
