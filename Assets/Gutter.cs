using UnityEngine;

 public class Gutter : MonoBehaviour
 {
 private void OnTriggerEnter(Collider triggeredBody)
 {
 
 Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

 Debug.Log($"Ball {triggeredBody.name} entered the gutter.");

 float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

 ballRigidBody.linearVelocity = Vector3.zero;
 ballRigidBody.angularVelocity = Vector3.zero;

    
 ballRigidBody.AddForce(transform.up * velocityMagnitude, ForceMode.VelocityChange);
 }
 }