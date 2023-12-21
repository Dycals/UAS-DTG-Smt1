using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponBehaviour : MonoBehaviour
{
    protected Vector3 direction;
    public float destroyAfterSecond;

    // Start is called before the first frame update
    protected void Start()
    {
        Destroy(gameObject, destroyAfterSecond);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;
    }
}
