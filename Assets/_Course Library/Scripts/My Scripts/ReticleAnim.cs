using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleAnim : MonoBehaviour
{
    [SerializeField] float rotation = 0;

    // Update is called once per frame
    void Update()
    {
        rotation = rotation + 45 *Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, rotation, 0);
    }
}
