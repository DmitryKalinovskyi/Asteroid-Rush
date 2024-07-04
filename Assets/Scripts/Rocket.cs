using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Main game entity, responds for the rocket physics and player interaction
/// </summary>
public class Rocket : MonoBehaviour
{
    [SerializeField]
    public float VelocityForce = 3f;

    [SerializeField]
    public float YAngleRange = 45f;

    [SerializeField]
    public float XAngleRange = 45f;

    [SerializeField]
    public float YAngleRotationMutliplier = 4f;

    [SerializeField]
    public float XAngleRotationMutliplier = 4f;

    private Vector3 _velocity;

    void FixedUpdate()
    {
        // rocket movement
        var dx = Input.GetAxis("Horizontal");
        var dy = Input.GetAxis("Vertical");

        _velocity = new Vector3(dx, dy) * VelocityForce * Time.deltaTime;

        // update position based on velocity
        transform.position += _velocity;

        RotateBasedOnVelocity();
    }

    private void RotateBasedOnVelocity()
    {
        // we should rotate our rocket using _velocity
        var xAngle = XAngleRange * _velocity.x * XAngleRotationMutliplier;
        var yAngle = YAngleRange * _velocity.y * YAngleRotationMutliplier;

        transform.rotation = Quaternion.Euler(-yAngle,0, -xAngle);
    }

    public void OnCollisionEnter(Collision collision)
    {
        var obj = collision.gameObject;

        obj.SetActive(false);
    }
}
