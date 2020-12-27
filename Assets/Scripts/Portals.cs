using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{
    [SerializeField] private Collider portal1;
    [SerializeField] private Collider portal2;
    public float addedForce;
    private void OnCollisionEnter(Collision other)
    {
        foreach (ContactPoint contact in other.contacts)
        {
            
            
            if (contact.thisCollider.Equals(portal1))//
            {
                /*Vector3 pos = portal2.transform.up;
                GameObject Ball = Instantiate(Resources.Load("Prefabs/Ball")) as GameObject;
                float collisionForce = other.impulse.magnitude / Time.fixedDeltaTime;
                Debug.Log("entered portal with force " + collisionForce);
                
                
                
                Rigidbody oldRb = contact.otherCollider.GetComponent<Rigidbody>();
                Rigidbody rb = Ball.GetComponent<Rigidbody>();
                rb.position = portal2.transform.position;
                rb = oldRb;
                //rb.velocity = pos * oldRb.velocity.magnitude;
                GameObject oldBall = contact.otherCollider.gameObject;
                Destroy(oldBall);
                rb.AddForce(addedForce*pos);*/
                
                Rigidbody oldRb = contact.otherCollider.GetComponent<Rigidbody>();
                Vector3 pos = portal2.transform.up;
                oldRb.position = portal2.transform.position;
                oldRb.velocity = pos * oldRb.velocity.magnitude;
            }
        }
    }
    
    private Component CopyComponent(Component original, GameObject destination)
    {
        System.Type type = original.GetType();
        Component copy = destination.AddComponent(type);
        // Copied fields can be restricted with BindingFlags
        System.Reflection.FieldInfo[] fields = type.GetFields(); 
        foreach (System.Reflection.FieldInfo field in fields)
        {
            field.SetValue(copy, field.GetValue(original));
        }
        return copy;
    }
    
    
    
}
