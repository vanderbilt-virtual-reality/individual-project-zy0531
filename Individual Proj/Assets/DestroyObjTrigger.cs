using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjTrigger : MonoBehaviour
{
    //public int Score = 1;
    void OnTriggerEnter(Collider col)
    {
        print("Enter Trigger");
        if (col.gameObject.tag == "OVR")
        {
            StartCoroutine(Wait());
            //Score +=1;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    

    //void OnGUI()
    //{
    //    GUI.Box(new Rect(0, 0, Screen.width, Screen.height), Score.ToString());
    //}


}