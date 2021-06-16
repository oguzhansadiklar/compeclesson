using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "lessons/Lesson1/Control Rigidbody Settings")]
public class RigidBodySettings : ScriptableObject
{
    [SerializeField] private Vector3 _jumpForce;

    public Vector3 JumpForce { get { return _jumpForce; } } 
}