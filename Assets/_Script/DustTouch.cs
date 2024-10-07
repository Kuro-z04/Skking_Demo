using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTouch : MonoBehaviour
{
    [SerializeField] ParticleSystem dust;
    
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Level Snow") {
            dust.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Level Snow") {
            dust.Stop();
        }
    }
}
