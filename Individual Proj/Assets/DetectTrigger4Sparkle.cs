using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTrigger4Sparkle : MonoBehaviour
{
    //public Transform sparkle;
    public ParticleSystem sparkle;
    public bool moduleEnabled=false;
    public Rigidbody TargetTrigger;
    // Start is called before the first frame update
    void Start()
    {
        sparkle = GetComponent<ParticleSystem>();
        var emission = sparkle.emission;
        emission.enabled = moduleEnabled;
        //sparkle.GetComponent<ParticleSystem>().enableEmission = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody==TargetTrigger)
        {
            moduleEnabled = true;
            //sparkle.GetComponent<ParticleSystem>().enableEmission = true;
            //StartCoroutine(stopSparkles());
        }
        
    }
    
    IEnumerator stopSparkles()
    {
        yield return new WaitForSeconds(5.5f);
        moduleEnabled = false;
    }
}
